#pragma checksum "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b6550d15cd3098a6d9ef8981b37b13cfdfdefa5"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1 style=\"color:green\"> Libros </h1>\r\n<hr style=\"color: #0056b2;\">\r\n\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
                 ventasmodel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
                                               () => FiltrosUpsert()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "form-inline");
                __builder2.AddMarkupContent(7, "<b><label class=\"control-lable\">FILTRAR POR:</label></b>\r\n        ");
                __Blazor.FinalEvanyeline.Pages.Ventas.Index.TypeInference.CreateInputSelect_0(__builder2, 8, 9, 
#nullable restore
#line 21 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
                             RespuestaSelect

#line default
#line hidden
#nullable disable
                , 10, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 21 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
                                                               (string b ) => OnCHange(b)

#line default
#line hidden
#nullable disable
                ), 11, 
#nullable restore
#line 22 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
                                         () =>RespuestaSelect

#line default
#line hidden
#nullable disable
                , 12, "form-control col-md-4", 13, "margin-left:5px", 14, (__builder3) => {
                    __builder3.AddMarkupContent(15, "<option>--Seleccione--</option>\r\n            ");
                    __builder3.AddMarkupContent(16, "<option value=\"1\">Libros por Dia</option>\r\n            ");
                    __builder3.AddMarkupContent(17, "<option value=\"2\">Libros Disponibles</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n    <br>");
#nullable restore
#line 33 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
     if (FiltroporDia == true)
    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-inline");
                __builder2.AddMarkupContent(21, "<label class=\"control-lable \">FECHA: </label>\r\n            ");
                __Blazor.FinalEvanyeline.Pages.Ventas.Index.TypeInference.CreateInputDate_1(__builder2, 22, 23, "form-control col-md-4", 24, "margin-left:5px", 25, 
#nullable restore
#line 38 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
                                     FechaporDia

#line default
#line hidden
#nullable disable
                , 26, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => FechaporDia = __value, FechaporDia)), 27, () => FechaporDia);
                __builder2.CloseElement();
#nullable restore
#line 40 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(28, "<br>\r\n    ");
                __builder2.AddMarkupContent(29, "<div class=\"mb-3\"><button type=\"submit\" class=\"btn btn-outline-success\">Buscar</button></div>\r\n    <br>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(30, "\r\n<br>");
#nullable restore
#line 53 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
 if (ResultadosFiltro == true)
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
     if (ListaResultado == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "<p><em>Loading...</em></p>");
#nullable restore
#line 59 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "table");
            __builder.AddAttribute(33, "class", "table table-hover table-bordered");
            __builder.AddMarkupContent(34, "<thead><tr><th>Libro</th>\r\n                    <th>Comprador</th>\r\n                    <th>Total</th>\r\n                    <th>Cantidad</th>\r\n                    <th>Fecha</th></tr></thead>\r\n            ");
            __builder.OpenElement(35, "tbody");
#nullable restore
#line 73 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
                 foreach (var context in ListaResultado)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "tr");
            __builder.OpenElement(37, "td");
#nullable restore
#line 76 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
__builder.AddContent(38, NombreLibro(ListaLibros, context.idlibro));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.OpenElement(40, "td");
#nullable restore
#line 77 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
__builder.AddContent(41, context.nombreCliente);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.OpenElement(43, "td");
#nullable restore
#line 78 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
__builder.AddContent(44, context.total);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                        ");
            __builder.OpenElement(46, "td");
#nullable restore
#line 79 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
__builder.AddContent(47, context.cantidad);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.OpenElement(49, "td");
#nullable restore
#line 80 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
__builder.AddContent(50, context.ventas_fecha);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 82 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 85 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
     

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
 if (ResultadosFiltro == true)
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
     if (ListaResultado == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(51, "<p><em>Loading...</em></p>");
#nullable restore
#line 96 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(52, "table");
            __builder.AddAttribute(53, "class", "table table-hover table-bordered");
            __builder.AddMarkupContent(54, "<thead><tr><th>Nombre Libro</th>\r\n                    <th>Autor</th>\r\n                    <th>Cantidad</th>\r\n                    <th>Editorial</th>\r\n                    <th>Genero</th></tr></thead>\r\n            ");
            __builder.OpenElement(55, "tbody");
#nullable restore
#line 110 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
                 foreach (var context in ListaResultadoDisponible)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(56, "tr");
            __builder.OpenElement(57, "td");
#nullable restore
#line 113 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
__builder.AddContent(58, context.nombre);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                        ");
            __builder.OpenElement(60, "td");
#nullable restore
#line 114 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
__builder.AddContent(61, context.autor);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                        ");
            __builder.OpenElement(63, "td");
#nullable restore
#line 115 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
__builder.AddContent(64, context.Cant_disponible);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                        ");
            __builder.OpenElement(66, "td");
#nullable restore
#line 116 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
__builder.AddContent(67, context.editorial);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                        ");
            __builder.OpenElement(69, "td");
#nullable restore
#line 117 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
__builder.AddContent(70, context.genero);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 119 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 122 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
     

}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(71, "<br>");
#nullable restore
#line 126 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
 if (FiltroporDia == true)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(72, "p");
            __builder.AddContent(73, "Total de libros vendidos en el dia : ");
            __builder.OpenElement(74, "p");
            __builder.AddAttribute(75, "style", "color:red");
#nullable restore
#line 128 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"
__builder.AddContent(76, ListaResultado.Count());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 129 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Ventas\Index.razor"

}

#line default
#line hidden
#nullable disable
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
namespace __Blazor.FinalEvanyeline.Pages.Ventas.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, System.Object __arg3, int __seq4, System.Object __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "class", __arg3);
        __builder.AddAttribute(__seq4, "style", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "style", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591