#pragma checksum "C:\Users\kamil\source\repos\wygrzebforum\Pages\Register.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f0ad2aae6dfceb541bb3602958fc8c1081706ba"
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
#line 1 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Register.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Register.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Register.razor"
using wygrzebforum.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Register : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<p style=\"font-size: 0.8em;\" b-vxjr8mqqjo>\r\n    masz już konto? <a href=\"/login\" class=\"page-link text-primary\" style=\"width: 10em;\" b-vxjr8mqqjo>zaloguj się tutaj!</a></p>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "reg-form");
            __builder.AddAttribute(3, "b-vxjr8mqqjo");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Register.razor"
                      userModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Register.razor"
                                                 ValidOnSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-input-block");
                __builder2.AddAttribute(12, "b-vxjr8mqqjo");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.AddAttribute(15, "b-vxjr8mqqjo");
                __builder2.AddMarkupContent(16, "<label for=\"login\" b-vxjr8mqqjo>Login</label>\r\n\r\n                ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "msg-invalid");
                __builder2.AddAttribute(19, "b-vxjr8mqqjo");
                __Blazor.wygrzebforum.Pages.Register.TypeInference.CreateValidationMessage_0(__builder2, 20, 21, 
#nullable restore
#line 20 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Register.razor"
                                              () => userModel.Login

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "class", "form-control form-input");
                __builder2.AddAttribute(25, "placeholder", "wpisz login");
                __builder2.AddAttribute(26, "id", "login");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Register.razor"
                                        userModel.Login

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userModel.Login = __value, userModel.Login))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userModel.Login));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.AddMarkupContent(31, "<small class=\"form-text text-muted\" b-vxjr8mqqjo>login będzie wyświetlany jako nazwa użytkownika</small>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddAttribute(35, "b-vxjr8mqqjo");
                __builder2.AddMarkupContent(36, "<label for=\"password\" b-vxjr8mqqjo>Hasło</label>\r\n                \r\n                ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "msg-invalid");
                __builder2.AddAttribute(39, "b-vxjr8mqqjo");
                __Blazor.wygrzebforum.Pages.Register.TypeInference.CreateValidationMessage_1(__builder2, 40, 41, 
#nullable restore
#line 30 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Register.razor"
                                              () => userModel.Password

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(43);
                __builder2.AddAttribute(44, "type", "password");
                __builder2.AddAttribute(45, "class", "form-control form-input");
                __builder2.AddAttribute(46, "placeholder", "wpisz hasło");
                __builder2.AddAttribute(47, "id", "password");
                __builder2.AddAttribute(48, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 33 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Register.razor"
                                                        userModel.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userModel.Password = __value, userModel.Password))));
                __builder2.AddAttribute(50, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userModel.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n                ");
                __builder2.AddMarkupContent(52, "<small class=\"form-text text-muted\" b-vxjr8mqqjo>pamiętaj, aby twoje hasło było bezpieczne</small>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n            ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "form-group");
                __builder2.AddAttribute(56, "b-vxjr8mqqjo");
                __builder2.AddMarkupContent(57, "<label for=\"email\" b-vxjr8mqqjo>Email</label>\r\n                \r\n                ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "msg-invalid");
                __builder2.AddAttribute(60, "b-vxjr8mqqjo");
                __Blazor.wygrzebforum.Pages.Register.TypeInference.CreateValidationMessage_2(__builder2, 61, 62, 
#nullable restore
#line 40 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Register.razor"
                                              () => userModel.Email

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(64);
                __builder2.AddAttribute(65, "type", "email");
                __builder2.AddAttribute(66, "class", "form-control form-input");
                __builder2.AddAttribute(67, "placeholder", "wpisz email");
                __builder2.AddAttribute(68, "id", "email");
                __builder2.AddAttribute(69, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 43 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Register.razor"
                                                     userModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userModel.Email = __value, userModel.Email))));
                __builder2.AddAttribute(71, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => userModel.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n            ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "form-group");
                __builder2.AddAttribute(75, "b-vxjr8mqqjo");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "msg-invalid");
                __builder2.AddAttribute(78, "b-vxjr8mqqjo");
                __Blazor.wygrzebforum.Pages.Register.TypeInference.CreateValidationMessage_3(__builder2, 79, 80, 
#nullable restore
#line 48 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Register.razor"
                                              () => userModel.PolicyAgreement

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(82);
                __builder2.AddAttribute(83, "class", "custom-checkbox");
                __builder2.AddAttribute(84, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 51 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Register.razor"
                                            userModel.PolicyAgreement

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(85, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => userModel.PolicyAgreement = __value, userModel.PolicyAgreement))));
                __builder2.AddAttribute(86, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => userModel.PolicyAgreement));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\r\n                ");
                __builder2.AddMarkupContent(88, "<label for=\"agreement-info\" b-vxjr8mqqjo><small b-vxjr8mqqjo>Zgadzam się z warunkami korzystania z serwisu</small></label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "  \r\n            ");
                __builder2.AddMarkupContent(90, @"<div class=""form-group"" style=""display: inline-block; margin-top: 2em;"" b-vxjr8mqqjo><input type=""submit"" value=""prześlij"" class=""btn btn-outline-dark"" style=""margin-right: 1em;"" b-vxjr8mqqjo>
                <input type=""reset"" value=""wyczyść"" class=""btn btn-outline-danger"" b-vxjr8mqqjo></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Register.razor"
       
    User userModel = new();

    async void ValidOnSubmit(EditContext editContext)
    {
        object userToSubmit = new 
        {
            login = userModel.Login,
            password = userModel.Password,
            email = userModel.Email
        };

        var json = JsonConvert.SerializeObject(userToSubmit);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var url = "https://localhost:44392/user/register";
        using var client = new HttpClient();

        var response = await client.PostAsync(url, data);
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.wygrzebforum.Pages.Register
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
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
