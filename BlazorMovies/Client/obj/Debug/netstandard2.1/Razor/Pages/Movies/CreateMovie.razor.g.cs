#pragma checksum "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\CreateMovie.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efe61a40bfc64772b7fdaedd7394ac6369ad31d6"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages.Movies
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
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.DTOs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/create")]
    public partial class CreateMovie : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Create Movie</h3>\n\n");
#nullable restore
#line 8 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\CreateMovie.razor"
 if (NotSelectedGenres != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<BlazorMovies.Client.Pages.Movies.MovieForm>(2);
            __builder.AddAttribute(3, "Movie", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorMovies.Shared.Entities.Movie>(
#nullable restore
#line 10 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\CreateMovie.razor"
                      Movie

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 10 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\CreateMovie.razor"
                                            SaveMovie

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "NotSelectedGenres", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorMovies.Shared.Entities.Genre>>(
#nullable restore
#line 10 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\CreateMovie.razor"
                                                                          NotSelectedGenres

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\n");
#nullable restore
#line 11 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\CreateMovie.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\CreateMovie.razor"
       

    private Movie Movie = new Movie();

    protected async override Task OnInitializedAsync()
    {
        NotSelectedGenres = await gengeRepository.GetGenres();
    }

    private List<Genre> NotSelectedGenres;

    private async Task SaveMovie()
    {
        try
        {
            var movieId = await moviesRepository.CreateMovie(Movie);
            navigationManager.NavigateTo($"movie/{movieId}/{Movie.Title.Replace(" ", "-")}");
        }
        catch (Exception ex)
        {

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGenreRepository gengeRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMoviesRepository moviesRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
    }
}
#pragma warning restore 1591
