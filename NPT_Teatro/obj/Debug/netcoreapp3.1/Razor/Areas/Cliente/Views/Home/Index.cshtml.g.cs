#pragma checksum "C:\Users\agust\source\repos\NPT_Teatro\NPT_Teatro\Areas\Cliente\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df6f68528b0c4af4a2fb09e2a391bc8e5f96156d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cliente_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Cliente/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\agust\source\repos\NPT_Teatro\NPT_Teatro\Areas\Cliente\Views\_ViewImports.cshtml"
using NPT_Teatro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\agust\source\repos\NPT_Teatro\NPT_Teatro\Areas\Cliente\Views\_ViewImports.cshtml"
using NPT_Teatro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df6f68528b0c4af4a2fb09e2a391bc8e5f96156d", @"/Areas/Cliente/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f82a6215405a9f3ab3830d86fac7f418a84bcdb", @"/Areas/Cliente/Views/_ViewImports.cshtml")]
    public class Areas_Cliente_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NPT_Teatro.Models.ViewModels.HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("boton-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("border-radius: 5px; background-color: #1e8535; "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\agust\source\repos\NPT_Teatro\NPT_Teatro\Areas\Cliente\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Inicio";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div id=\"carouselExampleControls\" class=\"carousel slide\" data-ride=\"carousel\">\r\n    <div class=\"carousel-inner\" style=\"height: 500px;\">\r\n\r\n");
#nullable restore
#line 16 "C:\Users\agust\source\repos\NPT_Teatro\NPT_Teatro\Areas\Cliente\Views\Home\Index.cshtml"
           int cont = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\agust\source\repos\NPT_Teatro\NPT_Teatro\Areas\Cliente\Views\Home\Index.cshtml"
         foreach (var item in Model.ListaFunciones)
        {
            var itemDinamico = cont++ == 0 ? "item active" : "item";

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div");
            BeginWriteAttribute("class", " class=\"", 636, "\"", 671, 2);
            WriteAttributeValue("", 644, "carousel-item", 644, 13, true);
#nullable restore
#line 20 "C:\Users\agust\source\repos\NPT_Teatro\NPT_Teatro\Areas\Cliente\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 657, itemDinamico, 658, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                <img class=\"w-100 fill\"");
            BeginWriteAttribute("src", " src=\"", 716, "\"", 750, 1);
#nullable restore
#line 22 "C:\Users\agust\source\repos\NPT_Teatro\NPT_Teatro\Areas\Cliente\Views\Home\Index.cshtml"
WriteAttributeValue("", 722, Url.Content(item.UrlImagen), 722, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n");
#nullable restore
#line 24 "C:\Users\agust\source\repos\NPT_Teatro\NPT_Teatro\Areas\Cliente\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"texto-carousel\">\r\n    <div class=\"col-sm-12 py-5\">\r\n        <h1 class=\"text-center text-white position-relative mt-5\">Pr??ximas funciones</h1>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 37 "C:\Users\agust\source\repos\NPT_Teatro\NPT_Teatro\Areas\Cliente\Views\Home\Index.cshtml"
 if (Model.ListaFunciones.Count() > 0)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n");
#nullable restore
#line 41 "C:\Users\agust\source\repos\NPT_Teatro\NPT_Teatro\Areas\Cliente\Views\Home\Index.cshtml"
         foreach (var funcion in Model.ListaFunciones.OrderBy(o => o.Id))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-3 mb-5 mt-5\">\r\n                <div class=\"card\" style=\"background-color: black; border-radius: 10px;\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1301, "\"", 1325, 1);
#nullable restore
#line 45 "C:\Users\agust\source\repos\NPT_Teatro\NPT_Teatro\Areas\Cliente\Views\Home\Index.cshtml"
WriteAttributeValue("", 1307, funcion.UrlImagen, 1307, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail p-0\" />\r\n                    <div class=\"card-body\">\r\n                        <!--<h5 class=\"tex-center\"></h5>-->\r\n                        <p class=\"text-light\">");
#nullable restore
#line 48 "C:\Users\agust\source\repos\NPT_Teatro\NPT_Teatro\Areas\Cliente\Views\Home\Index.cshtml"
                                         Write(funcion.Fecha.ToString("MM/dd/yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df6f68528b0c4af4a2fb09e2a391bc8e5f96156d8498", async() => {
                WriteLiteral("M??s informaci??n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\agust\source\repos\NPT_Teatro\NPT_Teatro\Areas\Cliente\Views\Home\Index.cshtml"
                                                                                                                                                  WriteLiteral(funcion.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 53 "C:\Users\agust\source\repos\NPT_Teatro\NPT_Teatro\Areas\Cliente\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 55 "C:\Users\agust\source\repos\NPT_Teatro\NPT_Teatro\Areas\Cliente\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No hay funciones pr??ximas</p>\r\n");
#nullable restore
#line 59 "C:\Users\agust\source\repos\NPT_Teatro\NPT_Teatro\Areas\Cliente\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NPT_Teatro.Models.ViewModels.HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
