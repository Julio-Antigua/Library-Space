#pragma checksum "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Editar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a27346515df7ca58f434b9d71454b8b5b68654c3"
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
            __builder.AddMarkupContent(0, "<h1 style=\"color:green\">Crear Autor</h1>\r\n\r\n\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 24 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Editar.razor"
                         AutoresModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 24 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Editar.razor"
                                                        () => ManejadorUpsert()

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(9);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(10, "\r\n\r\n            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", " row");
                __builder2.AddMarkupContent(13, "<label class=\"control-lable col-md-2\"> Nombre:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "class", "form-control col-md-4 ");
                __builder2.AddAttribute(16, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Editar.razor"
                                        AutoresModel.nombre_autor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AutoresModel.nombre_autor = __value, AutoresModel.nombre_autor))));
                __builder2.AddAttribute(18, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AutoresModel.nombre_autor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n            <br>\r\n\r\n\r\n            ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", " row");
                __builder2.AddMarkupContent(22, "<label class=\"control-lable col-md-2\"> Apellido:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "class", "form-control col-md-4 ");
                __builder2.AddAttribute(25, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Editar.razor"
                                        AutoresModel.apellido_autor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AutoresModel.apellido_autor = __value, AutoresModel.apellido_autor))));
                __builder2.AddAttribute(27, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AutoresModel.apellido_autor));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n\r\n            <br>\r\n\r\n            ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", " row");
                __builder2.AddMarkupContent(31, "<label class=\"control-lable col-md-2\"> Edad:</label>\r\n                ");
                __Blazor.FinalEvanyeline.Pages.Autores.Editar.TypeInference.CreateInputNumber_0(__builder2, 32, 33, "form-control col-md-4 ", 34, 
#nullable restore
#line 45 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Editar.razor"
                                          AutoresModel.edad

#line default
#line hidden
#nullable disable
                , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AutoresModel.edad = __value, AutoresModel.edad)), 36, () => AutoresModel.edad);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n\r\n            <br>\r\n\r\n\r\n            ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", " row");
                __builder2.AddMarkupContent(40, "<label class=\"control-lable col-md-2\"> Nacionalidad:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(41);
                __builder2.AddAttribute(42, "class", "form-control col-md-4 ");
                __builder2.AddAttribute(43, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Editar.razor"
                                        AutoresModel.nacionalidad

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AutoresModel.nacionalidad = __value, AutoresModel.nacionalidad))));
                __builder2.AddAttribute(45, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AutoresModel.nacionalidad));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n            <br>\r\n\r\n\r\n            ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", " row");
                __builder2.AddMarkupContent(49, "<label class=\"control-lable col-md-2\"> Nacimiento:</label>\r\n                ");
                __Blazor.FinalEvanyeline.Pages.Autores.Editar.TypeInference.CreateInputDate_1(__builder2, 50, 51, "form-control col-md-4 ", 52, 
#nullable restore
#line 61 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Editar.razor"
                                        AutoresModel.nacimiento

#line default
#line hidden
#nullable disable
                , 53, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AutoresModel.nacimiento = __value, AutoresModel.nacimiento)), 54, () => AutoresModel.nacimiento);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n            <br>\r\n\r\n\r\n            ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", " row");
                __builder2.AddMarkupContent(58, "<label class=\"control-lable col-md-2\"> Muerte:</label>\r\n                ");
                __Blazor.FinalEvanyeline.Pages.Autores.Editar.TypeInference.CreateInputDate_2(__builder2, 59, 60, "form-control col-md-4 ", 61, 
#nullable restore
#line 69 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Editar.razor"
                                        AutoresModel.muerte

#line default
#line hidden
#nullable disable
                , 62, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AutoresModel.muerte = __value, AutoresModel.muerte)), 63, () => AutoresModel.muerte);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n\r\n            <br>\r\n\r\n            ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", " row");
                __builder2.AddMarkupContent(67, "<label class=\"control-lable col-md-2\"> Estado:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(68);
                __builder2.AddAttribute(69, "class", "form-control col-md-4 ");
                __builder2.AddAttribute(70, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 77 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Editar.razor"
                                        AutoresModel.estado

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AutoresModel.estado = __value, AutoresModel.estado))));
                __builder2.AddAttribute(72, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => AutoresModel.estado));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n            <br>\r\n\r\n            ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", " row");
                __builder2.AddMarkupContent(76, "<label class=\"control-lable col-md-2\"> Libros Escritos:</label>\r\n                ");
                __Blazor.FinalEvanyeline.Pages.Autores.Editar.TypeInference.CreateInputNumber_3(__builder2, 77, 78, "form-control col-md-4 ", 79, 
#nullable restore
#line 85 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Editar.razor"
                                          AutoresModel.libros_escritos

#line default
#line hidden
#nullable disable
                , 80, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => AutoresModel.libros_escritos = __value, AutoresModel.libros_escritos)), 81, () => AutoresModel.libros_escritos);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n\r\n            <br>\r\n            ");
                __builder2.AddMarkupContent(83, "<div class=\"row\"><label class=\"control-lable col-md-2\"> Foto:</label>\r\n                <input type=\"file\" class=\"form-control col-md-4 \"></div>\r\n\r\n            <br>\r\n            ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "mb-3");
                __builder2.AddMarkupContent(86, "<button type=\"submit\" class=\"btn btn-outline-success\">Guardar</button>\r\n                ");
                __builder2.OpenElement(87, "button");
                __builder2.AddAttribute(88, "type", "button");
                __builder2.AddAttribute(89, "class", "btn btn-outline-danger m-3 ");
                __builder2.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 100 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Autores\Editar.razor"
                                                                                   VolverA

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(91, "Cancelar");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
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
namespace __Blazor.FinalEvanyeline.Pages.Autores.Editar
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
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
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
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591