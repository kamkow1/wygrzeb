#pragma checksum "C:\Users\kamil\source\repos\wygrzebforum\Pages\Account.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45a37a1a9dbc574150ab7a5a1c0fd8b9f59558dd"
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
#line 1 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Account.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Account.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Account.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Account.razor"
using wygrzebforum.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/account")]
    public partial class Account : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "text-center");
            __builder.AddAttribute(2, "b-qh1iez3yxd");
            __builder.AddMarkupContent(3, "<h3 b-qh1iez3yxd>Dane użytkownika</h3>\r\n\r\n    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table thead-dark table-striped border-primary rounded");
            __builder.AddAttribute(6, "b-qh1iez3yxd");
            __builder.AddMarkupContent(7, "<thead b-qh1iez3yxd><tr b-qh1iez3yxd><th b-qh1iez3yxd>Login</th>\r\n                <th b-qh1iez3yxd>Hasło</th>\r\n                <th b-qh1iez3yxd>Email</th>\r\n                <th b-qh1iez3yxd>Data dołączenia</th></tr></thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddAttribute(9, "b-qh1iez3yxd");
            __builder.OpenElement(10, "tr");
            __builder.AddAttribute(11, "b-qh1iez3yxd");
            __builder.OpenElement(12, "td");
            __builder.AddAttribute(13, "b-qh1iez3yxd");
            __builder.OpenElement(14, "span");
            __builder.AddAttribute(15, "b-qh1iez3yxd");
            __builder.AddContent(16, 
#nullable restore
#line 26 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Account.razor"
                           user.Login

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "td");
            __builder.AddAttribute(19, "b-qh1iez3yxd");
            __builder.OpenElement(20, "span");
            __builder.AddAttribute(21, "b-qh1iez3yxd");
            __builder.AddContent(22, 
#nullable restore
#line 29 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Account.razor"
                           user.Password

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "td");
            __builder.AddAttribute(25, "b-qh1iez3yxd");
            __builder.OpenElement(26, "span");
            __builder.AddAttribute(27, "b-qh1iez3yxd");
            __builder.AddContent(28, 
#nullable restore
#line 32 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Account.razor"
                           user.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "td");
            __builder.AddAttribute(31, "b-qh1iez3yxd");
            __builder.AddContent(32, 
#nullable restore
#line 34 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Account.razor"
                     user.creationDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\r\n    ");
            __builder.AddMarkupContent(34, "<h3 b-qh1iez3yxd>Moje artykuły</h3>\r\n\r\n    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "article-results");
            __builder.AddAttribute(37, "b-qh1iez3yxd");
            __builder.OpenElement(38, "ul");
            __builder.AddAttribute(39, "style", "list-style-type: none;");
            __builder.AddAttribute(40, "b-qh1iez3yxd");
#nullable restore
#line 43 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Account.razor"
             for (int i = 0; i < this.articles.Count; i++)
            {
                Article a = this.articles[i];


#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "li");
            __builder.AddAttribute(42, "b-qh1iez3yxd");
            __builder.OpenElement(43, "table");
            __builder.AddAttribute(44, "class", "table table-striped table-light border-primary rounded");
            __builder.AddAttribute(45, "style", "width: 50em;");
            __builder.AddAttribute(46, "b-qh1iez3yxd");
            __builder.OpenElement(47, "thead");
            __builder.AddAttribute(48, "b-qh1iez3yxd");
            __builder.OpenElement(49, "tr");
            __builder.AddAttribute(50, "b-qh1iez3yxd");
            __builder.OpenElement(51, "th");
            __builder.AddAttribute(52, "b-qh1iez3yxd");
            __builder.OpenElement(53, "p");
            __builder.AddAttribute(54, "b-qh1iez3yxd");
            __builder.AddContent(55, 
#nullable restore
#line 52 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Account.razor"
                                        a.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                                    ");
            __builder.OpenElement(57, "i");
            __builder.AddAttribute(58, "style", "font-size: 0.7em");
            __builder.AddAttribute(59, "b-qh1iez3yxd");
            __builder.AddContent(60, "data utworzenia: ");
            __builder.AddContent(61, 
#nullable restore
#line 53 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Account.razor"
                                                                                  a.creationDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(62, " <br b-qh1iez3yxd>\r\n                                    ");
            __builder.OpenElement(63, "i");
            __builder.AddAttribute(64, "style", "font-size: 0.7em");
            __builder.AddAttribute(65, "b-qh1iez3yxd");
            __builder.AddMarkupContent(66, "liczba wyświetleń: ");
            __builder.AddContent(67, 
#nullable restore
#line 54 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Account.razor"
                                                                                    a.viewCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                                ");
            __builder.OpenElement(69, "th");
            __builder.AddAttribute(70, "class", "up-down-group");
            __builder.AddAttribute(71, "b-qh1iez3yxd");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "btn-down");
            __builder.AddAttribute(74, "b-qh1iez3yxd");
            __builder.OpenElement(75, "button");
            __builder.AddAttribute(76, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Account.razor"
                                                          () => Downvote(a.id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(77, "b-qh1iez3yxd");
            __builder.AddMarkupContent(78, @"<svg xmlns=""http://www.w3.org/2000/svg"" width=""18"" height=""18"" fill=""currentColor"" class=""bi bi-hand-thumbs-down-fill"" viewBox=""0 0 16 16"" b-qh1iez3yxd><path d=""M6.956 14.534c.065.936.952 1.659 1.908 1.42l.261-.065a1.378 1.378 0 0 0 1.012-.965c.22-.816.533-2.512.062-4.51.136.02.285.037.443.051.713.065 1.669.071 2.516-.211.518-.173.994-.68 1.2-1.272a1.896 1.896 0 0 0-.234-1.734c.058-.118.103-.242.138-.362.077-.27.113-.568.113-.856 0-.29-.036-.586-.113-.857a2.094 2.094 0 0 0-.16-.403c.169-.387.107-.82-.003-1.149a3.162 3.162 0 0 0-.488-.9c.054-.153.076-.313.076-.465a1.86 1.86 0 0 0-.253-.912C13.1.757 12.437.28 11.5.28H8c-.605 0-1.07.08-1.466.217a4.823 4.823 0 0 0-.97.485l-.048.029c-.504.308-.999.61-2.068.723C2.682 1.815 2 2.434 2 3.279v4c0 .851.685 1.433 1.357 1.616.849.232 1.574.787 2.132 1.41.56.626.914 1.28 1.039 1.638.199.575.356 1.54.428 2.591z"" b-qh1iez3yxd></path></svg>");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                                        ");
            __builder.AddContent(80, 
#nullable restore
#line 63 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Account.razor"
                                         a.downvotes

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                                    ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "btn-up");
            __builder.AddAttribute(84, "b-qh1iez3yxd");
            __builder.OpenElement(85, "button");
            __builder.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Account.razor"
                                                          () => Upvote(a.id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "b-qh1iez3yxd");
            __builder.AddMarkupContent(88, @"<svg xmlns=""http://www.w3.org/2000/svg"" width=""18"" height=""18"" fill=""currentColor"" class=""bi bi-hand-thumbs-up-fill"" viewBox=""0 0 16 16"" b-qh1iez3yxd><path d=""M6.956 1.745C7.021.81 7.908.087 8.864.325l.261.066c.463.116.874.456 1.012.965.22.816.533 2.511.062 4.51a9.84 9.84 0 0 1 .443-.051c.713-.065 1.669-.072 2.516.21.518.173.994.681 1.2 1.273.184.532.16 1.162-.234 1.733.058.119.103.242.138.363.077.27.113.567.113.856 0 .289-.036.586-.113.856-.039.135-.09.273-.16.404.169.387.107.819-.003 1.148a3.163 3.163 0 0 1-.488.901c.054.152.076.312.076.465 0 .305-.089.625-.253.912C13.1 15.522 12.437 16 11.5 16H8c-.605 0-1.07-.081-1.466-.218a4.82 4.82 0 0 1-.97-.484l-.048-.03c-.504-.307-.999-.609-2.068-.722C2.682 14.464 2 13.846 2 13V9c0-.85.685-1.432 1.357-1.615.849-.232 1.574-.787 2.132-1.41.56-.627.914-1.28 1.039-1.639.199-.575.356-1.539.428-2.59z"" b-qh1iez3yxd></path></svg>");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                                        ");
            __builder.AddContent(90, 
#nullable restore
#line 71 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Account.razor"
                                         a.upvotes

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                        ");
            __builder.OpenElement(92, "tbody");
            __builder.AddAttribute(93, "b-qh1iez3yxd");
            __builder.OpenElement(94, "tr");
            __builder.AddAttribute(95, "b-qh1iez3yxd");
            __builder.OpenElement(96, "td");
            __builder.AddAttribute(97, "colspan", "2");
            __builder.AddAttribute(98, "b-qh1iez3yxd");
            __builder.OpenElement(99, "img");
            __builder.AddAttribute(100, "src", 
#nullable restore
#line 79 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Account.razor"
                                               a.thumbail

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(101, "title", 
#nullable restore
#line 79 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Account.razor"
                                                                   a.title

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(102, "alt", "miniaturka");
            __builder.AddAttribute(103, "width", "250");
            __builder.AddAttribute(104, "height", "250");
            __builder.AddAttribute(105, "class", "img-thumbnail article-img");
            __builder.AddAttribute(106, "b-qh1iez3yxd");
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n                                    ");
            __builder.OpenElement(108, "p");
            __builder.AddAttribute(109, "class", "article-content");
            __builder.AddAttribute(110, "b-qh1iez3yxd");
            __builder.AddContent(111, 
#nullable restore
#line 80 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Account.razor"
                                                                a.content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n\r\n                    <hr b-qh1iez3yxd>");
            __builder.CloseElement();
#nullable restore
#line 88 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Account.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Account.razor"
       
    int userIdFromSession;
    HttpResponseMessage response = new();
    User user = new();
    List<Article> articles = new();

    protected override async Task OnInitializedAsync()
    {
        // fetch json user data from api
        Session Utemp = new();
        Utemp = await sessionStorage.GetItemAsync<Session>("SessionState");
        userIdFromSession = Utemp.CurrentUserId; 
        var Uurl = "https://localhost:44392/user/getbyid";
        object idToSubmit = new 
        {
            id = userIdFromSession
        };
        var Ujson = JsonConvert.SerializeObject(idToSubmit);
        var Udata = new StringContent(Ujson, Encoding.UTF8, "application/json");
        using var client = new HttpClient();
        response = await client.PostAsync(Uurl, Udata);
        user = response.Content.ReadAsAsync<User>().Result;
        await sessionStorage.SetItemAsync<User>("SessionState", user);

        // fetch json array of articles for current user
        var url = "https://localhost:44392/user/articles";
        var json = JsonConvert.SerializeObject(idToSubmit);
        var data = new StringContent(json, Encoding.UTF8, "application/json");
        response = await client.PostAsync(url, data);
        var temp = Task.Run(async() => JArray.Parse(await response.Content.ReadAsStringAsync()));
        Console.WriteLine(response.Content.ReadAsStringAsync().Result);
        this.articles = (await temp).ToObject<List<Article>>();
    }

    async void Upvote(int articleid)
    {
        var url = "https://localhost:44392/article/upvote";

        string data = JsonConvert.SerializeObject(new { id = articleid });

        using var client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Add(
            new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);
        request.Content = new StringContent(data,
                                    Encoding.UTF8, 
                                    "application/json");

        await client.SendAsync(request);
    }

    async void Downvote(int articleid)
    {
        var url = "https://localhost:44392/article/downvote";

        string data = JsonConvert.SerializeObject(new { id = articleid });

        using var client = new HttpClient();
        client.DefaultRequestHeaders.Accept.Add(
            new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, url);
        request.Content = new StringContent(data,
                                    Encoding.UTF8, 
                                    "application/json");

        await client.SendAsync(request);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Session session { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
