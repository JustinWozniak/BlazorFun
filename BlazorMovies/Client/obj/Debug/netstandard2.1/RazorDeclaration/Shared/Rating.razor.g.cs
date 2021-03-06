#pragma checksum "C:\Users\Rocka\Desktop\BlazorMovies-master\ASP.NET Core 3.2\Module 7 - Security\End\BlazorMovies\Client\Shared\Rating.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45efe05fbe89345046263cc622489f02d92642cf"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorMovies.Client.Shared
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
    public partial class Rating : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\Rocka\Desktop\BlazorMovies-master\ASP.NET Core 3.2\Module 7 - Security\End\BlazorMovies\Client\Shared\Rating.razor"
       
    [Parameter] public int MaximumRating { get; set; }
    [Parameter] public int SelectedRating { get; set; }
    [Parameter] public EventCallback<int> OnVote { get; set; }
    [CascadingParameter] public Task<AuthenticationState> AuthenticationState { get; set; }

    private bool voted = false;

    private async Task onclickHandle(int starNumber)
    {
        var authState = await AuthenticationState;
        var user = authState.User;

        if (!user.Identity.IsAuthenticated)
        {
            await displayMessage.DisplayErrorMessage("You must login in order to vote");
            return;
        }

        SelectedRating = starNumber;
        voted = true;
        await OnVote.InvokeAsync(SelectedRating);
    }

    private void onmouseoverHandle(int starNumber)
    {
        if (!voted)
        {
            SelectedRating = starNumber;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDisplayMessage displayMessage { get; set; }
    }
}
#pragma warning restore 1591
