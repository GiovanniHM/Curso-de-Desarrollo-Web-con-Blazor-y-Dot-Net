#pragma checksum "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\Components\Category\UpdateCategoryComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7112d98ba8bb76a24bb3d10fd091d26bec9d28d0"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Inventory2.Components.Category
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
#line 1 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\Components\Category\UpdateCategoryComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\Components\Category\UpdateCategoryComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public class UpdateCategoryComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\Components\Category\UpdateCategoryComponent.razor"
       
    [Parameter]
    public string CategoryId { get; set; }

    CategoryEntity oCategory = new CategoryEntity();

    protected override async Task OnInitializedAsync()
    {
        oCategory = B_Category.CategoryById(CategoryId);
    }

    private void UpdateCategory()
    {
        B_Category.UpdateCategory(oCategory);
        NavManager.NavigateTo("category/list");
        

    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591