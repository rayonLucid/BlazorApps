#pragma checksum "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dba34c9ec5acf66f2fdab880d9f50a4ff65af97"
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
#line 2 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Login.razor"
using Club_Portal.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(NewLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "form");
            __builder.AddMarkupContent(1, "\r\n        ");
            __builder.OpenElement(2, "section");
            __builder.AddAttribute(3, "class", "vh-100");
            __builder.AddMarkupContent(4, "\r\n            ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container py-5 h-100");
            __builder.AddMarkupContent(7, "\r\n                ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row d-flex justify-content-center align-items-center h-100");
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-12 col-md-8 col-lg-6 col-xl-5");
            __builder.AddMarkupContent(13, "\r\n                        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "card bg-dark text-white");
            __builder.AddAttribute(16, "style", "border-radius: 1rem;");
            __builder.AddMarkupContent(17, "\r\n                            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "card-body p-5 text-center");
            __builder.AddMarkupContent(20, "\r\n\r\n                                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "mb-md-5 mt-md-4 pb-5");
            __builder.AddMarkupContent(23, "\r\n\r\n                                    ");
            __builder.AddMarkupContent(24, "<h2 class=\"fw-bold mb-2 text-uppercase\">Club System Login</h2>\r\n                                    ");
            __builder.AddMarkupContent(25, "<p class=\"text-white-50 mb-5\">Please enter your login and password!</p>\r\n                                      ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "form-outline form-white mb-4");
            __builder.AddMarkupContent(28, "\r\n                                          ");
            __builder.AddMarkupContent(29, "<label class=\"form-label\" for=\"clubid\">Club Name</label>\r\n                                        ");
            __builder.OpenElement(30, "select");
            __builder.AddAttribute(31, "id", "clubid");
            __builder.AddAttribute(32, "class", "form-control form-control-lg");
            __builder.AddAttribute(33, "name", "ClubID");
            __builder.AddAttribute(34, "required", true);
            __builder.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Login.razor"
                                                                                                         user.ClubID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.ClubID = __value, user.ClubID));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(37, "\r\n                                            ");
            __builder.OpenElement(38, "option");
            __builder.AddAttribute(39, "value", true);
            __builder.AddAttribute(40, "selected", true);
            __builder.AddAttribute(41, "disabled", "disabled");
            __builder.AddContent(42, "--Select Club Name--");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n");
#nullable restore
#line 25 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Login.razor"
                                             if(Clubs == null)  
{  

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "<p>  \r\n    <em>Loading ...</em>  \r\n</p>  \r\n");
#nullable restore
#line 30 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Login.razor"
}  else{
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Login.razor"
                                         foreach(var clubs in  Clubs)
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(45, "                                              ");
            __builder.OpenElement(46, "option");
            __builder.AddAttribute(47, "value", 
#nullable restore
#line 33 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Login.razor"
                                                              clubs.ClubName

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 33 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Login.razor"
__builder.AddContent(48, clubs.ClubName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
#nullable restore
#line 34 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Login.razor"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Login.razor"
                                         
}

#line default
#line hidden
#nullable disable
            __builder.AddContent(50, "                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                                      \r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                                    ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "form-outline form-white mb-4");
            __builder.AddMarkupContent(55, "\r\n                                          ");
            __builder.AddMarkupContent(56, "<label class=\"form-label\" for=\"typeEmailX\">Username</label>\r\n                                        ");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "type", "text");
            __builder.AddAttribute(59, "id", "username");
            __builder.AddAttribute(60, "class", "form-control form-control-lg");
            __builder.AddAttribute(61, "name", "username");
            __builder.AddAttribute(62, "placeholder", "username");
            __builder.AddAttribute(63, "required", true);
            __builder.AddAttribute(64, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Login.razor"
                                                                                                                     user.UserName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.UserName = __value, user.UserName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                                      \r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n\r\n                                    ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "form-outline form-white mb-4");
            __builder.AddMarkupContent(70, "\r\n                                         ");
            __builder.AddMarkupContent(71, "<label class=\"form-label\" for=\"typePasswordX\">Password</label>\r\n                                        ");
            __builder.OpenElement(72, "input");
            __builder.AddAttribute(73, "type", "password");
            __builder.AddAttribute(74, "id", "password");
            __builder.AddAttribute(75, "class", "form-control form-control-lg");
            __builder.AddAttribute(76, "name", "password");
            __builder.AddAttribute(77, "placeholder", "password");
            __builder.AddAttribute(78, "required", true);
            __builder.AddAttribute(79, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Login.razor"
                                                      user.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Password = __value, user.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                                       \r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n\r\n\r\n                                   \r\n                                  \r\n\r\n\r\n\r\n                                    ");
            __builder.AddMarkupContent(83, "<p class=\"small mb-5 pb-lg-2\"><a class=\"text-white-50\" href=\"#!\">Forgot password?</a></p>\r\n                                  \r\n                                    ");
            __builder.OpenElement(84, "button");
            __builder.AddAttribute(85, "id", "LoginBtn");
            __builder.AddAttribute(86, "class", "btn btn-outline-light btn-lg px-5");
            __builder.AddAttribute(87, "type", "button");
            __builder.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Login.razor"
                                                                                                                            () =>LoginUser(user)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(89, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n\r\n                                    ");
            __builder.AddMarkupContent(91, @"<div class=""d-flex justify-content-center text-center mt-4 pt-1"">
                                        <a href=""#!"" class=""text-white""><i class=""fab fa-facebook-f fa-lg""></i></a>
                                        <a href=""#!"" class=""text-white""><i class=""fab fa-twitter fa-lg mx-4 px-2""></i></a>
                                        <a href=""#!"" class=""text-white""><i class=""fab fa-google fa-lg""></i></a>
                                    </div>

                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n\r\n                                ");
            __builder.AddMarkupContent(93, "<div>\r\n                                    <p class=\"mb-0\">Don\'t have an account? <a href=\"register\" class=\"text-white-50 fw-bold\">Sign Up</a></p>\r\n                                </div>\r\n\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "C:\Users\Tekn0Hub PC1\Documents\Raymond\Club-Portal\Club-Portal\Pages\Login.razor"
       
    [Inject] IJSRuntime JSRuntime { get; set; }
    IEnumerable<ClubInformation> Clubs { get; set; }
    UserInformation userResult  = new UserInformation();
    UserInformation user = new UserInformation();
    public async void LoginUser(UserInformation loginuser)
    {
        if(loginuser.UserName.Length >0 && loginuser.Password.Length >0  ){
            userResult = loginService.ValidateUser(loginuser).FirstOrDefault();
            // await JSRuntime.InvokeVoidAsync("AlertUsernamePassword");
            // base.OnAfterRender(firstRender);
            if(userResult!=null){
                // Session["UserName"] = userResult.UserID;
                if (!userResult.IsActive)
                {
                    await JSRuntime.InvokeVoidAsync("alert"," User has been deactivated");
                    return;
                }
                else
                {
                    await  storage.SetAsync("UserID", userResult.UserID);
                NavigationManager.NavigateTo("/Index");
                }
              
            }
            else
            {
                await JSRuntime.InvokeVoidAsync("alert","Wrong Username or Password"); 
            }
        }
    }
    protected async override Task OnInitializedAsync()
    {
      
        Clubs =    await Task.Run(() => loginService.GetAllClubs());
    }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedBrowserStorage storage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LoginService loginService { get; set; }
    }
}
#pragma warning restore 1591
