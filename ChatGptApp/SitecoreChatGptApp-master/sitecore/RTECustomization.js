Telerik.Web.UI.Editor.CommandList["InsertDialog"] = function(commandName, editor, args) {
 var d = Telerik.Web.UI.Editor.CommandList._getLinkArgument(editor);
 Telerik.Web.UI.Editor.CommandList._getDialogArguments(d, "A", editor, "DocumentManager");

var html = editor.getSelectionHtml();
var id;
// internal link in form of <a href="~/link.aspx?_id=110D559FDEA542EA9C1C8A5DF7E70EF9">...</a>
 if (html) {
 id = GetMediaID(html);
 }
// link to media in form of <a href="-/media/CC2393E7CA004EADB4A155BE4761086B.ashx">...</a>
 if (!id) {
 var regex = /~\/media\/([\w\d]+)\.ashx/;
 var match = regex.exec(html);
 if (match && match.length >= 1 && match[1]) {
 id = match[1];
 }
 }
if (!id) {
 id = scItemID;
 }
 id = scFormatId(id);
scEditor = editor;
editor.showExternalDialog(
 "/sitecore/shell/default.aspx?xmlcontrol=RichText.InsertDialog&la=" + scLanguage + "&fo=" + id + (scDatabase ? "&databasename=" + scDatabase : ""),
 null, //argument
 1100,
 700,
 scInsertDialog, //callback
 null, // callback args
 "Insert Dialog",
 true, //modal
 Telerik.Web.UI.WindowBehaviors.Close, // behaviors
 false, //showStatusBar
 false //showTitleBar
 );
};
function scInsertDialog(sender, returnValue) {
 if (!returnValue) {
 return;
 }
var d = scEditor.getSelection().getParentElement();
if ($telerik.isFirefox && d.tagName == "A") {
 d.parentNode.removeChild(d);
 } else {
 scEditor.fire("Unlink");
 }
 var text = scEditor.getSelectionHtml();
if ($telerik.isIE) {
 text = scIEFixRTETextRange(scEditor);
 }
var returnURL = returnValue.url.replace("{", "").replace("}", "").replace('-', '');

if (text == "" || text == null || ((text != null) && (text.length == 15) && (text.substring(2, 15).toLowerCase() == "<p>&nbsp;</p>"))) {
 text = returnValue.text;
 }
 else {
 // if selected string is a full paragraph, we want to insert the link inside the paragraph, and not the other way around.
 var regex = /^[\s]*<p>(.+)<\/p>[\s]*$/i;
 var match = regex.exec(text);
 if (match && match.length >= 2) {
 var placeholderHtml = "<a class=\"Green Goblin\""
 + " href=\"~/link.aspx?_id=" + returnURL
 + "&amp;_z=z\""
 + match[0]
 + "</a>";

scEditor.pasteHtml(placeholderHtml, "DocumentManager");
 return;
 }
 }
var placeholderHtml = "<a class=\"Green Goblin\""
 + " href=\"~/link.aspx?_id=" + returnURL
 + "&amp;_z=z\""
 + text
 + "</a>";
 
scEditor.pasteHtml(placeholderHtml, "DocumentManager");
}