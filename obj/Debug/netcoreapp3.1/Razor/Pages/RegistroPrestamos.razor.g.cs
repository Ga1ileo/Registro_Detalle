#pragma checksum "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d07b20a5b0a4c28a9c67f5903caa67fc6277e3e"
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
#line 4 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor"
using Registro_Detalle.BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor"
using Registro_Detalle.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/prestamos")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/prestamos/{PrestamosId:int}")]
    public partial class RegistroPrestamos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddMarkupContent(2, "\n\n        ");
            __builder.AddMarkupContent(3, "<div class=\"card-header\">\n\n            <h3>Registro de Prestamo</h3>\n\n        </div>\n\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddMarkupContent(6, "\n            ");
            __builder.OpenElement(7, "form");
            __builder.AddMarkupContent(8, "\n                ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-row align-items-center");
            __builder.AddMarkupContent(11, "\n                    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col");
            __builder.AddMarkupContent(14, "\n                        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "\n                            ");
            __builder.AddMarkupContent(18, "<label>PrestamoId:</label>\n                            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "input-group");
            __builder.AddMarkupContent(21, "\n                                ");
            __Blazor.Registro_Detalle.Pages.RegistroPrestamos.TypeInference.CreateInputNumber_0(__builder, 22, 23, "form-control col-4", 24, 
#nullable restore
#line 25 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor"
                                                          prestamo.PrestamoId

#line default
#line hidden
#nullable disable
            , 25, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => prestamo.PrestamoId = __value, prestamo.PrestamoId)), 26, () => prestamo.PrestamoId);
            __builder.AddMarkupContent(27, "\n                                ");
            __Blazor.Registro_Detalle.Pages.RegistroPrestamos.TypeInference.CreateValidationMessage_1(__builder, 28, 29, 
#nullable restore
#line 26 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor"
                                                        (() => prestamo.PrestamoId)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(30, "\n                                ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "input-group-append");
            __builder.AddMarkupContent(33, "\n                                    ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "type", "button");
            __builder.AddAttribute(36, "class", "btn btn-primary input-group-text");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor"
                                                                                                             Buscar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "Buscar");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n                ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "form-group");
            __builder.AddMarkupContent(47, "\n                    ");
            __builder.AddMarkupContent(48, "<label>FECHA:</label>\n                    ");
            __Blazor.Registro_Detalle.Pages.RegistroPrestamos.TypeInference.CreateInputDate_2(__builder, 49, 50, "form-control", 51, 
#nullable restore
#line 37 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor"
                                            prestamo.Fecha

#line default
#line hidden
#nullable disable
            , 52, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => prestamo.Fecha = __value, prestamo.Fecha)), 53, () => prestamo.Fecha);
            __builder.AddMarkupContent(54, "\n                    ");
            __Blazor.Registro_Detalle.Pages.RegistroPrestamos.TypeInference.CreateValidationMessage_3(__builder, 55, 56, 
#nullable restore
#line 38 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor"
                                              () => prestamo.Fecha

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(57, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\n\n                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "form-group");
            __builder.AddMarkupContent(61, "\n                    ");
            __builder.AddMarkupContent(62, "<label for=\"persona_select\">PERSONA:</label>\n                    ");
            __builder.OpenElement(63, "select");
            __builder.AddAttribute(64, "id", "persona_select");
            __builder.AddAttribute(65, "class", "form-control");
            __builder.AddAttribute(66, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor"
                                                       prestamo.PersonaId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => prestamo.PersonaId = __value, prestamo.PersonaId));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(68, "\n                        ");
            __builder.OpenElement(69, "option");
            __builder.AddAttribute(70, "value", true);
            __builder.AddAttribute(71, "disabled", true);
            __builder.AddAttribute(72, "selected", true);
            __builder.AddContent(73, "Elija una Persona");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n");
