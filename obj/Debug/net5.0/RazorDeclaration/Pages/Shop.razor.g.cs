// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorProjectDemo.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Rahul\Rahul\Demo Project\BlazorProjectDemo\BlazorProjectDemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Rahul\Rahul\Demo Project\BlazorProjectDemo\BlazorProjectDemo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Rahul\Rahul\Demo Project\BlazorProjectDemo\BlazorProjectDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Rahul\Rahul\Demo Project\BlazorProjectDemo\BlazorProjectDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Rahul\Rahul\Demo Project\BlazorProjectDemo\BlazorProjectDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Rahul\Rahul\Demo Project\BlazorProjectDemo\BlazorProjectDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Rahul\Rahul\Demo Project\BlazorProjectDemo\BlazorProjectDemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Rahul\Rahul\Demo Project\BlazorProjectDemo\BlazorProjectDemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Rahul\Rahul\Demo Project\BlazorProjectDemo\BlazorProjectDemo\_Imports.razor"
using BlazorProjectDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Rahul\Rahul\Demo Project\BlazorProjectDemo\BlazorProjectDemo\_Imports.razor"
using BlazorProjectDemo.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/shop/{id}")]
    public partial class Shop : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "F:\Rahul\Rahul\Demo Project\BlazorProjectDemo\BlazorProjectDemo\Pages\Shop.razor"
       

    [Parameter]
    public string Id { get; set; }

    private Data.Shop shop = new Data.Shop();

    protected override void OnInitialized()
    {
        if (!String.IsNullOrWhiteSpace(Id) & Id == "0")
        {
            shop = new Data.Shop();
        }
        else
        {
            shop = ShopService.Getshop(Guid.Parse(Id));
        }
    }

    private void SubmitForm()
    {
        if (shop.Id == Guid.Empty)
        {
            ShopService.AddShop(shop);
        }
        else
        {
            ShopService.UpdateShop(shop);
        }
        Navigation.NavigateTo("shops");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private BlazorProjectDemo.Data.IShopService ShopService { get; set; }
    }
}
#pragma warning restore 1591
