#pragma checksum "C:\Users\Reza\source\Workspaces\MicroservicesBMI\WebFramework\WebFramework\Website\Views\Role\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a67488b28937480904eb0b5fc76b136e2f15918"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Add), @"mvc.1.0.view", @"/Views/Role/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Role/Add.cshtml", typeof(AspNetCore.Views_Role_Add))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a67488b28937480904eb0b5fc76b136e2f15918", @"/Views/Role/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"971d47fbe439df3910fb180c393f0b2f21208c79", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Reza\source\Workspaces\MicroservicesBMI\WebFramework\WebFramework\Website\Views\Role\Add.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
            BeginContext(44, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(49, 17, false);
#line 4 "C:\Users\Reza\source\Workspaces\MicroservicesBMI\WebFramework\WebFramework\Website\Views\Role\Add.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(66, 9, true);
            WriteLiteral("</h1>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(94, 737, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {            
            $('#btnajx').click(function () {
                var _Role =  { RoleID: $(""#roleid"").val() , Descriptions:$(""#descriptions"").val()};  
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
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(834, 17, true);
            WriteLiteral("<p>Register</p>\r\n");
            EndContext();
            BeginContext(851, 296, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a67488b28937480904eb0b5fc76b136e2f159185279", async() => {
                BeginContext(913, 227, true);
                WriteLiteral("\r\n    RoleID: <input type=\"text\" id=\"roleid\" /> <br />\r\n    Descriptions: <input type=\"email\" id=\"descriptions\" /> <br />\r\n    <input type=\"button\" value=\"Submit Add\" id=\"btnajx\" class=\"btn btn-sm btn-primary btn-block\" />\r\n   ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 30 "C:\Users\Reza\source\Workspaces\MicroservicesBMI\WebFramework\WebFramework\Website\Views\Role\Add.cshtml"
AddHtmlAttributeValue("", 879, Url.Action("SignUp", "Account"), 879, 32, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
