#pragma checksum "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\Home\Razor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6589c60fc4e433f3164e93cad754f5f4f2298672"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Razor), @"mvc.1.0.view", @"/Views/Home/Razor.cshtml")]
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
#line 1 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\_ViewImports.cshtml"
using CursoMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\_ViewImports.cshtml"
using CursoMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6589c60fc4e433f3164e93cad754f5f4f2298672", @"/Views/Home/Razor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccb8eaa04eed6621e55a1442e3f20fbcd19719bf", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Razor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/html-css.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("scaleA"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\Home\Razor.cshtml"
  
    ViewData["Title"] = "Razor Page & Bootstrap";
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\Home\Razor.cshtml"
                                                                    
    var titulo = "Usando variáveis com RazorPages";
    var paragrafo1 = "Texto paragrafo 1";
    var paragrafo2 = "Texto paragrafo 2";

    string[] nomes = { "Maria", "Carla", "Rafael", "Taine", "Suzana", "Pedro"};
    int[] nota = { 2, 4, 7, 3, 10, 7 };
    var resultado = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<link href=\"/css/Razor.css\" rel=\"stylesheet\" />\r\n\r\n<h1>");
#nullable restore
#line 15 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\Home\Razor.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<h3>");
#nullable restore
#line 16 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\Home\Razor.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<div class=\"col-12\">\r\n    <h5>");
#nullable restore
#line 19 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\Home\Razor.cshtml"
   Write(titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \"col-12\"</h5>\r\n</div>\r\n<div class=\"col-12 d-flex justify-content-around\">\r\n    <p>");
#nullable restore
#line 22 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\Home\Razor.cshtml"
  Write(paragrafo1);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \"col-6\"</p>\r\n    <p>");
#nullable restore
#line 23 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\Home\Razor.cshtml"
  Write(paragrafo2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \"col-6\"</p>\r\n</div>\r\n\r\n<div col-12>\r\n    <h3>Nomes dos alunos</h3>\r\n    <ul>\r\n");
#nullable restore
#line 29 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\Home\Razor.cshtml"
         foreach (var nome in nomes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>");
#nullable restore
#line 31 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\Home\Razor.cshtml"
               Write(nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 32 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\Home\Razor.cshtml"
            }        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>\r\n\r\n<div col-12>\r\n    <h3>Aprovação:</h3>\r\n");
#nullable restore
#line 38 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\Home\Razor.cshtml"
     for (int i = 0; i < nomes.Length; i++)
    {
        if (nota[i] > 5)
        {
            resultado = "aprovado";
        } 
        else
        {
            resultado = "reprovado";
        }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"pl-5\">\r\n            <span>");
#nullable restore
#line 50 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\Home\Razor.cshtml"
              Write("Aluno: " + nomes[i] + ", " + "Nota: ");

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span");
            BeginWriteAttribute("class", " class=\"", 1272, "\"", 1290, 1);
#nullable restore
#line 51 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\Home\Razor.cshtml"
WriteAttributeValue("", 1280, resultado, 1280, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 51 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\Home\Razor.cshtml"
                                Write(nota[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>                  \r\n");
#nullable restore
#line 53 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\Home\Razor.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<div class=""pt-5"">
    <table class=""table table-bordered w-50 table-striped"">
        <thead class=""custom-border"">
            <tr>
                <th>#</th>
                <th>Aluno</th>
                <th>Nota</th>            
                <th>Status</th>            
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 67 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\Home\Razor.cshtml"
             for (int i = 0; i < nomes.Length; i ++)
                {
                    if (nota[i] > 5)
                    {
                        resultado = "aprovado";
                    }
                    else
                    {
                        resultado = "reprovado";
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <th>");
#nullable restore
#line 78 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\Home\Razor.cshtml"
                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        <td>");
#nullable restore
#line 79 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\Home\Razor.cshtml"
                       Write(nomes[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 2162, "\"", 2180, 1);
#nullable restore
#line 80 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\Home\Razor.cshtml"
WriteAttributeValue("", 2170, resultado, 2170, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 80 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\Home\Razor.cshtml"
                                          Write(nota[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td");
            BeginWriteAttribute("class", " class=\"", 2224, "\"", 2242, 1);
#nullable restore
#line 81 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\Home\Razor.cshtml"
WriteAttributeValue("", 2232, resultado, 2232, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 81 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\Home\Razor.cshtml"
                                          Write(resultado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 83 "C:\Users\rafael.basso\Documents\Personal\CursoMVC\CursoMVC\Views\Home\Razor.cshtml"
                }        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
</div>

<div class=""col-12 my-5"">
    <label for=""check"" class=""tog"">Click here</label>
    <input type=""checkbox"" class=""check"" id=""check""/>
    <div class=""content"">Contents</div>
</div>

<div class=""col-12"">
    <label>auto-resize: simple img</label>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6589c60fc4e433f3164e93cad754f5f4f229867211732", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n<div class=\"col-12\">\r\n    <label>auto-resize: div background img</label>\r\n    <div class=\"scaleB\">Content</div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
