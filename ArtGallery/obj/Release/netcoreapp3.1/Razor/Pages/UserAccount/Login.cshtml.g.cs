#pragma checksum "C:\Users\natha\source\repos\ArtGallery\ArtGallery\Pages\UserAccount\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0545752592a47fd0615d363d13b89703b7643ba5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ArtGallery.Pages.UserAccount.Pages_UserAccount_Login), @"mvc.1.0.razor-page", @"/Pages/UserAccount/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0545752592a47fd0615d363d13b89703b7643ba5", @"/Pages/UserAccount/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b065b80bb7f6559a39686d2a1b4c8fdf2d0c5a9", @"/Pages/_ViewImports.cshtml")]
    public class Pages_UserAccount_Login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/login.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0545752592a47fd0615d363d13b89703b7643ba53663", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script></script>
<div class=""section"">
    <div class=""container"">
        <div class=""row full-height justify-content-center"">
            <div class=""col-12 text-center align-self-center py-5"">
                <div class=""section pb-5 pt-5 pt-sm-2 text-center"">
                    <h6 class=""mb-0 pb-3""><span>Log In </span><span>Sign Up</span></h6>
                    <input class=""checkbox"" type=""checkbox"" id=""reg-log"" name=""reg-log"" />
                    <label for=""reg-log""></label>
                    <div class=""card-3d-wrap mx-auto"">
                        <div class=""card-3d-wrapper"">
                            <div class=""card-front"">
                                <div class=""center-wrap"">
                                    <div class=""section text-center"">
                                        <h4 class=""mb-4 pb-3"">Log In</h4>
                                        <div class=""form-group"">
                                            <input type=""email"" name=""logemail"" cla");
            WriteLiteral(@"ss=""form-style"" placeholder=""Your Email"" id=""logemail"" autocomplete=""off"">
                                            <i class=""input-icon uil uil-at""></i>
                                        </div>
                                        <div class=""form-group mt-2"">
                                            <input type=""password"" name=""logpass"" class=""form-style"" placeholder=""Your Password"" id=""logpass"" autocomplete=""off"">
                                            <i class=""input-icon uil uil-lock-alt""></i>
                                        </div>
                                        <a href=""#"" class=""btn mt-4"">submit</a>
                                        <p class=""mb-0 mt-4 text-center""><a href=""#0"" class=""link"">Forgot your password?</a></p>
                                    </div>
                                </div>
                            </div>
                            <div class=""card-back"">
                                <div class=""center-wrap"">
   ");
            WriteLiteral("                                 <div class=\"section text-center\">\r\n                                        <h4 class=\"mb-4 pb-3\">Sign Up</h4>\r\n");
#nullable restore
#line 39 "C:\Users\natha\source\repos\ArtGallery\ArtGallery\Pages\UserAccount\Login.cshtml"
                                         if (Model.errorMessage.Length > 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <div class=\'alert alert-warning alert-dismissible fade show\' role=\'alert\'>\r\n                                                <strong>");
#nullable restore
#line 42 "C:\Users\natha\source\repos\ArtGallery\ArtGallery\Pages\UserAccount\Login.cshtml"
                                                   Write(Model.errorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                                                <button type=\'button\' class=\'btn-close\' data-bs-dismiss=\'alert\' aria-label=\'Close\'></button>\r\n                                            </div>\r\n");
#nullable restore
#line 45 "C:\Users\natha\source\repos\ArtGallery\ArtGallery\Pages\UserAccount\Login.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div class=\"form-group\">\r\n\r\n                                            <input type=\"text\" name=\"Username\" class=\"form-style\" placeholder=\"Your User Name\" id=\"logname\" autocomplete=\"off\"");
            BeginWriteAttribute("value", " value=\"", 3086, "\"", 3116, 1);
#nullable restore
#line 48 "C:\Users\natha\source\repos\ArtGallery\ArtGallery\Pages\UserAccount\Login.cshtml"
WriteAttributeValue("", 3094, Model.client.Username, 3094, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                            <i class=""input-icon uil uil-user""></i>
                                        </div>
                                        <div class=""form-group mt-2"">
                                            <input type=""email"" name=""Email"" class=""form-style"" placeholder=""Your Email"" id=""logemail"" autocomplete=""off""");
            BeginWriteAttribute("value", " value=\"", 3477, "\"", 3504, 1);
#nullable restore
#line 52 "C:\Users\natha\source\repos\ArtGallery\ArtGallery\Pages\UserAccount\Login.cshtml"
WriteAttributeValue("", 3485, Model.client.Email, 3485, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                            <i class=""input-icon uil uil-at""></i>
                                        </div>
                                        <div class=""form-group mt-2"">
                                            <input type=""password"" name=""logpass"" class=""form-style"" placeholder=""Your Password"" id=""logpass"" autocomplete=""off"">
                                            <i class=""input-icon uil uil-lock-alt""></i>
                                        </div>
                                        <div class=""form-group mt-2"">
                                            <input type=""password"" name=""Password"" class=""form-style"" placeholder=""Confirm Password"" id=""logpass"" autocomplete=""off""");
            BeginWriteAttribute("value", " value=\"", 4245, "\"", 4275, 1);
#nullable restore
#line 60 "C:\Users\natha\source\repos\ArtGallery\ArtGallery\Pages\UserAccount\Login.cshtml"
WriteAttributeValue("", 4253, Model.client.Password, 4253, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <i class=\"input-icon uil uil-lock-alt\"></i>\r\n                                        </div>\r\n");
#nullable restore
#line 63 "C:\Users\natha\source\repos\ArtGallery\ArtGallery\Pages\UserAccount\Login.cshtml"
                                         if (Model.successMessage.Length > 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""row mb-3"">
                                                <div class=""col-sm-9"">
                                                    <div class='alert alert-success alert-dismissible fade show' role='alert'>
                                                        <strong>");
#nullable restore
#line 68 "C:\Users\natha\source\repos\ArtGallery\ArtGallery\Pages\UserAccount\Login.cshtml"
                                                           Write(Model.successMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong>
                                                        <button type='button' class='btn-close' data-bs-dismiss='alert' aria-label='Close'></button>
                                                    </div>
                                                </div>
                                            </div>
");
#nullable restore
#line 73 "C:\Users\natha\source\repos\ArtGallery\ArtGallery\Pages\UserAccount\Login.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <button type=""submit"" href=""#"" class=""btn mt-4"">submit</button>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ArtGallery.Pages.User.LoginModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ArtGallery.Pages.User.LoginModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ArtGallery.Pages.User.LoginModel>)PageContext?.ViewData;
        public ArtGallery.Pages.User.LoginModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591