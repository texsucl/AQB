#pragma checksum "C:\Users\Texsucl\Desktop\AQBT1\MyAQB1\MyAQB1\Views\SimpleOdbcDemo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b62c3e60f2cea011c6e66f4e366111de137ce5d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SimpleOdbcDemo_Index), @"mvc.1.0.view", @"/Views/SimpleOdbcDemo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SimpleOdbcDemo/Index.cshtml", typeof(AspNetCore.Views_SimpleOdbcDemo_Index))]
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
#line 1 "C:\Users\Texsucl\Desktop\AQBT1\MyAQB1\MyAQB1\Views\SimpleOdbcDemo\Index.cshtml"
using ActiveQueryBuilder.Web.Core.HtmlHelpers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b62c3e60f2cea011c6e66f4e366111de137ce5d1", @"/Views/SimpleOdbcDemo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7583c8c933f83752c345d466f1c93a4fcfe8be76", @"/Views/_ViewImports.cshtml")]
    public class Views_SimpleOdbcDemo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ActiveQueryBuilder.Web.Server.QueryBuilder>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/jqx.base.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/jqx-all.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Texsucl\Desktop\AQBT1\MyAQB1\MyAQB1\Views\SimpleOdbcDemo\Index.cshtml"
  
    ViewBag.Title = "ODBC Connection Demo";
    var controls = Html.QueryBuilder(Model, ViewContext.HttpContext.Request, s => s.Theme = "default");

