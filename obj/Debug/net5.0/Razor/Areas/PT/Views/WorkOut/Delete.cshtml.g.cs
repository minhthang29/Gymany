#pragma checksum "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Areas\PT\Views\WorkOut\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d68b4532179a418fec434b55745ddcfe27cb52a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_PT_Views_WorkOut_Delete), @"mvc.1.0.view", @"/Areas/PT/Views/WorkOut/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d68b4532179a418fec434b55745ddcfe27cb52a", @"/Areas/PT/Views/WorkOut/Delete.cshtml")]
    public class Areas_PT_Views_WorkOut_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gymany.Models.WorkoutPlan>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Areas\PT\Views\WorkOut\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Areas\PT\Views\WorkOut\Delete.cshtml"
  
    Layout = "PTLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\"padding-top: 50px;\"></div>\r\n<div class=\"card mb-4 shadow-sm\">\r\n    <div class=\"card-header\">\r\n        <h2 class=\"my-0 font-weight-normal\">");
#nullable restore
#line 12 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Areas\PT\Views\WorkOut\Delete.cshtml"
                                       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <p class=\"card-text\">");
#nullable restore
#line 15 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Areas\PT\Views\WorkOut\Delete.cshtml"
                        Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <div class=\"row\">\r\n            <div class=\"col-md-6\">\r\n                <p><strong>Start Date:</strong> ");
#nullable restore
#line 18 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Areas\PT\Views\WorkOut\Delete.cshtml"
                                           Write(Html.DisplayFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><strong>End Date:</strong> ");
#nullable restore
#line 19 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Areas\PT\Views\WorkOut\Delete.cshtml"
                                         Write(Html.DisplayFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><strong>Session:</strong> ");
#nullable restore
#line 20 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Areas\PT\Views\WorkOut\Delete.cshtml"
                                        Write(Html.DisplayFor(model => model.Session));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                <p><strong>Activity:</strong> ");
#nullable restore
#line 23 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Areas\PT\Views\WorkOut\Delete.cshtml"
                                         Write(Html.DisplayFor(model => model.Activity));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p><strong>Member ID:</strong> ");
#nullable restore
#line 24 "E:\SE1707_Ky5\Project\project_G\Gymany\Gymany\Gymany\Areas\PT\Views\WorkOut\Delete.cshtml"
                                          Write(Html.DisplayFor(model => model.MemberID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<hr>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d68b4532179a418fec434b55745ddcfe27cb52a6238", async() => {
                WriteLiteral("\r\n    <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gymany.Models.WorkoutPlan> Html { get; private set; }
    }
}
#pragma warning restore 1591
