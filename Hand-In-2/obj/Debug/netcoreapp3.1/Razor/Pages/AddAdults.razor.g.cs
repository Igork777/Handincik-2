#pragma checksum "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\AddAdults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecb9ab0a0605dce96d1cef035d7955333d30a58c"
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
#line 2 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\AddAdults.razor"
using Hand_In_2.Data.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\AddAdults.razor"
using Hand_In_2.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddAdults")]
    public partial class AddAdults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>AddAdults</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\AddAdults.razor"
                  newAdult

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "\r\n        First Name <br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "id", "first-name");
                __builder2.AddAttribute(14, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\AddAdults.razor"
                                                newAdult.FirstName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.FirstName = __value, newAdult.FirstName))));
                __builder2.AddAttribute(16, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.FirstName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n        ");
                __builder2.OpenElement(18, "p");
                __builder2.AddAttribute(19, "style", "color: red");
                __builder2.AddContent(20, 
#nullable restore
#line 14 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\AddAdults.razor"
                               firstNameError

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n    ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "form-group");
                __builder2.AddMarkupContent(25, "\r\n        Last Name <br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(26);
                __builder2.AddAttribute(27, "id", "last-name");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\AddAdults.razor"
                                               newAdult.LastName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newAdult.LastName = __value, newAdult.LastName))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newAdult.LastName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.OpenElement(32, "p");
                __builder2.AddAttribute(33, "style", "color: red");
                __builder2.AddContent(34, 
#nullable restore
#line 19 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\AddAdults.razor"
                               lastNameError

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n    ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "form-group");
                __builder2.AddMarkupContent(39, "\r\n        Hair Color <br>\r\n        ");
                __builder2.OpenElement(40, "select");
                __builder2.AddAttribute(41, "class", "form-control selectpicker");
                __builder2.AddAttribute(42, "style", "width: 300px");
                __builder2.AddAttribute(43, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\AddAdults.razor"
                       hairColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => hairColor = __value, hairColor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(45, "\r\n            ");
                __builder2.OpenElement(46, "option");
                __builder2.AddAttribute(47, "selected", true);
                __builder2.AddAttribute(48, "disabled", true);
                __builder2.AddAttribute(49, "value", "-1");
                __builder2.AddContent(50, "Choose the hair color");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n            ");
                __builder2.OpenElement(52, "option");
                __builder2.AddContent(53, "blond");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n            ");
                __builder2.OpenElement(55, "option");
                __builder2.AddContent(56, "red");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n            ");
                __builder2.OpenElement(58, "option");
                __builder2.AddContent(59, "brown");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n            ");
                __builder2.OpenElement(61, "option");
                __builder2.AddContent(62, "black");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n            ");
                __builder2.OpenElement(64, "option");
                __builder2.AddContent(65, "white");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n            ");
                __builder2.OpenElement(67, "option");
                __builder2.AddContent(68, "grey");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n            ");
                __builder2.OpenElement(70, "option");
                __builder2.AddContent(71, "blue");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n            ");
                __builder2.OpenElement(73, "option");
                __builder2.AddContent(74, "green");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n            ");
                __builder2.OpenElement(76, "option");
                __builder2.AddContent(77, "leverpostej");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n    ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "form-group");
                __builder2.AddMarkupContent(83, "\r\n        Eye color <br>\r\n        ");
                __builder2.OpenElement(84, "select");
                __builder2.AddAttribute(85, "class", "form-control selectpicker");
                __builder2.AddAttribute(86, "style", "width: 300px");
                __builder2.AddAttribute(87, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\AddAdults.razor"
                       eyeColor

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => eyeColor = __value, eyeColor));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(89, "\r\n            ");
                __builder2.OpenElement(90, "option");
                __builder2.AddAttribute(91, "selected", true);
                __builder2.AddAttribute(92, "disabled", true);
                __builder2.AddAttribute(93, "value", "-1");
                __builder2.AddContent(94, "Choose the eye color");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(95, "\r\n            ");
                __builder2.OpenElement(96, "option");
                __builder2.AddContent(97, "brown");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n            ");
                __builder2.OpenElement(99, "option");
                __builder2.AddContent(100, "grey");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n            ");
                __builder2.OpenElement(102, "option");
                __builder2.AddContent(103, "green");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(104, "\r\n            ");
                __builder2.OpenElement(105, "option");
                __builder2.AddContent(106, "blue");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n            ");
                __builder2.OpenElement(108, "option");
                __builder2.AddContent(109, "amber");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n            ");
                __builder2.OpenElement(111, "option");
                __builder2.AddContent(112, "hazel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n    ");
                __builder2.OpenElement(116, "div");
                __builder2.AddAttribute(117, "class", "form-group");
                __builder2.AddMarkupContent(118, "\r\n        Age <br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(119);
                __builder2.AddAttribute(120, "id", "age");
                __builder2.AddAttribute(121, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 50 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\AddAdults.razor"
                                         age

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(122, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => age = __value, age))));
                __builder2.AddAttribute(123, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => age));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(124, "\r\n        ");
                __builder2.OpenElement(125, "p");
                __builder2.AddAttribute(126, "style", "color: red");
                __builder2.AddContent(127, 
#nullable restore
#line 51 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\AddAdults.razor"
                               ageError

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(128, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n\r\n    ");
                __builder2.OpenElement(130, "div");
                __builder2.AddAttribute(131, "class", "form-group");
                __builder2.AddMarkupContent(132, "\r\n        Weight <br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(133);
                __builder2.AddAttribute(134, "id", "weight");
                __builder2.AddAttribute(135, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\AddAdults.razor"
                                            weight

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(136, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => weight = __value, weight))));
                __builder2.AddAttribute(137, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => weight));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(138, "\r\n        ");
                __builder2.OpenElement(139, "p");
                __builder2.AddAttribute(140, "style", "color: red");
                __builder2.AddContent(141, 
#nullable restore
#line 57 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\AddAdults.razor"
                               weightError

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(142, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "\r\n    ");
                __builder2.OpenElement(144, "div");
                __builder2.AddAttribute(145, "class", "form-group");
                __builder2.AddMarkupContent(146, "\r\n        Height <br>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(147);
                __builder2.AddAttribute(148, "id", "height");
                __builder2.AddAttribute(149, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 61 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\AddAdults.razor"
                                            height

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(150, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => height = __value, height))));
                __builder2.AddAttribute(151, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => height));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(152, "\r\n        ");
                __builder2.OpenElement(153, "p");
                __builder2.AddAttribute(154, "style", "color: red");
                __builder2.AddContent(155, 
#nullable restore
#line 62 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\AddAdults.razor"
                               heightError

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(156, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(157, "\r\n    ");
                __builder2.OpenElement(158, "div");
                __builder2.AddAttribute(159, "class", "form-group");
                __builder2.AddMarkupContent(160, "\r\n        Sex <br>\r\n        ");
                __builder2.OpenElement(161, "select");
                __builder2.AddAttribute(162, "class", "form-control selectpicker");
                __builder2.AddAttribute(163, "style", "width: 300px");
                __builder2.AddAttribute(164, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 66 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\AddAdults.razor"
                       newAdult.Sex

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(165, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAdult.Sex = __value, newAdult.Sex));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(166, "\r\n            ");
                __builder2.OpenElement(167, "option");
                __builder2.AddAttribute(168, "selected", true);
                __builder2.AddAttribute(169, "disabled", true);
                __builder2.AddAttribute(170, "value", "-1");
                __builder2.AddContent(171, "Choose the sex");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(172, "\r\n            ");
                __builder2.OpenElement(173, "option");
                __builder2.AddContent(174, "F");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(175, "\r\n            ");
                __builder2.OpenElement(176, "option");
                __builder2.AddContent(177, "M");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(178, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(179, "\r\n        ");
                __builder2.OpenElement(180, "p");
                __builder2.AddAttribute(181, "style", "color: red");
                __builder2.AddContent(182, 
#nullable restore
#line 71 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\AddAdults.razor"
                               sexError

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(183, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(184, "\r\n    ");
                __builder2.OpenElement(185, "div");
                __builder2.AddAttribute(186, "class", "form-group");
                __builder2.AddMarkupContent(187, "\r\n        Job title <br>\r\n        ");
                __builder2.OpenElement(188, "select");
                __builder2.AddAttribute(189, "class", "form-control selectpicker");
                __builder2.AddAttribute(190, "style", "width: 300px");
                __builder2.AddAttribute(191, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 75 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\AddAdults.razor"
                       newAdult.JobTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(192, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newAdult.JobTitle = __value, newAdult.JobTitle));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.AddMarkupContent(193, "\r\n            ");
                __builder2.OpenElement(194, "option");
                __builder2.AddAttribute(195, "selected", true);
                __builder2.AddAttribute(196, "disabled", true);
                __builder2.AddAttribute(197, "value", "-1");
                __builder2.AddContent(198, "Choose the eye job");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(199, "\r\n            ");
                __builder2.OpenElement(200, "option");
                __builder2.AddContent(201, "Teacher");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(202, "\r\n            ");
                __builder2.OpenElement(203, "option");
                __builder2.AddContent(204, "Engineering");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(205, "\r\n            ");
                __builder2.OpenElement(206, "option");
                __builder2.AddContent(207, "Garbage Collector");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(208, "\r\n            ");
                __builder2.OpenElement(209, "option");
                __builder2.AddContent(210, "Shepherd");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(211, "\r\n            ");
                __builder2.OpenElement(212, "option");
                __builder2.AddContent(213, "Pilot");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(214, "\r\n            ");
                __builder2.OpenElement(215, "option");
                __builder2.AddContent(216, "Police Officer");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(217, "\r\n            ");
                __builder2.OpenElement(218, "option");
                __builder2.AddContent(219, "Pirate");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(220, "\r\n            ");
                __builder2.OpenElement(221, "option");
                __builder2.AddContent(222, "Fireman");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(223, "\r\n            ");
                __builder2.OpenElement(224, "option");
                __builder2.AddContent(225, "Astronaut");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(226, "\r\n            ");
                __builder2.OpenElement(227, "option");
                __builder2.AddContent(228, "Captain");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(229, "\r\n            ");
                __builder2.OpenElement(230, "option");
                __builder2.AddContent(231, "Solider");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(232, "\r\n            ");
                __builder2.OpenElement(233, "option");
                __builder2.AddContent(234, "Pizza Chef");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(235, "\r\n            ");
                __builder2.OpenElement(236, "option");
                __builder2.AddContent(237, "Chef");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(238, "\r\n            ");
                __builder2.OpenElement(239, "option");
                __builder2.AddContent(240, "Janitor");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(241, "\r\n            ");
                __builder2.OpenElement(242, "option");
                __builder2.AddContent(243, "Factory Worker");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(244, "\r\n            ");
                __builder2.OpenElement(245, "option");
                __builder2.AddContent(246, "Chauffeur");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(247, "\r\n            ");
                __builder2.OpenElement(248, "option");
                __builder2.AddContent(249, "Waitress");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(250, "\r\n            ");
                __builder2.OpenElement(251, "option");
                __builder2.AddContent(252, "Ninja");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(253, "\r\n            ");
                __builder2.OpenElement(254, "option");
                __builder2.AddContent(255, "Doctor");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(256, "\r\n            ");
                __builder2.OpenElement(257, "option");
                __builder2.AddContent(258, "Nurse");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(259, "\r\n            ");
                __builder2.OpenElement(260, "option");
                __builder2.AddContent(261, "Chemist");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(262, "\r\n            ");
                __builder2.OpenElement(263, "option");
                __builder2.AddContent(264, "Caretaker");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(265, "\r\n            ");
                __builder2.OpenElement(266, "option");
                __builder2.AddContent(267, "Gardener");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(268, "\r\n            ");
                __builder2.OpenElement(269, "option");
                __builder2.AddContent(270, "Mascot");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(271, "\r\n            ");
                __builder2.OpenElement(272, "option");
                __builder2.AddContent(273, "Athlete");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(274, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(275, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(276, "\r\n    ");
                __builder2.OpenElement(277, "div");
                __builder2.AddAttribute(278, "class", "form-group");
                __builder2.AddMarkupContent(279, "\r\n        ");
                __builder2.OpenElement(280, "button");
                __builder2.AddAttribute(281, "class", "btn btn-outline-dark");
                __builder2.AddAttribute(282, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 105 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\AddAdults.razor"
                                                       AddNewAdult

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(283, "Add");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(284, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(285, "\r\n    ");
                __builder2.OpenElement(286, "p");
                __builder2.AddAttribute(287, "style", "color: red");
                __builder2.AddContent(288, 
#nullable restore
#line 107 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\AddAdults.razor"
                           theSameName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(289, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 110 "D:\C#\DNP\AuthenticationAndAuthorization\Handincik-2\Hand-In-2\Pages\AddAdults.razor"
       
    string age, weight, height, eyeColor, hairColor;
    private string ageError, weightError, heightError, firstNameError, lastNameError, sexError, theSameName;
    private Adult newAdult = new Adult();
    private ValidHairColor _validHairColor = new ValidHairColor();
    private ValidEyeColor _validEyeColor = new ValidEyeColor();
    private IList<Adult> _adults;

    private async Task AddNewAdult()
    {
        try
        {
            if (_validHairColor.IsValid(hairColor))
            {
                newAdult.HairColor = hairColor;
            }
            if (_validEyeColor.IsValid(eyeColor))
            {
                newAdult.EyeColor = eyeColor;
            }
            _adults = await AdultsService.getAllAdults();
            newAdult.Id = _adults.Count;
            if (newAdult.FirstName == null)
            {
                firstNameError = "Input the first name";
            }
            else
            {
                firstNameError = "";
            }
            if (newAdult.LastName == null)
            {
                lastNameError = "Input the last name";
            }
            else
            {
                lastNameError = "";
            }
            bool isAgeOk = Int32.TryParse(age, out int resultAge);
            if (!isAgeOk)
            {
                ageError = "Input the number for the age field";
            }
            else if (Int32.Parse(age) < 1)
            {
                ageError = "The age cannot be negative";
            }
            else
            {
                ageError = "";
                newAdult.Age = resultAge;
            }
            bool isWeightOk = float.TryParse(weight, out float resultWeight);
            if (!isWeightOk)
            {
                weightError = "Input the number for the weight field";
            }
            else
            {
                weightError = "";
                newAdult.Weight = resultWeight;
            }
            bool isHeightOk = Int32.TryParse(height, out int resultHeight);
            if (!isHeightOk)
            {
                heightError = "Input the number for the height field";
            }
            else
            {
                heightError = "";
                newAdult.Height = resultHeight;
            }

            if (newAdult.Sex == null)
            {
                sexError = "Sex has to be F or M";
            }
            else
            {
                sexError = "";
            }
            if (newAdult.JobTitle == null)
            {
                newAdult.JobTitle = "Not working";
            }

            if (isAgeOk && isHeightOk && isWeightOk && ageError == "" && weightError == "" && heightError == "" && firstNameError == "" && lastNameError == "" && sexError == "")
            {
                _adults = await AdultsService.getAllAdults();
                foreach (Adult adult in _adults)
                {
                    if (adult.FirstName.Equals(newAdult.FirstName) && adult.LastName.Equals(newAdult.LastName))
                    {
                        theSameName = "The adult " + newAdult.FirstName + " " + newAdult.LastName + " already exists";
                        return;
                    }
                }
              await AdultsService.addAdult(newAdult);
                NavigationManager.NavigateTo("/Adults");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultsService AdultsService { get; set; }
    }
}
#pragma warning restore 1591
