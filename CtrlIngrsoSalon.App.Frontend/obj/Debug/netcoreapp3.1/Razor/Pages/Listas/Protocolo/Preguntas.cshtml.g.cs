#pragma checksum "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Laboratorios\GitHub\CtrlIngrSlnApp-1\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Protocolo\Preguntas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b19ce62548f6e6ce3d84357cfbe0aee0874f4034"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CtrlIngrsoSalon.App.Frontend.Pages.Listas.Protocolo.Pages_Listas_Protocolo_Preguntas), @"mvc.1.0.razor-page", @"/Pages/Listas/Protocolo/Preguntas.cshtml")]
namespace CtrlIngrsoSalon.App.Frontend.Pages.Listas.Protocolo
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
#line 1 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Laboratorios\GitHub\CtrlIngrSlnApp-1\CtrlIngrsoSalon.App.Frontend\Pages\_ViewImports.cshtml"
using CtrlIngrsoSalon.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b19ce62548f6e6ce3d84357cfbe0aee0874f4034", @"/Pages/Listas/Protocolo/Preguntas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bebc4a6fac64d2586c7826768cf2a9300de76ba5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Listas_Protocolo_Preguntas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./DetallePreguntas", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-sm-6\">\r\n                <h3>Listado de Preguntas</h3>\r\n            </div>\r\n            <div class=\"col-sm-2\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b19ce62548f6e6ce3d84357cfbe0aee0874f40344876", async() => {
                WriteLiteral("Agregar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral(@"    <div class=""row"">
        <table class=""table table-bordered table-striped"">
            <thead>
                <tr>
                    <td>ID</td>
                    <td>Pregunta</td>
                    <td>Resultado</td>
                    <td>Operaciones</td>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 28 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Laboratorios\GitHub\CtrlIngrSlnApp-1\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Protocolo\Preguntas.cshtml"
                 if (Model.Preguntas != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Laboratorios\GitHub\CtrlIngrSlnApp-1\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Protocolo\Preguntas.cshtml"
                     foreach (var pregunta in Model.Preguntas)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 33 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Laboratorios\GitHub\CtrlIngrSlnApp-1\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Protocolo\Preguntas.cshtml"
                           Write(pregunta.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 34 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Laboratorios\GitHub\CtrlIngrSlnApp-1\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Protocolo\Preguntas.cshtml"
                           Write(pregunta.pregunta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 35 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Laboratorios\GitHub\CtrlIngrSlnApp-1\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Protocolo\Preguntas.cshtml"
                             if (@pregunta.respuestaEsperada == true)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>Verdadero</td>\r\n");
#nullable restore
#line 38 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Laboratorios\GitHub\CtrlIngrSlnApp-1\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Protocolo\Preguntas.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>Falso</td>\r\n");
#nullable restore
#line 42 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Laboratorios\GitHub\CtrlIngrSlnApp-1\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Protocolo\Preguntas.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b19ce62548f6e6ce3d84357cfbe0aee0874f40349466", async() => {
                WriteLiteral("\r\n                                    <i class=\"fas fa-info-circle\"> </i>\r\n                                    Consultar\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-preguntaId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Laboratorios\GitHub\CtrlIngrSlnApp-1\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Protocolo\Preguntas.cshtml"
                                      WriteLiteral(pregunta.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["preguntaId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-preguntaId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["preguntaId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b19ce62548f6e6ce3d84357cfbe0aee0874f403412035", async() => {
                WriteLiteral("\r\n                                    <i class=\"fas fa-address-book\"> </i>\r\n                                    Editar\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-preguntaId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Laboratorios\GitHub\CtrlIngrSlnApp-1\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Protocolo\Preguntas.cshtml"
                                      WriteLiteral(pregunta.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["preguntaId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-preguntaId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["preguntaId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b19ce62548f6e6ce3d84357cfbe0aee0874f403414603", async() => {
                WriteLiteral("\r\n                                    <i class=\"fas fa-trash-alt\"> </i>\r\n                                    Eliminar\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-preguntaId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Laboratorios\GitHub\CtrlIngrSlnApp-1\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Protocolo\Preguntas.cshtml"
                                                                                                  WriteLiteral(pregunta.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["preguntaId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-preguntaId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["preguntaId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 60 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Laboratorios\GitHub\CtrlIngrSlnApp-1\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Protocolo\Preguntas.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Laboratorios\GitHub\CtrlIngrSlnApp-1\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Protocolo\Preguntas.cshtml"
                     
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"4\">No hay registros!</td>\r\n                    </tr>\r\n");
#nullable restore
#line 67 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Laboratorios\GitHub\CtrlIngrSlnApp-1\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Protocolo\Preguntas.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CtrlIngrsoSalon.App.Frontend.Pages.PreguntasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CtrlIngrsoSalon.App.Frontend.Pages.PreguntasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CtrlIngrsoSalon.App.Frontend.Pages.PreguntasModel>)PageContext?.ViewData;
        public CtrlIngrsoSalon.App.Frontend.Pages.PreguntasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
