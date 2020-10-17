#pragma checksum "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPersonas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc7c45c4f7e0a14175b477e28555a7ea2be8875d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 4 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPersonas.razor"
using Registro_Detalle.BLL;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPersonas.razor"
using Registro_Detalle.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/personas")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/personas/{PersonaId:int}")]
    public partial class RegistroPersonas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 86 "/Users/miguelgondres/Projects/Registro_Detalle/Pages/RegistroPersonas.razor"
       

    Personas persona = new Personas();

    [Parameter]
    public int PersonaId { get; set; }

    private void Nuevo()
    {
        this.persona = new Personas();
    }

    protected override void OnInitialized()
    {
        Nuevo();
        if (PersonaId > 0)
        {
            var auxPersona = PersonasBLL.Buscar(PersonaId);
            if (auxPersona != null)
                this.persona = auxPersona;
            else
                toast.ShowWarning("No encontrado.");
        }
    }

    private void Buscar()
    {
        var encontrado = PersonasBLL.Buscar(persona.PersonaId);
        if (encontrado != null)
            this.persona = encontrado;
        else
            toast.ShowWarning("No encontrado");

    }

    private void Guardar()
    {
        bool paso;
        paso = PersonasBLL.Guardar(persona);

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

        elimino = PersonasBLL.Eliminar(persona.PersonaId);

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
#pragma warning restore 1591
