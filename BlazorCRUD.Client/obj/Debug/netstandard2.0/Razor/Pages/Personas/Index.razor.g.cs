#pragma checksum "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Pages\Personas\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a23b76083880ce6300e2cf18e43b129e1b75c4a0"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUD.Client.Pages.Personas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 2 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#line 3 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 4 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 5 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 6 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\_Imports.razor"
using BlazorCRUD.Client;

#line default
#line hidden
#line 8 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\_Imports.razor"
using BlazorCRUD.Client.Shared;

#line default
#line hidden
#line 9 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\_Imports.razor"
using BlazorCRUD.Shared.Models;

#line default
#line hidden
#line 10 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\_Imports.razor"
using BlazorCRUD.Client.Helpers;

#line default
#line hidden
#line 11 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\_Imports.razor"
using OfficeOpenXml;

#line default
#line hidden
#line 12 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\_Imports.razor"
using OfficeOpenXml.Style;

#line default
#line hidden
#line 13 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\_Imports.razor"
using System.Drawing;

#line default
#line hidden
#line 4 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Pages\Personas\Index.razor"
using System.IO;

#line default
#line hidden
#line 5 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Pages\Personas\Index.razor"
using CsvHelper;

#line default
#line hidden
#line 6 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Pages\Personas\Index.razor"
using System.Text.Json;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/indice-personas")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Personas</h3>\r\n\r\n\r\n        ");
            __builder.AddMarkupContent(1, "<div class=\"form-group\">\r\n            <a class=\"btn btn-success\" href=\"crear-persona\">Nueva Persona</a>\r\n        </div>\r\n   \r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "form-inline");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.AddMarkupContent(5, "<label class=\"sr-only\" for=\"nombre-filtro\">Filtrar</label>\r\n    ");
            __builder.OpenElement(6, "input");
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "class", "form-control mb-2 mr-sm-2");
            __builder.AddAttribute(9, "placeholder", "Filtrar por Nombre");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#line 19 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Pages\Personas\Index.razor"
                 nombrePersonaFiltro

#line default
#line hidden
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => nombrePersonaFiltro = __value, nombrePersonaFiltro));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "class", "btn btn-primary mr-sm-2 mb-2");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 21 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Pages\Personas\Index.razor"
                      Filtrar

#line default
#line hidden
            ));
            __builder.AddContent(17, "Filtrar");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n    ");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "type", "button");
            __builder.AddAttribute(21, "class", "btn btn-danger mb-2");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 23 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Pages\Personas\Index.razor"
                      Limpiar

#line default
#line hidden
            ));
            __builder.AddContent(23, "Limpiar");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n");
            __builder.OpenComponent<BlazorCRUD.Client.Shared.Paginacion>(26);
            __builder.AddAttribute(27, "PaginasTotales", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 27 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Pages\Personas\Index.razor"
                            paginasTotales

#line default
#line hidden
            ));
            __builder.AddAttribute(28, "PaginaActual", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 27 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Pages\Personas\Index.razor"
                                                          paginaActual

#line default
#line hidden
            ));
            __builder.AddAttribute(29, "Radio", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#line 27 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Pages\Personas\Index.razor"
                                                                                2

#line default
#line hidden
            ));
            __builder.AddAttribute(30, "PaginaSeleccionada", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#line 28 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Pages\Personas\Index.razor"
                                PaginaSeleccionada

#line default
#line hidden
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\r\n\r\n");
            __Blazor.BlazorCRUD.Client.Pages.Personas.Index.TypeInference.CreateListadoGenerico_0(__builder, 32, 33, 
#line 30 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Pages\Personas\Index.razor"
                          personas

#line default
#line hidden
            , 34, (__builder2) => {
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.OpenElement(36, "table");
                __builder2.AddAttribute(37, "class", "table");
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.AddMarkupContent(39, "<thead>\r\n                <tr>\r\n                    <th></th>\r\n                    <th>Id</th>\r\n                    <th>Nombre</th>\r\n                </tr>\r\n            </thead>\r\n            ");
                __builder2.OpenElement(40, "tbody");
                __builder2.AddMarkupContent(41, "\r\n");
#line 41 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Pages\Personas\Index.razor"
                 foreach (var persona in personas)
                {

#line default
#line hidden
                __builder2.AddContent(42, "                    ");
                __builder2.OpenElement(43, "tr");
                __builder2.AddMarkupContent(44, "\r\n                        ");
                __builder2.OpenElement(45, "td");
                __builder2.AddMarkupContent(46, "\r\n                            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(47);
                __builder2.AddAttribute(48, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(49, "\r\n                                    ");
                    __builder3.OpenElement(50, "a");
                    __builder3.AddAttribute(51, "class", "btn btn-success");
                    __builder3.AddAttribute(52, "href", "editar-persona/" + (
#line 47 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Pages\Personas\Index.razor"
                                                                                     persona.Id

#line default
#line hidden
                    ));
                    __builder3.AddContent(53, "Editar");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(54, "\r\n                                    ");
                    __builder3.OpenElement(55, "button");
                    __builder3.AddAttribute(56, "class", "btn btn-danger");
                    __builder3.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 48 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Pages\Personas\Index.razor"
                                                                               () => BorrarPersona(persona.Id)

#line default
#line hidden
                    ));
                    __builder3.AddContent(58, "Borrar");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(59, "\r\n                                ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(60, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                        ");
                __builder2.OpenElement(62, "td");
                __builder2.AddContent(63, 
#line 52 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Pages\Personas\Index.razor"
                             persona.Id

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                        ");
                __builder2.OpenElement(65, "td");
                __builder2.AddContent(66, 
#line 53 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Pages\Personas\Index.razor"
                             persona.Nombre

#line default
#line hidden
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n");
#line 55 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Pages\Personas\Index.razor"
                }

#line default
#line hidden
                __builder2.AddContent(69, "            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n\r\n    ");
            }
            );
            __builder.AddMarkupContent(72, "\r\n\r\n");
#line 62 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Pages\Personas\Index.razor"
 if (personas?.Count > 0)
{

#line default
#line hidden
            __builder.AddContent(73, "    ");
            __builder.OpenElement(74, "button");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 64 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Pages\Personas\Index.razor"
                      ExportarCSV

#line default
#line hidden
            ));
            __builder.AddContent(76, "Exportar a CSV");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n    ");
            __builder.OpenElement(78, "button");
            __builder.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 65 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Pages\Personas\Index.razor"
                      ExportarExcel

#line default
#line hidden
            ));
            __builder.AddContent(80, "Exportar a Excel");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
