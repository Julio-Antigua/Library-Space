// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FinalEvanyeline.Pages.Ventas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\_Imports.razor"
using FinalEvanyeline;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\_Imports.razor"
using FinalEvanyeline.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
using FinalEvanyeline.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
using FinalEvanyeline.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FiltroVentas")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 132 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
       
    public bool FiltroporDia = false;
    public bool FiltroDisponible = false;



    public bool ResultadosFiltro = false;
    public string RespuestaSelect;

    public DateTime FechaporDia = DateTime.Today;

    public Ventas ventasmodel = new Ventas();
    public List<Libros> ListaLibros = new List<Libros>();


    public List<Ventas> ListaResultado = new List<Ventas>();
    public List<Libros> ListaResultadoDisponible = new List<Libros>();


    protected override async Task OnInitializedAsync()
    {
        ListaLibros = await librocontroler.Get();
        //ListaAutor = await autorcontroler.Get();

    }

    private string NombreAutor(List<Autores> lista, int id)
    {
        foreach (Autores a in lista)
        {
            if (a.idAutor == id)
            {
                return a.nombre_autor;
            }
        }
        return null;
    }

    private string NombreLibro(List<Libros> lista, int id)
    {
        foreach (Libros a in lista)
        {
            if (a.idlibro == id)
            {
                return a.nombre;
            }
        }
        return null;
    }

    private async Task OnCHange(string value)
    {

        //-------Mantiene el nombre Refrescado---------
        RespuestaSelect = value;

        if (value == "1")
        {
            ResultadosFiltro = false;
            FiltroporDia = true;


        }
        if (value == "2")
        {
            ResultadosFiltro = false;

            FiltroporDia = false;
            FiltroDisponible = true;
        }

    }

    private async Task FiltrosUpsert()
    {

        if (FiltroporDia == true)
        {
            ListaResultado = await ventascontroler.FiltroporFecha(FechaporDia);
            ResultadosFiltro = true;

        }
        if (FiltroDisponible == true)
        {
            ListaResultadoDisponible = await librocontroler.FiltroporDisponibilidad();
            ResultadosFiltro = true;

        }





    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LibrosController librocontroler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private VentasController ventascontroler { get; set; }
    }
}
#pragma warning restore 1591