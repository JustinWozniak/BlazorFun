#pragma checksum "C:\Users\Rocka\Desktop\BlazorMovies-master\ASP.NET Core 3.2\Module 7 - Security\End\BlazorMovies\Client\Pages\Auth\Logout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a131211afc45cd4b535051188770b33eec7bc2ec"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorMovies.Client.Pages.Auth
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
#nullable restore
#line 6 "C:\Users\Rocka\Desktop\BlazorMovies-master\ASP.NET Core 3.2\Module 7 - Security\End\BlazorMovies\Client\Pages\Auth\Logout.razor"
using BlazorMovies.Client.Auth;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/logout")]
    public partial class Logout : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\Rocka\Desktop\BlazorMovies-master\ASP.NET Core 3.2\Module 7 - Security\End\BlazorMovies\Client\Pages\Auth\Logout.razor"
      
    protected async override Task OnInitializedAsync()
    {
        await loginService.Logout();
        navigationManager.NavigateTo("");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILoginService loginService { get; set; }
    }
}
#pragma warning restore 1591
