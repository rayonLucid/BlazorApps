// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Club_Portal.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\_Imports.razor"
using Club_Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\_Imports.razor"
using Club_Portal.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Users.razor"
using Club_Portal.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Users")]
    public partial class Users : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Users.razor"
       
      [Inject] IJSRuntime JSRuntime { get; set; }
    IEnumerable<ClubInformation> Clubs { get; set; }
    string userResult =string.Empty  ;
    UserInformation user = new UserInformation();
    public async void SaveUser(UserInformation loginuser)
    {
        if(loginuser.UserName.Length >0 && loginuser.Password.Length >0  ){
            userResult = userService.AddUser(loginuser);

            if(!string.IsNullOrEmpty(userResult) && userResult=="Successfull"){ 
               await JSRuntime.InvokeVoidAsync("alert","Record Successfully Created"); 
            }
            else
            {
                await JSRuntime.InvokeVoidAsync("alert",userResult);
            }
        }
    }

    protected async override Task OnInitializedAsync()
    {
        Clubs =   await Task.Run(()=> userService.GetAllClubs());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService userService { get; set; }
    }
}
#pragma warning restore 1591
