#pragma checksum "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\HomeDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f97350eff1e25f4a7aad7b41c5d65a2edb955c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rooms_HomeDetail), @"mvc.1.0.view", @"/Views/Rooms/HomeDetail.cshtml")]
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
#line 1 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\_ViewImports.cshtml"
using DATN_WebDatPhongKhachSan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\_ViewImports.cshtml"
using DATN_WebDatPhongKhachSan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f97350eff1e25f4a7aad7b41c5d65a2edb955c2", @"/Views/Rooms/HomeDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a33e98feb92e4d3b91cf17b1616085778ef81795", @"/Views/_ViewImports.cshtml")]
    public class Views_Rooms_HomeDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DATN_WebDatPhongKhachSan.Models.Room>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/product-details/new.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("newarrival"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\HomeDetail.cshtml"
  
    ViewData["Title"] = "Chi Tiết Phòng "+ @Html.DisplayFor(model => model.Name);
    Layout = "~/Views/Shared/_LayoutIndex.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"product-details\">\r\n    <!--product-details-->\r\n    <div class=\"col-sm-5\">\r\n        <div class=\"view-product\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2f97350eff1e25f4a7aad7b41c5d65a2edb955c24911", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 337, "~/assets/images/", 337, 16, true);
#nullable restore
#line 12 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\HomeDetail.cshtml"
AddHtmlAttributeValue("", 353, Html.DisplayFor(model => model.Image), 353, 38, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-sm-7\">\r\n        <div class=\"product-information\">\r\n            <!--/product-information-->\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2f97350eff1e25f4a7aad7b41c5d65a2edb955c26722", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <h1 style=\"font-weight:800;color:orange\">");
#nullable restore
#line 19 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\HomeDetail.cshtml"
                                                Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <p><b>Mã phòng:</b>");
#nullable restore
#line 20 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\HomeDetail.cshtml"
                          Write(Html.DisplayFor(model => model.RoomCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <img src=\"images/product-details/rating.png\"");
            BeginWriteAttribute("alt", " alt=\"", 861, "\"", 867, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <span>\r\n                <span>");
#nullable restore
#line 23 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\HomeDetail.cshtml"
                 Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" VNĐ</span>
                <label>Số phòng trống :</label>
                <input type=""text"" value=""3"" />
                <button type=""button"" class=""btn btn-fefault cart"">
                    <i class=""fa fa-shopping-cart""></i>
                    Thêm vào giỏ hàng
                </button>
            </span>
            <p><b>Loại phòng:</b> ");
#nullable restore
#line 31 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\HomeDetail.cshtml"
                             Write(Html.DisplayFor(model => model.RoomType.RoomTypeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>\r\n                <b>\r\n");
#nullable restore
#line 34 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\HomeDetail.cshtml"
                     if (Model.AmountRoom>0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h4 style=\"color:green\">Còn phòng</h4>\r\n");
#nullable restore
#line 37 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\HomeDetail.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4 style=\"color:red\">Hết phòng</h4>");
#nullable restore
#line 39 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\HomeDetail.cshtml"
                                                         }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </b>\r\n            </p>\r\n        </div><!--/product-information-->\r\n    </div>\r\n</div><!--/product-details-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DATN_WebDatPhongKhachSan.Models.Room> Html { get; private set; }
    }
}
#pragma warning restore 1591