#pragma checksum "D:\GIT2\DATN\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\HomeIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0739dd302b370bca49ade1f9f90ec766ee6f7eb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rooms_HomeIndex), @"mvc.1.0.view", @"/Views/Rooms/HomeIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0739dd302b370bca49ade1f9f90ec766ee6f7eb7", @"/Views/Rooms/HomeIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a33e98feb92e4d3b91cf17b1616085778ef81795", @"/Views/_ViewImports.cshtml")]
    public class Views_Rooms_HomeIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DATN_WebDatPhongKhachSan.Models.Room>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("200"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: #ee5057"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HomeDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Rooms", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\GIT2\DATN\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\HomeIndex.cshtml"
  
    ViewData["Title"] = "Trang chủ";
    Layout = "~/Views/Shared/_LayoutIndex.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 9 "D:\GIT2\DATN\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\HomeIndex.cshtml"
     foreach (var room in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-3\">\r\n            <div class=\"product-image-wrapper\" width=\"300\" height=\"300\">\r\n                <div class=\"single-products\">\r\n                    <div class=\"productinfo text-center\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0739dd302b370bca49ade1f9f90ec766ee6f7eb76153", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 465, "~/assets/images/", 465, 16, true);
#nullable restore
#line 15 "D:\GIT2\DATN\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\HomeIndex.cshtml"
AddHtmlAttributeValue("", 481, room.Image.Trim(), 481, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            WriteLiteral("\r\n                        <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0739dd302b370bca49ade1f9f90ec766ee6f7eb77932", async() => {
#nullable restore
#line 16 "D:\GIT2\DATN\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\HomeIndex.cshtml"
                                                                                                                            Write(room.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 16 "D:\GIT2\DATN\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\HomeIndex.cshtml"
                                                                                WriteLiteral(room.RoomID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\r\n                        <p>");
#nullable restore
#line 17 "D:\GIT2\DATN\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\HomeIndex.cshtml"
                      Write(room.Price.ToString(("#,##0. VNĐ")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p style=\"margin-left:5px\">");
#nullable restore
#line 18 "D:\GIT2\DATN\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\HomeIndex.cshtml"
                                              Write(room.Detail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p style=\"margin-left:5px\">");
#nullable restore
#line 19 "D:\GIT2\DATN\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\HomeIndex.cshtml"
                                              Write(room.RoomType.RoomTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p style=\"margin-left:5px\"> ");
#nullable restore
#line 20 "D:\GIT2\DATN\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\HomeIndex.cshtml"
                                               Write(room.AmountRoom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p style=\"margin-left:5px\">");
#nullable restore
#line 21 "D:\GIT2\DATN\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\HomeIndex.cshtml"
                                              Write(room.Owner.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <a asp- href=\"#\" class=\"btn btn-default\"><i");
            BeginWriteAttribute("class", " class=\"", 1123, "\"", 1131, 0);
            EndWriteAttribute();
            WriteLiteral("></i>Đặt phòng ngay</a>\r\n                    </div>\r\n                </div>\r\n                <div class=\"choose\">\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 30 "D:\GIT2\DATN\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\HomeIndex.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DATN_WebDatPhongKhachSan.Models.Room>> Html { get; private set; }
    }
}
#pragma warning restore 1591
