#pragma checksum "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\List_by_vacuna.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bca3cf72ef4aee4a0af969c72d5dbb3ff7d78330"
// <auto-generated/>
#pragma warning disable 1591
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
#line 4 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

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
#line 2 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\List_by_vacuna.razor"
using Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\rrody\Desktop\Tarea 7 programacion III\Programacion-III-Tarea-7\Pages\List_by_vacuna.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Listbyvacuna")]
    public partial class List_by_vacuna : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"titulocantvacuna\">Cantidad de personas vacunadas por vacuna</h3>\r\n\r\n");
            __builder.AddMarkupContent(1, @"<div class=""contenido-counts""><div class=""small-box""><div class=""inner""><h3>150</h3>
        <p>Astrazeneca</p></div>
    <div class=""icon""><i class=""oi oi-person""></i></div></div>
<div class=""small-box""><div class=""inner""><h3>150</h3>
        <p>Pfizer</p></div>
    <div class=""icon""><i class=""oi oi-person""></i></div></div>
<div class=""small-box""><div class=""inner""><h3>150</h3>
        <p>Sinovac</p></div>
    <div class=""icon""><i class=""oi oi-person""></i></div></div></div>

");
            __builder.AddMarkupContent(2, "<div class=\"alert alert-success\" role=\"alert\">\r\n  Listado de vacunas\r\n</div>\r\n");
            __builder.AddMarkupContent(3, @"<table class=""table""><tr><td>Id</td>
        <td>Nombre</td>
        <td></td></tr>

    <tr><td></td>
        <td></td>
        <td><button type=""button"" class=""btn btn-info""><i class=""io io-plus""></i></button> 
           <button type=""button"" class=""btn btn-danger""><i class=""io io-trash""></i></button></td></tr></table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private vacunaContext vc { get; set; }
    }
}
#pragma warning restore 1591
