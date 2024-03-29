using System;
using Sitecore.Web.UI.Pages;
using Sitecore.Diagnostics;
using Sitecore;
using Sitecore.Web;
using Sitecore.Web.UI.Sheer;

namespace ChatGptApp.Models
{
    public class ModalPopup : DialogForm
    {
        protected Sitecore.Web.UI.HtmlControls.Combobox Target;

        string Wrapping = @"<button type=""button"" aria-label=""View Additional Information"" aria-haspopup=""dialog"" class=""button--more-info a-icon-info"" data-name=""{0}""></button>";
        protected override void OnLoad(EventArgs e)
        {
            Assert.ArgumentNotNull(e, "e");
            base.OnLoad(e);

            if (!Context.ClientPage.IsEvent)
            {
                Mode = WebUtil.GetQueryString("mo");

                Context.ClientPage.ClientScript.RegisterStartupScript(GetType(), "script", "scOnLoad();", true);
            }
        }

        protected override void OnOK(object sender, EventArgs args)
        {
            Assert.ArgumentNotNull(sender, "sender");
            Assert.ArgumentNotNull(args, "args");

            string code = string.Format(Wrapping, Target.Value);

            if (Mode == "webedit")
            {
                SheerResponse.SetDialogValue(StringUtil.EscapeJavascriptString(code));
                base.OnOK(sender, args);
            }
            else
            {
                SheerResponse.Eval($"scClose({StringUtil.EscapeJavascriptString(code)})");
            }
        }

        protected override void OnCancel(object sender, EventArgs args)
        {
            Assert.ArgumentNotNull(sender, "sender");
            Assert.ArgumentNotNull(args, "args");

            if (Mode == "webedit")
            {
                base.OnCancel(sender, args);
            }
            else
            {
                SheerResponse.Eval("scCancel()");
            }
        }

        protected string Mode
        {
            get
            {
                string str = StringUtil.GetString(base.ServerProperties["Mode"]);
                if (!string.IsNullOrEmpty(str))
                {
                    return str;
                }
                return "shell";
            }
            set
            {
                Assert.ArgumentNotNull(value, "value");
                base.ServerProperties["Mode"] = value;
            }
        }
    }
}