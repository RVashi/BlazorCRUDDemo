#pragma checksum "F:\Rahul\Rahul\Demo Project\BlazorProjectDemo\BlazorProjectDemo\Pages\Shop.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebba645cf7212eecb29fb650195edea91f00d90a"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h3>Edit Shop</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 7 "F:\Rahul\Rahul\Demo Project\BlazorProjectDemo\BlazorProjectDemo\Pages\Shop.razor"
                 shop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "F:\Rahul\Rahul\Demo Project\BlazorProjectDemo\BlazorProjectDemo\Pages\Shop.razor"
                                  SubmitForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "form-group");
                __builder2.AddMarkupContent(7, "<label>Id</label>\r\n        ");
                __builder2.OpenElement(8, "input");
                __builder2.AddAttribute(9, "id", "Id");
                __builder2.AddAttribute(10, "class", "form-control");
                __builder2.AddAttribute(11, "value", 
#nullable restore
#line 10 "F:\Rahul\Rahul\Demo Project\BlazorProjectDemo\BlazorProjectDemo\Pages\Shop.razor"
                                                    shop.Id

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(12, "readonly");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(13, "\r\n    ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.AddMarkupContent(16, "<label>Name</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(17);
                __builder2.AddAttribute(18, "id", "shopName");
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "name", "shopName");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "F:\Rahul\Rahul\Demo Project\BlazorProjectDemo\BlazorProjectDemo\Pages\Shop.razor"
                                                                                    shop.ShopName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => shop.ShopName = __value, shop.ShopName))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => shop.ShopName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n    ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group");
                __builder2.AddMarkupContent(27, "<label>Address</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(28);
                __builder2.AddAttribute(29, "id", "address");
                __builder2.AddAttribute(30, "class", "form-control");
                __builder2.AddAttribute(31, "name", "address");
                __builder2.AddAttribute(32, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "F:\Rahul\Rahul\Demo Project\BlazorProjectDemo\BlazorProjectDemo\Pages\Shop.razor"
                                                                                  shop.Address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => shop.Address = __value, shop.Address))));
                __builder2.AddAttribute(34, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => shop.Address));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "form-group");
                __builder2.AddMarkupContent(38, "<label>ZipCode</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "id", "zipCode");
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "name", "zipCode");
                __builder2.AddAttribute(43, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "F:\Rahul\Rahul\Demo Project\BlazorProjectDemo\BlazorProjectDemo\Pages\Shop.razor"
                                                                                  shop.ZipCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => shop.ZipCode = __value, shop.ZipCode))));
                __builder2.AddAttribute(45, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => shop.ZipCode));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n    ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "form-group");
                __builder2.AddMarkupContent(49, "<label>Location</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(50);
                __builder2.AddAttribute(51, "id", "location");
                __builder2.AddAttribute(52, "class", "form-control");
                __builder2.AddAttribute(53, "name", "location");
                __builder2.AddAttribute(54, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 26 "F:\Rahul\Rahul\Demo Project\BlazorProjectDemo\BlazorProjectDemo\Pages\Shop.razor"
                                                                                    shop.Location

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => shop.Location = __value, shop.Location))));
                __builder2.AddAttribute(56, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => shop.Location));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n    ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group");
                __builder2.AddMarkupContent(60, "<label>CountryName</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(61);
                __builder2.AddAttribute(62, "id", "countryName");
                __builder2.AddAttribute(63, "class", "form-control");
                __builder2.AddAttribute(64, "name", "countryName");
                __builder2.AddAttribute(65, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "F:\Rahul\Rahul\Demo Project\BlazorProjectDemo\BlazorProjectDemo\Pages\Shop.razor"
                                                                                          shop.CountryName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(66, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => shop.CountryName = __value, shop.CountryName))));
                __builder2.AddAttribute(67, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => shop.CountryName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n    ");
                __builder2.AddMarkupContent(69, "<div class=\"form-group\"><button type=\"submit\" class=\"btn btn-primary\">Update</button></div>");
            }
            ));
            __builder.CloseComponent();
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