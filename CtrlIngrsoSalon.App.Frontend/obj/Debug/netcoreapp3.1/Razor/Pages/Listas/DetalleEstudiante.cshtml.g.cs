#pragma checksum "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Módulo 4\Equipo\GitHub\CtrlIngrSlnApp\CtrlIngrsoSalon.App.Frontend\Pages\Listas\DetalleEstudiante.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c8890a96f4e5586f648b23e23822907d42621e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CtrlIngrsoSalon.App.Frontend.Pages.Listas.Pages_Listas_DetalleEstudiante), @"mvc.1.0.razor-page", @"/Pages/Listas/DetalleEstudiante.cshtml")]
namespace CtrlIngrsoSalon.App.Frontend.Pages.Listas
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
#line 1 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Módulo 4\Equipo\GitHub\CtrlIngrSlnApp\CtrlIngrsoSalon.App.Frontend\Pages\_ViewImports.cshtml"
using CtrlIngrsoSalon.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c8890a96f4e5586f648b23e23822907d42621e9", @"/Pages/Listas/DetalleEstudiante.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bebc4a6fac64d2586c7826768cf2a9300de76ba5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Listas_DetalleEstudiante : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Estudiantes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Módulo 4\Equipo\GitHub\CtrlIngrSlnApp\CtrlIngrsoSalon.App.Frontend\Pages\Listas\DetalleEstudiante.cshtml"
  

    var estudiante = Model.estudiante; 
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Detalle del Estudiante : ");
#nullable restore
#line 7 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Módulo 4\Equipo\GitHub\CtrlIngrSlnApp\CtrlIngrsoSalon.App.Frontend\Pages\Listas\DetalleEstudiante.cshtml"
                            Write(estudiante.persona.apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Módulo 4\Equipo\GitHub\CtrlIngrSlnApp\CtrlIngrsoSalon.App.Frontend\Pages\Listas\DetalleEstudiante.cshtml"
                                                          Write(estudiante.persona.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h1>
    <table class=""table"">
        <tr>
            <td>FECHA NACIMIENTO</td>
            <td>TELEFONO</td>
            <td>E-MAIL</td>
            <td>CARRERA</td>
            <td>SEMESTRE</td>

        </tr>
        <tr>
            <td>");
#nullable restore
#line 18 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Módulo 4\Equipo\GitHub\CtrlIngrSlnApp\CtrlIngrsoSalon.App.Frontend\Pages\Listas\DetalleEstudiante.cshtml"
           Write(estudiante.persona.fechaNacimiento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td>");
#nullable restore
#line 19 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Módulo 4\Equipo\GitHub\CtrlIngrSlnApp\CtrlIngrsoSalon.App.Frontend\Pages\Listas\DetalleEstudiante.cshtml"
           Write(estudiante.persona.telefono);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>   \r\n            <td>");
#nullable restore
#line 20 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Módulo 4\Equipo\GitHub\CtrlIngrSlnApp\CtrlIngrsoSalon.App.Frontend\Pages\Listas\DetalleEstudiante.cshtml"
           Write(estudiante.persona.correo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>            \r\n            <td>");
#nullable restore
#line 21 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Módulo 4\Equipo\GitHub\CtrlIngrSlnApp\CtrlIngrsoSalon.App.Frontend\Pages\Listas\DetalleEstudiante.cshtml"
           Write(estudiante.carrera);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>   \r\n            <td>");
#nullable restore
#line 22 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Módulo 4\Equipo\GitHub\CtrlIngrSlnApp\CtrlIngrsoSalon.App.Frontend\Pages\Listas\DetalleEstudiante.cshtml"
           Write(estudiante.semestre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c8890a96f4e5586f648b23e23822907d42621e97338", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-info-circle\"> </i> \r\n                     Regresar\r\n                     ");
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
            WriteLiteral("\r\n            </td>\r\n        </tr>        \r\n\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CtrlIngrsoSalon.App.Frontend.Pages.DetalleEstudianteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CtrlIngrsoSalon.App.Frontend.Pages.DetalleEstudianteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CtrlIngrsoSalon.App.Frontend.Pages.DetalleEstudianteModel>)PageContext?.ViewData;
        public CtrlIngrsoSalon.App.Frontend.Pages.DetalleEstudianteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
