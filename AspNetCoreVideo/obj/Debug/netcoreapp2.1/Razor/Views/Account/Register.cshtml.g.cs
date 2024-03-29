#pragma checksum "E:\workspace\AspNetCoreVideo\AspNetCoreVideo\Views\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "535b3f27a79febe509b6e89d4e55b22f1692f64c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Register), @"mvc.1.0.view", @"/Views/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Register.cshtml", typeof(AspNetCore.Views_Account_Register))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"535b3f27a79febe509b6e89d4e55b22f1692f64c", @"/Views/Account/Register.cshtml")]
    public class Views_Account_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspNetCoreVideo.ViewModels.RegisterViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\workspace\AspNetCoreVideo\AspNetCoreVideo\Views\Account\Register.cshtml"
   ViewBag.Title = "Register"; 

#line default
#line hidden
            BeginContext(87, 573, true);
            WriteLiteral(@"
<h1>Register</h1>

<form method=""post"" asp-controller=""Account"" asp-action=""Register"">
    <div asp-validation-summary=""ModelOnly""></div>

    <div>
        <label asp-for=""Username""></label>
        <input asp-for=""Username"" />
        <span asp-validation-for=""Username""></span>
    </div>

    <div>
        <label asp-for=""ConfirmPassword""></label>
        <input asp-for=""ConfirmPassword"" />
        <span asp-validation-for=""ConfirmPassword""></span>
    </div>

    <div>
        <input type=""submit"" value=""Register"" />
    </div>

</form>

");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNetCoreVideo.ViewModels.RegisterViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