#nullable restore
#line 46 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor"
                         foreach (var item in listaPersona)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(75, "                            ");
            __builder.OpenElement(76, "option");
            __builder.AddAttribute(77, "value", 
#nullable restore
#line 48 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor"
                                            item.PersonaId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(78, 
#nullable restore
#line 48 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor"
                                                             item.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\n");
#nullable restore
#line 49 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(80, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\n\n                ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "form-group");
            __builder.AddMarkupContent(85, "\n                    ");
            __builder.AddMarkupContent(86, "<label>CONCEPTO:</label>\n                    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(87);
            __builder.AddAttribute(88, "class", "form-control");
            __builder.AddAttribute(89, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor"
                                            prestamo.Concepto

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => prestamo.Concepto = __value, prestamo.Concepto))));
            __builder.AddAttribute(91, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => prestamo.Concepto));
            __builder.CloseComponent();
            __builder.AddMarkupContent(92, "\n                    ");
            __Blazor.Registro_Detalle.Pages.RegistroPrestamos.TypeInference.CreateValidationMessage_4(__builder, 93, 94, 
#nullable restore
#line 57 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor"
                                              () => prestamo.Concepto

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(95, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\n                ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "form-group");
            __builder.AddMarkupContent(99, "\n                    ");
            __builder.AddMarkupContent(100, "<label>MONTO:</label>\n                    ");
            __Blazor.Registro_Detalle.Pages.RegistroPrestamos.TypeInference.CreateInputNumber_5(__builder, 101, 102, "0.2", 103, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 62 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor"
                                                                                      IgualarMontoBalance

#line default
#line hidden
#nullable disable
            ), 104, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 62 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor"
                                                                                                                       IgualarMontoBalance

#line default
#line hidden
#nullable disable
            ), 105, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor"
                                                                                                                                                      IgualarMontoBalance

#line default
#line hidden
#nullable disable
            ), 106, "form-control", 107, 
#nullable restore
#line 62 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor"
                                              prestamo.Monto

#line default
#line hidden
#nullable disable
            , 108, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => prestamo.Monto = __value, prestamo.Monto)), 109, () => prestamo.Monto);
            __builder.AddMarkupContent(110, "\n                    ");
            __Blazor.Registro_Detalle.Pages.RegistroPrestamos.TypeInference.CreateValidationMessage_6(__builder, 111, 112, 
#nullable restore
#line 63 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor"
                                              () => prestamo.Monto

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(113, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\n                ");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "class", "form-group");
            __builder.AddMarkupContent(117, "\n                    ");
            __builder.AddMarkupContent(118, "<label>BALANCE:</label>\n                    ");
            __Blazor.Registro_Detalle.Pages.RegistroPrestamos.TypeInference.CreateInputNumber_7(__builder, 119, 120, "true", 121, "form-control", 122, 
#nullable restore
#line 68 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor"
                                              prestamo.Balance

#line default
#line hidden
#nullable disable
            , 123, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => prestamo.Balance = __value, prestamo.Balance)), 124, () => prestamo.Balance);
            __builder.AddMarkupContent(125, "\n                    ");
            __Blazor.Registro_Detalle.Pages.RegistroPrestamos.TypeInference.CreateValidationMessage_8(__builder, 126, 127, 
#nullable restore
#line 69 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor"
                                              () => prestamo.Balance

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(128, "\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\n        ");
            __builder.OpenElement(132, "div");
            __builder.AddAttribute(133, "class", "card-footer");
            __builder.AddMarkupContent(134, "\n            ");
            __builder.OpenElement(135, "div");
            __builder.AddAttribute(136, "class", "form-group text-center");
            __builder.AddAttribute(137, "display:", true);
            __builder.AddAttribute(138, "inline-block", true);
            __builder.AddMarkupContent(139, "\n                ");
            __builder.OpenElement(140, "button");
            __builder.AddAttribute(141, "type", "button");
            __builder.AddAttribute(142, "class", "btn btn-lg btn-secondary");
            __builder.AddAttribute(143, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor"
                                                                                 Nuevo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(144, "Nuevo");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\n                ");
            __builder.AddMarkupContent(146, "<button type=\"submit\" class=\"btn btn-lg btn-success\">Guardar</button>\n                ");
            __builder.OpenElement(147, "button");
            __builder.AddAttribute(148, "type", "button");
            __builder.AddAttribute(149, "class", "btn btn-lg btn-danger");
            __builder.AddAttribute(150, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor"
                                                                              Eliminar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(151, "Eliminar");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPrestamos.razor"
       

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
namespace __Blazor.Registro_Detalle.Pages.RegistroPrestamos
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
