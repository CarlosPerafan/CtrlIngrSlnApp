#pragma checksum "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Módulo 4\Equipo\GitHub\CtrlIngrSlnApp\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Estudiantes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92f2ab37c369e71a677156eaf36ac3193576c075"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CtrlIngrsoSalon.App.Frontend.Pages.Listas.Pages_Listas_Estudiantes), @"mvc.1.0.razor-page", @"/Pages/Listas/Estudiantes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92f2ab37c369e71a677156eaf36ac3193576c075", @"/Pages/Listas/Estudiantes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bebc4a6fac64d2586c7826768cf2a9300de76ba5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Listas_Estudiantes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EditarEstudiante", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./DetalleEstudiante", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./EliminarEstudiante", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"row\">\r\n             <div class= \"col-sm-6\">\r\n               <h3>Listado de Estudiantes</h3>\r\n             </div>\r\n             <div class= \"col-sm-2\">\r\n               ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92f2ab37c369e71a677156eaf36ac3193576c0755440", async() => {
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
            WriteLiteral("\r\n             </div>             \r\n    </div>\r\n</div>\r\n");
            WriteLiteral("<div class=\"row\">\r\n\r\n");
#nullable restore
#line 19 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Módulo 4\Equipo\GitHub\CtrlIngrSlnApp\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Estudiantes.cshtml"
 if (Model.Estudiantes != null)

{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-bordered table-striped"">
        <thead>
            <tr>
                <td>CODIGO</td>                
                <td>NOMBRE</td> 
                <td>APELLIDOS</td> 
                <td>OPERACIONES</td>              
            </tr> 
        </thead>
        <tbody>
");
#nullable restore
#line 33 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Módulo 4\Equipo\GitHub\CtrlIngrSlnApp\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Estudiantes.cshtml"
         foreach(var estudiante in Model.Estudiantes)
        {      

#line default
#line hidden
#nullable disable
            WriteLiteral("           <tr>\r\n                <td>");
#nullable restore
#line 36 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Módulo 4\Equipo\GitHub\CtrlIngrSlnApp\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Estudiantes.cshtml"
               Write(estudiante.persona.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>                \r\n                <td>");
#nullable restore
#line 37 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Módulo 4\Equipo\GitHub\CtrlIngrSlnApp\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Estudiantes.cshtml"
               Write(estudiante.persona.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                <td>");
#nullable restore
#line 38 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Módulo 4\Equipo\GitHub\CtrlIngrSlnApp\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Estudiantes.cshtml"
               Write(estudiante.persona.apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92f2ab37c369e71a677156eaf36ac3193576c0759026", async() => {
                WriteLiteral("\r\n                    <i class=\"fas fa-info-circle\"> </i> \r\n                     Consultar\r\n                     ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-personaId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Módulo 4\Equipo\GitHub\CtrlIngrSlnApp\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Estudiantes.cshtml"
                                                                                                 WriteLiteral(estudiante.persona.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["personaId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-personaId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["personaId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Módulo 4\Equipo\GitHub\CtrlIngrSlnApp\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Estudiantes.cshtml"
                                                                                                                                            WriteLiteral(estudiante.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["estudId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-estudId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["estudId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92f2ab37c369e71a677156eaf36ac3193576c07512529", async() => {
                WriteLiteral("\r\n                     <i class=\"fas fa-address-book\"> </i>\r\n                     Editar\r\n                     ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-estudianteId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Módulo 4\Equipo\GitHub\CtrlIngrSlnApp\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Estudiantes.cshtml"
                                                                                                    WriteLiteral(estudiante.persona.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["estudianteId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-estudianteId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["estudianteId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                     ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92f2ab37c369e71a677156eaf36ac3193576c07515118", async() => {
                WriteLiteral("\r\n                     <i> </i>\r\n                     Eliminar\r\n                     ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-estudianteId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Módulo 4\Equipo\GitHub\CtrlIngrSlnApp\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Estudiantes.cshtml"
                                                                                           WriteLiteral(estudiante.persona.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["estudianteId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-estudianteId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["estudianteId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("                     \r\n\r\n                </td>                                      \r\n            </tr>\r\n");
#nullable restore
#line 54 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Módulo 4\Equipo\GitHub\CtrlIngrSlnApp\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Estudiantes.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>        \r\n    </table>\r\n");
#nullable restore
#line 58 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Módulo 4\Equipo\GitHub\CtrlIngrSlnApp\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Estudiantes.cshtml"

} else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No hay registros mi pana !!!</p>\r\n");
#nullable restore
#line 62 "L:\JORGEALBERTO\Universidad\Universidad de Caldas\Ciclo 3\DS-C3-23 Desarrollo de Software\Módulo 4\Equipo\GitHub\CtrlIngrSlnApp\CtrlIngrsoSalon.App.Frontend\Pages\Listas\Estudiantes.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n</div>    \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CtrlIngrsoSalon.App.Frontend.Pages.EstudiantesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CtrlIngrsoSalon.App.Frontend.Pages.EstudiantesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CtrlIngrsoSalon.App.Frontend.Pages.EstudiantesModel>)PageContext?.ViewData;
        public CtrlIngrsoSalon.App.Frontend.Pages.EstudiantesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
