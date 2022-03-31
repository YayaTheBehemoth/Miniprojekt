// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
