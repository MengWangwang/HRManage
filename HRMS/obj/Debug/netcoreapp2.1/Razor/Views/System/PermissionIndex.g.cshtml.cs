#pragma checksum "D:\HRManage\HRMS\Views\System\PermissionIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67e52054d4245c3a3327e3bbdf4ad65a528d9acb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_System_PermissionIndex), @"mvc.1.0.view", @"/Views/System/PermissionIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/System/PermissionIndex.cshtml", typeof(AspNetCore.Views_System_PermissionIndex))]
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
#line 1 "D:\HRManage\HRMS\Views\_ViewImports.cshtml"
using HRMS.Middleware.PermissionMiddleware;

#line default
#line hidden
#line 2 "D:\HRManage\HRMS\Views\_ViewImports.cshtml"
using HRMS.App_Start;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e52054d4245c3a3327e3bbdf4ad65a528d9acb", @"/Views/System/PermissionIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"308e485a9cf43d1ee77f9280bbe22e6601398bd4", @"/Views/_ViewImports.cshtml")]
    public class Views_System_PermissionIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\HRManage\HRMS\Views\System\PermissionIndex.cshtml"
  
    ViewBag.Title = "权限管理";
    Layout = ViewBag.Layout;

#line default
#line hidden
            BeginContext(68, 731, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-md-12"">

        <div class=""form-inline"">

            <div class=""booking-search"">
                <div class=""form-group "">
                    <div class=""fiter"" data-column=""0"">
                        <input class=""form-control"" type=""text"" id=""col0_filter"" placeholder=""权限名"">
                    </div>
                </div>
                <div class=""form-group "">
                    <button class=""btn green"" width=""120"" id=""Search"">查询 <i class=""fa fa-search""></i></button>
                </div>
            </div>
        </div>
    </div>
</div>
<br />
<div class=""row"">
    <table id=""myTable"" class=""table table-striped table-bordered""></table>
</div>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(816, 512, true);
                WriteLiteral(@"

    <script>
        function filterColumn(i) {
            $('#myTable').DataTable().column(i).search(
                $('#col' + i + '_filter').val(),
                false,
                false
            ).draw();
        }
        var editor;
        $(document).ready(function () {

            editor = new $.fn.dataTable.Editor({
                idSrc: ""Id"",
                ajax: {
                    create: {
                        type: 'POST',
                        url:  '");
                EndContext();
                BeginContext(1329, 45, false);
#line 47 "D:\HRManage\HRMS\Views\System\PermissionIndex.cshtml"
                          Write(Url.Action("PermissionIndexCreate", "System"));

#line default
#line hidden
                EndContext();
                BeginContext(1374, 126, true);
                WriteLiteral("\'\r\n                    },\r\n                    edit: {\r\n                        type: \'POST\',\r\n                        url:  \'");
                EndContext();
                BeginContext(1501, 45, false);
#line 51 "D:\HRManage\HRMS\Views\System\PermissionIndex.cshtml"
                          Write(Url.Action("PermissionIndexUpdate", "System"));

#line default
#line hidden
                EndContext();
                BeginContext(1546, 128, true);
                WriteLiteral("\'\r\n                    },\r\n                    remove: {\r\n                        type: \'POST\',\r\n                        url:  \'");
                EndContext();
                BeginContext(1675, 45, false);
#line 55 "D:\HRManage\HRMS\Views\System\PermissionIndex.cshtml"
                          Write(Url.Action("PermissionIndexDelete", "System"));

#line default
#line hidden
                EndContext();
                BeginContext(1720, 689, true);
                WriteLiteral(@"'
                    }
                },
                table: ""#myTable"",
                fields: [
                    { label: ""权限名称:"", name: ""Name"" },
                    { label: ""区域:"", name: ""Area"" },
                    { label: ""控制器:"", name: ""Control"" },
                    { label: ""动作:"", name: ""Action"" },
                    { label: ""排列序号:"", name: ""OrderIndex"" },
                    {
                        label: ""父权限:"", name: ""ParentID"", type: ""select2"",
                        opts: {
                            theme: ""classic"",
                            ajax: {
                                type: 'GET',
                                url: """);
                EndContext();
                BeginContext(2410, 42, false);
#line 71 "D:\HRManage\HRMS\Views\System\PermissionIndex.cshtml"
                                 Write(Url.Action("PermissionInfraData", "Infra"));

#line default
#line hidden
                EndContext();
                BeginContext(2452, 1487, true);
                WriteLiteral(@""",
                                dataType: 'json',
                                delay: 250,
                                data: function (params) {
                                    return {
                                        term: params.term, // search term 请求参数
                                        page: params.page
                                    };
                                },
                                processResults: function (data, params) {
                                    params.page = params.page || 1;
                                    return {
                                        results: data.items,//itemList
                                        pagination: {
                                            more: (params.page * 30) < data.total_count
                                        }
                                    };
                                },
                                cache: true
                            },
  ");
                WriteLiteral(@"                          escapeMarkup: function (markup) { return markup; },
                            formatResult: function formatRepo(repo) { return repo.text; },
                            formatSelection: function formatRepoSelection(repo) { return repo.text; }
                        }
                    },
                ]
            });
            var table = $('#myTable').DataTable({
                ajax: {
                    url: """);
                EndContext();
                BeginContext(3940, 43, false);
#line 100 "D:\HRManage\HRMS\Views\System\PermissionIndex.cshtml"
                     Write(Url.Action("PermissionIndexData", "System"));

#line default
#line hidden
                EndContext();
                BeginContext(3983, 5087, true);
                WriteLiteral(@""",
                    type: ""post""
                },
                rowGroup: {
                    dataSrc: ['ParentName'],
                    startRender: function ( rows, group ) {
                        return group +' ('+rows.count()+' 条记录)';
                    }
                },
                order: [[5, 'asc']],//一定要添加
                columns: [
                    { data: ""Name"", title: ""权限名称"", searchable: true, orderable: true, width: ""100px"", className: 'search-0' },
                    { data: ""Area"", title: ""区域"", searchable: true, orderable: true, width: ""100px"" },
                    { data: ""Control"", title: ""控制器"", searchable: true, orderable: true, width: ""100px"" },
                    { data: ""Action"", title: ""动作"", searchable: true, orderable: true, width: ""100px"" },
                    { data: ""OrderIndex"", title: ""排列序号"", searchable: true, orderable: true, width: ""100px"" },
                    { data: ""ParentName"", title: ""父权限名称"", searchable: false, orderable: false,");
                WriteLiteral(@" width: ""100px"" },
                    //{ data: ""Modifier"", title: ""修改者"", searchable: true, orderable: true, width: ""100px"" },
                    //{
                    //    data: ""ModifyTime"", title: ""修改日期"", searchable: true, orderable: true, width: ""100px"",
                    //    render: function (val, type, row) {
                    //        if (val != null && val.match(/\/Date\((\d+)\)\//gi)) {
                    //            val = moment(eval(val.replace(/\/Date\((\d+)\)\//gi, ""new Date($1)""))).format('YYYY-MM-DD HH:mm:ss');
                    //            row.createtime = val;
                    //        }
                    //        return val;
                    //    }
                    //},
                    { data: ""Creator"", title: ""创建者"", searchable: true, orderable: true, width: ""100px"" },
                    {
                        data: ""CreateTime"", title: ""创建日期"", searchable: true, orderable: true, width: ""100px"",
                        render: function ");
                WriteLiteral(@"(val, type, row) {
                            if (val != null && val.match(/\/Date\((\d+)\)\//gi)) {
                                val = moment(eval(val.replace(/\/Date\((\d+)\)\//gi, ""new Date($1)""))).format('YYYY-MM-DD HH:mm:ss');
                                row.createtime = val;
                            }
                            return val;
                        }
                    },
                ],
                buttons: [
                    { extend: ""create"", text: ""创建"", editor: editor },
                    { extend: ""edit"", text: ""编辑"", editor: editor },
                    { extend: ""remove"", text: ""删除"", editor: editor },
                    {
                        extend: ""selectedSingle"",
                        text: ""复制创建"",
                        action: function (e, dt, node, config) {
                            var rows = table.rows({ selected: true }).data();
                            editor
                                .title('复制创建一条记录')
  ");
                WriteLiteral(@"                              .buttons('创建')
                                .create(true)
                                .set('Name', rows[0].name)
                                .set('Control', rows[0].controller)
                                .set('Action', rows[0].action)
                                .set('OrderIndex', rows[0].orderindex + 1)
                                .set('ParentID', rows[0].parentid);

                        }
                    },
                    {
                        extend: 'collection',
                        text: '导出',
                        buttons: [
                             { extend: ""copyHtml5"", text: ""复制"" },
                             { extend: ""excelHtml5"", text: ""导出EXCEL"" },
                             { extend: ""csvHtml5"", text: ""导出CSV"" },
                             { extend: ""pdfHtml5"", text: ""导出PDF"" }
                        ]
                    }
                ]
            });

            editor.on('preSubmit");
                WriteLiteral(@"', function (e, o, action) {
                if (action !== 'remove') {

                }
            });
            $('#Search').click(function () {
                var items = $(this).parents('.booking-search').find('.fiter');
                $.each(items, function (index, obj) {
                    var i = $(obj).attr('data-column');
                    var val = $('#col' + i + '_filter').val();
                    if (val == null)
                        val = '';
                    var selectot = '.search-' + i;
                    if ($(selectot).length == 0) {
                        $('#myTable').DataTable().column(i).search(val, false, false);
                    }
                    else {
                        $('#myTable').DataTable().column($(selectot)).search(val, false, false);
                    }
                });

                $('#myTable').DataTable().columns().search().draw();
            });

        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
