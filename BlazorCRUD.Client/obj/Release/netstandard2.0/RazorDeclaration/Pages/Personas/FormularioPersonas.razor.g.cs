// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    public partial class FormularioPersonas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 62 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Pages\Personas\FormularioPersonas.razor"
       
    [Parameter] public Persona Persona { get; set; } = new Persona();
    [Parameter] public String TextoBoton { get; set; } = "Salvar cambios";
    [Parameter] public EventCallback OnValidSubmit { get; set; }
    List<Estado> Estados = new List<Estado>();
    List<Pais> Paises = new List<Pais>();
    private int paisId = 0;

    protected override async Task OnInitializedAsync()
    {
        if (Persona.Estado != null)
        {
            paisId = Persona.Estado.PaisId;
            await CargarEstados(Persona.Estado.PaisId);
        }

        Paises = await http.GetJsonAsync<List<Pais>>("api/paises");
    }

    private async Task ValorPaisCambiado(int value)
    {
        Persona.EstadoId = 0;
        paisId = value;
        await InvokeAsync(StateHasChanged);

        if (value == 0)
        {
            Estados.Clear();
        }
        else
        {
            await CargarEstados(value);
        }
    }

    private async Task CargarEstados(int paisId)
    {
        Estados = await http.GetJsonAsync<List<Estado>>($"api/paises/{paisId}/estados");
    }

#line default
#line hidden
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
