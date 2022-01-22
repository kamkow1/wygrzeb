// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
        }
        #pragma warning restore 1998
#nullable restore
#line 100 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Account.razor"
       
    //int userIdFromSession;
    HttpResponseMessage response = new();
    User user = new();
    List<Article> articles = new();

    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine("account OnInitializedAsync");

        // fetch json user data from api
        WygrzebSessionData wsd = await sessionStorage.GetItemAsync<WygrzebSessionData>("SessionState");
        Console.WriteLine(wsd.Dump());

        using var client = new HttpClient();

        object idToSubmit = new 
        {
            id = wsd.CurrentUserId
        };

        var Uurl = "https://localhost:44392/user/getbyid";
        var Ujson = JsonConvert.SerializeObject(idToSubmit);
        var Udata = new StringContent(Ujson, Encoding.UTF8, "application/json");      
        response = await client.PostAsync(Uurl, Udata);
        this.user = response.Content.ReadAsAsync<User>().Result;

        // fetch json array of articles for current user
        Console.WriteLine("id to submit =" + idToSubmit);
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private WygrzebSessionData wygrzebSessionData { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
