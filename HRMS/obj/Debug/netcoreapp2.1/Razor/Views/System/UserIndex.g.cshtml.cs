#pragma checksum "D:\HRManage\HRMS\Views\System\UserIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "beaa3c79ce2a6efc46667eaedd722f087b440f97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_System_UserIndex), @"mvc.1.0.view", @"/Views/System/UserIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/System/UserIndex.cshtml", typeof(AspNetCore.Views_System_UserIndex))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"beaa3c79ce2a6efc46667eaedd722f087b440f97", @"/Views/System/UserIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"308e485a9cf43d1ee77f9280bbe22e6601398bd4", @"/Views/_ViewImports.cshtml")]
    public class Views_System_UserIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\HRManage\HRMS\Views\System\UserIndex.cshtml"
  
    ViewBag.Title = "用户管理";
    Layout = ViewBag.Layout;

#line default
#line hidden
            BeginContext(68, 1849, true);
            WriteLiteral(@"<div class=""page-content-body"">
    <div class=""row"">
        <div class=""col-md-12"">

            <div class=""form-inline"">

                <div class=""booking-search"">
                    <div class=""form-group "">
                        <div class=""fiter"" data-column=""0"">
                            <input class=""form-control"" type=""text"" id=""col0_filter"" placeholder=""登录名"">
                        </div>
                    </div>
                    <div class=""form-group "">
                        <div class=""fiter"" data-column=""1"">
                            <input class=""form-control"" type=""text"" id=""col1_filter"" placeholder=""别名"">
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
   ");
            WriteLiteral(@"     <div class=""col-md-12"">
            <table id=""myTable"" class=""table table-striped table-bordered""></table>
        </div>
    </div>
    <div id=""customForm"">
        <fieldset class=""userinfo"">
            <legend>用户信息</legend>
            <div data-editor-template=""LoginName""></div>
            <div data-editor-template=""Password""></div>
            <div data-editor-template=""AliasName""></div>
        </fieldset>
        <fieldset class=""relationinfo"">
            <legend>关联信息</legend>
            <div data-editor-template=""UserRole[].RoleId""></div>
        </fieldset>
        <fieldset class=""exinfo"">
            <legend>扩展信息</legend>
            <div data-editor-template=""IsDisabled""></div>
            <div data-editor-template=""IsAdmin""></div>
        </fieldset>
    </div>
</div>
");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1934, 521, true);
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
                BeginContext(2456, 39, false);
#line 71 "D:\HRManage\HRMS\Views\System\UserIndex.cshtml"
                              Write(Url.Action("UserIndexCreate", "System"));

#line default
#line hidden
                EndContext();
                BeginContext(2495, 142, true);
                WriteLiteral("\'\r\n                        },\r\n                        edit: {\r\n                            type: \'POST\',\r\n                            url:  \'");
                EndContext();
                BeginContext(2638, 39, false);
#line 75 "D:\HRManage\HRMS\Views\System\UserIndex.cshtml"
                              Write(Url.Action("UserIndexUpdate", "System"));

#line default
#line hidden
                EndContext();
                BeginContext(2677, 144, true);
                WriteLiteral("\'\r\n                        },\r\n                        remove: {\r\n                            type: \'POST\',\r\n                            url:  \'");
                EndContext();
                BeginContext(2822, 39, false);
#line 79 "D:\HRManage\HRMS\Views\System\UserIndex.cshtml"
                              Write(Url.Action("UserIndexDelete", "System"));

#line default
#line hidden
                EndContext();
                BeginContext(2861, 1552, true);
                WriteLiteral(@"'
                        }
                    },
                table: ""#myTable"",
                template: '#customForm',
                fields: [
                    { label: ""登录名:"", name: ""LoginName"" },
                    { label: ""密码:"", name: ""Password"", type: ""password"", },
                    { label: ""别名:"", name: ""AliasName"" },
                     {
                         type: ""radio"",
                         label: ""是否禁用:"",
                         name: ""IsDisabled"",
                         options: [
                             { label: ""禁用"", value: true },
                             { label: ""启用"", value: false }
                         ]
                     }
                     ,
                     {
                         type: ""radio"",
                         label: ""是否管理员:"",
                         name: ""IsAdmin"",
                         options: [
                             { label: ""是"", value: true },
                             { label: """);
                WriteLiteral(@"否"", value: false }
                         ]
                     }, {
                         label: ""角色:"", name: ""UserRole[].RoleId"",
                         type: ""select2"",
                         opts: {
                             theme: ""classic"",
                             tags: true,
                             allowClear: false,
                             multiple: true,
                             ajax: {
                                 type: 'GET',
                                 url: """);
                EndContext();
                BeginContext(4414, 40, false);
#line 116 "D:\HRManage\HRMS\Views\System\UserIndex.cshtml"
                                  Write(Url.Action("UserRoleInfraData", "Infra"));

#line default
#line hidden
                EndContext();
                BeginContext(4454, 1512, true);
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
                ");
                WriteLiteral(@"             },
                             escapeMarkup: function (markup) { return markup; },
                             formatResult: function formatRepo(repo) { return repo.text; },
                             formatSelection: function formatRepoSelection(repo) { return repo.text; }
                         }

                     }
                ]
            });
            var table = $('#myTable').DataTable({
                ajax: {
                    url: """);
                EndContext();
                BeginContext(5967, 37, false);
#line 146 "D:\HRManage\HRMS\Views\System\UserIndex.cshtml"
                     Write(Url.Action("UserIndexData", "System"));

#line default
#line hidden
                EndContext();
                BeginContext(6004, 3140, true);
                WriteLiteral(@""",
                    type: ""POST""
                },
                order: [[7, 'desc']],//一定要添加
                columns: [
                    { data: ""LoginName"", title: ""登录名"", searchable: true, orderable: true, width: ""100px"" },
                    { data: ""AliasName"", title: ""别名"", searchable: true, orderable: true, width: ""100px"" },
                {
                    data: ""LastLoginDatetime"", title: ""最后登录时间"", searchable: true, orderable: true, width: ""100px"",
                    render: function (val, type, row) {
                        if (val != null && val.match(/\/Date\((\d+)\)\//gi)) {
                            val = moment(eval(val.replace(/\/Date\((\d+)\)\//gi, ""new Date($1)""))).format('YYYY-MM-DD HH:mm:ss');
                            row.lastlogintime = val;
                        }
                        return val;
                    }
                },
                    { data: ""LoginNumber"", title: ""登录次数"", searchable: true, orderable: true, width: ""100px"" },");
                WriteLiteral(@"
                {
                    data: ""IsDisabled"", title: ""是否禁用"", searchable: true, orderable: false, width: ""100px"",
                    render: function (val, type, row) {
                        return val == true ? ""禁用"" : ""启用"";
                    }
                },
               {
                   data: ""IsAdmin"", title: ""是否管理员"", searchable: true, orderable: false, width: ""100px"",
                   render: function (val, type, row) {
                       return val == true ? ""是"" : ""不是"";
                   }
                    },
                    { data: ""UserRole"", title: ""所属角色"", width: ""100px"", orderable: false, render: ""[, ].RoleName"", },
                    //{ data: ""Modifier"", title: ""修改者"", searchable: true, orderable: true, width: ""100px"" },
                    //{
                    //    data: ""ModifyTime"", title: ""修改日期"", searchable: true, orderable: true, width: ""100px"",
                    //    render: function (val, type, row) {
                    //    ");
                WriteLiteral(@"    if (val != null && val.match(/\/Date\((\d+)\)\//gi)) {
                    //            val = moment(eval(val.replace(/\/Date\((\d+)\)\//gi, ""new Date($1)""))).format('YYYY-MM-DD HH:mm:ss');
                    //            row.createtime = val;
                    //        }
                    //        return val;
                    //    }
                    //},
                    { data: ""Creator"", title: ""创建者"", searchable: true, orderable: true, width: ""100px"" },
                {
                    data: ""CreateTime"", title: ""创建日期"", searchable: true, orderable: true, width: ""100px"",
                    render: function (val, type, row) {
                        if (val != null && val.match(/\/Date\((\d+)\)\//gi)) {
                            val = moment(eval(val.replace(/\/Date\((\d+)\)\//gi, ""new Date($1)""))).format('YYYY-MM-DD HH:mm:ss');
                            row.createtime = val;
                        }
                        return val;
                    }
");
                WriteLiteral("                },\r\n                ],\r\n                buttons: [\r\n");
                EndContext();
#line 201 "D:\HRManage\HRMS\Views\System\UserIndex.cshtml"
                 if (Context.HasPermission(Url.Action("UserIndexCreate", "System")))
                {
                    Output.WriteLine("{ extend: \"create\", text: \"创建\", editor: editor },");
                }

#line default
#line hidden
                BeginContext(9364, 16, true);
                WriteLiteral("                ");
                EndContext();
#line 205 "D:\HRManage\HRMS\Views\System\UserIndex.cshtml"
                 if (Context.HasPermission(Url.Action("UserIndexUpdate", "System")))
                {
                    Output.WriteLine("{ extend: \"edit\", text: \"编辑\", editor: editor },");
                }

#line default
#line hidden
                BeginContext(9582, 16, true);
                WriteLiteral("                ");
                EndContext();
#line 209 "D:\HRManage\HRMS\Views\System\UserIndex.cshtml"
                 if (Context.HasPermission(Url.Action("UserIndexDelete", "System")))
                {
                    Output.WriteLine("{ extend: \"remove\", text: \"删除\", editor: editor },");
                }

#line default
#line hidden
                BeginContext(9802, 1813, true);
                WriteLiteral(@"                    {
                        extend: 'collection',
                        text: '导出',
                        buttons: [
                             { extend: ""copyHtml5"", text: ""复制"" },
                             { extend: ""excelHtml5"", text: ""导出EXCEL"" },
                             { extend: ""csvHtml5"", text: ""导出CSV"" },
                             //{ extend: ""pdfHtml5"", text: ""导出PDF"" }
                        ]
                    }
                ]
            });
            editor.on('initCreate', function () {
                editor.show(); //Shows all fields
            });

            editor.on('initEdit', function () {
                editor.show(); //Shows all fields
                editor.hide('Password');
            });

            editor.on('preSubmit', function (e, o, action) {
                if (action !== 'remove') {

                }
            });

            $('#Search').click(function () {
                var items = $(this).parent");
                WriteLiteral(@"s('.booking-search').find('.fiter');
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
