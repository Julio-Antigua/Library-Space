// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FinalEvanyeline.Pages.Autores
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
#line 4 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Editar.razor"
using FinalEvanyeline.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Editar.razor"
using FinalEvanyeline.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Editar.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditarAutor/{id:int}")]
    public partial class Editar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 108 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Editar.razor"
       

    [Parameter]
    public int id { get; set; }

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
    private Autores AutoresModel = new Autores();



    //---------METODOS---------
    protected override async Task OnInitializedAsync()
    {

        AutoresModel = await autorescontroler.ObtenerAutorPorId(id);
    }

    private async Task ManejadorUpsert()
    {


        var respuestaEditar = await autorescontroler.Actualizar(id,AutoresModel);

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AutoresController autorescontroler { get; set; }
    }
}
#pragma warning restore 1591
