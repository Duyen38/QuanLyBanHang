#pragma checksum "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\HoaDons\Views\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5246835fa3659596a16f308e799489afbf98b20b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Features_HoaDons_Views_Details), @"mvc.1.0.view", @"/Features/HoaDons/Views/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Features/HoaDons/Views/Details.cshtml", typeof(AspNetCore.Features_HoaDons_Views_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5246835fa3659596a16f308e799489afbf98b20b", @"/Features/HoaDons/Views/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44e4996073d576984abf173902213fa20e43f99f", @"/Features/_ViewImports.cshtml")]
    public class Features_HoaDons_Views_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuanLy.src.Abstractions.Data.HoaDon>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "QuanLy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("MaSP"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\HoaDons\Views\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(89, 30, true);
            WriteLiteral("\r\n<h3>Thông tin hóa đơn <span>");
            EndContext();
            BeginContext(120, 36, false);
#line 7 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\HoaDons\Views\Details.cshtml"
                       Write(Html.DisplayFor(model => model.MaHD));

#line default
#line hidden
            EndContext();
            BeginContext(156, 166, true);
            WriteLiteral("</span></h3>\r\n<hr />\r\n<div>\r\n    <div>\r\n        <div class=\"container\">\r\n            <dl class=\"row\">\r\n                <dt class=\"col col-sm-3\">\r\n                    ");
            EndContext();
            BeginContext(323, 50, false);
#line 14 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\HoaDons\Views\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.KhachHang.MaKH));

#line default
#line hidden
            EndContext();
            BeginContext(373, 90, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col col-sm-3\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 463, "\"", 542, 1);
