#pragma checksum "E:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dcf72dddbde28851efc61f18ec53155ff4434fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Owners_Details), @"mvc.1.0.view", @"/Views/Owners/Details.cshtml")]
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
#line 1 "E:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\_ViewImports.cshtml"
using DATN_WebDatPhongKhachSan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\_ViewImports.cshtml"
using DATN_WebDatPhongKhachSan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0dcf72dddbde28851efc61f18ec53155ff4434fb", @"/Views/Owners/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a33e98feb92e4d3b91cf17b1616085778ef81795", @"/Views/_ViewImports.cshtml")]
    public class Views_Owners_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DATN_WebDatPhongKhachSan.Models.Owner>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Details.cshtml"
  
    ViewData["Title"] = "Th??ng tin ??i???m cho thu??";
    Layout = "~/Views/Shared/_layout_admin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>??i???m cho thu?? c???a ");
#nullable restore
#line 8 "E:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Details.cshtml"
                 Write(Model.User.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            T??n t??i kho???n\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "E:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Details.cshtml"
       Write(Html.DisplayFor(model => model.User.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ?????a ch???\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "E:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 23 "E:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Details.cshtml"
                                                 Write(Html.DisplayFor(model => model.Ward));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n            ");
#nullable restore
#line 24 "E:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Details.cshtml"
       Write(Html.DisplayFor(model => model.District));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 24 "E:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Details.cshtml"
                                                  Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Lo???i h??nh kinh doanh\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 30 "E:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Details.cshtml"
             if (Model.IsHotel == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h6>Kh??ch s???n</h6>\r\n");
#nullable restore
#line 33 "E:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Details.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h6>Ph??ng cho thu??</h6>");
#nullable restore
#line 35 "E:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Details.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "E:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HotelName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "E:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Details.cshtml"
       Write(Html.DisplayFor(model => model.HotelName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "E:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "E:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Details.cshtml"
       Write(String.Format("{0:dd/MM/yyyy}", Model.CreatedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            Ch???nh s???a l???n cu???i\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "E:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Details.cshtml"
       Write(String.Format("{0:dd/MM/yyyy}", Model.ModifiedOn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dcf72dddbde28851efc61f18ec53155ff4434fb9537", async() => {
                WriteLiteral("Ch???nh s???a");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "E:\DATN\DATN_NhomPhuc_Duy_WebsiteDatPhongKhachSan\DATN_WebDatPhongKhachSan\DATN_WebDatPhongKhachSan\Views\Owners\Details.cshtml"
                           WriteLiteral(Model.OwnerID);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0dcf72dddbde28851efc61f18ec53155ff4434fb11737", async() => {
                WriteLiteral("Quay l???i");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DATN_WebDatPhongKhachSan.Models.Owner> Html { get; private set; }
    }
}
#pragma warning restore 1591
