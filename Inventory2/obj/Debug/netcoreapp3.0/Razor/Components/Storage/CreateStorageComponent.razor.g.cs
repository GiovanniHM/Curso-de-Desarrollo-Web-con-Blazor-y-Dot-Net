#pragma checksum "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\Components\Storage\CreateStorageComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3d4d4abda3d92e14a68850d42d542bbc8c002db"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory2.Components.Storage
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
#line 1 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\Components\Storage\CreateStorageComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\Components\Storage\CreateStorageComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public class CreateStorageComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\Components\Storage\CreateStorageComponent.razor"
                 oStorage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n\r\n    ");
                __builder2.OpenElement(4, "div");
                __builder2.AddMarkupContent(5, "\r\n        ");
                __builder2.AddMarkupContent(6, "<label>Bodega</label>\r\n        ");
                __Blazor.Inventory2.Components.Storage.CreateStorageComponent.TypeInference.CreateInputSelect_0(__builder2, 7, 8, 
#nullable restore
#line 9 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\Components\Storage\CreateStorageComponent.razor"
                                  oStorage.WarehouseId

#line default
#line hidden
#nullable disable
                , 9, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oStorage.WarehouseId = __value, oStorage.WarehouseId)), 10, () => oStorage.WarehouseId);
                __builder2.AddMarkupContent(11, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(12, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\Components\Storage\CreateStorageComponent.razor"
       
    StorageEntity oStorage = new StorageEntity();

    List<WarehouseEntity> warehouses = new List<WarehouseEntity>();
    List<ProductEntity> products = new List<ProductEntity>();

    protected override async Task OnInitializedAsync()
    {
        warehouses = B_Warehouse.WarehouseList();
        products = B_Product.ProductList();
        

    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Inventory2.Components.Storage.CreateStorageComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591