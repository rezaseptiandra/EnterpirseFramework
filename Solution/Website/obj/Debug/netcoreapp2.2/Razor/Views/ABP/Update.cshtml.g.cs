#pragma checksum "C:\Users\Reza\source\Workspaces\MicroservicesBMI\WebFramework\WebFramework\Website\Views\ABP\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "356edade39b1406cc2b5305d8f7e8964d3167ee3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ABP_Update), @"mvc.1.0.view", @"/Views/ABP/Update.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ABP/Update.cshtml", typeof(AspNetCore.Views_ABP_Update))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"356edade39b1406cc2b5305d8f7e8964d3167ee3", @"/Views/ABP/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"971d47fbe439df3910fb180c393f0b2f21208c79", @"/Views/_ViewImports.cshtml")]
    public class Views_ABP_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\Reza\source\Workspaces\MicroservicesBMI\WebFramework\WebFramework\Website\Views\ABP\Update.cshtml"
  
    ViewData["Title"] = "Update";

#line default
#line hidden
            BeginContext(42, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(47, 17, false);
#line 4 "C:\Users\Reza\source\Workspaces\MicroservicesBMI\WebFramework\WebFramework\Website\Views\ABP\Update.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(64, 9, true);
            WriteLiteral("</h1>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(92, 699, true);
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $('#btnajx').click(function () {
                var _Role = { RoleID: $(""#roleid"").val(), Descriptions: $(""#descriptions"").val() };
                _Role = JSON.stringify(_Role);
                $.ajax({
                    url: ""SubmitUpdate"",
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
            BeginContext(794, 17, true);
            WriteLiteral("<p>Register</p>\r\n");
            EndContext();
            BeginContext(811, 304, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "356edade39b1406cc2b5305d8f7e8964d3167ee35257", async() => {
                BeginContext(873, 235, true);
                WriteLiteral("\r\n    RoleID: <input type=\"text\" id=\"roleid\" /> <br />\r\n    Descriptions: <input type=\"email\" id=\"descriptions\" /> <br />\r\n\r\n    <input type=\"button\" value=\"Submit Add\" id=\"btnajx\" class=\"btn btn-sm btn-primary btn-block\" />\r\n   \r\n\r\n\r\n");
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
#line 29 "C:\Users\Reza\source\Workspaces\MicroservicesBMI\WebFramework\WebFramework\Website\Views\ABP\Update.cshtml"
AddHtmlAttributeValue("", 839, Url.Action("SignUp", "Account"), 839, 32, false);

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
            BeginContext(1115, 2, true);
            WriteLiteral("\r\n");
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
