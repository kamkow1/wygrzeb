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
#line 1 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Browse.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Browse.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Browse.razor"
using Microsoft.Extensions.Logging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Browse.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Browse.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Browse")]
    public partial class Browse : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\kamil\source\repos\wygrzebforum\Pages\Browse.razor"
       
    JArray articles = new();

    protected override async Task OnInitializedAsync()
    {
        // fetch json from api
        var url = "https://localhost:44392/article/recent";
        using var client = new HttpClient();
        var response = await client.GetAsync(url);
        Console.WriteLine(response);
        string temp = await response.Content.ReadAsStringAsync();
        temp = temp.Replace("$", "");
        Console.WriteLine(temp);
        dynamic content = JObject.Parse(temp);
        Console.WriteLine(content.values);
        Console.WriteLine(content.values.GetType());
        articles = content.values;
    }

    public class Article
    {
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Thumbail { get; set; }
        public int Upvotes { get; set; }
        public int Downvotes { get; set; }
        public int ViewCount { get; set; }
        public int UserId { get; set; }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
