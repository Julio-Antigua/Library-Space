#pragma checksum "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64df504c41ab43deeb6c36aacfa72df86c410cc2"
// <auto-generated/>
#pragma warning disable 1591
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
#line 4 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Index.razor"
using FinalEvanyeline.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Index.razor"
using FinalEvanyeline.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/autores")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 style=\"color:green\"> Lista De Autores </h1>\r\n<hr style=\"color: #0056b2;\">\r\n<br>\r\n\r\n<br>");
#nullable restore
#line 18 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Index.razor"
 if (ListaAutor == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 21 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddAttribute(3, "class", "table table-hover table-bordered");
            __builder.AddMarkupContent(4, "<thead><tr><th>Nombre</th>\r\n                <th>Apellido</th>\r\n                <th>Edad</th>\r\n                <th>Estado</th>\r\n                <th>Nacionalidad</th>\r\n                <th>Opciones</th></tr></thead>\r\n        ");
            __builder.OpenElement(5, "tbody");
#nullable restore
#line 36 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Index.razor"
             foreach (var context in ListaAutor)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "tr");
            __builder.OpenElement(7, "td");
#nullable restore
#line 39 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Index.razor"
__builder.AddContent(8, context.nombre_autor);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                    ");
            __builder.OpenElement(10, "td");
#nullable restore
#line 40 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Index.razor"
__builder.AddContent(11, context.apellido_autor);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
#nullable restore
#line 41 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Index.razor"
__builder.AddContent(14, context.edad);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
#nullable restore
#line 42 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Index.razor"
__builder.AddContent(17, context.estado);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
#nullable restore
#line 43 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Index.razor"
__builder.AddContent(20, context.nacionalidad);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.AddMarkupContent(22, "<td><i class=\"btn btn-success text-light fa-solid fa-magnifying-glass\" data-bs-toggle=\"modal\" data-bs-target=\"#miModal\"></i></td>");
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "<div class=\"modal fade\" id=\"miModal\" tabindex=\"-1\" aria-hidden=\"true\" aria-labelledby=\"modalTitle\" data-bs-backdrop=\"static\"><div class=\"modal-dialog\"><div class=\"modal-content\"><div class=\"modal-header\"><h5 class=\"modal-title\" id=\"modalTitle\">Informacion</h5>\r\n                    <button type=\"button\" class=\"btn btn-close\" data-bs-dismiss=\"modal\" aria-label=\"Close\"></button></div>\r\n                <div class=\"modal-body\"><div class=\"row\"><div Model=\"LibrosModel\" style=\"font-size: 15px\" class=\"col-sm-7 mt-4\"><ul><li><span><strong>Nombre:</strong> Juan Emilio Bosch Gaviño</span></li>\r\n                                <li><span><strong>Edad:</strong> 92</span></li>\r\n                                <li><span><strong>Estado:</strong> Muerto</span></li>\r\n                                <li><span><strong>Nacimiento:</strong> 30-06-1909</span></li>\r\n                                <li><span><strong>Nacionalidad:</strong> Dominicano</span></li>\r\n                                <li><span><strong>Muerte:</strong> 01-11-2001</span></li>\r\n                                <li><span><strong>Libros Escritos:</strong> 20</span></li></ul></div>\r\n                        <div class=\"col-sm-5\"><img src=\"https://upload.wikimedia.org/wikipedia/commons/c/cf/Juan_Bosch_%281963%29.jpg\" width=\"140px\" height=\"190px\" alt=\"Alternate Text\"></div></div></div>\r\n                <div class=\"modal-footer\"><button type=\"button\" class=\" btn btn-secondary\" data-bs-dismiss=\"modal\">Cerrar</button></div></div></div></div>");
#nullable restore
#line 87 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 89 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Index.razor"
       


    public List<Autores> ListaAutor = new List<Autores>();


    public List<Libros> ListaLibros = new List<Libros>();



    [Parameter]
    public int id { get; set; }


    protected override async Task OnInitializedAsync()
    {
        ListaLibros = await librocontroler.Get();
        ListaAutor = await autorcontroler.Get();

    }

    private Libros LibrosModel = new Libros();




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

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LibrosController librocontroler { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AutoresController autorcontroler { get; set; }
    }
}
#pragma warning restore 1591