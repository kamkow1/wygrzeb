#pragma checksum "C:\Users\kamil\source\repos\wygrzebforum\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "948c4e947bbdbe524104e2a619f1fad5ecf9c60d"
// <auto-generated/>
#pragma warning disable 1591
namespace wygrzebforum.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kamil\source\repos\wygrzebforum\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kamil\source\repos\wygrzebforum\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kamil\source\repos\wygrzebforum\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kamil\source\repos\wygrzebforum\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kamil\source\repos\wygrzebforum\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kamil\source\repos\wygrzebforum\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kamil\source\repos\wygrzebforum\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kamil\source\repos\wygrzebforum\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kamil\source\repos\wygrzebforum\_Imports.razor"
using wygrzebforum;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\kamil\source\repos\wygrzebforum\_Imports.razor"
using wygrzebforum.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Login.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Login.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Login.razor"
using wygrzebforum.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 11 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Login.razor"
 if (!wygrzebSessionData.IsUserLoggedIn)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "reg-form");
            __builder.AddAttribute(2, "b-f10krebyoc");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Login.razor"
                      userModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Login.razor"
                                            ValidOnSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n        ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-input-block");
                __builder2.AddAttribute(11, "b-f10krebyoc");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "form-group");
                __builder2.AddAttribute(14, "b-f10krebyoc");
                __builder2.AddMarkupContent(15, "<label for=\"login\" b-f10krebyoc>Login</label>\r\n\r\n                ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "msg-invalid");
                __builder2.AddAttribute(18, "b-f10krebyoc");
                __Blazor.wygrzebforum.Pages.Login.TypeInference.CreateValidationMessage_0(__builder2, 19, 20, 
#nullable restore
#line 22 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Login.razor"
                                              () => userModel.Login

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "class", "form-control form-input");
                __builder2.AddAttribute(24, "placeholder", "wpisz login");
                __builder2.AddAttribute(25, "id", "login");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Login.razor"
                                        userModel.Login

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userModel.Login = __value, userModel.Login))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userModel.Login));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n            ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddAttribute(32, "b-f10krebyoc");
                __builder2.AddMarkupContent(33, "<label for=\"password\" b-f10krebyoc>Hasło</label>\r\n                \r\n                ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "msg-invalid");
                __builder2.AddAttribute(36, "b-f10krebyoc");
                __Blazor.wygrzebforum.Pages.Login.TypeInference.CreateValidationMessage_1(__builder2, 37, 38, 
#nullable restore
#line 33 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Login.razor"
                                              () => userModel.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(40);
                __builder2.AddAttribute(41, "type", "password");
                __builder2.AddAttribute(42, "class", "form-control form-input");
                __builder2.AddAttribute(43, "placeholder", "wpisz hasło");
                __builder2.AddAttribute(44, "id", "password");
                __builder2.AddAttribute(45, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Login.razor"
                                                        userModel.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userModel.Password = __value, userModel.Password))));
                __builder2.AddAttribute(47, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userModel.Password));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n            ");
                __builder2.AddMarkupContent(49, "<div class=\"form-group\" style=\"display: inline-block; margin-top: 2em;\" b-f10krebyoc><button type=\"submit\" class=\"btn btn-outline-dark\" style=\"margin-right: 1em;\" b-f10krebyoc>zaloguj</button></div>");
                __builder2.CloseElement();
#nullable restore
#line 47 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Login.razor"
         if ((int)response.StatusCode != 200)
        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(50, "<p class=\"text-centet text-danger\" b-f10krebyoc>Nie udało się zalogować!</p>");
#nullable restore
#line 50 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Login.razor"
        }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Login.razor"
}
else 
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "text-center");
            __builder.AddAttribute(53, "b-f10krebyoc");
            __builder.AddMarkupContent(54, "<h3 b-f10krebyoc>już jesteś zalogowany!</h3>\r\n        ");
            __builder.OpenElement(55, "p");
            __builder.AddAttribute(56, "b-f10krebyoc");
            __builder.AddMarkupContent(57, "\r\n            Teraz w pasku nawigacji możesz ");
            __builder.OpenElement(58, "a");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Login.razor"
                                                        NavToAccount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "style", "color: dodgerblue; text-decoration: underline;");
            __builder.AddAttribute(61, "b-f10krebyoc");
            __builder.AddMarkupContent(62, "wyświetlić swoje konto");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, ", <br b-f10krebyoc>\r\n            możesz ");
            __builder.OpenElement(64, "a");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Login.razor"
                                NavToBrowse

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "style", "color: dodgerblue; text-decoration: underline;");
            __builder.AddAttribute(67, "b-f10krebyoc");
            __builder.AddMarkupContent(68, "przeglądać dostępne artykuły");
            __builder.CloseElement();
            __builder.AddContent(69, " lub ");
            __builder.OpenElement(70, "a");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Login.razor"
                                                                                                                                                      NavToCreate

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "style", "color: dodgerblue; text-decoration: underline;");
            __builder.AddAttribute(73, "b-f10krebyoc");
            __builder.AddMarkupContent(74, "stworzyć własny");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 63 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Login.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Login.razor"
       
    User userModel = new();
    HttpResponseMessage response = new();

    async void ValidOnSubmit(EditContext editContext)
    {
        object userToSubmit = new 
        {
            login = userModel.Login,
            password = userModel.Password
        };

        var json = JsonConvert.SerializeObject(userToSubmit);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var url = "https://localhost:44392/user/login";
        using var client = new HttpClient();

        response = await client.PostAsync(url, data);

        RequestResult result = response.Content.ReadAsAsync<RequestResult>().Result;

        if (response.IsSuccessStatusCode)
        {
            wygrzebSessionData.IsUserLoggedIn = true;
            wygrzebSessionData.CurrentUserId = result.id;
            wygrzebSessionData.RemoteIpAdress = result.ip;
            await sessionStorage.SetItemAsync("SessionState", wygrzebSessionData);

            Console.WriteLine(wygrzebSessionData.Dump());

            nav.NavigateTo("/", false);
        }
    }

    class RequestResult
    {
        public int id { get; set; }
        public string ip { get; set; }
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Login.razor"
            
    void NavToAccount()
    {
        nav.NavigateTo("account", false);
    }

    void NavToBrowse()
    {
        nav.NavigateTo("browse", false);
    }

    void NavToCreate()
    {
        nav.NavigateTo("create", false);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WygrzebSessionData wygrzebSessionData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
    }
}
namespace __Blazor.wygrzebforum.Pages.Login
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591