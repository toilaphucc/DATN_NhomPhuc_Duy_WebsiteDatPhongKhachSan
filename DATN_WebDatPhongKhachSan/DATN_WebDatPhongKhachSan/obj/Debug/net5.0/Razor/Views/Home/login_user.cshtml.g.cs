#pragma checksum "D:\GIT2\DATN\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Home\login_user.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20600bacb4f8257dcdd1a779a76836e86f8e28e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_login_user), @"mvc.1.0.view", @"/Views/Home/login_user.cshtml")]
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
#nullable restore
#line 1 "D:\GIT2\DATN\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\_ViewImports.cshtml"
using DATN_WebDatPhongKhachSan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GIT2\DATN\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\_ViewImports.cshtml"
using DATN_WebDatPhongKhachSan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20600bacb4f8257dcdd1a779a76836e86f8e28e0", @"/Views/Home/login_user.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a33e98feb92e4d3b91cf17b1616085778ef81795", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_login_user : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#!"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\GIT2\DATN\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Home\login_user.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\GIT2\DATN\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Home\login_user.cshtml"
  
    Layout = "_layout_login_user";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div class=""container-fluid p-0 w-login"">
      <div class=""row no-gutters"">
        <div class=""col-sm-7 login-card-wrapper"">
            <div class=""card login-card"">
              <div class=""card-body"">
                <h2 class=""login-card-title"">Đăng nhập với đối tác</h2>
                <p class=""login-card-description"">Sign into your account</p>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20600bacb4f8257dcdd1a779a76836e86f8e28e04454", async() => {
                WriteLiteral(@"
                  <div class=""form-group"">
                    <label for=""email"" class=""sr-only"">Email</label>
                    <input type=""email"" name=""email"" id=""email"" class=""form-control"" placeholder=""Email"">
                  </div>
                  <div class=""form-group"">
                    <label for=""password"" class=""sr-only"">Password</label>
                    <input type=""password"" name=""password"" id=""password"" class=""form-control"" placeholder=""Password"">
                  </div>
                  <div class=""form-options-wrapper"">
                    <div class=""custom-control custom-checkbox login-card-check-box"">
                      <input type=""checkbox"" class=""custom-control-input"" id=""customCheck1"">
                      <label class=""custom-control-label"" for=""customCheck1"">Remember me</label>
                    </div>
                    <a href=""#!"" class=""text-reset"">Forgot password?</a>
                  </div>
                  <input name=""login"" id=""login"" ");
                WriteLiteral("class=\"btn btn-block login-btn\" type=\"button\" value=\"Sign In\">\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <p class=\"login-card-footer-text\">Need an account?<a href=\"#!\" class=\"text-reset\">Signup</a></p>\r\n              </div>\r\n            </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  ");
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
