#pragma checksum "E:\ejercicio\practica04\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb99c22664e64bb964528b5f607fce135309adf7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "E:\ejercicio\practica04\Views\_ViewImports.cshtml"
using Practica04;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ejercicio\practica04\Views\_ViewImports.cshtml"
using Practica04.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb99c22664e64bb964528b5f607fce135309adf7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b343465d778e9975797342551c98a6555fadffaf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FormularioRegistro>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\ejercicio\practica04\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "PERU FAILS";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "E:\ejercicio\practica04\Views\Home\Index.cshtml"
 if (Model.Count() == 0){
    

#line default
#line hidden
#nullable disable
            WriteLiteral("     <p class=\"text-center\">Peru Fails </p>\r\n    <p class=\"text-center\">No se ingreso fotos</p>\r\n");
#nullable restore
#line 11 "E:\ejercicio\practica04\Views\Home\Index.cshtml"
} else {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n");
#nullable restore
#line 13 "E:\ejercicio\practica04\Views\Home\Index.cshtml"
     foreach(var Registros in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-4 text-center\">\r\n  <p>Titulo:</p><h2>");
#nullable restore
#line 16 "E:\ejercicio\practica04\Views\Home\Index.cshtml"
               Write(Registros.titulofoto);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n <p>Subidopor:</p><p>");
#nullable restore
#line 17 "E:\ejercicio\practica04\Views\Home\Index.cshtml"
                Write(Registros.subidopor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n <img");
            BeginWriteAttribute("src", " src=\"", 424, "\"", 448, 1);
#nullable restore
#line 18 "E:\ejercicio\practica04\Views\Home\Index.cshtml"
WriteAttributeValue("", 430, Registros.urlfoto, 430, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"/>\r\n <p>Enviar comentarios:</p> <p>");
#nullable restore
#line 19 "E:\ejercicio\practica04\Views\Home\Index.cshtml"
                          Write(Registros.comentario);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n <button class=\"btn btn-primary\">Enviar Comentario</button>\r\n\r\n</div>\r\n");
#nullable restore
#line 23 "E:\ejercicio\practica04\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 25 "E:\ejercicio\practica04\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FormularioRegistro>> Html { get; private set; }
    }
}
#pragma warning restore 1591