#line default
#line hidden
            BeginContext(256, 390, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12"">
        <h1>ODBC Connection Demo</h1>
        <p>Loading metadata from live database.</p>
    </div>
    <div class=""col-md-12"">
        <button id=""loader"">Load from localStorage</button>
        <p>Users can save their queries and use them as data sources in subsequent queries.</p>
    </div>
    <div class=""col-md-12"">
        ");
            EndContext();
            BeginContext(647, 18, false);
#line 18 "C:\Users\Texsucl\Desktop\AQBT1\MyAQB1\MyAQB1\Views\SimpleOdbcDemo\Index.cshtml"
   Write(controls.GetHtml());

#line default
#line hidden
            EndContext();
            BeginContext(665, 516, true);
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
            BeginContext(1182, 35, false);
#line 27 "C:\Users\Texsucl\Desktop\AQBT1\MyAQB1\MyAQB1\Views\SimpleOdbcDemo\Index.cshtml"
                           Write(controls.ObjectTreeView().GetHtml());

#line default
#line hidden
            EndContext();
            BeginContext(1217, 394, true);
            WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""qb-ui-structure-tabs__tab"">
                            <input type=""radio"" id=""queries-tab"" name=""qb-tabs"" />
                            <label for=""queries-tab"">Queries</label>
                            <div class=""qb-ui-structure-tabs__content"">
                                ");
            EndContext();
            BeginContext(1612, 32, false);
#line 34 "C:\Users\Texsucl\Desktop\AQBT1\MyAQB1\MyAQB1\Views\SimpleOdbcDemo\Index.cshtml"
                           Write(controls.UserQueries().GetHtml());

#line default
#line hidden
            EndContext();
            BeginContext(1644, 193, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"qb-ui-layout__right\">\r\n                    ");
            EndContext();
            BeginContext(1838, 42, false);
#line 40 "C:\Users\Texsucl\Desktop\AQBT1\MyAQB1\MyAQB1\Views\SimpleOdbcDemo\Index.cshtml"
               Write(controls.SubQueryNavigationBar().GetHtml());

#line default
#line hidden
            EndContext();
            BeginContext(1880, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1903, 27, false);
#line 41 "C:\Users\Texsucl\Desktop\AQBT1\MyAQB1\MyAQB1\Views\SimpleOdbcDemo\Index.cshtml"
               Write(controls.Canvas().GetHtml());

#line default
#line hidden
            EndContext();
            BeginContext(1930, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1953, 30, false);
#line 42 "C:\Users\Texsucl\Desktop\AQBT1\MyAQB1\MyAQB1\Views\SimpleOdbcDemo\Index.cshtml"
               Write(controls.StatusBar().GetHtml());

#line default
#line hidden
            EndContext();
            BeginContext(1983, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2006, 25, false);
#line 43 "C:\Users\Texsucl\Desktop\AQBT1\MyAQB1\MyAQB1\Views\SimpleOdbcDemo\Index.cshtml"
               Write(controls.Grid().GetHtml());

#line default
#line hidden
            EndContext();
            BeginContext(2031, 552, true);
            WriteLiteral(@"
                </div>
            </div>
            <div class=""qb-ui-layout__bottom"">
                <div class=""qb-ui-structure-tabs"">
                    <div class=""qb-ui-structure-tabs__tab"">
                        <input type=""radio"" id=""w-tab"" name=""sql-tabs"" checked />
                        <label for=""w-tab"">Full Query Text</label>
                        <div class=""qb-ui-structure-tabs__content"">
                            <span class=""label label-info"">Text of the entire SQL query.</span>
                            ");
            EndContext();
            BeginContext(2584, 30, false);
#line 53 "C:\Users\Texsucl\Desktop\AQBT1\MyAQB1\MyAQB1\Views\SimpleOdbcDemo\Index.cshtml"
                       Write(controls.SqlEditor().GetHtml());

#line default
#line hidden
            EndContext();
            BeginContext(2614, 62, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
            BeginContext(4031, 592, true);
            WriteLiteral(@"                    <div class=""qb-ui-structure-tabs__tab"">
                        <input type=""radio"" id=""qr-tab"" name=""sql-tabs"" />
                        <label for=""qr-tab"">Preview results</label>
                        <div class=""qb-ui-structure-tabs__content"">
                            <a class=""link-to-grid-site"" href=""https://www.jqwidgets.com"">https://www.jqwidgets.com</a>
                            <div id=""jqxgrid""></div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(4640, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4646, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8d2e6c8586a64b41886e010c4db3b6e7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4713, 556, true);
                WriteLiteral(@"

    <style>
        .qb-ui-layout__bottom {
            height: 300px;
        }

        .qb-ui-layout .qb-ui-layout__left,
        .qb-ui-layout .qb-ui-layout__right {
            height: 500px;
        }

            .qb-ui-layout .qb-ui-layout__right .qb-ui-canvas {
                height: 300px;
            }

        .link-to-grid-site {
            float: right;
            color: blue !important;
        }

        .label-info {
            display: inline-block;
            font-size: 14px;
        }
    </style>
");
                EndContext();
            }
            );
            BeginContext(5272, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(5299, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5305, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb05cbfe8d774ff693609b4bcf2a1eb7", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5344, 3107, true);
                WriteLiteral(@"
    <script>
        var container = $('#jqxgrid'),
            grid;

        AQB.Web.onQueryBuilderReady(function (qb) {
            qb.on(qb.Events.ActiveUnionSubQueryChanged, loadPreview);
            qb.on(qb.Events.SqlChanged, loadPreview);
            loadPreview();
        });

        function loadPreview() {
            if (grid)
                grid.jqxGrid('showloadelement');

            $.ajax({
                url: ""SimpleOdbcDemo/GetData"",
                success: function (result) {
                    if (grid)
                        grid.jqxGrid('destroy');

                    grid = $('<div class=""grid"">');
                    container.append(grid);

                    var source =
                    {
                        localdata: result.data,
                        datafields: result.columns.map(function (c, i) {
                            return { name: c, map: i.toString() }
                        }),
                        datatype: ""array""");
                WriteLiteral(@"
                    };

                    var dataAdapter = new $.jqx.dataAdapter(source);

                    grid.jqxGrid(
                        {
                            width: '100%',
                            source: dataAdapter,
                            columnsresize: true,
                            columns: result.columns.map(function (c) {
                                return { text: c, datafield: c }
                            })
                        });
                }
            });
        }

        var key = ""UserDefinedQueriesDemo"";

        function saveToLocalStorage() {
            setTimeout(function () {
                $.ajax({
                    type: 'GET',
                    url: '/SimpleOdbcDemo/GetUserQueriesXml',
                    success: function (xml) {
                        localStorage.setItem(key, xml);
                        loader.style.display = 'inline-block';
                    }
                });
         ");
                WriteLiteral(@"   }, 1000);
        }

        function loadFromLocalStorage() {
            $.ajax({
                type: 'POST',
                url: '/SimpleOdbcDemo/LoadUserQueries',
                data: { xml: localStorage.getItem(key) },
                success: function () {
                    AQB.Web.QueryBuilder.fullUpdate();
                }
            });
        }

        AQB.Web.onQueryBuilderReady(function (qb) {
            var uq = qb.UserQueriesComponent;

            uq.on(uq.Events.OnCreateFolder, saveToLocalStorage);
            uq.on(uq.Events.OnCreateUserQuery, saveToLocalStorage);
            uq.on(uq.Events.OnEdit, saveToLocalStorage);
            uq.on(uq.Events.OnRemove, saveToLocalStorage);
            uq.on(uq.Events.OnRename, saveToLocalStorage);
            uq.on(uq.Events.OnSaveUserQuery, saveToLocalStorage);

            loader.addEventListener('click', loadFromLocalStorage);
        });

        if (localStorage.getItem(key) == null)
            loader.style");
                WriteLiteral(".display = \'none\';\r\n    </script>\r\n");
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
