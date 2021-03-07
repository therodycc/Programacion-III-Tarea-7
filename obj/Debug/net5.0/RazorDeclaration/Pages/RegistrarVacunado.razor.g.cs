// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Tarea7.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\_Imports.razor"
using Tarea7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\_Imports.razor"
using Tarea7.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
using Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/registrar")]
    public partial class RegistrarVacunado : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 121 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\RegistrarVacunado.razor"
       
    private string cedulaInput = "";
    private string cedula = "";
    private string error = "";

    private Vacunado vacunado = null;
    private bool existente = false;
    private bool nuevo = true;


    private void parseaCedula() {
        cedula = cedulaInput.Replace("-", "").Replace(" ", "");

        if (!Functions.ValidaCedula(cedula)) {
            error = "La cedula ingresada no es valida";
            return;
        }

        buscaCedula();
    }

    private void buscaCedula() {
        try {
            vacunado = vc.Vacunados.Where(x => x.Cedula == cedula).First();
            existente = true;
            nuevo = false;
            error = "";
        }
        catch (InvalidOperationException) {
            buscaEnApi();
        }
    }

    private async void buscaEnApi() {
        string url = $"https://api.adamix.net/apec/cedula/{cedula}";
        try {
            CedulaInfo datos = await http.GetJsonAsync<CedulaInfo>(url);
            reemplazarDatos(datos);
        }
        catch {
            vacunado = new Vacunado();
        }

        error = "";
        StateHasChanged();
    }

    private void reemplazarDatos(CedulaInfo datos)
    {
        string nombre = datos.Nombres;
        string apellido = datos.Apellido1 + " " + datos.Apellido2;
        DateTime fechaNacimiento = Convert.ToDateTime(datos.FechaNacimiento);

        vacunado = new Vacunado {
            Cedula = cedula,
            Nombre = nombre,
            Apellido = apellido,
            FechaNacimiento = fechaNacimiento,
            SignoZodiacal = fechaNacimiento.toZodiacSign()
        };
    }

    private void vacunadoValido() {
        if (existente && (!vacunado.Vacuna2Id.HasValue || !vacunado.Vacuna2Fecha.HasValue)) {
            error = "Falta la fecha o la marca de la vacuna #2";
            return;
        }

        if (nuevo) {
            vc.Add(vacunado);
        }

        vc.SaveChanges();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private vacunaContext vc { get; set; }
    }
}
#pragma warning restore 1591
