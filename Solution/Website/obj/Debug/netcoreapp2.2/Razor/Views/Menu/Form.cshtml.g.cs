#pragma checksum "C:\Users\Reza\source\Workspaces\MicroservicesBMI\WebFramework\WebFramework\Website\Views\Menu\Form.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69801874dece924c22c6f6b84614df5219339f1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Menu_Form), @"mvc.1.0.view", @"/Views/Menu/Form.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Menu/Form.cshtml", typeof(AspNetCore.Views_Menu_Form))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69801874dece924c22c6f6b84614df5219339f1d", @"/Views/Menu/Form.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"971d47fbe439df3910fb180c393f0b2f21208c79", @"/Views/_ViewImports.cshtml")]
    public class Views_Menu_Form : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(383, 182, true);
            WriteLiteral("<div class=\"d-none d-md-block d-lg-none\">\r\n    Ulolka\r\n</div>\r\n<div class=\"row\">\r\n    \r\n    <div class=\"col-md-8 order-md-1\">\r\n        <h4 class=\"mb-3\">Billing address</h4>\r\n        ");
            EndContext();
            BeginContext(565, 1470, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69801874dece924c22c6f6b84614df5219339f1d3697", async() => {
                BeginContext(571, 1457, true);
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-md-6 mb-3"">
                    <label for=""firstName"">Parent Menu</label>
                    <input type=""text"" class=""form-control"" id=""firstName"" name=""parentid"" placeholder="""" value="""" required="""">
                    <div class=""invalid-feedback"">
                        Valid first name is required.
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-6 mb-3"">
                    <label for=""firstName"">Menu Name</label>
                    <input type=""text"" class=""form-control"" id=""firstName"" name=""menuname"" placeholder="""" value="""" required="""">
                    <div class=""invalid-feedback"">
                        Valid first name is required.
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-6 mb-3"">
                    <label for=""firstName"">Path</lab");
                WriteLiteral(@"el>
                    <input type=""text"" class=""form-control"" id=""firstName"" name=""path"" placeholder="""" value="""" required="""">
                    <div class=""invalid-feedback"">
                        Valid first name is required.
                    </div>
                </div>
            </div>
            <hr class=""mb-4"">
            <button class=""btn btn-primary btn-block"" type=""submit"">Submit</button>
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
            BeginContext(2035, 53, true);
            WriteLiteral("\r\n\r\n        </div>\r\n</div>\r\n    <!-- Content here -->");
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
