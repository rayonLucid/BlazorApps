#pragma checksum "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Users.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14089e38f5c1dd1bc60ce83ea0b38647779c32a1"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row form-group");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenElement(3, "ul");
            __builder.AddAttribute(4, "class", "nav flex-column");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.OpenElement(6, "li");
            __builder.AddAttribute(7, "class", "nav-item px-3");
            __builder.AddMarkupContent(8, "\r\n              ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(9);
            __builder.AddAttribute(10, "class", "nav-link");
            __builder.AddAttribute(11, "href", "UserList");
            __builder.AddAttribute(12, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 8 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Users.razor"
                                                               NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(14, "\r\n                <span class=\"oi  oi-list-rich\" aria-hidden=\"true\"></span> View User List\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(15, "\r\n           \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.AddMarkupContent(19, "<h3 class=\"text-center\">User\'s Information</h3>\r\n<hr class=\"text-black-50\" style=\"border-bottom:0.2em black solid;margin-bottom:0.5em\">\r\n");
            __builder.OpenElement(20, "form");
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "container-fluid");
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "row form-group");
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "col-md-6");
            __builder.AddMarkupContent(30, "\r\n                 ");
            __builder.AddMarkupContent(31, "<label>User ID</label>\r\n        ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "text");
            __builder.AddAttribute(34, "class", "form-control");
            __builder.AddAttribute(35, "id", "userID");
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Users.razor"
                                                                 user.UserID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.UserID = __value, user.UserID));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n               ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "col-md-6");
            __builder.AddMarkupContent(42, "\r\n                    ");
            __builder.AddMarkupContent(43, "<label>Club name</label>\r\n        ");
            __builder.OpenElement(44, "select");
            __builder.AddAttribute(45, "class", "form-control");
            __builder.AddAttribute(46, "id", "ClubID");
            __builder.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Users.razor"
                                                       user.ClubID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.ClubID = __value, user.ClubID));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(49, "option");
            __builder.AddContent(50, "--Select Club Name--");
            __builder.CloseElement();
            __builder.AddContent(51, " ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n               ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "row form-group");
            __builder.AddMarkupContent(57, "\r\n              ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "col-md-6");
            __builder.AddMarkupContent(60, "\r\n              ");
            __builder.AddMarkupContent(61, "<label>First name</label>\r\n        ");
            __builder.OpenElement(62, "input");
            __builder.AddAttribute(63, "type", "text");
            __builder.AddAttribute(64, "class", "form-control");
            __builder.AddAttribute(65, "id", "FirstName");
            __builder.AddAttribute(66, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Users.razor"
                                                                    user.FirstName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.FirstName = __value, user.FirstName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n          ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "col-md-6");
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.AddMarkupContent(73, "<label>Surname</label>\r\n        ");
            __builder.OpenElement(74, "input");
            __builder.AddAttribute(75, "type", "text");
            __builder.AddAttribute(76, "class", "form-control");
            __builder.AddAttribute(77, "id", "Surname");
            __builder.AddAttribute(78, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Users.razor"
                                                                  user.LastName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.LastName = __value, user.LastName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n              \r\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n         ");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "row form-group");
            __builder.AddMarkupContent(85, "\r\n              ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "col-md-6");
            __builder.AddMarkupContent(88, "\r\n                     ");
            __builder.AddMarkupContent(89, "<label>Email</label>\r\n        ");
            __builder.OpenElement(90, "input");
            __builder.AddAttribute(91, "type", "text");
            __builder.AddAttribute(92, "class", "form-control");
            __builder.AddAttribute(93, "id", "Email");
            __builder.AddAttribute(94, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Users.razor"
                                                                user.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(95, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Email = __value, user.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n             \r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n         ");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "col-md-6");
            __builder.AddMarkupContent(100, "\r\n               ");
            __builder.AddMarkupContent(101, "<label>Phone Number</label>\r\n        ");
            __builder.OpenElement(102, "input");
            __builder.AddAttribute(103, "type", "text");
            __builder.AddAttribute(104, "class", "form-control");
            __builder.AddAttribute(105, "id", "Phone");
            __builder.AddAttribute(106, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 49 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Users.razor"
                                                                user.PhoneNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(107, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.PhoneNumber = __value, user.PhoneNumber));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n         ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n         ");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "row form-group");
            __builder.AddMarkupContent(113, "\r\n              ");
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "col-md-6");
            __builder.AddMarkupContent(116, "\r\n                 ");
            __builder.AddMarkupContent(117, "<label>User name</label>\r\n        ");
            __builder.OpenElement(118, "input");
            __builder.AddAttribute(119, "type", "text");
            __builder.AddAttribute(120, "class", "form-control");
            __builder.AddAttribute(121, "id", "UserName");
            __builder.AddAttribute(122, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Users.razor"
                                                                   user.UserName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(123, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.UserName = __value, user.UserName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n             ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n             \r\n             ");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "col-md-6");
            __builder.AddMarkupContent(128, "\r\n                 ");
            __builder.AddMarkupContent(129, "<label>Password</label>\r\n        ");
            __builder.OpenElement(130, "input");
            __builder.AddAttribute(131, "type", "password");
            __builder.AddAttribute(132, "class", "form-control");
            __builder.AddAttribute(133, "id", "Password");
            __builder.AddAttribute(134, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 60 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Users.razor"
                                                                       user.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(135, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Password = __value, user.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(136, "\r\n             ");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n        ");
            __builder.OpenElement(139, "div");
            __builder.AddAttribute(140, "class", "row form-group");
            __builder.AddMarkupContent(141, "\r\n             ");
            __builder.OpenElement(142, "div");
            __builder.AddAttribute(143, "class", "col-md-6");
            __builder.AddMarkupContent(144, "\r\n               ");
            __builder.OpenElement(145, "label");
            __builder.AddContent(146, "Is Admin  ");
            __builder.OpenElement(147, "input");
            __builder.AddAttribute(148, "type", "checkbox");
            __builder.AddAttribute(149, "id", "isAdmin");
            __builder.AddAttribute(150, "style", "transform:scale(2);margin:1em 1em");
            __builder.AddAttribute(151, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 65 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Users.razor"
                                                                           user.IsAdmin

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(152, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.IsAdmin = __value, user.IsAdmin));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(153, "\r\n           ");
            __builder.CloseElement();
            __builder.AddMarkupContent(154, "\r\n            ");
            __builder.OpenElement(155, "div");
            __builder.AddAttribute(156, "class", "col-md-6");
            __builder.AddMarkupContent(157, "\r\n               ");
            __builder.OpenElement(158, "label");
            __builder.AddContent(159, "Is Active  ");
            __builder.OpenElement(160, "input");
            __builder.AddAttribute(161, "type", "checkbox");
            __builder.AddAttribute(162, "id", "isActive");
            __builder.AddAttribute(163, "style", "transform:scale(2);margin:1em 1em");
            __builder.AddAttribute(164, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 68 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Users.razor"
                                                                             user.IsActive

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(165, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.IsActive = __value, user.IsActive));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(166, "\r\n           ");
            __builder.CloseElement();
            __builder.AddMarkupContent(167, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n         ");
            __builder.OpenElement(169, "div");
            __builder.AddAttribute(170, "class", "row form-group");
            __builder.AddMarkupContent(171, "\r\n             ");
            __builder.OpenElement(172, "button");
            __builder.AddAttribute(173, "type", "button");
            __builder.AddAttribute(174, "class", "btn btn-block btn-primary");
            __builder.AddAttribute(175, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Users.razor"
                                                                               () =>SaveUser(user)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(176, "Save User");
            __builder.CloseElement();
            __builder.AddMarkupContent(177, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(178, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(179, "\r\n");
            __builder.CloseElement();
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
