#pragma checksum "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\SanPhams\Views\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4bfb214b4a325a9538f132365ab5364d0948dc7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Features_SanPhams_Views_Index), @"mvc.1.0.view", @"/Features/SanPhams/Views/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Features/SanPhams/Views/Index.cshtml", typeof(AspNetCore.Features_SanPhams_Views_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4bfb214b4a325a9538f132365ab5364d0948dc7c", @"/Features/SanPhams/Views/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44e4996073d576984abf173902213fa20e43f99f", @"/Features/_ViewImports.cshtml")]
    public class Features_SanPhams_Views_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<QuanLy.src.Abstractions.Data.SanPham>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "QuanLy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ThongKeDSSP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\SanPhams\Views\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(101, 49, true);
            WriteLiteral("\r\n<h3 style=\"\">Danh sách sản phẩm</h3>\r\n<p>\r\n    ");
            EndContext();
            BeginContext(150, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bfb214b4a325a9538f132365ab5364d0948dc7c4738", async() => {
                BeginContext(196, 27, true);
                WriteLiteral("Thống kê danh sách sản phẩm");
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
            BeginContext(227, 555, true);
            WriteLiteral(@"
</p>
<div class=""row"">
    <div class=""col-md-7"">
        <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#modalCreate"">
            Create
        </button>
    </div>    
    <div class=""col-sm-5 text-right"">
        Ngày: <span id=""datetime""> </span>
        <script>
            var dt = new Date();
            document.getElementById(""datetime"").innerHTML = dt.toLocaleString();
        </script>
    </div>
</div>

<table class=""table"">
    <thead>
        <tr>
            <th>
                ");
            EndContext();
            BeginContext(783, 41, false);
#line 30 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\SanPhams\Views\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TenSp));

#line default
#line hidden
            EndContext();
            BeginContext(824, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(880, 45, false);
#line 33 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\SanPhams\Views\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DonViTinh));

#line default
#line hidden
            EndContext();
            BeginContext(925, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(981, 42, false);
#line 36 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\SanPhams\Views\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DonGia));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 777, true);
            WriteLiteral(@"
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody id=""data-table""></tbody>
</table>

<!-- Modal create -->
<div class=""modal fade"" id=""modalCreate"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""create-new"">Thêm sản phẩm mới</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""container"">
                    ");
            EndContext();
            BeginContext(1800, 1910, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bfb214b4a325a9538f132365ab5364d0948dc7c8957", async() => {
                BeginContext(1806, 129, true);
                WriteLiteral("\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-6\">\r\n                                ");
                EndContext();
                BeginContext(1935, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4bfb214b4a325a9538f132365ab5364d0948dc7c9477", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 59 "C:\Users\duyenNH\source\repos\HD.Station.QuanLy\src\MVC\Features\SanPhams\Views\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2001, 237, true);
                WriteLiteral("\r\n                                <div class=\"form-group\">\r\n                                    <label for=\"MaSP\" class=\"control-label\"> Mã sản phẩm </label>\r\n                                    <input id=\"MaSP\" class=\"form-control\" />\r\n");
                EndContext();
                BeginContext(2339, 275, true);
                WriteLiteral(@"                                </div>
                                <div class=""form-group"">
                                    <label for=""DonGia"" class=""control-label""> Đơn giá </label>
                                    <input id=""DonGia"" class=""form-control"" />
");
                EndContext();
                BeginContext(2717, 365, true);
                WriteLiteral(@"                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label for=""TenSp"" class=""control-label"">Tên sản phẩm </label>
                                    <input id=""TenSp"" class=""form-control"" />
");
                EndContext();
                BeginContext(3184, 285, true);
                WriteLiteral(@"                                </div>
                                <div class=""form-group"">
                                    <label for=""DonViTinh"" class=""control-label""> Đơn vị tính </label>
                                    <input id=""DonViTinh"" class=""form-control"" />
");
                EndContext();
                BeginContext(3575, 128, true);
                WriteLiteral("                                </div>\r\n                            </div>\r\n                        </div>\r\n                    ");
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
            BeginContext(3710, 2665, true);
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
<!-- Modal Edit -->
<div class=""modal fade"" id=""modalEdit"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""create-new"">Cập nhật thông tin sản phẩm</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""container"">
                    <div class=""row"">
   ");
            WriteLiteral(@"                     <div class=""col-sm-6"">
                            <div class=""form-group"">
                                <label for=""MaSP"" class=""control-label""> Mã sản phẩm </label>
                                <input type=""text"" class=""form-control"" id=""editMaSP"" readonly />
                            </div>
                            <div class=""form-group"">
                                <label for=""TenSp"" class=""control-label""> Tên sản phẩm</label>
                                <input type=""text"" class=""form-control"" id=""editTenSp"" />
                            </div>
                        </div>
                        <div class=""col-sm-6"">
                            <div class=""form-group"">
                                <label for=""DonGia"" class=""control-label""> Đơn giá </label>
                                <input type=""text"" id=""editDonGia"" class=""form-control"" />
                            </div>
                            <div class=""form-group"">
         ");
            WriteLiteral(@"                       <label for=""DonViTinh"" class=""control-label""> Đơn vị tính </label>
                                <input id=""editDonViTinh"" class=""form-control"" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"" id=""btnEditSave"">Save changes</button>
            </div>
        </div>
    </div>
</div>


");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6392, 6103, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            GetData();

            $('#btnSave').click(function () {
                if (IsValidate()) {
                    var model = {
                        ""MaSP"": $('#MaSP').val(),
                        ""TenSp"": $('#TenSp').val(),
                        ""DonGia"": $('#DonGia').val(),
                        ""DonViTinh"": $('#DonViTinh').val()
                    };
                    $.ajax({
                        url: '/QuanLy/SanPhams/Create',
                        dataType: 'json',
                        type: 'POST',
                        data: model,
                        success: function (res) {
                            if (res.success) {
                                $('#modalCreaete').modal('hide');
                                GetData();
                            }
                        },
                        error: function (xhr) { alert('error'); }
             ");
                WriteLiteral(@"       });
                }
            });
            //Edit
            $('body').on('click', '.btnEdit', function () {
                var id = $(this).data('id');
                console.log(""edit clicked "" + id);
                GetDataById(id);
            });

            //Save info from modal edit/update
            $('#btnEditSave').click(function () {
                var model = {
                    ""MaSP"": $('#editMaSP').val(),
                    ""TenSp"": $('#editTenSp').val(),
                    ""DonGia"": $('#editDonGia').val(),
                    ""DonViTinh"": $('#editDonViTinh').val()
                };
                $.ajax({
                    url: '/QuanLy/SanPhams/Edit',
                    dataType: 'json',
                    type: 'POST',
                    data: model,
                    success: function (res) {
                        alert(""Cập nhật thành công."");
                        if (res.success) {
                            $('#modalEdit')");
                WriteLiteral(@".modal('hide');
                            GetData();
                        }
                    },
                    error: function (xhr) { alert('error'); }
                });
            });

            //Delete
            $('body').on('click', '.btnDelete', function () {
                var id = $(this).data('id');
                console.log(""delete clicked "" + id);
                var conf = confirm('Xác nhận xóa sản phẩm.');
                if (conf) {
                    Delete(id);
                }
            });
        });

        function GetDataById(id) {
            $.ajax({
                url: '/QuanLy/SanPhams/GetDataById',
                type: 'GET',
                data: { id: id },
                success: function (res) {
                    if (res.success) {
                        if (res.data != null) {
                            $('#editMaSP').val(res.data.result.maSP);
                            $('#editTenSp').val(res.data.result.tenSp);");
                WriteLiteral(@"
                            $('#editDonGia').val(res.data.result.donGia);
                            $('#editDonViTinh').val(res.data.result.donViTinh);
                            $('#modalEdit').modal('show');
                        }
                    }
                },
                error: function (xhr) { alert('error'); }
            });
        }

        function GetData() {
            $.ajax({
                url: '/QuanLy/SanPhams/GetData',
                type: 'GET',
                success: function (res) {
                    if (res.totalItem > 0) {
                        var list = res.data;
                        var html = """";
                        for (let i = 0; i < res.totalItem; i++) {
                            url = ""/QuanLy/SanPhams/Details/"" + list[i].maSP;
                            html += ""<tr id='tr"" + list[i].maSP + ""'>"";
                            html += ""<td>"" + list[i].tenSp + ""</td>"";
                            html += ""<td>"" + list[i");
                WriteLiteral(@"].donGia + ""</td>"";
                            html += ""<td>"" + list[i].donViTinh + ""</td>"";
                            html += ""<td><a class='btn btn-warning btnEdit' data-id ='"" + list[i].maSP + ""'><i class='fas fa-user-edit'></i></a> | "" +
                                ""<a href='"" + url + ""' class='btn btn-info btnDetails' data-id ='"" + list[i].maSP + ""'><i class='fas fa-info-circle'></i></a> | "" +
                                ""<a class='btn btn-danger btnDelete' data-id='"" + list[i].maSP + ""'><i class='fas fa-trash'></i></a></td > "";
                            html += ""</tr>"";
                        }
                        $('#data-table').html(html);
                    }
                },
                error: function (xhr) { alert('error'); }
            });
        }

        function Delete(id) {
            $.ajax({
                url: '/QuanLy/SanPhams/Delete',
                type: 'POST',
                data: { id: id },
                success: function (res) {");
                WriteLiteral(@"
                    if (res.success) {
                        $('#tr' + id).remove();
                        GetData();
                    } else {
                        console.log(""Error!"");
                    }
                },
                error: function (xhr) { alert('error'); }
            });
        }
        function IsValidate() {
            var check = false;
            if ($('#MaSP').val() == '') {
                $('#MaSP').next().html('Mời nhập mã sản phẩm!');
                check = false; return;
            } else {
                $('#MaSP').next().html('');
                check = true;
            }

            if ($('#TenSp').val() == '') {
                $('#TenSp').next().html('Mời nhập tên sản phẩm!');
                check = false; return;
            } else {
                $('#TenSp').next().html('');
                check = true;
            }
            return check;
        }
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<QuanLy.src.Abstractions.Data.SanPham>> Html { get; private set; }
    }
}
#pragma warning restore 1591
