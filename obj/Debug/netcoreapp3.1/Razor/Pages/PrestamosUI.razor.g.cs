#pragma checksum "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a7a2f1e9cc023e8ec3f29d26e93cc091fad1f1a"
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
#line 4 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
using Registro_Detalle.BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
using Registro_Detalle.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/prestamos")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/prestamos/{PrestamosId:int}")]
    public partial class PrestamosUI : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
                 prestamo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
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
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "card");
                __builder2.AddMarkupContent(9, "\n\n        ");
                __builder2.AddMarkupContent(10, "<div class=\"card-header\">\n\n            <h3>Registro de Prestamo</h3>\n\n        </div>\n\n        ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "card-body");
                __builder2.AddMarkupContent(13, "\n            ");
                __builder2.OpenElement(14, "form");
                __builder2.AddMarkupContent(15, "\n                ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "form-row align-items-center");
                __builder2.AddMarkupContent(18, "\n                    ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "col");
                __builder2.AddMarkupContent(21, "\n                        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "form-group");
                __builder2.AddMarkupContent(24, "\n                            ");
                __builder2.AddMarkupContent(25, "<label>PrestamoId:</label>\n                            ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "input-group");
                __builder2.AddMarkupContent(28, "\n                                ");
                __Blazor.Registro_Detalle.Pages.PrestamosUI.TypeInference.CreateInputNumber_0(__builder2, 29, 30, "form-control col-4", 31, 
#nullable restore
#line 28 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
                                                          prestamo.PrestamoId

#line default
#line hidden
#nullable disable
                , 32, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => prestamo.PrestamoId = __value, prestamo.PrestamoId)), 33, () => prestamo.PrestamoId);
                __builder2.AddMarkupContent(34, "\n                                ");
                __Blazor.Registro_Detalle.Pages.PrestamosUI.TypeInference.CreateValidationMessage_1(__builder2, 35, 36, 
#nullable restore
#line 29 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
                                                        (() => prestamo.PrestamoId)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(37, "\n                                ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "input-group-append");
                __builder2.AddMarkupContent(40, "\n                                    ");
                __builder2.OpenElement(41, "button");
                __builder2.AddAttribute(42, "type", "button");
                __builder2.AddAttribute(43, "class", "btn btn-primary input-group-text");
                __builder2.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
                                                                                                             Buscar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(45, "Buscar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\n                ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group");
                __builder2.AddMarkupContent(54, "\n                    ");
                __builder2.AddMarkupContent(55, "<label>FECHA:</label>\n                    ");
                __Blazor.Registro_Detalle.Pages.PrestamosUI.TypeInference.CreateInputDate_2(__builder2, 56, 57, "form-control", 58, 
#nullable restore
#line 40 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
                                            prestamo.Fecha

#line default
#line hidden
#nullable disable
                , 59, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => prestamo.Fecha = __value, prestamo.Fecha)), 60, () => prestamo.Fecha);
                __builder2.AddMarkupContent(61, "\n                    ");
                __Blazor.Registro_Detalle.Pages.PrestamosUI.TypeInference.CreateValidationMessage_3(__builder2, 62, 63, 
#nullable restore
#line 41 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
                                              () => prestamo.Fecha

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(64, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\n\n                ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-group");
                __builder2.AddMarkupContent(68, "\n                    ");
                __builder2.AddMarkupContent(69, "<label for=\"persona_select\">PERSONA:</label>\n                    ");
                __builder2.OpenElement(70, "select");
                __builder2.AddAttribute(71, "id", "persona_select");
                __builder2.AddAttribute(72, "class", "form-control");
                __builder2.AddAttribute(73, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
                                                       prestamo.PersonaId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => prestamo.PersonaId = __value, prestamo.PersonaId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(75, "\n                        ");
                __builder2.OpenElement(76, "option");
                __builder2.AddAttribute(77, "value", true);
                __builder2.AddAttribute(78, "disabled", true);
                __builder2.AddAttribute(79, "selected", true);
                __builder2.AddContent(80, "Elija una Persona");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\n");
#nullable restore
#line 49 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
                         foreach (var item in listaPersona)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(82, "                            ");
                __builder2.OpenElement(83, "option");
                __builder2.AddAttribute(84, "value", 
#nullable restore
#line 51 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
                                            item.PersonaId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(85, 
#nullable restore
#line 51 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
                                                             item.Nombre

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\n");
#nullable restore
#line 52 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(87, "                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\n\n                ");
                __builder2.OpenElement(90, "div");
                __builder2.AddAttribute(91, "class", "form-group");
                __builder2.AddMarkupContent(92, "\n                    ");
                __builder2.AddMarkupContent(93, "<label>CONCEPTO:</label>\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(94);
                __builder2.AddAttribute(95, "class", "form-control");
                __builder2.AddAttribute(96, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
                                            prestamo.Concepto

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(97, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => prestamo.Concepto = __value, prestamo.Concepto))));
                __builder2.AddAttribute(98, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => prestamo.Concepto));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(99, "\n                    ");
                __Blazor.Registro_Detalle.Pages.PrestamosUI.TypeInference.CreateValidationMessage_4(__builder2, 100, 101, 
#nullable restore
#line 60 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
                                              () => prestamo.Concepto

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(102, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\n                ");
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "class", "form-group");
                __builder2.AddMarkupContent(106, "\n                    ");
                __builder2.AddMarkupContent(107, "<label>MONTO:</label>\n                    ");
                __Blazor.Registro_Detalle.Pages.PrestamosUI.TypeInference.CreateInputNumber_5(__builder2, 108, 109, "0.2", 110, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 65 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
                                                                                      IgualarMontoBalance

#line default
#line hidden
#nullable disable
                ), 111, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 65 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
                                                                                                                       IgualarMontoBalance

#line default
#line hidden
#nullable disable
                ), 112, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
                                                                                                                                                      IgualarMontoBalance

#line default
#line hidden
#nullable disable
                ), 113, "form-control", 114, 
#nullable restore
#line 65 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
                                              prestamo.Monto

#line default
#line hidden
#nullable disable
                , 115, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => prestamo.Monto = __value, prestamo.Monto)), 116, () => prestamo.Monto);
                __builder2.AddMarkupContent(117, "\n                    ");
                __Blazor.Registro_Detalle.Pages.PrestamosUI.TypeInference.CreateValidationMessage_6(__builder2, 118, 119, 
#nullable restore
#line 66 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
                                              () => prestamo.Monto

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(120, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(121, "\n                ");
                __builder2.OpenElement(122, "div");
                __builder2.AddAttribute(123, "class", "form-group");
                __builder2.AddMarkupContent(124, "\n                    ");
                __builder2.AddMarkupContent(125, "<label>BALANCE:</label>\n                    ");
                __Blazor.Registro_Detalle.Pages.PrestamosUI.TypeInference.CreateInputNumber_7(__builder2, 126, 127, "true", 128, "form-control", 129, 
#nullable restore
#line 71 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
                                              prestamo.Balance

#line default
#line hidden
#nullable disable
                , 130, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => prestamo.Balance = __value, prestamo.Balance)), 131, () => prestamo.Balance);
                __builder2.AddMarkupContent(132, "\n                    ");
                __Blazor.Registro_Detalle.Pages.PrestamosUI.TypeInference.CreateValidationMessage_8(__builder2, 133, 134, 
#nullable restore
#line 72 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
                                              () => prestamo.Balance

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(135, "\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(136, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(137, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(138, "\n        ");
                __builder2.OpenElement(139, "div");
                __builder2.AddAttribute(140, "class", "card-footer");
                __builder2.AddMarkupContent(141, "\n            ");
                __builder2.OpenElement(142, "div");
                __builder2.AddAttribute(143, "class", "form-group text-center");
                __builder2.AddAttribute(144, "display:", true);
                __builder2.AddAttribute(145, "inline-block", true);
                __builder2.AddMarkupContent(146, "\n                ");
                __builder2.OpenElement(147, "button");
                __builder2.AddAttribute(148, "type", "button");
                __builder2.AddAttribute(149, "class", "btn btn-lg btn-secondary");
                __builder2.AddAttribute(150, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
                                                                                 Nuevo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(151, "Nuevo");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(152, "\n                ");
                __builder2.AddMarkupContent(153, "<button type=\"submit\" class=\"btn btn-lg btn-success\">Guardar</button>\n                ");
                __builder2.OpenElement(154, "button");
                __builder2.AddAttribute(155, "type", "button");
                __builder2.AddAttribute(156, "class", "btn btn-lg btn-danger");
                __builder2.AddAttribute(157, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
                                                                              Eliminar

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(158, "Eliminar");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(159, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(160, "\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(161, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(162, "\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/PrestamosUI.razor"
       

    Prestamos prestamo = new Prestamos();

    [Parameter]
    public int PrestamosId { get; set; }

    private List<Personas> listaPersona = new List<Personas>();



    protected override void OnInitialized()
    {
        Nuevo();
        if (PrestamosId > 0)
        {
            var auxPretamo = PrestamosBLL.Buscar(PrestamosId);
            if (auxPretamo != null)
                this.prestamo = auxPretamo;
            else
                toast.ShowWarning("No encontrado.");
        }

        listaPersona = PersonasBLL.GetList(p => true);
    }

    private void Buscar()
    {
        var encontrado = PrestamosBLL.Buscar(prestamo.PrestamoId);
        if (encontrado != null)
        {
            this.prestamo = encontrado;
        }
        else
            toast.ShowWarning("No encontrado");

    }


    private void IgualarMontoBalance()
    {
        decimal auxMonto = prestamo.Monto;
        prestamo.Balance = auxMonto;
    }

    private void Nuevo()
    {
        this.prestamo = new Prestamos();
    }


    private void Guardar()
    {
        bool paso;
        paso = PrestamosBLL.Guardar(prestamo);

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

    private void Eliminar()
    {
        bool elimino;

        elimino = PrestamosBLL.Eliminar(prestamo.PrestamoId);

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
namespace __Blazor.Registro_Detalle.Pages.PrestamosUI
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
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, global::System.Object __arg2, int __seq3, global::System.Object __arg3, int __seq4, System.Object __arg4, int __seq5, TValue __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg6, int __seq7, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg7)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "step", __arg0);
        __builder.AddAttribute(__seq1, "onfocusout", __arg1);
        __builder.AddAttribute(__seq2, "onfocusin", __arg2);
        __builder.AddAttribute(__seq3, "onclick", __arg3);
        __builder.AddAttribute(__seq4, "class", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.AddAttribute(__seq7, "ValueExpression", __arg7);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "readonly", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
