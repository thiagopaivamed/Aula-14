#pragma checksum "C:\Users\thiag\Desktop\PrimeiroCRUD\PrimeiroCRUD\Views\Carros\Detalhes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d11bc92d23b764c59bcc34ad2c04f21db6734ff8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Carros_Detalhes), @"mvc.1.0.view", @"/Views/Carros/Detalhes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Carros/Detalhes.cshtml", typeof(AspNetCore.Views_Carros_Detalhes))]
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
#line 1 "C:\Users\thiag\Desktop\PrimeiroCRUD\PrimeiroCRUD\Views\_ViewImports.cshtml"
using PrimeiroCRUD;

#line default
#line hidden
#line 2 "C:\Users\thiag\Desktop\PrimeiroCRUD\PrimeiroCRUD\Views\_ViewImports.cshtml"
using PrimeiroCRUD.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d11bc92d23b764c59bcc34ad2c04f21db6734ff8", @"/Views/Carros/Detalhes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7e576a0bac9f50b21b98eee6ed13364fc36e6f3", @"/Views/_ViewImports.cshtml")]
    public class Views_Carros_Detalhes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PrimeiroCRUD.Models.Carro>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\thiag\Desktop\PrimeiroCRUD\PrimeiroCRUD\Views\Carros\Detalhes.cshtml"
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
            BeginContext(80, 46, true);
            WriteLiteral("\r\n<h2>Detalhes</h2>\r\n\r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(127, 37, false);
#line 10 "C:\Users\thiag\Desktop\PrimeiroCRUD\PrimeiroCRUD\Views\Carros\Detalhes.cshtml"
Write(Html.DisplayFor(model => model.Marca));

#line default
#line hidden
            EndContext();
            BeginContext(164, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(171, 36, false);
#line 11 "C:\Users\thiag\Desktop\PrimeiroCRUD\PrimeiroCRUD\Views\Carros\Detalhes.cshtml"
Write(Html.DisplayFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(207, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(214, 35, false);
#line 12 "C:\Users\thiag\Desktop\PrimeiroCRUD\PrimeiroCRUD\Views\Carros\Detalhes.cshtml"
Write(Html.DisplayFor(model => model.Ano));

#line default
#line hidden
            EndContext();
            BeginContext(249, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrimeiroCRUD.Models.Carro> Html { get; private set; }
    }
}
#pragma warning restore 1591
