#pragma checksum "D:\proof of concept\SEP3 - tier 1\Pages\MyProfile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c72737a3345b415ddaf1d56f2a7f9a7b9eb95d48"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebApplication7.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\proof of concept\SEP3 - tier 1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\proof of concept\SEP3 - tier 1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\proof of concept\SEP3 - tier 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\proof of concept\SEP3 - tier 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\proof of concept\SEP3 - tier 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\proof of concept\SEP3 - tier 1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\proof of concept\SEP3 - tier 1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\proof of concept\SEP3 - tier 1\_Imports.razor"
using WebApplication7;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\proof of concept\SEP3 - tier 1\_Imports.razor"
using WebApplication7.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\proof of concept\SEP3 - tier 1\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\proof of concept\SEP3 - tier 1\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\proof of concept\SEP3 - tier 1\Pages\MyProfile.razor"
using WebApplication7.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\proof of concept\SEP3 - tier 1\Pages\MyProfile.razor"
using WebApplication7.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\proof of concept\SEP3 - tier 1\Pages\MyProfile.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\proof of concept\SEP3 - tier 1\Pages\MyProfile.razor"
using WebApplication7.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\proof of concept\SEP3 - tier 1\_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MyProfile")]
    public partial class MyProfile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 83 "D:\proof of concept\SEP3 - tier 1\Pages\MyProfile.razor"
       
    private User _user;
    private string _password = "";
    private string _oldUserName = "";
    
    protected override async Task OnInitializedAsync()
    {
        _user = await ((CustomAuthenticationStateProvider) Authentication).GetCachedUser();
        _oldUserName = _user.Name;
    }

     private void Submit()
     {
         UserService.PutUser(_user, _oldUserName);
         new Thread(() => {
                              Thread.Sleep(100);
                              if (!string.IsNullOrWhiteSpace(_password))
                                  UserService.UpdatePw(new UserPw(_user.Name, _password));
         }).Start();
         NavigationManager.NavigateTo("/Home");
     }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime Js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider Authentication { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
    }
}
#pragma warning restore 1591
