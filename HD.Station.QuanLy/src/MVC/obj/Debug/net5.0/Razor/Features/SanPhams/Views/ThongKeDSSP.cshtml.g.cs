#pragma checksum "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\SanPhams\Views\ThongKeDSSP.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "016ce9954d3d2fa23af597c865ed51cc51bb49f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Features_SanPhams_Views_ThongKeDSSP), @"mvc.1.0.view", @"/Features/SanPhams/Views/ThongKeDSSP.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Features/SanPhams/Views/ThongKeDSSP.cshtml", typeof(AspNetCore.Features_SanPhams_Views_ThongKeDSSP))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"016ce9954d3d2fa23af597c865ed51cc51bb49f0", @"/Features/SanPhams/Views/ThongKeDSSP.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44e4996073d576984abf173902213fa20e43f99f", @"/Features/_ViewImports.cshtml")]
    public class Features_SanPhams_Views_ThongKeDSSP : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuanLy.src.Abstractions.Data.ThongKeSanPhamViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\SanPhams\Views\ThongKeDSSP.cshtml"
  
    ViewData["Title"] = "ThongKeDSSP";

#line default
#line hidden
#line 6 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\SanPhams\Views\ThongKeDSSP.cshtml"
 if (ViewBag.Message != null)
{

#line default
#line hidden
            BeginContext(157, 87, true);
            WriteLiteral("    <script type=\"text/javascript\">\r\n    window.onload = function () {\r\n        alert(\"");
            EndContext();
            BeginContext(245, 15, false);
#line 10 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\SanPhams\Views\ThongKeDSSP.cshtml"
          Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(260, 28, true);
            WriteLiteral("\");\r\n    };\r\n    </script>\r\n");
            EndContext();
#line 13 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\SanPhams\Views\ThongKeDSSP.cshtml"
}

#line default
#line hidden
#line 14 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\SanPhams\Views\ThongKeDSSP.cshtml"
  
    var dlist = Model.GroupBy(m => m.TenSp);

#line default
#line hidden
            BeginContext(344, 271, true);
            WriteLiteral(@"
<h5>Thống kê theo từng loại sản phẩm</h5>

<p style=""text-align:right"">
    Ngày thống kê: <span id=""datetime""> </span>
    <script>
        var dt = new Date();
        document.getElementById(""datetime"").innerHTML = dt.toLocaleString();
    </script>
</p>

");
            EndContext();
#line 28 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\SanPhams\Views\ThongKeDSSP.cshtml"
 foreach (var item in dlist)
{

#line default
#line hidden
            BeginContext(648, 46, true);
            WriteLiteral("    <h6>\r\n        Tên sản phẩm: <span><strong>");
            EndContext();
            BeginContext(695, 38, false);
#line 31 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\SanPhams\Views\ThongKeDSSP.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Key));

#line default
#line hidden
            EndContext();
            BeginContext(733, 29, true);
            WriteLiteral("</strong></span>\r\n    </h6>\r\n");
            EndContext();
#line 33 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\SanPhams\Views\ThongKeDSSP.cshtml"

    decimal total = 0;


#line default
#line hidden
            BeginContext(790, 265, true);
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th>Ngày lập hóa đơn</th>
                <th>Số lượng</th>
                <th>Đơn giá</th>
                <th>Thành tiền</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 46 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\SanPhams\Views\ThongKeDSSP.cshtml"
             foreach (var itemProduct in item)
            {
                total = total + itemProduct.ThanhTien;


#line default
#line hidden
            BeginContext(1176, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1249, 51, false);
#line 52 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\SanPhams\Views\ThongKeDSSP.cshtml"
                   Write(Html.DisplayFor(modelItem => itemProduct.NgayLapHD));

#line default
#line hidden
            EndContext();
            BeginContext(1300, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1380, 49, false);
#line 55 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\SanPhams\Views\ThongKeDSSP.cshtml"
                   Write(Html.DisplayFor(modelItem => itemProduct.SoLuong));

#line default
#line hidden
            EndContext();
            BeginContext(1429, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1509, 48, false);
#line 58 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\SanPhams\Views\ThongKeDSSP.cshtml"
                   Write(Html.DisplayFor(modelItem => itemProduct.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(1557, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1637, 51, false);
#line 61 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\SanPhams\Views\ThongKeDSSP.cshtml"
                   Write(Html.DisplayFor(modelItem => itemProduct.ThanhTien));

#line default
#line hidden
            EndContext();
            BeginContext(1688, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 64 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\SanPhams\Views\ThongKeDSSP.cshtml"
            }

#line default
#line hidden
            BeginContext(1755, 171, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n    <p style=\"color:crimson; text-align:right; margin-top: 10px; margin-bottom: 20px\">\r\n        Tổng tiền: <span id=\"total_money\"> <strong>");
            EndContext();
            BeginContext(1927, 5, false);
#line 68 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\SanPhams\Views\ThongKeDSSP.cshtml"
                                              Write(total);

#line default
#line hidden
            EndContext();
            BeginContext(1932, 28, true);
            WriteLiteral("</strong></span>\r\n    </p>\r\n");
            EndContext();
#line 70 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\SanPhams\Views\ThongKeDSSP.cshtml"
}

#line default
#line hidden
            BeginContext(1963, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuanLy.src.Abstractions.Data.ThongKeSanPhamViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591