#pragma checksum "C:\Users\natha\source\repos\ArtGallery\ArtGallery\Pages\UserAccount\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b22b19550a0e6ab143e303501ebd852f6749036"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ArtGallery.Pages.UserAccount.Pages_UserAccount_Create), @"mvc.1.0.razor-page", @"/Pages/UserAccount/Create.cshtml")]
namespace ArtGallery.Pages.UserAccount
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\natha\source\repos\ArtGallery\ArtGallery\Pages\_ViewImports.cshtml"
using ArtGallery;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b22b19550a0e6ab143e303501ebd852f6749036", @"/Pages/UserAccount/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b065b80bb7f6559a39686d2a1b4c8fdf2d0c5a9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UserAccount_Create : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<br>\r\n<h2>New User</h2>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\natha\source\repos\ArtGallery\ArtGallery\Pages\UserAccount\Create.cshtml"
 if (Model.errorMessage.Length > 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\'alert alert-warning alert-dismissible fade show\' role=\'alert\'>\r\n                    <strong>");
#nullable restore
#line 11 "C:\Users\natha\source\repos\ArtGallery\ArtGallery\Pages\UserAccount\Create.cshtml"
                       Write(Model.errorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                    <button type=\'button\' class=\'btn-close\' data-bs-dismiss=\'alert\' aria-label=\'Close\'></button>\r\n                </div>\r\n");
#nullable restore
#line 14 "C:\Users\natha\source\repos\ArtGallery\ArtGallery\Pages\UserAccount\Create.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b22b19550a0e6ab143e303501ebd852f67490364406", async() => {
                WriteLiteral("\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Username</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"Username\"");
                BeginWriteAttribute("value", " value=\"", 661, "\"", 691, 1);
#nullable restore
#line 20 "C:\Users\natha\source\repos\ArtGallery\ArtGallery\Pages\UserAccount\Create.cshtml"
WriteAttributeValue("", 669, Model.client.Username, 669, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Email</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"Email\"");
                BeginWriteAttribute("value", " value=\"", 911, "\"", 938, 1);
#nullable restore
#line 26 "C:\Users\natha\source\repos\ArtGallery\ArtGallery\Pages\UserAccount\Create.cshtml"
WriteAttributeValue("", 919, Model.client.Email, 919, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Password</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"Password\"");
                BeginWriteAttribute("value", " value=\"", 1164, "\"", 1194, 1);
#nullable restore
#line 32 "C:\Users\natha\source\repos\ArtGallery\ArtGallery\Pages\UserAccount\Create.cshtml"
WriteAttributeValue("", 1172, Model.client.Password, 1172, 22, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        </div>\r\n    </div>\r\n\r\n");
#nullable restore
#line 36 "C:\Users\natha\source\repos\ArtGallery\ArtGallery\Pages\UserAccount\Create.cshtml"
     if (Model.successMessage.Length > 0){

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"row mb-3\">\r\n            <div class=\"col-sm-9\">\r\n                <div class=\'alert alert-success alert-dismissible fade show\' role=\'alert\'>\r\n                    <strong>");
#nullable restore
#line 40 "C:\Users\natha\source\repos\ArtGallery\ArtGallery\Pages\UserAccount\Create.cshtml"
                       Write(Model.successMessage);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                    <button type=\'button\' class=\'btn-close\' data-bs-dismiss=\'alert\' aria-label=\'Close\'></button>\r\n                </div>\r\n             </div>\r\n        </div>\r\n");
#nullable restore
#line 45 "C:\Users\natha\source\repos\ArtGallery\ArtGallery\Pages\UserAccount\Create.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <div class=""row mb-3"">
                <div class=""offset-sm-3 col-sm-3 d-grid"">
                    <button type=""submit"" class=""btn btn-primary"">Submit</button>
                </div>
                <div class=""col-sm-3 d-grid"">
                    <a class=""btn btn-outline-primary"" href=""/"" role=""button"">Cancel</a>
                </div>
            </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArtGallery.Pages.UserAccount.CreateModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ArtGallery.Pages.UserAccount.CreateModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ArtGallery.Pages.UserAccount.CreateModel>)PageContext?.ViewData;
        public ArtGallery.Pages.UserAccount.CreateModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591