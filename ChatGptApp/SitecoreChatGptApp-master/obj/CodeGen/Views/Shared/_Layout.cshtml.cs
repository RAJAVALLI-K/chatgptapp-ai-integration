#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using ChatGptApp;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_Layout.cshtml")]
    public partial class _Views_Shared__Layout_cshtml : System.Web.Mvc.WebViewPage<dynamic>
    {
        public _Views_Shared__Layout_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<!DOCTYPE html>\n<html>\n<head>\n    <meta");

WriteLiteral(" charset=\"utf-8\"");

WriteLiteral(" />\n    <meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width, initial-scale=1.0\"");

WriteLiteral(">\n    <title>");

            
            #line 6 "..\..\Views\Shared\_Layout.cshtml"
      Write(ViewBag.Title);

            
            #line default
            #line hidden
WriteLiteral(" - ChatGpt</title>\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 187), Tuple.Create("\"", 212)
, Tuple.Create(Tuple.Create("", 194), Tuple.Create<System.Object, System.Int32>(Href("~/Content/Site.css")
, 194), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 259), Tuple.Create("\"", 293)
, Tuple.Create(Tuple.Create("", 266), Tuple.Create<System.Object, System.Int32>(Href("~/Content/bootstrap.min.css")
, 266), false)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 342), Tuple.Create("\"", 376)
, Tuple.Create(Tuple.Create("", 348), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/modernizr-2.8.3.js")
, 348), false)
);

WriteLiteral("></script>\n    <script");

WriteLiteral(" src=\"https://code.jquery.com/jquery-3.6.0.js\"");

WriteLiteral("></script>\n</head>\n<body>\n    <div");

WriteLiteral(" class=\"navbar navbar-inverse navbar-fixed-top\"");

WriteLiteral(">\n        <div");

WriteLiteral(" class=\"container\"");

WriteLiteral(">\n            <div");

WriteLiteral(" class=\"navbar-header\"");

WriteLiteral(">\n                <button");

WriteLiteral(" type=\"button\"");

WriteLiteral(" class=\"navbar-toggle\"");

WriteLiteral(" data-toggle=\"collapse\"");

WriteLiteral(" data-target=\".navbar-collapse\"");

WriteLiteral(">\n                    <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\n                    <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\n                    <span");

WriteLiteral(" class=\"icon-bar\"");

WriteLiteral("></span>\n                </button>\n                <a");

WriteLiteral(" href=\"/chat/chatgpt\"");

WriteLiteral(" class=\"navbar-brand\"");

WriteLiteral(">ChatGpt App</a>\n            </div>\n            <div");

WriteLiteral(" class=\"navbar-collapse collapse\"");

WriteLiteral(">\n                <ul");

WriteLiteral(" class=\"nav navbar-nav\"");

WriteLiteral(">\n                </ul>\n            </div>\n        </div>\n    </div>\n\n    <div");

WriteLiteral(" class=\"container body-content\"");

WriteLiteral(">\n");

WriteLiteral("        ");

            
            #line 31 "..\..\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\n        <hr />\n        <footer>\n            <p>&copy; ");

            
            #line 34 "..\..\Views\Shared\_Layout.cshtml"
                 Write(DateTime.Now.Year);

            
            #line default
            #line hidden
WriteLiteral("</p>\n        </footer>\n    </div>\n    \n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1338), Tuple.Create("\"", 1370)
, Tuple.Create(Tuple.Create("", 1344), Tuple.Create<System.Object, System.Int32>(Href("~/Scripts/bootstrap.min.js")
, 1344), false)
);

WriteLiteral("></script>\n</body>\n</html>");

        }
    }
}
#pragma warning restore 1591
