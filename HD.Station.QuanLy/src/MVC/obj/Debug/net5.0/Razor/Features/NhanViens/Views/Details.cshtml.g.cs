#pragma checksum "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\NhanViens\Views\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "229b916541ac4e75f5dfd0f98eb5679d6b426526"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Features_NhanViens_Views_Details), @"mvc.1.0.view", @"/Features/NhanViens/Views/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Features/NhanViens/Views/Details.cshtml", typeof(AspNetCore.Features_NhanViens_Views_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"229b916541ac4e75f5dfd0f98eb5679d6b426526", @"/Features/NhanViens/Views/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44e4996073d576984abf173902213fa20e43f99f", @"/Features/_ViewImports.cshtml")]
    public class Features_NhanViens_Views_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuanLy.src.Abstractions.Data.NhanVien>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "QuanLy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HoaDons", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "h.MaHD", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "KhachHangs", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "h.MaKH", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\NhanViens\Views\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(91, 166, true);
            WriteLiteral("\r\n<h3>Th??ng tin v??? nh??n vi??n</h3>\r\n\r\n<div>\r\n    <hr />\r\n    <div class=\"container\">\r\n        <dl class=\"row\">\r\n            <dt class=\"col col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(258, 40, false);
#line 14 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\NhanViens\Views\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.HoNV));

#line default
#line hidden
            EndContext();
            BeginContext(298, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(317, 41, false);
#line 15 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\NhanViens\Views\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.TenNV));

#line default
#line hidden
            EndContext();
            BeginContext(358, 76, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(435, 36, false);
#line 18 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\NhanViens\Views\Details.cshtml"
           Write(Html.DisplayFor(model => model.HoNV));

#line default
#line hidden
            EndContext();
            BeginContext(471, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(490, 37, false);
#line 19 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\NhanViens\Views\Details.cshtml"
           Write(Html.DisplayFor(model => model.TenNV));

#line default
#line hidden
            EndContext();
            BeginContext(527, 196, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col col-sm-3\">\r\n\r\n            </dt>\r\n            <dd class=\"col col-sm-3\">\r\n\r\n            </dd>\r\n            <dt class=\"col col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(724, 46, false);
#line 28 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\NhanViens\Views\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.GioiTinhNV));

#line default
#line hidden
            EndContext();
            BeginContext(770, 57, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col -sm-3\">\r\n");
            EndContext();
#line 31 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\NhanViens\Views\Details.cshtml"
                 if (@Model.GioiTinhNV == true)
                {

#line default
#line hidden
            BeginContext(895, 31, true);
            WriteLiteral("                    <p>N???</p>\r\n");
            EndContext();
#line 34 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\NhanViens\Views\Details.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(986, 32, true);
            WriteLiteral("                    <p>Nam</p>\r\n");
            EndContext();
#line 38 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\NhanViens\Views\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(1037, 74, true);
            WriteLiteral("            </dd>\r\n            <dt class=\"col col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(1112, 44, false);
#line 41 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\NhanViens\Views\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.NgaySinh));

#line default
#line hidden
            EndContext();
            BeginContext(1156, 76, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(1233, 40, false);
#line 44 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\NhanViens\Views\Details.cshtml"
           Write(Html.DisplayFor(model => model.NgaySinh));

#line default
#line hidden
            EndContext();
            BeginContext(1273, 76, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(1350, 42, false);
#line 47 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\NhanViens\Views\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(1392, 76, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(1469, 38, false);
#line 50 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\NhanViens\Views\Details.cshtml"
           Write(Html.DisplayFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(1507, 76, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(1584, 45, false);
#line 53 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\NhanViens\Views\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.DienThoai));

#line default
#line hidden
            EndContext();
            BeginContext(1629, 76, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col col-sm-3\">\r\n                ");
            EndContext();
            BeginContext(1706, 41, false);
#line 56 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\NhanViens\Views\Details.cshtml"
           Write(Html.DisplayFor(model => model.DienThoai));

#line default
#line hidden
            EndContext();
            BeginContext(1747, 410, true);
            WriteLiteral(@"
            </dd>
        </dl>
    </div>
    <div>
        <p>Danh s??ch h??a ????n</p>
        <table class=""table"">
            <thead>
                <tr>
                    <th>M?? h??a ????n</th>
                    <th>M?? kh??ch h??ng</th>
                    <th>Ng??y l???p h??a ????n</th>
                    <th>Ng??y nh???n h??ng</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 72 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\NhanViens\Views\Details.cshtml"
                 foreach (var h in @Model.HoaDons)
                {

#line default
#line hidden
            BeginContext(2228, 84, true);
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2312, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "229b916541ac4e75f5dfd0f98eb5679d6b42652612362", async() => {
                BeginContext(2402, 6, false);
#line 76 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\NhanViens\Views\Details.cshtml"
                                                                                                                Write(h.MaHD);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2412, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2503, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "229b916541ac4e75f5dfd0f98eb5679d6b42652614973", async() => {
                BeginContext(2596, 6, false);
#line 79 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\NhanViens\Views\Details.cshtml"
                                                                                                                   Write(h.MaKH);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2606, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2698, 41, false);
#line 82 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\NhanViens\Views\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => h.NgayLapHD));

#line default
#line hidden
            EndContext();
            BeginContext(2739, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(2831, 44, false);
#line 85 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\NhanViens\Views\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => h.NgayNhanHang));

#line default
#line hidden
            EndContext();
            BeginContext(2875, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 88 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\NhanViens\Views\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(2954, 71, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3025, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "229b916541ac4e75f5dfd0f98eb5679d6b42652618862", async() => {
                BeginContext(3065, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3081, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLy.src.Abstractions.Data.NhanVien> Html { get; private set; }
    }
}
#pragma warning restore 1591
