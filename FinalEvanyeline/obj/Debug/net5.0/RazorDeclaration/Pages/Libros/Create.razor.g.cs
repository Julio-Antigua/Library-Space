// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FinalEvanyeline.Pages.Libros
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
#line 4 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Libros\Create.razor"
using FinalEvanyeline.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Libros\Create.razor"
using FinalEvanyeline.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Libros\Create.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/CreateLibro")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 109 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Libros\Create.razor"
       

    //private async Task IngChange(string value)
    //{

    //    //-------Mantiene el nombre Refrescado---------
    //    NotasModel.Ingeniero_id = Convert.ToInt32(value);


    //}
    //private async Task SubChange(string value)
    //{

    //    //-------Mantiene el nombre Refrescado---------
    //    NotasModel.SubSistema_id = value;


    //}
    //private async Task RengChange(string value)
    //{

    //    //-------Mantiene el nombre Refrescado---------
    //    NotasModel.RenglonNota_id = Convert.ToByte(value);


    //}




    //---------Listas-------------



    //----------Objetos--------
    private Libros LibrosModel = new Libros();
    public List<Autores> ListaAutor = new List<Autores>();



    //---------METODOS---------
    protected override async Task OnInitializedAsync()
    {

        ListaAutor = await autorcontroler.Get();

    }

    private async Task ManejadorUpsert()
    {


        var respuestaEditar = await librocontroler.CrearLibro(LibrosModel);

        Nav.NavigateTo("/admin");


    }

    private void VolverA()
    {
        Nav.NavigateTo("/admin");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AutoresController autorcontroler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LibrosController librocontroler { get; set; }
    }
}
#pragma warning restore 1591
