#pragma checksum "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2e96024eea325f54b6f30c0c921538e2df7233d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddContent(1, "Hello, ");
            __builder.AddContent(2, 
#nullable restore
#line 4 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Index.razor"
           StringUtilities.CustomToUpper(name)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n\r\n");
            __builder.OpenElement(4, "p");
            __builder.AddContent(5, "Lets add 2 + 2 = ");
            __builder.AddContent(6, 
#nullable restore
#line 6 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Index.razor"
                      2 + 2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Index.razor"
                   WriteInLog

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "CLICK ME");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenElement(12, "div");
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.AddMarkupContent(14, "<h3>Movies:</h3>\r\n");
#nullable restore
#line 12 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Index.razor"
     foreach (var movie in movies)
    {


#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "        ");
            __builder.OpenElement(16, "p");
            __builder.AddContent(17, "Title: ");
            __builder.OpenElement(18, "b");
            __builder.AddContent(19, 
#nullable restore
#line 15 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Index.razor"
                      movie.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "p");
            __builder.AddContent(22, "Release Date: ");
            __builder.OpenElement(23, "b");
            __builder.AddContent(24, 
#nullable restore
#line 16 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Index.razor"
                             movie.RealeaseDate.ToString("dd MMM yyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 17 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 19 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Index.razor"
     for (var i = 0; i < movies.Count; i++)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "style", "background-color:" + " " + (
#nullable restore
#line 21 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Index.razor"
                                        i % 2 == 0 ? "blue" : "red"

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "p");
            __builder.AddContent(32, " ");
            __builder.AddContent(33, 
#nullable restore
#line 22 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Index.razor"
                  i + 1

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(34, ") Title:");
            __builder.AddContent(35, 
#nullable restore
#line 22 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Index.razor"
                                  (MarkupString) movies[i].Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "p");
            __builder.AddContent(38, "Release Date: ");
            __builder.OpenElement(39, "b");
            __builder.AddContent(40, 
#nullable restore
#line 23 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Index.razor"
                                 movies[i].RealeaseDate.ToString("dd MMM yyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 25 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Index.razor"
      
    string name = "Justin";

    List<Movie> movies;

    protected override void OnInitialized()
    {
        movies = new List<Movie>()
{
            new Movie(){Title = "<b>Jumanji</b>", RealeaseDate = new DateTime(2019,2,2)},
              new Movie(){Title = "<i>Jurrasic Park</i>", RealeaseDate = new DateTime(2013,2,2)},
                new Movie(){Title = "Jaws", RealeaseDate = new DateTime(1987,2,2)},

        };
    }

    BlazorMovies.Shared.Entities.Movie fearandloathing = new BlazorMovies.Shared.Entities.Movie()
    {
        Title = "Fear and Loathing in Las Vegas",
        RealeaseDate = new DateTime(2017, 7, 2)
    };


    string CustomToUpper(string value) => value.ToUpper();

    void WriteInLog()
    {

        Console.WriteLine("Ive been clicked in app");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
