#pragma checksum "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Shared\ListadoGenerico.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "55a05328371c539661f173313a0e86e2d16bb4fb"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUD.Client.Shared
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
    public partial class ListadoGenerico<TElemento> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 3 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Shared\ListadoGenerico.razor"
 if (Listado == null)
{
    if (PlantillaNula == null)
    {
        

#line default
#line hidden
            __builder.AddContent(0, "Cargando...");
#line 7 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Shared\ListadoGenerico.razor"
                                
    }
    else
    {
        

#line default
#line hidden
            __builder.AddContent(1, 
#line 11 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Shared\ListadoGenerico.razor"
         PlantillaNula

#line default
#line hidden
            );
#line 11 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Shared\ListadoGenerico.razor"
                      
    }
}
else if (Listado.Count == 0)
{
    if (PlantillaVacia == null)
    {
        

#line default
#line hidden
            __builder.AddContent(2, "No hay registros en la base de datos");
#line 18 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Shared\ListadoGenerico.razor"
                                                         
    }
    else
    {
        

#line default
#line hidden
            __builder.AddContent(3, 
#line 22 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Shared\ListadoGenerico.razor"
         PlantillaVacia

#line default
#line hidden
            );
#line 22 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Shared\ListadoGenerico.razor"
                       
    }
}
else
{
    if (PlantillaConElementos != null)
    {
        

#line default
#line hidden
            __builder.AddContent(4, 
#line 29 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Shared\ListadoGenerico.razor"
         PlantillaConElementos

#line default
#line hidden
            );
#line 29 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Shared\ListadoGenerico.razor"
                              
    }
    else
    {
        foreach (var elemento in Listado)
        {
            

#line default
#line hidden
            __builder.AddContent(5, 
#line 35 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Shared\ListadoGenerico.razor"
             PlantillaConElementosTipo(elemento)

#line default
#line hidden
            );
#line 35 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Shared\ListadoGenerico.razor"
                                                
        }
    }
}

#line default
#line hidden
        }
        #pragma warning restore 1998
#line 40 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Shared\ListadoGenerico.razor"
       
    [Parameter] public List<TElemento> Listado { get; set; }
    [Parameter] public RenderFragment PlantillaVacia { get; set; }
    [Parameter] public RenderFragment PlantillaNula { get; set; }
    [Parameter] public RenderFragment PlantillaConElementos { get; set; }
    [Parameter] public RenderFragment<TElemento> PlantillaConElementosTipo { get; set; }

#line default
#line hidden
    }
}
#pragma warning restore 1591
