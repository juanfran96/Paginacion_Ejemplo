#pragma checksum "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2517e96f2b139e9642e6d53033f155000c731e30"
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<BlazorCRUD.Client.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "top-row px-4");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenComponent<BlazorCRUD.Client.Shared.EnlacesLogin>(12);
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.AddMarkupContent(14, "<a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\">About</a>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "content px-4");
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.AddContent(19, 
#line 14 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\Shared\MainLayout.razor"
         Body

#line default
#line hidden
            );
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
