#pragma checksum "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\User\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "847f40a16b2311c13f3742f7e5f37caf53886d18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Edit), @"mvc.1.0.view", @"/Views/User/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Edit.cshtml", typeof(AspNetCore.Views_User_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"847f40a16b2311c13f3742f7e5f37caf53886d18", @"/Views/User/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68f6dc990a22771954a6fe36597dc1073e50f77d", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserModel>
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
            BeginContext(18, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\User\Edit.cshtml"
  
    ViewData["Title"] = "Edit User";

#line default
#line hidden
            BeginContext(65, 96, true);
            WriteLiteral("\r\n<div id=\"main\" class=\"container-fluid\">\r\n    <h3 class=\"page-header\">Editar Usuário</h3>\r\n    ");
            EndContext();
            BeginContext(161, 1168, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "017f4d1f215545149b2165c26793636d", async() => {
                BeginContext(222, 206, true);
                WriteLiteral("\r\n        <div class=\"row\">\r\n            <div class=\"form-group col-md-8\">\r\n                <label for=\"nome\">Name</label>\r\n                <input type=\"text\" class=\"form-control\" name=\"name\" maxlength=\"50\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 428, "\"", 447, 1);
#line 13 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\User\Edit.cshtml"
WriteAttributeValue("", 436, Model.Name, 436, 11, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(448, 214, true);
                WriteLiteral(" required>\r\n            </div>\r\n            <div class=\"form-group col-md-8\">\r\n                <label for=\"email\">E-mail</label>\r\n                <input type=\"email\" class=\"form-control\" name=\"email\" maxlength=\"50\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 662, "\"", 682, 1);
#line 17 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\User\Edit.cshtml"
WriteAttributeValue("", 670, Model.Email, 670, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(683, 200, true);
                WriteLiteral(" required>\r\n            </div>\r\n            <div class=\"form-group col-md-8\">\r\n                <label for=\"telefone\">Phone</label>\r\n                <input type=\"text\" class=\"form-control\" name=\"phone\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 883, "\"", 903, 1);
#line 21 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\User\Edit.cshtml"
WriteAttributeValue("", 891, Model.Phone, 891, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(904, 305, true);
                WriteLiteral(@" onkeypress=""return somenteNumeros(event)"" maxlength=""11"" readonly required>
            </div>
        </div>
        <hr />
        <div id=""actions"" class=""row"">
            <div class=""col-md-12"">
                <input type=""submit"" class=""btn btn-primary"" value=""Salvar"" />
                <a");
                EndContext();
                BeginWriteAttribute("href", " href=\'", 1209, "\'", 1244, 1);
#line 28 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\User\Edit.cshtml"
WriteAttributeValue("", 1216, Url.Action("Index", "User"), 1216, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1245, 77, true);
                WriteLiteral(" class=\"btn btn-default\">Voltar</a>\r\n            </div>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 9 "C:\Users\Turing-PC\Desktop\super-app-pet-frontend-aspnetcore\Views\User\Edit.cshtml"
AddHtmlAttributeValue("", 175, Url.Action("EditUser", "User"), 175, 31, false);

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
            BeginContext(1329, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserModel> Html { get; private set; }
    }
}
#pragma warning restore 1591