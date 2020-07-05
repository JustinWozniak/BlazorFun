#pragma checksum "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\EditPerson.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80f7297c649a2c18d09fb82384ed755316fcd19b"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages.People
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/person/edit/{PersonId:int}")]
    public partial class EditPerson : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit Person</h3>\n\n");
#nullable restore
#line 5 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\EditPerson.razor"
 if (Person != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.OpenComponent<BlazorMovies.Client.Pages.People.PersonForm>(2);
            __builder.AddAttribute(3, "Person", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorMovies.Shared.Entities.Person>(
#nullable restore
#line 7 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\EditPerson.razor"
                        Person

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 7 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\EditPerson.razor"
                                               Edit

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\n");
#nullable restore
#line 8 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\EditPerson.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\Rocka\source\repos\BlazorMovies\BlazorMovies\Client\Pages\People\EditPerson.razor"
       
    [Parameter] public int PersonId { get; set; }

    Person Person;

    protected override void OnInitialized()
    {
        Person = new Person() { Name = "Felipe", DateOfBirth = DateTime.Today, Biography = "something" };
    }

    private void Edit()
    {
        Console.WriteLine("editing the person...");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
