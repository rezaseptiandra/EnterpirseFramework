#pragma checksum "C:\Users\Reza\source\Workspaces\MicroservicesBMI\WebFramework\WebFramework\Website\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8ab3d677abefc4cc843197b8fa1aadc421dc084"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8ab3d677abefc4cc843197b8fa1aadc421dc084", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"971d47fbe439df3910fb180c393f0b2f21208c79", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Reza\source\Workspaces\MicroservicesBMI\WebFramework\WebFramework\Website\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            DefineSection("Scripts", async() => {
                BeginContext(64, 1319, true);
                WriteLiteral(@"
    <script>
        var jsonSelectedRow = '{""selectedRow"":[]}';
        var objJsonSelectedRow = JSON.parse(jsonSelectedRow);
        var jsonStr = '{""theTeam"":[{""teamId"":""1"",""status"":""pending""},{""teamId"":""2"",""status"":""member""},{""teamId"":""3"",""status"":""member""}]}';
        var obj = JSON.parse(jsonStr);
        $(document).ready(function () {            
            $('#example tfoot th').each( function () {
                var title = $(this).text();
                $(this).html( '<input type=""text"" placeholder=""Search '+title+'"" />' );
            });

            function renderIco(data, type, row)
            {
                return """";
                
            };
            //$('.fa fa-edit').click(function(event) { 
            //    event.preventDefault(); 
            //    $.ajax({
            //        url: $(this).attr('href'),
            //        success: function(response) {
            //            alert(response);
            //        }
            //    });
");
                WriteLiteral(@"            //    return false; // for good measure
            //});
            // DataTable
            // var table =
            var table = $('#example').DataTable({
                serverSide: true,
                paging : true,
                ajax: {
                    url: """);
                EndContext();
                BeginContext(1384, 29, false);
#line 38 "C:\Users\Reza\source\Workspaces\MicroservicesBMI\WebFramework\WebFramework\Website\Views\Home\Index.cshtml"
                     Write(Url.Action("GetList", "Home"));

#line default
#line hidden
                EndContext();
                BeginContext(1413, 3257, true);
                WriteLiteral(@""",
                    type: 'POST'
                },
                columns: [
                /*{ ""data"": ""Ico"",""orderable"": false,""render"":renderIco },*/
                  { ""data"": """",""width"": ""10px"" },
                  { ""data"": ""name"" },
                  { ""data"": ""position"" },
                  { ""data"": ""office"" },
                  { ""data"": ""age"" },
                  { ""data"": ""startDate"", type:""date"" },
                  { ""data"": ""salary"" },
                  { ""data"": ""active"" }
                ],
                columnDefs: [{
                    width: ""10px"",
                    orderable: false,
                    defaultContent: '',
                    data: null,
                    className: 'select-checkbox',
                    targets:   0
                }],
                select: {
                    style:    'multi',
                    selector: 'td:first-child'
                },
                order: [[ 1, 'asc' ]]
                /*buttons: [");
                WriteLiteral(@"
                    { extend: ""edit"",   editor: editor }
                    { extend: ""create"", editor: editor },
                    { extend: ""edit"",   editor: editor },
                    { extend: ""remove"", editor: editor }
                ]*/

            });
            
            $('#example tbody').on( 'click', 'td', function () {
                console.log(this);
                //console.log( table.row( this ).data() );
            } );
            table.columns().every( function () {
                var that = this;
                $( 'input', this.footer() ).on( 'keyup change', function () {
                    if ( that.search() !== this.value ) {
                        that
                            .search( this.value )
                            .draw();
                    }
                } );
            });

           
            $('#btnajx').click(function () {
                var _Role = { RoleID: $(""#roleid"").val(), Descriptions: $(""#descriptions"").");
                WriteLiteral(@"val() };
                _Role = JSON.stringify(_Role);
                debugger;
                $.ajax({
                    url: ""SubmitAdd"",
                    type: 'post',
                    datatype: 'application/json',
                    data: { obj: _Role },
                    success: function (data) {
                    },
                    error: function () {
                        alert('Ajax error!');
                    }
                });
            });

            $('#tadd').click(function () {                            
                $.ajax({
                    url: ""SubmitAdd"",
                    type: 'post',
                    datatype: 'application/json',
                    data:
                    {
                        obj: {
                            RoleID: ""JOPON"",
                            Descriptions: ""JO PONI""
                        }
                    },
                    success: function (data) {
                  ");
                WriteLiteral("  },\r\n                    error: function () {\r\n                        alert(\'Ajax error!\');\r\n                    }\r\n                });\r\n            });\r\n         });\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(4673, 1401, true);
            WriteLiteral(@"    <div class=""text-center"">
        <h1 class=""display-4"">Welcome</h1>
        <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
    </div>
    <p>Main</p>
    <button type=""button"" class=""btn btn-primary"">Add New</button>
    <button type=""button"" class=""btn btn-primary"">Delete</button>
    <button type=""button"" class=""btn btn-primary"">Edit</button>
    <div class=""table-responsive"">
        <table id=""example"" class=""display"" style=""width:100%"">
            <thead>
                <tr>
                    <th></th>
                    <th>Name</th>
                    <th>Position</th>
                    <th>Office</th>
                    <th>Age</th>
                    <th>Start date</th>
                    <th>Salary</th>
                    <th>Active</th>
                </tr>
            </thead>
            <tfoot>
                <tr>
                    <th></th>
                    <th>Name</th>
             ");
            WriteLiteral(@"       <th>Position</th>
                    <th>Office</th>
                    <th>Age</th>
                    <th>Start date</th>
                    <th>Salary</th>
                    <th>Active</th>
                </tr>
            </tfoot>
        </table>
    </div>
    <div class=""col-md-8 order-md-1"">
        <h4 class=""mb-3"">Form Detail</h4>
        ");
            EndContext();
            BeginContext(6074, 7261, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8ab3d677abefc4cc843197b8fa1aadc421dc08411622", async() => {
                BeginContext(6119, 2651, true);
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-md-6 mb-3"">
                    <label for=""firstName"">First name</label>
                    <input type=""text"" class=""form-control"" id=""firstName"" placeholder="""" value="""" required="""">
                    <div class=""invalid-feedback"">
                        Valid first name is required.
                    </div>
                </div>
                <div class=""col-md-6 mb-3"">
                    <label for=""lastName"">Last name</label>
                    <input type=""text"" class=""form-control"" id=""lastName"" placeholder="""" value="""" required="""">
                    <div class=""invalid-feedback"">
                        Valid last name is required.
                    </div>
                </div>
            </div>

            <div class=""mb-3"">
                <label for=""username"">Username</label>
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <sp");
                WriteLiteral(@"an class=""input-group-text""></span>
                    </div>
                    <input type=""text"" class=""form-control"" id=""username"" placeholder=""Username"" required="""">
                    <div class=""invalid-feedback"" style=""width: 100%;"">
                        Your username is required.
                    </div>
                </div>
            </div>

            <div class=""mb-3"">
                <label for=""email"">Email <span class=""text-muted"">(Optional)</span></label>
                <input type=""email"" class=""form-control"" id=""email"" placeholder=""you@example.com"">
                <div class=""invalid-feedback"">
                    Please enter a valid email address for shipping updates.
                </div>
            </div>

            <div class=""mb-3"">
                <label for=""address"">Address</label>
                <input type=""text"" class=""form-control"" id=""address"" placeholder=""1234 Main St"" required="""">
                <div class=""invalid-feedback"">
        ");
                WriteLiteral(@"            Please enter your shipping address.
                </div>
            </div>

            <div class=""mb-3"">
                <label for=""address2"">Address 2 <span class=""text-muted"">(Optional)</span></label>
                <input type=""text"" class=""form-control"" id=""address2"" placeholder=""Apartment or suite"">
            </div>

            <div class=""row"">
                <div class=""col-md-5 mb-3"">
                    <label for=""country"">Country</label>
                    <select class=""custom-select d-block w-100"" id=""country"" required="""">
                        ");
                EndContext();
                BeginContext(8770, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8ab3d677abefc4cc843197b8fa1aadc421dc08414849", async() => {
                    BeginContext(8787, 9, true);
                    WriteLiteral("Choose...");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8805, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(8831, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8ab3d677abefc4cc843197b8fa1aadc421dc08416342", async() => {
                    BeginContext(8839, 13, true);
                    WriteLiteral("United States");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(8861, 405, true);
                WriteLiteral(@"
                    </select>
                    <div class=""invalid-feedback"">
                        Please select a valid country.
                    </div>
                </div>
                <div class=""col-md-4 mb-3"">
                    <label for=""state"">State</label>
                    <select class=""custom-select d-block w-100"" id=""state"" required="""">
                        ");
                EndContext();
                BeginContext(9266, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8ab3d677abefc4cc843197b8fa1aadc421dc08418022", async() => {
                    BeginContext(9283, 9, true);
                    WriteLiteral("Choose...");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9301, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(9327, 27, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8ab3d677abefc4cc843197b8fa1aadc421dc08419515", async() => {
                    BeginContext(9335, 10, true);
                    WriteLiteral("California");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9354, 3974, true);
                WriteLiteral(@"
                    </select>
                    <div class=""invalid-feedback"">
                        Please provide a valid state.
                    </div>
                </div>
                <div class=""col-md-3 mb-3"">
                    <label for=""zip"">Zip</label>
                    <input type=""text"" class=""form-control"" id=""zip"" placeholder="""" required="""">
                    <div class=""invalid-feedback"">
                        Zip code required.
                    </div>
                </div>
            </div>
            <hr class=""mb-4"">
            <div class=""custom-control custom-checkbox"">
                <input type=""checkbox"" class=""custom-control-input"" id=""same-address"">
                <label class=""custom-control-label"" for=""same-address"">Shipping address is the same as my billing address</label>
            </div>
            <div class=""custom-control custom-checkbox"">
                <input type=""checkbox"" class=""custom-control-input"" id=""save-info"">
");
                WriteLiteral(@"                <label class=""custom-control-label"" for=""save-info"">Save this information for next time</label>
            </div>
            <hr class=""mb-4"">

            <h4 class=""mb-3"">Payment</h4>

            <div class=""d-block my-3"">
                <div class=""custom-control custom-radio"">
                    <input id=""credit"" name=""paymentMethod"" type=""radio"" class=""custom-control-input"" checked="""" required="""">
                    <label class=""custom-control-label"" for=""credit"">Credit card</label>
                </div>
                <div class=""custom-control custom-radio"">
                    <input id=""debit"" name=""paymentMethod"" type=""radio"" class=""custom-control-input"" required="""">
                    <label class=""custom-control-label"" for=""debit"">Debit card</label>
                </div>
                <div class=""custom-control custom-radio"">
                    <input id=""paypal"" name=""paymentMethod"" type=""radio"" class=""custom-control-input"" required="""">
            ");
                WriteLiteral(@"        <label class=""custom-control-label"" for=""paypal"">Paypal</label>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-6 mb-3"">
                    <label for=""cc-name"">Name on card</label>
                    <input type=""text"" class=""form-control"" id=""cc-name"" placeholder="""" required="""">
                    <small class=""text-muted"">Full name as displayed on card</small>
                    <div class=""invalid-feedback"">
                        Name on card is required
                    </div>
                </div>
                <div class=""col-md-6 mb-3"">
                    <label for=""cc-number"">Credit card number</label>
                    <input type=""text"" class=""form-control"" id=""cc-number"" placeholder="""" required="""">
                    <div class=""invalid-feedback"">
                        Credit card number is required
                    </div>
                </div>
            </div>
            <div class=""ro");
                WriteLiteral(@"w"">
                <div class=""col-md-3 mb-3"">
                    <label for=""cc-expiration"">Expiration</label>
                    <input type=""text"" class=""form-control"" id=""cc-expiration"" placeholder="""" required="""">
                    <div class=""invalid-feedback"">
                        Expiration date required
                    </div>
                </div>
                <div class=""col-md-3 mb-3"">
                    <label for=""cc-expiration"">CVV</label>
                    <input type=""text"" class=""form-control"" id=""cc-cvv"" placeholder="""" required="""">
                    <div class=""invalid-feedback"">
                        Security code required
                    </div>
                </div>
            </div>
            <hr class=""mb-4"">
            <button class=""btn btn-primary btn-lg btn-block"" type=""submit"">Continue to checkout</button>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(13335, 381, true);
            WriteLiteral(@"
    </div>
    <div>
        <button id=""tadd"" type=""button"" class=""btn btn-primary"">Test Add</button>
        <button id=""taddb"" type=""button"" class=""btn btn-primary"">Test Add Bulk</button>
        <button id=""tdel"" type=""button"" class=""btn btn-primary"">Test Delete</button>
        <button id=""tupd"" type=""button"" class=""btn btn-primary"">Test Update</button>
    </div>
");
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
