#pragma checksum "C:\Users\Ziad-PC20\EstudosDotNetCore\Aula2\Views\Home\Pessoa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bde8808fccd6e3a0fbbefded5d9e84a70807f940"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Pessoa), @"mvc.1.0.view", @"/Views/Home/Pessoa.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Pessoa.cshtml", typeof(AspNetCore.Views_Home_Pessoa))]
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
#line 1 "C:\Users\Ziad-PC20\EstudosDotNetCore\Aula2\Views\_ViewImports.cshtml"
using Aula2;

#line default
#line hidden
#line 2 "C:\Users\Ziad-PC20\EstudosDotNetCore\Aula2\Views\_ViewImports.cshtml"
using Aula2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bde8808fccd6e3a0fbbefded5d9e84a70807f940", @"/Views/Home/Pessoa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10eedc5397cdde30d2f51093d6c8b7b3a89350dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Pessoa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Aula2.Models.Pessoa>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Ziad-PC20\EstudosDotNetCore\Aula2\Views\Home\Pessoa.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
            BeginContext(78, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(83, 17, false);
#line 5 "C:\Users\Ziad-PC20\EstudosDotNetCore\Aula2\Views\Home\Pessoa.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(100, 18, true);
            WriteLiteral("</h1>\r\n\r\n<p>Nome: ");
            EndContext();
            BeginContext(119, 10, false);
#line 7 "C:\Users\Ziad-PC20\EstudosDotNetCore\Aula2\Views\Home\Pessoa.cshtml"
    Write(Model.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(129, 16, true);
            WriteLiteral("</p>\r\n<p>Idade: ");
            EndContext();
            BeginContext(146, 11, false);
#line 8 "C:\Users\Ziad-PC20\EstudosDotNetCore\Aula2\Views\Home\Pessoa.cshtml"
     Write(Model.Idade);

#line default
#line hidden
            EndContext();
            BeginContext(157, 6, true);
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Aula2.Models.Pessoa> Html { get; private set; }
    }
}
#pragma warning restore 1591