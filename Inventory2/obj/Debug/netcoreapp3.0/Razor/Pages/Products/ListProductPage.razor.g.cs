#pragma checksum "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\Pages\Products\ListProductPage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1605c9c9ca68aa191d18dd9941eb33a36978112"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory2.Pages.Products
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\_Imports.razor"
using Inventory2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\_Imports.razor"
using Inventory2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\_Imports.razor"
using Inventory2.Components.Ejercicios.BlazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\_Imports.razor"
using Inventory2.Components.Ejercicios.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\_Imports.razor"
using Inventory2.Components.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\_Imports.razor"
using Inventory2.Components.Category;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\_Imports.razor"
using Inventory2.Components.Warehouse;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\_Imports.razor"
using Inventory2.Components.Storage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/list")]
    public class ListProductPage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Lista de productos</h3>\r\n<hr>\r\n");
            __builder.AddMarkupContent(1, "<a href=\"product/create\">Crear producto</a>\r\n<hr>\r\n");
            __builder.OpenComponent<Inventory2.Components.Products.ListProductsComponent>(2);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
