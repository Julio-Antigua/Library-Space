#pragma checksum "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Usuarios\Editar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27e9aab286afdbddecdc55c881b690ecba21ba04"
// <auto-generated/>
#pragma warning disable 1591
namespace FinalEvanyeline.Pages.Usuarios
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
#line 4 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Usuarios\Editar.razor"
using FinalEvanyeline.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Usuarios\Editar.razor"
using FinalEvanyeline.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Usuarios\Editar.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/EditarUsuario/{id:int}")]
    public partial class Editar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 style=\"color:green\">Crear Nota</h1>\r\n\r\n\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 24 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Usuarios\Editar.razor"
                         UsuarioModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 24 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Usuarios\Editar.razor"
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
                __builder2.AddMarkupContent(13, "<label class=\"control-lable col-md-2\"> NOMBRE:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "class", "form-control col-md-4 ");
                __builder2.AddAttribute(16, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Usuarios\Editar.razor"
                                        UsuarioModel.nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UsuarioModel.nombre = __value, UsuarioModel.nombre))));
                __builder2.AddAttribute(18, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UsuarioModel.nombre));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n\r\n            <br>\r\n\r\n            ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", " row");
                __builder2.AddMarkupContent(22, "<label class=\"control-lable col-md-2\"> Email:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "class", "form-control col-md-4 ");
                __builder2.AddAttribute(25, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Usuarios\Editar.razor"
                                        UsuarioModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UsuarioModel.Email = __value, UsuarioModel.Email))));
                __builder2.AddAttribute(27, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UsuarioModel.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n\r\n            <br>\r\n\r\n            ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "row");
                __builder2.AddMarkupContent(31, "<label class=\"control-lable col-md-2\"> CLAVE:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "type", "password");
                __builder2.AddAttribute(34, "class", "form-control col-md-4 ");
                __builder2.AddAttribute(35, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 46 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Usuarios\Editar.razor"
                                                        UsuarioModel.contrasena

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UsuarioModel.contrasena = __value, UsuarioModel.contrasena))));
                __builder2.AddAttribute(37, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UsuarioModel.contrasena));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n            <br>\r\n\r\n            ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "row");
                __builder2.AddMarkupContent(41, "<label class=\"control-lable col-md-2\"> ROL:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(42);
                __builder2.AddAttribute(43, "class", "form-control col-md-4 ");
                __builder2.AddAttribute(44, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Usuarios\Editar.razor"
                                        UsuarioModel.Role

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(45, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => UsuarioModel.Role = __value, UsuarioModel.Role))));
                __builder2.AddAttribute(46, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => UsuarioModel.Role));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n\r\n            <br>\r\n            ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "mb-3");
                __builder2.AddMarkupContent(50, "<button type=\"submit\" class=\"btn btn-outline-success\">Guardar</button>\r\n                ");
                __builder2.OpenElement(51, "button");
                __builder2.AddAttribute(52, "type", "button");
                __builder2.AddAttribute(53, "class", "btn btn-outline-danger m-3 ");
                __builder2.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Usuarios\Editar.razor"
                                                                                   VolverA

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(55, "Cancelar");
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
#line 67 "C:\Users\Administrador\Downloads\FinalEvanyeline\FinalEvanyeline\FinalEvanyeline\Pages\Usuarios\Editar.razor"
       

    [Parameter]
    public int id { get; set; }


    private Usuario UsuarioModel = new Usuario();



    //---------METODOS---------
    protected override async Task OnInitializedAsync()
    {
        UsuarioModel = await usuariocontroler.ObtenerUsuarioPorId(id);

    }

    private async Task ManejadorUpsert()
    {


        var respuestaEditar = await usuariocontroler.Actualizar(id,UsuarioModel);

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UsuarioController usuariocontroler { get; set; }
    }
}
#pragma warning restore 1591