#pragma checksum "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b8d43c49cdcdbe37bde0ea1e93369f1db25b930"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Owners_Index), @"mvc.1.0.view", @"/Views/Owners/Index.cshtml")]
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
#line 1 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\_ViewImports.cshtml"
using DATN_WebDatPhongKhachSan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\_ViewImports.cshtml"
using DATN_WebDatPhongKhachSan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b8d43c49cdcdbe37bde0ea1e93369f1db25b930", @"/Views/Owners/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a33e98feb92e4d3b91cf17b1616085778ef81795", @"/Views/_ViewImports.cshtml")]
    public class Views_Owners_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DATN_WebDatPhongKhachSan.Models.Owner>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml"
  
    ViewData["Title"] = "Danh mục chủ phòng";
    Layout = "~/Views/Shared/_layout_admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Danh mục chủ phòng</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b8d43c49cdcdbe37bde0ea1e93369f1db25b9304874", async() => {
                WriteLiteral("Thêm chủ phòng mới");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UserID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ward));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.District));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsHotel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HotelName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ModifiedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 47 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Ward));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.District));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsHotel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HotelName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ModifiedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b8d43c49cdcdbe37bde0ea1e93369f1db25b93013029", async() => {
                WriteLiteral("Sửa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 77 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml"
                                       WriteLiteral(item.OwnerID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b8d43c49cdcdbe37bde0ea1e93369f1db25b93015245", async() => {
                WriteLiteral("Chi tiết");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml"
                                          WriteLiteral(item.OwnerID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b8d43c49cdcdbe37bde0ea1e93369f1db25b93017469", async() => {
                WriteLiteral("Xóa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml"
                                         WriteLiteral(item.OwnerID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 82 "D:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DATN_WebDatPhongKhachSan.Models.Owner>> Html { get; private set; }
    }
}
#pragma warning restore 1591
