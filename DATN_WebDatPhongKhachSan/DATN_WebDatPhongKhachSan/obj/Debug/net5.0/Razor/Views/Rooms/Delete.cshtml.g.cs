#pragma checksum "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed5bad02d70c4eaaede1c3a100f47ba723f01e1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rooms_Delete), @"mvc.1.0.view", @"/Views/Rooms/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed5bad02d70c4eaaede1c3a100f47ba723f01e1b", @"/Views/Rooms/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a33e98feb92e4d3b91cf17b1616085778ef81795", @"/Views/_ViewImports.cshtml")]
    public class Views_Rooms_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DATN_WebDatPhongKhachSan.Models.Room>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_layout_admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Room</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Owner));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Owner.OwnerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RoomCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RoomCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Detail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Detail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AmountRoom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AmountRoom));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IsActive));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RoomType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RoomType.RoomTypeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TagID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TagID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 70 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 73 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 76 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 79 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 82 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ModifiedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 85 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ModifiedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed5bad02d70c4eaaede1c3a100f47ba723f01e1b13956", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ed5bad02d70c4eaaede1c3a100f47ba723f01e1b14223", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 90 "E:\DATN_2\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Rooms\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RoomID);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed5bad02d70c4eaaede1c3a100f47ba723f01e1b16062", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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