#pragma checksum "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\Provider\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22dbb54e3524d71fa4bd4b15d002f5877f92af32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Provider_Add), @"mvc.1.0.view", @"/Views/Provider/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Provider/Add.cshtml", typeof(AspNetCore.Views_Provider_Add))]
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
#line 1 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\_ViewImports.cshtml"
using SuperAppPet;

#line default
#line hidden
#line 2 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\_ViewImports.cshtml"
using SuperAppPet.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22dbb54e3524d71fa4bd4b15d002f5877f92af32", @"/Views/Provider/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68f6dc990a22771954a6fe36597dc1073e50f77d", @"/Views/_ViewImports.cshtml")]
    public class Views_Provider_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\Provider\Add.cshtml"
  
    ViewData["Title"] = "Add Provider";

#line default
#line hidden
            BeginContext(48, 94, true);
            WriteLiteral("\r\n<div id=\"main\" class=\"container-fluid\">\r\n    <h3 class=\"page-header\">Add Provider</h3>\r\n    ");
            EndContext();
            BeginContext(142, 1095, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a21ede1237fb4789b02657f2fbcf2950", async() => {
                BeginContext(202, 911, true);
                WriteLiteral(@"
        <div class=""row"">
            <div class=""form-group col-md-8"">
                <label for=""name"">Name</label>
                <input type=""text"" class=""form-control"" name=""name"" maxlength=""50"" required>
            </div>
            <div class=""form-group col-md-8"">
                <label for=""email"">E-mail</label>
                <input type=""email"" class=""form-control"" name=""email"" maxlength=""50"" required>
            </div>
            <div class=""form-group col-md-8"">
                <label for=""phone"">Phone</label>
                <input type=""text"" class=""form-control"" name=""phone"" onkeypress=""return somenteNumeros(event)"" maxlength=""12"" required>
            </div>
        </div>
        <hr />
        <div id=""actions"" class=""row"">
            <div class=""col-md-12"">
                <input type=""submit"" class=""btn btn-primary"" value=""Salvar"">
                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 1113, "\'", 1152, 1);
#line 26 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\Provider\Add.cshtml"
WriteAttributeValue("", 1120, Url.Action("Index", "Provider"), 1120, 32, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1153, 77, true);
                WriteLiteral(" class=\"btn btn-default\">Voltar</a>\r\n            </div>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 7 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\Provider\Add.cshtml"
AddHtmlAttributeValue("", 156, Url.Action("Add", "Provider"), 156, 30, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1237, 8, true);
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