#line 17 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\HoaDons\Views\Details.cshtml"
WriteAttributeValue("", 470, Url.Action("Details", "KhachHangs", new { id = @Model.KhachHang.MaKH }), 470, 72, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(543, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(571, 46, false);
#line 18 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\HoaDons\Views\Details.cshtml"
                   Write(Html.DisplayFor(model => model.KhachHang.MaKH));

#line default
#line hidden
            EndContext();
            BeginContext(617, 114, true);
            WriteLiteral("\r\n                    </a>\r\n                </dd>\r\n                <dt class=\"col col-sm-3\">\r\n                    ");
            EndContext();
            BeginContext(732, 49, false);
#line 22 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\HoaDons\Views\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.NhanVien.MaNV));

#line default
#line hidden
            EndContext();
            BeginContext(781, 90, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col col-sm-3\">\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 871, "\"", 948, 1);
#line 25 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\HoaDons\Views\Details.cshtml"
WriteAttributeValue("", 878, Url.Action("Details", "NhanViens", new { id = @Model.NhanVien.MaNV }), 878, 70, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(949, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(977, 45, false);
#line 26 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\HoaDons\Views\Details.cshtml"
                   Write(Html.DisplayFor(model => model.NhanVien.MaNV));

#line default
#line hidden
            EndContext();
            BeginContext(1022, 164, true);
            WriteLiteral("\r\n                    </a>\r\n                </dd>\r\n            </dl>\r\n            <dl class=\"row \">\r\n                <dt class=\"col col-sm-3\">\r\n                    ");
            EndContext();
            BeginContext(1187, 45, false);
#line 32 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\HoaDons\Views\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.NgayLapHD));

#line default
#line hidden
            EndContext();
            BeginContext(1232, 84, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col-sm-3\">\r\n                    ");
            EndContext();
            BeginContext(1317, 41, false);
#line 35 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\HoaDons\Views\Details.cshtml"
               Write(Html.DisplayFor(model => model.NgayLapHD));

#line default
#line hidden
            EndContext();
            BeginContext(1358, 88, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt class=\"col col-sm-3\">\r\n                    ");
            EndContext();
            BeginContext(1447, 48, false);
#line 38 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\HoaDons\Views\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.NgayNhanHang));

#line default
#line hidden
            EndContext();
            BeginContext(1495, 88, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd class=\"col col-sm-3\">\r\n                    ");
            EndContext();
            BeginContext(1584, 44, false);
#line 41 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\HoaDons\Views\Details.cshtml"
               Write(Html.DisplayFor(model => model.NgayNhanHang));

#line default
#line hidden
            EndContext();
            BeginContext(1628, 151, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n    </div>\r\n\r\n    <h5>\r\n        Chi tiết hóa đơn\r\n        <span style=\"text-align:right\">\r\n");
            EndContext();
            BeginContext(1908, 499, true);
            WriteLiteral(@"            <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#modalCreate"">
                <i class=""fas fa-cart-plus""></i> Create
            </button>
        </span>
    </h5>
    <div>
        <table class=""table ml-5"">
            <thead>
                <tr>
                    <th>Mã sản phẩm</th>
                    <th>Số lượng</th>
                    <th></th>
                </tr>
            </thead>
            <tbody id=""data-table"">
");
            EndContext();
            BeginContext(3380, 71, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3451, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5246835fa3659596a16f308e799489afbf98b20b11788", async() => {
                BeginContext(3491, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3507, 717, true);
            WriteLiteral(@"
</div>

<!-- Modal Create -->
<div class=""modal fade"" id=""modalCreate"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""create-new"">Thêm sản phẩm vào hóa đơn</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-md-4"">
                        ");
            EndContext();
            BeginContext(4224, 1225, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5246835fa3659596a16f308e799489afbf98b20b14126", async() => {
                BeginContext(4230, 228, true);
                WriteLiteral("\r\n                            <div class=\"form-group\">\r\n                                <label for=\"MaHD\" class=\"control-label\"> Mã hóa đơn </label>\r\n                                <input id=\"MaHD\" class=\"form-control\" readonly");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4458, "\"", 4477, 1);
#line 107 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\HoaDons\Views\Details.cshtml"
WriteAttributeValue("", 4466, Model.MaHD, 4466, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4478, 220, true);
                WriteLiteral("/>\r\n                            </div>\r\n                            <div class=\"form-group\">\r\n                                <label for=\"MaSP\" class=\"control-label\">Mã sản phẩm </label>\r\n                                ");
                EndContext();
                BeginContext(4698, 420, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5246835fa3659596a16f308e799489afbf98b20b15419", async() => {
                    BeginContext(4762, 38, true);
                    WriteLiteral("\r\n                                    ");
                    EndContext();
                    BeginContext(4800, 39, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5246835fa3659596a16f308e799489afbf98b20b15862", async() => {
                        BeginContext(4817, 13, true);
                        WriteLiteral("Chọn sản phẩm");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(4839, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 113 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\HoaDons\Views\Details.cshtml"
                                         foreach( var sp in ViewBag.MaSP)
                                        {

#line default
#line hidden
                    BeginContext(4959, 44, true);
                    WriteLiteral("                                            ");
                    EndContext();
                    BeginContext(5003, 29, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5246835fa3659596a16f308e799489afbf98b20b17848", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 115 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\HoaDons\Views\Details.cshtml"
                                               WriteLiteral(sp);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(5032, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 116 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\HoaDons\Views\Details.cshtml"
                                        }

#line default
#line hidden
                    BeginContext(5077, 32, true);
                    WriteLiteral("                                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#line 111 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\HoaDons\Views\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.MaSP;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5118, 324, true);
                WriteLiteral(@"
                            </div>
                            <div class=""form-group"">
                                <label for=""SoLuong"" class=""control-label""> Số lượng </label>
                                <input id=""SoLuong"" class=""form-control"" />
                            </div>
                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5449, 2329, true);
            WriteLiteral(@"
                    </div>
                </div>

                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-primary"" id=""btnSave"">Save changes</button>
                </div>
            </div>
        </div>
    </div>
</div>

<!-- Modal Edit -->
<div class=""modal fade"" id=""modalEdit"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""create-new"">Cập nhật thông tin hóa đơn</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""containe");
            WriteLiteral(@"r"">
                    <div class=""row"">
                        <div class=""col-sm-6"">
                            <div class=""form-group"">
                                <label for=""MaHD"" class=""control-label""> Mã hóa đơn </label>
                                <input id=""editMaHD"" class=""form-control"" readonly />
                            </div>
                            <div class=""form-group"">
                                <label for=""MaSP"" class=""control-label"">Mã sản phẩm </label>
                                <input id=""editMaSP"" class=""form-control"" readonly />
                            </div>
                            <div class=""form-group"">
                                <label for=""SoLuong"" class=""control-label""> Số lượng </label>
                                <input id=""editSoLuong"" class=""form-control"" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div cla");
            WriteLiteral(@"ss=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"" id=""btnEditSave"">Save changes</button>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(7795, 100, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(document).ready(function () {\r\n            GetData(");
                EndContext();
                BeginContext(7896, 10, false);
#line 177 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\HoaDons\Views\Details.cshtml"
               Write(Model.MaHD);

#line default
#line hidden
                EndContext();
                BeginContext(7906, 5797, true);
                WriteLiteral(@");

            $('#btnSave').click(function () {
                if (IsValidate()) {
                    var model = {
                        ""MaHD"": $('#MaHD').val(),
                        ""MaSP"": $('#MaSP').val(),
                        ""SoLuong"": $('#SoLuong').val()
                    };
                    $.ajax({
                        url: '/QuanLy/ChiTietHoaDons/Create',
                        dataType: 'json',
                        type: 'POST',
                        data: model,
                        success: function (res) {
                            if (res.success) {
                                GetData(model.MaHD);
                            }
                        },
                        error: function (xhr) { alert('error'); }
                    });
                }
            });
            //Edit
            $('body').on('click', '.btnEdit', function () {
                var id = $(this).data('id');
                var sp = $(this).data");
                WriteLiteral(@"('sp');
                console.log(""edit clicked "" + id + sp);
                GetDataById(id, sp);
            });

            //Save info from modal edit/update
            $('#btnEditSave').click(function () {
                var model = {
                    ""MaHD"": $('#editMaHD').val(),
                    ""MaSP"": $('#editMaSP').val(),
                    ""SoLuong"": $('#editSoLuong').val()
                };
                $.ajax({
                    url: '/QuanLy/ChiTietHoaDons/Edit',
                    dataType: 'json',
                    type: 'POST',
                    data: model,
                    success: function (res) {
                        alert(""Cập nhật thành công."");
                        if (res.success) {
                            $('#modalEdit').modal('hide');
                            GetData(model.MaHD);
                        }
                    },
                    error: function (xhr) { alert('error'); }
                });
          ");
                WriteLiteral(@"  });

            //Delete
            $('body').on('click', '.btnDelete', function () {
                var id = $(this).data('id');
                var sp = $(this).data('sp');
                console.log(""btndelete clicked "" + id + sp);
                var conf = confirm('Xác nhận xóa khỏi hóa đơn?');
                if (conf) {
                    Delete(id, sp);
                }
            });
        });
        function GetDataById(id, maSP) {
            $.ajax({
                url: '/QuanLy/ChiTietHoaDons/GetDataById',
                type: 'GET',
                data: { id: id, maSP: maSP },
                success: function (res) {
                    if (res.success) {
                        if (res.data != null) {
                            $('#editMaHD').val(res.data.result.maHD);
                            $('#editMaSP').val(res.data.result.maSP);
                            $('#editSoLuong').val(res.data.result.soLuong);
                            $('#modalEdit'");
                WriteLiteral(@").modal('show');
                        }
                    }
                },
                error: function (xhr) { alert('error'); }
            });
        };

        function GetData(id) {
            $.ajax({
                url: '/QuanLy/ChiTietHoaDons/GetData/'+id,
                type: 'GET',
                success: function (res) {
                    if (res.totalItem > 0) {
                        var list = res.data;
                        var html = """";
                        for (let i = 0; i < res.totalItem; i++) {
                            url_sp = ""/QuanLy/SanPhams/Details/"" + list[i].maSP;

                            html += ""<tr id='tr"" + list[i].maHD + ""'>"";
                            html += ""<td><a href='"" + url_sp + ""'>"" + list[i].maSP + ""</a></td>"";
                            html += ""<td>"" + list[i].soLuong + ""</td>"";
                            html += ""<td><a class='btn btn-warning btnEdit' data-id='"" + list[i].maHD + ""' data-sp='""+list[i].maSP+");
                WriteLiteral(@"""'>Edit</a> | "" +
                                ""<a class='btn btn-danger btnDelete' data-id='"" + list[i].maHD + ""' data-sp='""+list[i].maSP+""'>Delete</a></td > "";
                            html += ""</tr>"";
                        }
                        $('#data-table').html(html);
                    }
                },
                error: function (xhr) { alert('error'); }
            });
        }

        function Delete(id, maSP) {
            $.ajax({
                url: '/QuanLy/ChiTietHoaDons/Delete',
                type: 'POST',
                data: { id: id, maSP: maSP },
                success: function (res) {
                    if (res.success) {
                        alert(""Xóa thành công!"");
                        //$('#tr' + id).remove();
                        GetData();
                    } else {
                        console.log(""Error!"");
                    }
                },
                error: function (xhr) { alert('error'); }
     ");
                WriteLiteral(@"       });
        }
        function IsValidate() {
            var check = false;

            if ($('#MaSP').val() == '') {
                $('#MaSP').next().html('Mời nhập mã sán phẩm!');
                check = false; return;
            } else {
                $('#MaSP').next().html('');
                check = true;
            }

            if ($('#Soluong').val() == '') {
                $('#Soluong').next().html('Mời nhập số lượng!');
                check = false; return;
            } else {
                $('#Soluong').next().html('');
                check = true;
            }
            return check;
        }

    </script>
");
                EndContext();
            }
            );
            BeginContext(13706, 4, true);
            WriteLiteral("    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLy.src.Abstractions.Data.HoaDon> Html { get; private set; }
    }
}
#pragma warning restore 1591
