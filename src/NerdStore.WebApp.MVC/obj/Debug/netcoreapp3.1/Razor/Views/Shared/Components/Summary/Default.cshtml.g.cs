#pragma checksum "D:\Estudos\Desenvolvedor.IO\Dominios Ricos\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a5df3376d69ee554b95f909cbaced6842de6371"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Summary_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Summary/Default.cshtml")]
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
#nullable restore
#line 1 "D:\Estudos\Desenvolvedor.IO\Dominios Ricos\NerdStore\src\NerdStore.WebApp.MVC\Views\_ViewImports.cshtml"
using NerdStore.WebApp.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Estudos\Desenvolvedor.IO\Dominios Ricos\NerdStore\src\NerdStore.WebApp.MVC\Views\_ViewImports.cshtml"
using NerdStore.WebApp.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a5df3376d69ee554b95f909cbaced6842de6371", @"/Views/Shared/Components/Summary/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"246ad970dd91c7456f8d33f4d8e9926f7afca0fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Summary_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Estudos\Desenvolvedor.IO\Dominios Ricos\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
 if (ViewData.ModelState.ErrorCount > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\">x</button>\r\n        <h3 id=\"msgRetorno\">Opa! Algo deu errado</h3>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a5df3376d69ee554b95f909cbaced6842de63714081", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 6 "D:\Estudos\Desenvolvedor.IO\Dominios Ricos\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 8 "D:\Estudos\Desenvolvedor.IO\Dominios Ricos\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Estudos\Desenvolvedor.IO\Dominios Ricos\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
 if (TempData["Erro"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\">x</button>\r\n        <h3 id=\"msgRetorno\">Opa! Algo deu errado</h3>\r\n        <p>");
#nullable restore
#line 14 "D:\Estudos\Desenvolvedor.IO\Dominios Ricos\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
      Write(TempData["Erro"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n");
#nullable restore
#line 16 "D:\Estudos\Desenvolvedor.IO\Dominios Ricos\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Estudos\Desenvolvedor.IO\Dominios Ricos\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
 if (TempData["Erros"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\">x</button>\r\n        <h3 id=\"msgRetorno\">Opa! Algo deu errado</h3>\r\n");
#nullable restore
#line 22 "D:\Estudos\Desenvolvedor.IO\Dominios Ricos\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
          
            var erros = TempData["Erros"] as string[];
            foreach (var erro in erros)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>");
#nullable restore
#line 26 "D:\Estudos\Desenvolvedor.IO\Dominios Ricos\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
              Write(erro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 27 "D:\Estudos\Desenvolvedor.IO\Dominios Ricos\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 30 "D:\Estudos\Desenvolvedor.IO\Dominios Ricos\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "D:\Estudos\Desenvolvedor.IO\Dominios Ricos\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
 if (!string.IsNullOrEmpty(ViewBag.Sucesso))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\">x</button>\r\n        <h3 id=\"msgRetorno\">");
#nullable restore
#line 35 "D:\Estudos\Desenvolvedor.IO\Dominios Ricos\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
                       Write(ViewBag.Sucesso);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n");
#nullable restore
#line 37 "D:\Estudos\Desenvolvedor.IO\Dominios Ricos\NerdStore\src\NerdStore.WebApp.MVC\Views\Shared\Components\Summary\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
