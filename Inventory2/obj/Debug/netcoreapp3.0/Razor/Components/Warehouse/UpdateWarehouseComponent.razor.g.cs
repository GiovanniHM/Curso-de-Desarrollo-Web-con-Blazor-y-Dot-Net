#pragma checksum "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\Components\Warehouse\UpdateWarehouseComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bab0661caa5fa98eac446d7f75a62c0165c1dc9c"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory2.Components.Warehouse
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
#nullable restore
#line 1 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\Components\Warehouse\UpdateWarehouseComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\Components\Warehouse\UpdateWarehouseComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
    public class UpdateWarehouseComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\Components\Warehouse\UpdateWarehouseComponent.razor"
                     oWarehouse

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n        ");
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "form-group");
                __builder2.AddMarkupContent(6, "\r\n            ");
                __builder2.AddMarkupContent(7, "<label>Nombre</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(8);
                __builder2.AddAttribute(9, "class", "form-control");
                __builder2.AddAttribute(10, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\Components\Warehouse\UpdateWarehouseComponent.razor"
                                    oWarehouse.WarehouseName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oWarehouse.WarehouseName = __value, oWarehouse.WarehouseName))));
                __builder2.AddAttribute(12, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oWarehouse.WarehouseName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.AddMarkupContent(17, "\r\n            ");
                __builder2.AddMarkupContent(18, "<label>Dirección</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\Components\Warehouse\UpdateWarehouseComponent.razor"
                                    oWarehouse.WarehouseAddress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => oWarehouse.WarehouseAddress = __value, oWarehouse.WarehouseAddress))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => oWarehouse.WarehouseAddress));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n        ");
                __builder2.OpenElement(26, "input");
                __builder2.AddAttribute(27, "type", "button");
                __builder2.AddAttribute(28, "value", "Actualizar");
                __builder2.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\Components\Warehouse\UpdateWarehouseComponent.razor"
                                                          UpdateWarehouse

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "class", "btn btn-success");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\Giovanni\Desktop\Escritorio-10-08-19\Platzi\Desarrollo de Aplicaciones con ASP .NET\Curso de Desarrollo Web con Blazor y .Net\Proyectos\Inventory2\Components\Warehouse\UpdateWarehouseComponent.razor"
       
    [Parameter]
    public string WarehouseId { get; set; }

    WarehouseEntity oWarehouse = new WarehouseEntity();

    protected override async Task OnInitializedAsync()
    {
        oWarehouse = B_Warehouse.WarehoseById(WarehouseId);
    }

    private void UpdateWarehouse()
    {
        B_Warehouse.UpdateWarehouse(oWarehouse);
        NavManager.NavigateTo("list/warehouse");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