#line 66 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Pages\Personas\Index.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 69 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Pages\Personas\Index.razor"
       
    List<Persona> personas { get; set; }

    private int paginaActual = 1;
    private int paginasTotales;
    private string nombrePersonaFiltro = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        await CargarPersonas();
    }

    private async Task PaginaSeleccionada(int pagina)
    {
        paginaActual = pagina;
        await CargarPersonas(pagina);
    }

    private async Task Filtrar()
    {
        paginaActual = 1;
        await CargarPersonas();
    }

    private async Task Limpiar()
    {
        nombrePersonaFiltro = string.Empty;
        paginaActual = 1;
        await CargarPersonas();
    }

    async Task CargarPersonas(int pagina = 1, int cantidadRegistrosAMostrar = 10)
    {

        
        var httpResponse = await Http.GetAsync($"personas?pagina={pagina}&CantidadAMostrar={cantidadRegistrosAMostrar}&nombre={nombrePersonaFiltro}");
        if (httpResponse.IsSuccessStatusCode)
        {
            paginasTotales = int.Parse(httpResponse.Headers.GetValues("totalPaginas").FirstOrDefault());
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            personas = JsonSerializer.Deserialize<List<Persona>>(responseString,
              new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
              
            

        }
        else
        {
            Console.WriteLine("error");
        }
        
        
    }

    async Task BorrarPersona(int idPersona)
    {
        var personaSeleccionada = personas.First(x => x.Id == idPersona);
        string mensajeConfirmacion = $"??Deseas borrar a la persona {personaSeleccionada.Nombre}?";
        if (await JS.Confirm("Confirmar", mensajeConfirmacion, TipoMensajeSweetAlert.question))
        {
            await Http.DeleteAsync($"personas/{idPersona}");
            await CargarPersonas();
        }
    }

    private void ExportarCSV()
    {
        using (var memoryStream = new MemoryStream())
        {
            using (var writer = new StreamWriter(memoryStream))
            {
                using (var csv = new CsvWriter(writer))
                {
                    csv.WriteRecords(personas);
                }

                var arr = memoryStream.ToArray();
                JS.GuardarComo("personas.csv", arr);
            }
        }
    }

    private void ExportarExcel()
    {
        using (var package = new ExcelPackage())
        {
            var worksheet = package.Workbook.Worksheets.Add("Personas");

            var tableBody = worksheet.Cells["A1:A1"].LoadFromCollection(
                from f in personas
                select new { f.Id, f.Nombre }, true);

            var header = worksheet.Cells["A1:B1"];
            worksheet.DefaultColWidth = 25;
            tableBody.Style.HorizontalAlignment = ExcelHorizontalAlignment.Left;
            tableBody.Style.Fill.PatternType = ExcelFillStyle.Solid;
            tableBody.Style.Fill.BackgroundColor.SetColor(Color.WhiteSmoke);
            tableBody.Style.Border.BorderAround(ExcelBorderStyle.Medium);
            header.Style.Font.Bold = true;
            header.Style.Font.Color.SetColor(Color.White);
            header.Style.Fill.PatternType = ExcelFillStyle.Solid;
            header.Style.Fill.BackgroundColor.SetColor(Color.DarkBlue);

            JS.GuardarComo("personas.xlsx", package.GetAsByteArray());
        }
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.BlazorCRUD.Client.Pages.Personas.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateListadoGenerico_0<TElemento>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TElemento> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::BlazorCRUD.Client.Shared.ListadoGenerico<TElemento>>(seq);
        __builder.AddAttribute(__seq0, "Listado", __arg0);
        __builder.AddAttribute(__seq1, "PlantillaConElementos", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
