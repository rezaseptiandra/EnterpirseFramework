#pragma checksum "C:\Users\Reza\source\Workspaces\MicroservicesBMI\WebFramework\WebFramework\Website\Views\ABP\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f59ee79f5fd0f9f6464c75ec09a062b6a40eb3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ABP_Index), @"mvc.1.0.view", @"/Views/ABP/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ABP/Index.cshtml", typeof(AspNetCore.Views_ABP_Index))]
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
#line 1 "C:\Users\Reza\source\Workspaces\MicroservicesBMI\WebFramework\WebFramework\Website\Views\_ViewImports.cshtml"
using Website;

#line default
#line hidden
#line 2 "C:\Users\Reza\source\Workspaces\MicroservicesBMI\WebFramework\WebFramework\Website\Views\_ViewImports.cshtml"
using Website.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f59ee79f5fd0f9f6464c75ec09a062b6a40eb3c", @"/Views/ABP/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"971d47fbe439df3910fb180c393f0b2f21208c79", @"/Views/_ViewImports.cshtml")]
    public class Views_ABP_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Reza\source\Workspaces\MicroservicesBMI\WebFramework\WebFramework\Website\Views\ABP\Index.cshtml"
  
    ViewData["Title"] = "ABP";

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(58, 309, true);
                WriteLiteral(@"
    <script>
        var Action = ""New"";
        $(document).ready(function () {
            init();
            var table = $('#grdABP').DataTable({
                serverSide: true,
                paging: true,
                autoWidth: false,
                ajax: {
                    url: """);
                EndContext();
                BeginContext(368, 28, false);
#line 15 "C:\Users\Reza\source\Workspaces\MicroservicesBMI\WebFramework\WebFramework\Website\Views\ABP\Index.cshtml"
                     Write(Url.Action("GetList", "ABP"));

#line default
#line hidden
                EndContext();
                BeginContext(396, 5246, true);
                WriteLiteral(@""",
                    type: 'POST'
                },
                columns: [
                    { ""data"": ""abpid"" },
                    { ""data"": ""deskripsi"" },
                    { ""data"": ""periodeStart"" },
                    { ""data"": ""periodeEnd"" }
                ],
                columnDefs: [{
                    targets: [2, 3], render: function (data) {
                        return moment(data).format('DD-MMM-YYYY');
                    }
                }],
                select: {
                    style: 'os'
                },
                order: [[1, 'asc']]
            })
            .on('select', function (e, dt, type, indexes) {
                rowSelectChange();
            })
            .on('deselect', function (e, dt, type, indexes) {
                rowSelectChange();
            })
            .on('draw', function (e, dt, type, indexes) {
                rowSelectChange();
            })
            .columns().every(function () {
           ");
                WriteLiteral(@"     var that = this;
                $('input', this.footer()).on('keyup change', function () {
                    if (that.search() !== this.value) {
                        that
                            .search(this.value)
                            .draw();
                    }
                });
            });

            function init() {
                $('#grdABP tfoot th').each(function () {
                    var title = $(this).text();
                    $(this).html('<input type=""text"" placeholder=""Search ' + title + '"" />');
                });
                defaultMainControlVisibility(false);
            };

            function rowSelectChange() {
                $(""#btnHomeDelete"").prop('disabled', $('#grdABP').DataTable().rows('.selected').data().length <= 0);
                $(""#btnHomeUpdate"").prop('disabled', $('#grdABP').DataTable().rows('.selected').data().length != 1);
                $(""#btnHomeDetail"").prop('disabled', $('#grdABP').DataTable().rows('");
                WriteLiteral(@".selected').data().length != 1);
            }

            function defaultMainControlVisibility (isCallback) {
                btShow('#divMain');
                if (isCallback) {
                    $('#grdABP').DataTable().ajax.reload(null,false);
                };
            };

            function afterSuccessNav(action) {
                btHide(""#divMain"");
                if (action == 'Detail' || action == 'Update' ) {                    
                }
            }            

            //Button
            $('#btnHomeDelete').click(function () {
                debugger;
                confirmationDialog(""Delete Confirmation"", ""Are you sure you want to Delete this selected ABP?"", function () {
                    $.ajax({
                        url: ""/ABP/SubmitDelete"",
                        type: 'post',
                        datatype: 'application/json',
                        data:
                        {
                            selectedData: JSO");
                WriteLiteral(@"N.stringify($('#grdABP').DataTable().rows('.selected').data().toArray())
                        },
                        success: function (data) {
                            table.ajax.reload(null, false);
                            successDialog(""Success"", ""Delete Success"");
                        },
                        error: function () {
                            alert('Ajax error!');
                            errorDialog(""Error"", ""Delete Error"");
                        }
                    })
                })
            });
            $('#btnHomeDetail').click(function () {
                _act= ""Detail"";
                loadDetail(
                    _act,
                    JSON.stringify($('#grdABP').DataTable().rows('.selected').data().toArray()[0]),
                    function () {
                        afterSuccessNav(_act);
                     },
                    function () {
                        alert('Error Populating '+_act);
            ");
                WriteLiteral(@"        },
                    defaultMainControlVisibility
                );
            });

            $('#btnHomeAdd').click(function () {
                 _act= ""New"";
                 loadDetail(
                    _act,
                    null,
                    function () {
                        afterSuccessNav(_act);
                    },
                    function () {
                        alert('Error Populating Detail');
                    },
                    defaultMainControlVisibility);
            });

            $('#btnHomeUpdate').click(function () {
                _act= ""Update"";
                loadDetail(
                    _act,
                    JSON.stringify($('#grdABP').DataTable().rows('.selected').data().toArray()[0]),
                    function () {
                        afterSuccessNav(_act);
                     },
                    function () {
                        alert('Error Populating Detail');
                 ");
                WriteLiteral("   },\r\n                    defaultMainControlVisibility\r\n                );\r\n            });\r\n        });\r\n    </script>    \r\n");
                EndContext();
            }
            );
            BeginContext(5645, 219, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n</div>\r\n\r\n<div style=\"width:100%\">\r\n");
            EndContext();
            BeginContext(5975, 32, true);
            WriteLiteral("\r\n    <div class=\"mb-3\"></div>\r\n");
            EndContext();
            BeginContext(6047, 1039, true);
            WriteLiteral(@"    <div id=""divMain"" class=""mb-3"">
        <button id=""btnHomeAdd"" type=""button"" class=""btn btn-primary"">Add New</button>
        <button id=""btnHomeDetail"" type=""button"" class=""btn btn-primary"">Detail</button>
        <button id=""btnHomeUpdate"" type=""button"" class=""btn btn-primary"">Update</button>
        <button id=""btnHomeDelete"" type=""button"" class=""btn btn-primary btn-danger"" disabled>Delete</button>
        <table id=""grdABP"" class=""table table-striped table-bordered nowrap"" style=""width:100%"">
            <thead>
                <tr>
                    <th>ABPID</th>
                    <th>Deskripsi</th>
                    <th>PeriodeStrat</th>
                    <th>PeriodeEnd</th>
                </tr>
            </thead>
            <tfoot>
                <tr>
                    <th>ABPID</th>
                    <th>Deskripsi</th>
                    <th>PeriodeStart</th>
                    <th>PeriodeEnd</th>
                </tr>
            </tfoot>
        </table");
            WriteLiteral(">\r\n    </div>\r\n");
            EndContext();
            BeginContext(7102, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(7108, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9f59ee79f5fd0f9f6464c75ec09a062b6a40eb3c11818", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7134, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
