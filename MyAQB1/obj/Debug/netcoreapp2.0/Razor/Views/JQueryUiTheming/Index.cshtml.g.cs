#pragma checksum "C:\Users\Texsucl\Desktop\AQBT1\MyAQB1\MyAQB1\Views\JQueryUiTheming\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a589f93acb5569ef6439f71633e75d62b628fe54"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_JQueryUiTheming_Index), @"mvc.1.0.view", @"/Views/JQueryUiTheming/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/JQueryUiTheming/Index.cshtml", typeof(AspNetCore.Views_JQueryUiTheming_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Texsucl\Desktop\AQBT1\MyAQB1\MyAQB1\Views\_ViewImports.cshtml"
using MyAQB1;

#line default
#line hidden
#line 2 "C:\Users\Texsucl\Desktop\AQBT1\MyAQB1\MyAQB1\Views\_ViewImports.cshtml"
using MyAQB1.Models;

#line default
#line hidden
#line 1 "C:\Users\Texsucl\Desktop\AQBT1\MyAQB1\MyAQB1\Views\JQueryUiTheming\Index.cshtml"
using ActiveQueryBuilder.Web.Core.HtmlHelpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a589f93acb5569ef6439f71633e75d62b628fe54", @"/Views/JQueryUiTheming/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7583c8c933f83752c345d466f1c93a4fcfe8be76", @"/Views/_ViewImports.cshtml")]
    public class Views_JQueryUiTheming_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ActiveQueryBuilder.Web.Server.QueryBuilder>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Texsucl\Desktop\AQBT1\MyAQB1\MyAQB1\Views\JQueryUiTheming\Index.cshtml"
  
    ViewBag.Title = "jQueryUI Theming Demo";
    var controls = Html.QueryBuilder(Model, ViewContext.HttpContext.Request, s => s.Theme = "jqueryui");

#line default
#line hidden
            BeginContext(258, 309, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <h1>jQueryUI Theming Demo</h1>
        <p>Apply and jQueryUI skin to Active Query Builder UI.</p>
        <div class=""header ui-widget-header"">
            <div id=""switcher""></div>
        </div>
    </div>
    <div class=""col-md-12"">
        ");
            EndContext();
            BeginContext(568, 18, false);
#line 17 "C:\Users\Texsucl\Desktop\AQBT1\MyAQB1\MyAQB1\Views\JQueryUiTheming\Index.cshtml"
   Write(controls.GetHtml());

#line default
#line hidden
            EndContext();
            BeginContext(586, 516, true);
            WriteLiteral(@"
        <div class=""qb-ui-layout"">
            <div class=""qb-ui-layout__top"">
                <div class=""qb-ui-layout__left"">
                    <div class=""qb-ui-structure-tabs"">
                        <div class=""qb-ui-structure-tabs__tab"">
                            <input type=""radio"" id=""tree-tab"" name=""qb-tabs"" checked />
                            <label for=""tree-tab"">Database</label>
                            <div class=""qb-ui-structure-tabs__content"">
                                ");
            EndContext();
            BeginContext(1103, 35, false);
#line 26 "C:\Users\Texsucl\Desktop\AQBT1\MyAQB1\MyAQB1\Views\JQueryUiTheming\Index.cshtml"
                           Write(controls.ObjectTreeView().GetHtml());

#line default
#line hidden
            EndContext();
            BeginContext(1138, 193, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"qb-ui-layout__right\">\r\n                    ");
            EndContext();
            BeginContext(1332, 42, false);
#line 32 "C:\Users\Texsucl\Desktop\AQBT1\MyAQB1\MyAQB1\Views\JQueryUiTheming\Index.cshtml"
               Write(controls.SubQueryNavigationBar().GetHtml());

#line default
#line hidden
            EndContext();
            BeginContext(1374, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1397, 27, false);
#line 33 "C:\Users\Texsucl\Desktop\AQBT1\MyAQB1\MyAQB1\Views\JQueryUiTheming\Index.cshtml"
               Write(controls.Canvas().GetHtml());

#line default
#line hidden
            EndContext();
            BeginContext(1424, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1447, 30, false);
#line 34 "C:\Users\Texsucl\Desktop\AQBT1\MyAQB1\MyAQB1\Views\JQueryUiTheming\Index.cshtml"
               Write(controls.StatusBar().GetHtml());

#line default
#line hidden
            EndContext();
            BeginContext(1477, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1500, 25, false);
#line 35 "C:\Users\Texsucl\Desktop\AQBT1\MyAQB1\MyAQB1\Views\JQueryUiTheming\Index.cshtml"
               Write(controls.Grid().GetHtml());

#line default
#line hidden
            EndContext();
            BeginContext(1525, 110, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"qb-ui-layout__bottom\">\r\n                ");
            EndContext();
            BeginContext(1636, 30, false);
#line 39 "C:\Users\Texsucl\Desktop\AQBT1\MyAQB1\MyAQB1\Views\JQueryUiTheming\Index.cshtml"
           Write(controls.SqlEditor().GetHtml());

#line default
#line hidden
            EndContext();
            BeginContext(1666, 60, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(1743, 191, true);
                WriteLiteral("\r\n    <style>\r\n        #switcher, .jquery-ui-switcher-link {\r\n            height: 22px !important;\r\n        }\r\n\r\n        .header {\r\n            margin-bottom: 10px;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(1937, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1957, 331, true);
                WriteLiteral(@"
    <script type=""text/javascript"" language=""JavaScript"" src=""./js/jquery.themeswitcher.min.js""></script>
    <script>
        $(function () {
            $(""#switcher"").themeswitcher({
                imgpath: ""./images/themeroller/"",
                jqueryuiversion: ""1.12.1""
            });
        });
    </script>
");
                EndContext();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ActiveQueryBuilder.Web.Server.QueryBuilder> Html { get; private set; }
    }
}
#pragma warning restore 1591
