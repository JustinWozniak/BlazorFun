#pragma checksum "C:\Users\Rocka\Desktop\BlazorMovies-master\ASP.NET Core 3.2\Module 7 - Security\End\BlazorMovies\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c944608a2ba6102bd68b8528d8e531155fc36175"
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
#line 1 "C:\Users\Rocka\Desktop\BlazorMovies-master\ASP.NET Core 3.2\Module 7 - Security\End\BlazorMovies\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rocka\Desktop\BlazorMovies-master\ASP.NET Core 3.2\Module 7 - Security\End\BlazorMovies\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Rocka\Desktop\BlazorMovies-master\ASP.NET Core 3.2\Module 7 - Security\End\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Rocka\Desktop\BlazorMovies-master\ASP.NET Core 3.2\Module 7 - Security\End\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Rocka\Desktop\BlazorMovies-master\ASP.NET Core 3.2\Module 7 - Security\End\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Rocka\Desktop\BlazorMovies-master\ASP.NET Core 3.2\Module 7 - Security\End\BlazorMovies\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Rocka\Desktop\BlazorMovies-master\ASP.NET Core 3.2\Module 7 - Security\End\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Rocka\Desktop\BlazorMovies-master\ASP.NET Core 3.2\Module 7 - Security\End\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Rocka\Desktop\BlazorMovies-master\ASP.NET Core 3.2\Module 7 - Security\End\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Rocka\Desktop\BlazorMovies-master\ASP.NET Core 3.2\Module 7 - Security\End\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Rocka\Desktop\BlazorMovies-master\ASP.NET Core 3.2\Module 7 - Security\End\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Rocka\Desktop\BlazorMovies-master\ASP.NET Core 3.2\Module 7 - Security\End\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Rocka\Desktop\BlazorMovies-master\ASP.NET Core 3.2\Module 7 - Security\End\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Rocka\Desktop\BlazorMovies-master\ASP.NET Core 3.2\Module 7 - Security\End\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddMarkupContent(1, "\n    ");
            __builder.AddMarkupContent(2, "<h3>In theaters</h3>\n    ");
            __builder.OpenComponent<BlazorMovies.Client.Shared.MoviesList>(3);
            __builder.AddAttribute(4, "Movies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorMovies.Shared.Entities.Movie>>(
#nullable restore
#line 9 "C:\Users\Rocka\Desktop\BlazorMovies-master\ASP.NET Core 3.2\Module 7 - Security\End\BlazorMovies\Client\Pages\Index.razor"
                        InTheaters

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n\n");
            __builder.OpenElement(7, "div");
            __builder.AddMarkupContent(8, "\n    ");
            __builder.AddMarkupContent(9, "<h3>Upcoming Releases</h3>\n    ");
            __builder.OpenComponent<BlazorMovies.Client.Shared.MoviesList>(10);
            __builder.AddAttribute(11, "Movies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorMovies.Shared.Entities.Movie>>(
#nullable restore
#line 14 "C:\Users\Rocka\Desktop\BlazorMovies-master\ASP.NET Core 3.2\Module 7 - Security\End\BlazorMovies\Client\Pages\Index.razor"
                        UpcomingReleases

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(12, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\Rocka\Desktop\BlazorMovies-master\ASP.NET Core 3.2\Module 7 - Security\End\BlazorMovies\Client\Pages\Index.razor"
      
    private List<Movie> InTheaters;
    private List<Movie> UpcomingReleases;
    protected async override Task OnInitializedAsync()
    {
        var response = await moviesRepository.GetIndexPageDTO();
        InTheaters = response.Intheaters;
        UpcomingReleases = response.UpcomingReleases;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMoviesRepository moviesRepository { get; set; }
    }
}
#pragma warning restore 1591
