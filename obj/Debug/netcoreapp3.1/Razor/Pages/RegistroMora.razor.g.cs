#pragma checksum "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45ab0be38674d917450a05a5950c9ef05bb228ee"
// <auto-generated/>
#pragma warning disable 1591
namespace Registro_Detalle.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/miguelgondres/Projects/Registro_Detalle/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/miguelgondres/Projects/Registro_Detalle/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/miguelgondres/Projects/Registro_Detalle/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/miguelgondres/Projects/Registro_Detalle/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/miguelgondres/Projects/Registro_Detalle/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/miguelgondres/Projects/Registro_Detalle/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/miguelgondres/Projects/Registro_Detalle/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/miguelgondres/Projects/Registro_Detalle/_Imports.razor"
using Registro_Detalle;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/miguelgondres/Projects/Registro_Detalle/_Imports.razor"
using Registro_Detalle.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/miguelgondres/Projects/Registro_Detalle/_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/miguelgondres/Projects/Registro_Detalle/_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
using Registro_Detalle.BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
using Registro_Detalle.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/moras")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/moras/{MoraId:int}")]
    public partial class RegistroMora : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                 mora

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                      Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n\n    ");
                __builder2.OpenElement(7, "section");
                __builder2.AddAttribute(8, "class", "form-register");
                __builder2.AddMarkupContent(9, "\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "card");
                __builder2.AddMarkupContent(12, "\n\n            ");
                __builder2.AddMarkupContent(13, "<div class=\"card-header\">\n                <h3>Registro de Mora</h3>\n            </div>\n\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "card-body");
                __builder2.AddMarkupContent(16, "\n                ");
                __builder2.OpenElement(17, "form");
                __builder2.AddMarkupContent(18, "\n                    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-row align-items-center");
                __builder2.AddMarkupContent(21, "\n                        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "col");
                __builder2.AddMarkupContent(24, "\n                            ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "\n                                ");
                __builder2.AddMarkupContent(28, "<label>ID:</label>\n                                ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "input-group");
                __builder2.AddMarkupContent(31, "\n                                    ");
                __Blazor.Registro_Detalle.Pages.RegistroMora.TypeInference.CreateInputNumber_0(__builder2, 32, 33, "form-control col-4", 34, 
#nullable restore
#line 26 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                                              mora.MoraId

#line default
#line hidden
#nullable disable
                , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => mora.MoraId = __value, mora.MoraId)), 36, () => mora.MoraId);
                __builder2.AddMarkupContent(37, "\n                                    ");
                __Blazor.Registro_Detalle.Pages.RegistroMora.TypeInference.CreateValidationMessage_1(__builder2, 38, 39, 
#nullable restore
#line 27 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                                            (() => mora.MoraId)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(40, "\n                                    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "input-group-append");
                __builder2.AddMarkupContent(43, "\n                                        ");
                __builder2.OpenElement(44, "button");
                __builder2.AddAttribute(45, "type", "button");
                __builder2.AddAttribute(46, "class", "btn btn-primary input-group-text");
                __builder2.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                                                                                                 Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(48, "Buscar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\n\n                    ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "form-group");
                __builder2.AddMarkupContent(57, "\n                        ");
                __builder2.AddMarkupContent(58, "<label>FECHA:</label>\n                        ");
                __Blazor.Registro_Detalle.Pages.RegistroMora.TypeInference.CreateInputDate_2(__builder2, 59, 60, "form-control", 61, 
#nullable restore
#line 39 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                                mora.Fecha

#line default
#line hidden
#nullable disable
                , 62, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => mora.Fecha = __value, mora.Fecha)), 63, () => mora.Fecha);
                __builder2.AddMarkupContent(64, "\n                        ");
                __Blazor.Registro_Detalle.Pages.RegistroMora.TypeInference.CreateValidationMessage_3(__builder2, 65, 66, 
#nullable restore
#line 40 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                                  () => mora.Fecha

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(67, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\n\n                    ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-group");
                __builder2.AddMarkupContent(71, "\n                        ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "form-row");
                __builder2.AddMarkupContent(74, "\n                            ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "col");
                __builder2.AddMarkupContent(77, "\n                                ");
                __builder2.AddMarkupContent(78, "<label>PRESTAMO ID:</label>\n                                ");
                __builder2.OpenElement(79, "select");
                __builder2.AddAttribute(80, "class", "form-control");
                __builder2.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                                                                                    MostrarNombrePersona

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                                                    prestamoSeleccionado

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => prestamoSeleccionado = __value, prestamoSeleccionado));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(84, "\n");
#nullable restore
#line 48 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                    foreach (var item in listaPrestamo)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(85, "                                        ");
                __builder2.OpenElement(86, "option");
                __builder2.AddAttribute(87, "value", 
#nullable restore
#line 50 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                                        item.PrestamoId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(88, 
#nullable restore
#line 50 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                                                          item.PrestamoId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\n");
#nullable restore
#line 51 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(90, "                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(91, "\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\n\n                            ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "col");
                __builder2.AddMarkupContent(95, "\n                                ");
                __builder2.AddMarkupContent(96, "<label>A NOMBRE DE:</label>\n                                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(97);
                __builder2.AddAttribute(98, "class", "form-control");
                __builder2.AddAttribute(99, "readonly", "true");
                __builder2.AddAttribute(100, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 57 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                                                                             nombrePersona

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(101, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => nombrePersona = __value, nombrePersona))));
                __builder2.AddAttribute(102, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => nombrePersona));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(103, "\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\n\n                            ");
                __builder2.OpenElement(105, "div");
                __builder2.AddAttribute(106, "class", "col");
                __builder2.AddMarkupContent(107, "\n                                ");
                __builder2.AddMarkupContent(108, "<label>VALOR:</label>\n                                ");
                __builder2.OpenElement(109, "div");
                __builder2.AddAttribute(110, "class", "input-group");
                __builder2.AddMarkupContent(111, "\n                                    ");
                __Blazor.Registro_Detalle.Pages.RegistroMora.TypeInference.CreateInputNumber_4(__builder2, 112, 113, "form-control", 114, 
#nullable restore
#line 63 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                                              valorColocado

#line default
#line hidden
#nullable disable
                , 115, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => valorColocado = __value, valorColocado)), 116, () => valorColocado);
                __builder2.AddMarkupContent(117, "\n                                    ");
                __builder2.OpenElement(118, "div");
                __builder2.AddAttribute(119, "class", "input-group-append");
                __builder2.AddMarkupContent(120, "\n                                        ");
                __builder2.OpenElement(121, "button");
                __builder2.AddAttribute(122, "type", "button");
                __builder2.AddAttribute(123, "class", "btn btn-info");
                __builder2.AddAttribute(124, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                                                                             AgregarMora

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(125, "Agregar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(126, "\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(130, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\n\n                    ");
                __builder2.OpenElement(132, "div");
                __builder2.AddAttribute(133, "class", "table-responsive text-nowrap");
                __builder2.AddMarkupContent(134, "\n                        ");
                __builder2.OpenElement(135, "table");
                __builder2.AddAttribute(136, "class", "table table-striped");
                __builder2.AddMarkupContent(137, "\n                            ");
                __builder2.AddMarkupContent(138, @"<thead class=""thead-light"">
                                <tr>
                                    <th>Id</th>
                                    <th>Mora Id</th>
                                    <th>Prestamo Id</th>
                                    <th>Valor</th>
                                </tr>
                            </thead>
                            ");
                __builder2.OpenElement(139, "tbody");
                __builder2.AddAttribute(140, "class", "bg-white");
                __builder2.AddMarkupContent(141, "\n");
#nullable restore
#line 83 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                foreach (var item in mora.MoraDetalles)
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(142, "                                    ");
                __builder2.OpenElement(143, "tr");
                __builder2.AddMarkupContent(144, "\n                                        ");
                __builder2.OpenElement(145, "td");
                __builder2.AddContent(146, 
#nullable restore
#line 86 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                             item.MoraDetalleId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(147, "\n                                        ");
                __builder2.OpenElement(148, "td");
                __builder2.AddContent(149, 
#nullable restore
#line 87 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                             item.MoraId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(150, "\n                                        ");
                __builder2.OpenElement(151, "td");
                __builder2.AddContent(152, 
#nullable restore
#line 88 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                             item.PrestamoId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(153, "\n                                        ");
                __builder2.OpenElement(154, "td");
                __builder2.AddContent(155, 
#nullable restore
#line 89 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                             item.Valor

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(156, "\n                                        ");
                __builder2.OpenElement(157, "td");
                __builder2.OpenElement(158, "button");
                __builder2.AddAttribute(159, "type", "button");
                __builder2.AddAttribute(160, "class", "btn btn-outline-danger");
                __builder2.AddAttribute(161, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 90 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                                                                                           (() => EliminarMoraDetalle(item))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(162, "Remover");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(163, "\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(164, "\n");
#nullable restore
#line 92 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(165, "\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(166, "\n\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(167, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(168, "\n\n                    ");
                __builder2.OpenElement(169, "div");
                __builder2.AddAttribute(170, "class", "form-group");
                __builder2.AddMarkupContent(171, "\n                        ");
                __builder2.AddMarkupContent(172, "<label>TOTAL:</label>\n                        ");
                __Blazor.Registro_Detalle.Pages.RegistroMora.TypeInference.CreateInputNumber_5(__builder2, 173, 174, "form-control", 175, "true", 176, 
#nullable restore
#line 102 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                                  mora.Total

#line default
#line hidden
#nullable disable
                , 177, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => mora.Total = __value, mora.Total)), 178, () => mora.Total);
                __builder2.AddMarkupContent(179, "\n                        ");
                __Blazor.Registro_Detalle.Pages.RegistroMora.TypeInference.CreateValidationMessage_6(__builder2, 180, 181, 
#nullable restore
#line 103 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                                  () => mora.Total

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(182, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(183, "\n\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(184, "\n\n                ");
                __builder2.OpenElement(185, "div");
                __builder2.AddAttribute(186, "class", "form-group text-center");
                __builder2.AddAttribute(187, "display:", true);
                __builder2.AddAttribute(188, "inline-block", true);
                __builder2.AddMarkupContent(189, "\n                    ");
                __builder2.OpenElement(190, "button");
                __builder2.AddAttribute(191, "type", "button");
                __builder2.AddAttribute(192, "class", "btn btn-lg btn-primary");
                __builder2.AddAttribute(193, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 109 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                                                                   Nuevo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(194, "Nuevo");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(195, "\n                    ");
                __builder2.AddMarkupContent(196, "<button type=\"submit\" class=\"btn btn-lg btn-success\">Guardar</button>\n                    ");
                __builder2.OpenElement(197, "button");
                __builder2.AddAttribute(198, "type", "button");
                __builder2.AddAttribute(199, "class", "btn btn-lg btn-danger");
                __builder2.AddAttribute(200, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 111 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
                                                                                  Eliminar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(201, "Eliminar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(202, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(203, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(204, "\n\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(205, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(206, "\n\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(207, "\n\n\n    }\n}");
        }
        #pragma warning restore 1998
#nullable restore
#line 120 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroMora.razor"
      
    Moras mora = new Moras();

    [Parameter]
    public int MoraId { get; set; }
    List<Prestamos> listaPrestamo = new List<Prestamos>();

    public int prestamoSeleccionado { get; set; }
    public decimal valorColocado { get; set; }
    public string nombrePersona { get; set; }

    protected override void OnInitialized()
    {
        Nuevo();
        if (MoraId > 0)
        {
            var auxMora = MorasBLL.Buscar(MoraId);
            if (auxMora != null)
                this.mora = auxMora;
            else
                toast.ShowWarning("No encontrado.");
        }

        listaPrestamo = PrestamosBLL.GetList(p => true);
    }

     private void Nuevo()
    {
        this.mora = new Moras();
        prestamoSeleccionado = 0;
        valorColocado = 0;
        nombrePersona = string.Empty;
        
    }

     private void Buscar()
    {
        var encontrado = MorasBLL.Buscar(mora.MoraId);
        if (encontrado != null)
        {
            this.mora = encontrado;
        }
        else
            toast.ShowWarning("No encontrado");

    }

    private void MostrarNombrePersona()
    {
        string auxNombre = string.Empty;

        var auxPrestamo = PrestamosBLL.Buscar(prestamoSeleccionado);
        if (auxPrestamo != null)
        {
            auxNombre = PersonasBLL.Buscar(auxPrestamo.PersonaId).Nombre;
            nombrePersona = auxNombre;
        }
    }

    private void AgregarMora()
    {
        if(prestamoSeleccionado == 0)
        {
            toast.ShowWarning("Tiene que seleccionar un Prestamo Id.");
            return;
        }

        if (valorColocado <= 0)
        {
            toast.ShowWarning("El valor debe ser mayor a 0.");
            return;
        }
        else
        {
            this.mora.MoraDetalles.Add(new MoraDetalles
            {
                MoraDetalleId = 0,
                MoraId = mora.MoraId,
                PrestamoId = prestamoSeleccionado,
                Valor = valorColocado
            });
            prestamoSeleccionado = 0;
            valorColocado = 0;
            nombrePersona = string.Empty;
        }
        CalcularTotal();

    }

    private void CalcularTotal()
    {
        decimal total = 0;
        foreach (var item in mora.MoraDetalles)
        {
            total += item.Valor;
        }
        mora.Total = total;
    }

    private void EliminarMoraDetalle(MoraDetalles detalles)
    {
        try
        {
            mora.MoraDetalles.Remove(detalles);
            CalcularTotal();
        }
        catch (Exception)
        {

            throw;
        }
    }

    private void Guardar()
    {
        bool paso;
        if (mora.MoraDetalles.Count == 0)
        {
            toast.ShowWarning("Tienes que agregar al menos un elemento a la lista", "Lista Vacía!");
            return;
        }
        else
        {
            paso = MorasBLL.Guardar(mora);

            if (paso)
            {
                Nuevo();
                toast.ShowSuccess("Guardado correctamente");
            }
            else
            {
                toast.ShowError("No fue posible guardar");
            }
        }
    }

        private void Eliminar()
        {
            bool elimino;

            elimino = MorasBLL.Eliminar(mora.MoraId);

            if (elimino)
            {
                Nuevo();
                toast.ShowSuccess("Eliminado correctamente");
            }
            else
                toast.ShowError("No fue posible eliminar");
            }
        

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService toast { get; set; }
    }
}
namespace __Blazor.Registro_Detalle.Pages.RegistroMora
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "readonly", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
