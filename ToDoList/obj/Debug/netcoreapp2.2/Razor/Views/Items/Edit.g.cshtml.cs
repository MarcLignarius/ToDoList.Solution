#pragma checksum "C:\Users\mimim\desktop\ToDoList.Solution\ToDoList\Views\Items\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83a7deb1839e94a78e3e1a344b49949a06ab8beb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Items_Edit), @"mvc.1.0.view", @"/Views/Items/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Items/Edit.cshtml", typeof(AspNetCore.Views_Items_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83a7deb1839e94a78e3e1a344b49949a06ab8beb", @"/Views/Items/Edit.cshtml")]
    public class Views_Items_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 244, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83a7deb1839e94a78e3e1a344b49949a06ab8beb4091", async() => {
                BeginContext(31, 166, true);
                WriteLiteral("\r\n  <meta charset=\'utf-8\'>\r\n  <title>To Do List</title>\r\n  <link rel=\'stylesheet\' href=\'https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css\'>\r\n  ");
                EndContext();
                BeginContext(197, 63, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "83a7deb1839e94a78e3e1a344b49949a06ab8beb4649", async() => {
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
                BeginContext(260, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(269, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(271, 690, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83a7deb1839e94a78e3e1a344b49949a06ab8beb6865", async() => {
                BeginContext(277, 117, true);
                WriteLiteral("\r\n  <div class=\"container\">\r\n    <div class=\"jumbotron\">\r\n      <h1>To Do List</h1>\r\n      <em>You can edit the item ");
                EndContext();
                BeginContext(395, 30, false);
#line 13 "C:\Users\mimim\desktop\ToDoList.Solution\ToDoList\Views\Items\Edit.cshtml"
                           Write(Model["item"].GetDescription());

#line default
#line hidden
                EndContext();
                BeginContext(425, 34, true);
                WriteLiteral(" here:</em>\r\n    </div>\r\n    <form");
                EndContext();
                BeginWriteAttribute("action", " action=\"", 459, "\"", 535, 4);
                WriteAttributeValue("", 468, "/categories/", 468, 12, true);
#line 15 "C:\Users\mimim\desktop\ToDoList.Solution\ToDoList\Views\Items\Edit.cshtml"
WriteAttributeValue("", 480, Model["category"].GetId(), 480, 26, false);

#line default
#line hidden
                WriteAttributeValue("", 506, "/items/", 506, 7, true);
#line 15 "C:\Users\mimim\desktop\ToDoList.Solution\ToDoList\Views\Items\Edit.cshtml"
WriteAttributeValue("", 513, Model["item"].GetId(), 513, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(536, 112, true);
                WriteLiteral(" method=\"post\">\r\n      <label for=\"newDescription\">Name:</label>\r\n      <input type=\"text\" name=\"newDescription\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 648, "\"", 687, 1);
#line 17 "C:\Users\mimim\desktop\ToDoList.Solution\ToDoList\Views\Items\Edit.cshtml"
WriteAttributeValue("", 656, Model["item"].GetDescription(), 656, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(688, 130, true);
                WriteLiteral(">\r\n      <button type=\"submit\" class=\"btn btn-dark\">Edit</button>\r\n    </form>\r\n    <div id=\"space\">\r\n    </div>\r\n    <hr>\r\n    <a");
                EndContext();
                BeginWriteAttribute("href", " href=\"", 818, "\"", 892, 4);
                WriteAttributeValue("", 825, "/categories/", 825, 12, true);
#line 23 "C:\Users\mimim\desktop\ToDoList.Solution\ToDoList\Views\Items\Edit.cshtml"
WriteAttributeValue("", 837, Model["category"].GetId(), 837, 26, false);

#line default
#line hidden
                WriteAttributeValue("", 863, "/items/", 863, 7, true);
#line 23 "C:\Users\mimim\desktop\ToDoList.Solution\ToDoList\Views\Items\Edit.cshtml"
WriteAttributeValue("", 870, Model["item"].GetId(), 870, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(893, 61, true);
                WriteLiteral(" class=\"btn btn-dark\">Return to previous page</a>\r\n  </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(961, 11, true);
            WriteLiteral("\r\n</html>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
