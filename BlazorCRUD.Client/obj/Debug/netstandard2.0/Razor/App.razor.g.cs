#pragma checksum "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d528b366d02240bc76912b9bbabe099e160e3f50"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUD.Client
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
    public partial class App : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Reflection.Assembly>(
#line 1 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "Found", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeRouteView>(4);
                __builder2.AddAttribute(5, "RouteData", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.RouteData>(
#line 3 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\App.razor"
                                        routeData

#line default
#line hidden
                ));
                __builder2.AddAttribute(6, "DefaultLayout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#line 3 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\App.razor"
                                                                   typeof(MainLayout)

#line default
#line hidden
                ));
                __builder2.AddAttribute(7, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(8, "\r\n                ");
                    __builder3.AddMarkupContent(9, "<h1>Sorry</h1>\r\n                ");
                    __builder3.AddMarkupContent(10, "<p>You\'re not authorized to reach this page.</p>\r\n                ");
                    __builder3.AddMarkupContent(11, "<p>You may need to log in as a different user.</p>\r\n            ");
                }
                ));
                __builder2.AddAttribute(12, "Authorizing", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(13, "\r\n                ");
                    __builder3.AddMarkupContent(14, "<h1>Authentication in progress</h1>\r\n                ");
                    __builder3.AddMarkupContent(15, "<p>Only visible while authentication is in progress.</p>\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n    ");
            }
            ));
            __builder.AddAttribute(17, "NotFound", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.CascadingAuthenticationState>(19);
                __builder2.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(21, "\r\n            ");
                    __builder3.OpenComponent<Microsoft.AspNetCore.Components.LayoutView>(22);
                    __builder3.AddAttribute(23, "Layout", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Type>(
#line 17 "E:\Kimen\EjemploPaginacion\BlazorCRUD.Client\App.razor"
                                 typeof(MainLayout)

#line default
#line hidden
                    ));
                    __builder3.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(25, "\r\n                ");
                        __builder4.AddMarkupContent(26, "<h1>Sorry</h1>\r\n                ");
                        __builder4.AddMarkupContent(27, "<p>Sorry, there\'s nothing at this address.</p>\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(28, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
