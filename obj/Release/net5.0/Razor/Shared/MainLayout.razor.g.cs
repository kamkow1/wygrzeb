#pragma checksum "C:\Users\kamil\source\repos\wygrzebforum\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1659d940991f0d317a5277307d6ef831135e1119"
// <auto-generated/>
#pragma warning disable 1591
namespace wygrzebforum.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-hiztd9n5xk");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-hiztd9n5xk");
            __builder.OpenComponent<wygrzebforum.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-hiztd9n5xk");
            __builder.AddMarkupContent(11, @"<div class=""top-row px-4"" b-hiztd9n5xk><svg xmlns=""http://www.w3.org/2000/svg"" width=""25"" height=""25"" fill=""currentColor"" class=""bi bi-github"" viewBox=""0 0 16 16"" b-hiztd9n5xk><path d=""M8 0C3.58 0 0 3.58 0 8c0 3.54 2.29 6.53 5.47 7.59.4.07.55-.17.55-.38 0-.19-.01-.82-.01-1.49-2.01.37-2.53-.49-2.69-.94-.09-.23-.48-.94-.82-1.13-.28-.15-.68-.52-.01-.53.63-.01 1.08.58 1.23.82.72 1.21 1.87.87 2.33.66.07-.52.28-.87.51-1.07-1.78-.2-3.64-.89-3.64-3.95 0-.87.31-1.59.82-2.15-.08-.2-.36-1.02.08-2.12 0 0 .67-.21 2.2.82.64-.18 1.32-.27 2-.27.68 0 1.36.09 2 .27 1.53-1.04 2.2-.82 2.2-.82.44 1.1.16 1.92.08 2.12.51.56.82 1.27.82 2.15 0 3.07-1.87 3.75-3.65 3.95.29.25.54.73.54 1.48 0 1.07-.01 1.93-.01 2.2 0 .21.15.46.55.38A8.012 8.012 0 0 0 16 8c0-4.42-3.58-8-8-8z"" b-hiztd9n5xk></path></svg> <a href=""https://github.com/kamkow1"" target=""_blank"" class=""align-self-auto"" b-hiztd9n5xk>&copy; Kamil Kowalczyk 1C</a>
            <a href=""https://github.com/kamkow1/wygrzebapi"" target=""_blank"" class=""align-self-auto"" b-hiztd9n5xk>wygrzeb api (back-end)</a>
            <a href=""https://github.com/kamkow1/wygrzebapi"" target=""_blank"" class=""align-self-auto"" b-hiztd9n5xk>wygrzeb (front-end)</a></div>

        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-hiztd9n5xk");
            __builder.AddContent(15, 
#nullable restore
#line 18 "C:\Users\kamil\source\repos\wygrzebforum\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591