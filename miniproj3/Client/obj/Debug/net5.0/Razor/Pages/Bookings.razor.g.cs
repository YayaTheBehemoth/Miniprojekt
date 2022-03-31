#pragma checksum "/Users/placeholder/Projects/miniproj3/miniproj3/Client/Pages/Bookings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a941e2735067b6728ee4c8098a5e0496252adf89"
// <auto-generated/>
#pragma warning disable 1591
namespace miniproj3.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/placeholder/Projects/miniproj3/miniproj3/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/placeholder/Projects/miniproj3/miniproj3/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/placeholder/Projects/miniproj3/miniproj3/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/placeholder/Projects/miniproj3/miniproj3/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/placeholder/Projects/miniproj3/miniproj3/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/placeholder/Projects/miniproj3/miniproj3/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/placeholder/Projects/miniproj3/miniproj3/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/placeholder/Projects/miniproj3/miniproj3/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/placeholder/Projects/miniproj3/miniproj3/Client/_Imports.razor"
using miniproj3.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/placeholder/Projects/miniproj3/miniproj3/Client/_Imports.razor"
using miniproj3.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/placeholder/Projects/miniproj3/miniproj3/Client/_Imports.razor"
using Syncfusion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/placeholder/Projects/miniproj3/miniproj3/Client/Pages/Bookings.razor"
using miniproj3.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Bookings")]
    public partial class Bookings : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 24 "/Users/placeholder/Projects/miniproj3/miniproj3/Client/Pages/Bookings.razor"
         if (shelters == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>the end is closer than you think</em></p>");
#nullable restore
#line 27 "/Users/placeholder/Projects/miniproj3/miniproj3/Client/Pages/Bookings.razor"
        }
        else
        {




#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-responsive");
            __builder.AddMarkupContent(3, @"<thead><tr><th>Id</th>
                        <th>Type</th>
                        <th>
                            Edit
                        </th>
                        <th>
                            Delete
                        </th></tr></thead>
                ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 47 "/Users/placeholder/Projects/miniproj3/miniproj3/Client/Pages/Bookings.razor"
                     foreach (var shelter in shelters)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
            __builder.AddContent(7, 
#nullable restore
#line 50 "/Users/placeholder/Projects/miniproj3/miniproj3/Client/Pages/Bookings.razor"
                             shelter.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n                        ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 51 "/Users/placeholder/Projects/miniproj3/miniproj3/Client/Pages/Bookings.razor"
                             shelter.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n                        ");
            __builder.OpenElement(12, "td");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "class", "btn btn-sm btn-primary");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "/Users/placeholder/Projects/miniproj3/miniproj3/Client/Pages/Bookings.razor"
                                                                               ()=>GetShelter(@shelter.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(16, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                        ");
            __builder.OpenElement(18, "td");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "class", "btn btn-sm btn-primary");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 56 "/Users/placeholder/Projects/miniproj3/miniproj3/Client/Pages/Bookings.razor"
                                                                               ()=>DeleteShelter(@shelter.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(22, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "/Users/placeholder/Projects/miniproj3/miniproj3/Client/Pages/Bookings.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 62 "/Users/placeholder/Projects/miniproj3/miniproj3/Client/Pages/Bookings.razor"

        }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "/Users/placeholder/Projects/miniproj3/miniproj3/Client/Pages/Bookings.razor"
       
    private Booking[] shelters;
    
    private bool edit = false;
    private Booking Booking = new Booking();
    
    protected override async Task OnInitializedAsync()
    {
        shelters = await Http.GetFromJsonAsync<Booking[]>("api/shelter");
    }

    private async Task DeleteShelter(string id)
    {
        await Http.DeleteAsync("api/shelter" + id);
        await OnInitializedAsync();
    }
    
    private async Task GetShelter(string id)
    {
        Booking = await Http.GetFromJsonAsync<Booking>("api/shelter" + id);
        edit = true;
    }
    private async Task SubmitShelter()
    {
        if (edit == false)
        {
            await Http.PostAsJsonAsync<Booking>("api/shelter", Booking);
            await OnInitializedAsync();
            Booking = new Booking();

        }
        else
        {
            await Http.PutAsJsonAsync<Booking>("api/shelter" + Booking.Id, Booking);
            Booking = new Booking();
            edit = false;
            await OnInitializedAsync();
        }
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
