#pragma checksum "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieFilter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a49aafdb09a11be697c8ed8abbf2ecdfcedf426"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/movies/search")]
    public partial class MovieFilter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Search Movies</h3>\n\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-inline");
            __builder.AddMarkupContent(3, "\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group mb-2");
            __builder.AddMarkupContent(6, "\n        ");
            __builder.AddMarkupContent(7, "<label for=\"title\" class=\"sr-only\">Title</label>\n        ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "text");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "id", "title");
            __builder.AddAttribute(12, "placeholder", "Movie Title");
            __builder.AddAttribute(13, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                              (KeyboardEventArgs e) => TitleKeyPress(e)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 10 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                            title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => title = __value, title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "form-group mx-sm-3 mb-2");
            __builder.AddMarkupContent(20, "\n        ");
            __builder.OpenElement(21, "select");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                                            selectedGenre

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => selectedGenre = __value, selectedGenre));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(25, "\n            ");
            __builder.OpenElement(26, "option");
            __builder.AddAttribute(27, "value", "0");
            __builder.AddMarkupContent(28, "\n                --Select a Genre--\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n");
#nullable restore
#line 18 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
             foreach (var genre in Genres)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(30, "                ");
            __builder.OpenElement(31, "option");
            __builder.AddAttribute(32, "value", 
#nullable restore
#line 20 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                                genre.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(33, 
#nullable restore
#line 20 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                                           genre.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\n");
#nullable restore
#line 21 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(35, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\n    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "form-group mx-sm-3 mb-2");
            __builder.AddMarkupContent(40, "\n        ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "checkbox");
            __builder.AddAttribute(43, "class", "form-check-input");
            __builder.AddAttribute(44, "id", "upcomingReleases");
            __builder.AddAttribute(45, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                                                                                     upcomingReleases

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => upcomingReleases = __value, upcomingReleases));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\n        ");
            __builder.AddMarkupContent(48, "<label class=\"form-check-label\" for=\"upcomingReleases\">\n            Upcoming Releases\n        </label>\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\n    ");
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "form-group mx-sm-3 mb-2");
            __builder.AddMarkupContent(52, "\n        ");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "type", "checkbox");
            __builder.AddAttribute(55, "class", "form-check-input");
            __builder.AddAttribute(56, "id", "upcomingReleases");
            __builder.AddAttribute(57, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                                                                                     inTheaters

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => inTheaters = __value, inTheaters));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\n        ");
            __builder.AddMarkupContent(60, "<label class=\"form-check-label\" for=\"inTheaters\">\n            In Theaters\n        </label>\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\n\n    ");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "type", "button");
            __builder.AddAttribute(64, "class", "btn btn-primary mb-2 mx-sm-3");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                                                                         SearchForMovies

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(66, "Filter");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\n    ");
            __builder.OpenElement(68, "button");
            __builder.AddAttribute(69, "type", "button");
            __builder.AddAttribute(70, "class", "btn btn-danger mb-2");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                                                                Clear

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(72, "Clear");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\n\n");
            __builder.OpenComponent<BlazorMovies.Client.Shared.MoviesList>(75);
            __builder.AddAttribute(76, "Movies", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorMovies.Shared.Entities.Movie>>(
#nullable restore
#line 41 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
                    Movies

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\Movies\MovieFilter.razor"
       
    private List<Movie> Movies;
    string title = "";
    string selectedGenre = "0";
    bool upcomingReleases = false;
    bool inTheaters = false;
    private List<Genre> Genres = new List<Genre>() { new Genre() { Id = 1, Name = "Action"},
    new Genre(){Id = 2, Name = "Comedy"}};

    protected override void OnInitialized()
    {
        Movies = repository.GetMovies();
    }

    private void SearchForMovies()
    {
        Movies = repository.GetMovies().Where(x => x.Title.Contains(title)).ToList();
        Console.WriteLine($"title: {title}");
        Console.WriteLine($"selectedGenre: {selectedGenre}");
        Console.WriteLine($"upcomingReleases: {upcomingReleases}");
        Console.WriteLine($"inTheaters: {inTheaters}");
    }

    private void Clear()
    {
        Movies = repository.GetMovies();
        title = "";
        selectedGenre = "0";
        upcomingReleases = false;
        inTheaters = false;
    }

    private void TitleKeyPress(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            SearchForMovies();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository repository { get; set; }
    }
}
#pragma warning restore 1591