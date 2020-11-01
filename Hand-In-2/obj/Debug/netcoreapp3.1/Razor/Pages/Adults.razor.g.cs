#pragma checksum "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af84bdca98a2fd0ba883dd1406085a94de8967ce"
// <auto-generated/>
#pragma warning disable 1591
namespace Hand_In_2.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\_Imports.razor"
using Hand_In_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\_Imports.razor"
using Hand_In_2.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\Adults.razor"
using Hand_In_2.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\Adults.razor"
using Hand_In_2.Data.Impl;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\Adults.razor"
using Hand_In_2.Data.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Adults</h3>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n    Filter by user First Name: ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 10 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\Adults.razor"
                                                              (arg) => FilterByFirstName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "width: 50px");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "p");
            __builder.AddMarkupContent(10, "\r\n    Filter by user Last Name: ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 13 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\Adults.razor"
                                                             (arg) => FilterByLastName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "style", "width: 50px");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
            __builder.OpenElement(17, "p");
            __builder.AddMarkupContent(18, "\r\n    Input min age : ");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "type", "text");
            __builder.AddAttribute(21, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 16 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\Adults.razor"
                                                   (arg) => FilteredByMinAge(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "style", "width: 50px");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n");
            __builder.OpenElement(25, "table");
            __builder.AddAttribute(26, "class", "table");
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.AddMarkupContent(28, @"<thead>
    <tr>
        <th>First Name</th>
        <th>Last Name</th>
        <th>Hair color</th>
        <th>Eye color</th>
        <th>Age</th>
        <th>Weight</th>
        <th>Height</th>
        <th>Sex</th>
        <th>JobTitle</th>
    </tr>
    </thead>
    ");
            __builder.OpenElement(29, "tbody");
            __builder.AddMarkupContent(30, "\r\n");
#nullable restore
#line 33 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\Adults.razor"
     foreach (var item in adults)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(31, "        ");
            __builder.OpenElement(32, "tr");
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "td");
            __builder.AddContent(35, 
#nullable restore
#line 36 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\Adults.razor"
                 item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "td");
            __builder.AddContent(38, 
#nullable restore
#line 37 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\Adults.razor"
                 item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 38 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\Adults.razor"
                 item.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 39 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\Adults.razor"
                 item.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n            ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 40 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\Adults.razor"
                 item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.OpenElement(49, "td");
            __builder.AddContent(50, 
#nullable restore
#line 41 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\Adults.razor"
                 item.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.OpenElement(52, "td");
            __builder.AddContent(53, 
#nullable restore
#line 42 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\Adults.razor"
                 item.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n            ");
            __builder.OpenElement(55, "td");
            __builder.AddContent(56, 
#nullable restore
#line 43 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\Adults.razor"
                 item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.OpenElement(58, "td");
            __builder.AddContent(59, 
#nullable restore
#line 44 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\Adults.razor"
                 item.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n            ");
            __builder.OpenElement(61, "td");
            __builder.AddMarkupContent(62, "\r\n                ");
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\Adults.razor"
                                    () => RemoveAdult(item.FirstName, item.LastName)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(65, "\r\n                    <i class=\"oi oi-trash\" style=\"color: red\"></i>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.OpenElement(68, "td");
            __builder.AddMarkupContent(69, "\r\n                ");
            __builder.OpenElement(70, "button");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\Adults.razor"
                                    () => UpdateAdult(item.FirstName, item.LastName)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(72, "\r\n                    Update\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n");
#nullable restore
#line 56 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\Adults.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(76, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\Adults.razor"
       
    private IList<Adult> adults = new List<Adult>();
    private string filterByFirstName = "", filterByLastName = "", filterByMinaAge = "";

    protected override async Task OnInitializedAsync()
    {
        try
        {
            adults = await AdultsService.getAllAdults();
            
        }
        catch (Exception ex)
        {
            Console.WriteLine("Shit happened here");
        }
       
    }

    private async Task RemoveAdult(string firstName, string lastName)
    {
      
        await AdultsService.removeAdult(firstName, lastName);
        adults = await AdultsService.getAllAdults();
    }

    private async Task UpdateAdult(string firstName, string lastName)
    {
        AppDataToUpdateAdult.adult = adults.First(t => t.FirstName.Equals(firstName) && t.LastName.Equals(lastName));
        NavigationManager.NavigateTo("/updateAdult");
    }

    private async Task FilterByFirstName(ChangeEventArgs changeEventArgs)
    {
        filterByFirstName = changeEventArgs.Value.ToString();
        await ExecuteFilter();
    }

    private async Task ExecuteFilter()
    {

        if (int.TryParse(filterByMinaAge, out int i))
        {
            IList<Adult> all = await AdultsService.getAllAdults();
            adults = all.Where((t => t.FirstName.StartsWith(filterByFirstName, StringComparison.OrdinalIgnoreCase) && (t.LastName.StartsWith(filterByLastName, StringComparison.OrdinalIgnoreCase) && (t.Age >= Int32.Parse(filterByMinaAge))))).ToList();
        }
        
        else
        {
            IList<Adult> all = await AdultsService.getAllAdults();
            adults = all.Where((t => t.FirstName.StartsWith(filterByFirstName, StringComparison.OrdinalIgnoreCase) && (t.LastName.StartsWith(filterByLastName, StringComparison.OrdinalIgnoreCase)))).ToList();

        }
    }

    private async Task FilterByLastName(ChangeEventArgs changeEventArgs)
    {
        filterByLastName = changeEventArgs.Value.ToString();
        await ExecuteFilter();
    }
    

    private async Task FilteredByMinAge(ChangeEventArgs changeEventArgs)
    {
        filterByMinaAge = changeEventArgs.Value.ToString();   
       await ExecuteFilter();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AppDataToUpdateAdult AppDataToUpdateAdult { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultsService AdultsService { get; set; }
    }
}
#pragma warning restore 1591
