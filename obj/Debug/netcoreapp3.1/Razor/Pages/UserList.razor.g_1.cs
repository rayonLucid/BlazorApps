#pragma checksum "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\UserList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb1178ec34df4dd3caaee78f62317cd39943c86c"
// <auto-generated/>
#pragma warning disable 1591
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
#line 10 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\_Imports.razor"
using Microsoft.AspNetCore.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\UserList.razor"
using Club_Portal.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/UserList")]
    public partial class UserList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "form-group");
            __builder.AddMarkupContent(2, "\r\n   ");
            __builder.AddMarkupContent(3, "<h4>User List</h4>\r\n    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table table-hover table-light");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, @"<thead class=""bg-primary"">
            <tr>
                <th>Name</th>
             
            
                <th>Address</th>
            
                <th>Phone Number</th>
           
               <th>E-mail</th>
            
             <th>Is Active</th>
              <th></th>
               <th></th>
            </tr>
        </thead>
        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 27 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\UserList.razor"
               foreach(var EachUser in userList)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n               \r\n                ");
            __builder.AddMarkupContent(13, "<td>EachUser.FirstName</td>\r\n            \r\n               \r\n                ");
            __builder.AddMarkupContent(14, "<td>EachUser.Address</td>\r\n           \r\n               \r\n                ");
            __builder.OpenElement(15, "td");
#nullable restore
#line 37 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\UserList.razor"
__builder.AddContent(16, user.PhoneNumber);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n           \r\n               \r\n                ");
            __builder.AddMarkupContent(18, "<td>EachUser.Email</td>\r\n           \r\n                \r\n                ");
            __builder.AddMarkupContent(19, "<td>EachUser.IsActive</td>\r\n                ");
            __builder.OpenElement(20, "td");
#nullable restore
#line 44 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\UserList.razor"
                      if (EachUser.FirstName!="Master") {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "type", "submit");
            __builder.AddAttribute(23, "value", "Delete");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\UserList.razor"
                                                                                                       (async () => await RemoveUser(EachUser.UserID))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "class", "btn btn-danger");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
#nullable restore
#line 45 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\UserList.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddContent(27, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "td");
            __builder.AddContent(30, "  ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "submit");
            __builder.AddAttribute(33, "value", "Cancel");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\UserList.razor"
                                                                    (() => Cancel())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "class", "btn btn-warning");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 49 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\UserList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(38, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.AddMarkupContent(42, "<div class=\"form-group\">\r\n   \r\n   \r\n</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\UserList.razor"
       
       [Inject] IJSRuntime JSRuntime { get; set; }
     UserInformation user = new UserInformation();
    IEnumerable<UserInformation> userList;
    protected override async Task OnInitializedAsync()
    {
        userList =  await Task.Run(()=> userService.GetAllUsers());
        
    }
    protected async Task RemoveUser(string userID)
    {
        bool deleted = false;
        deleted =  await Task.Run(()=> userService.DeleteUser(userID));
        if (deleted)
        {
              await JSRuntime.InvokeVoidAsync("alert","Record Successfully Deleted"); 
        }
        else
        {
              await JSRuntime.InvokeVoidAsync("alert","Record Not Deleted"); 
        }
    }
     void EditUser()
    {
        NavigationManager.NavigateTo("Users");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("Users");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserService userService { get; set; }
    }
}
#pragma warning restore 1591
