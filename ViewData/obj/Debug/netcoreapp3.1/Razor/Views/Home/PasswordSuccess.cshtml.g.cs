#pragma checksum "C:\Users\TKansa\source\repos\ViewData\ViewData\Views\Home\PasswordSuccess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "172a0940fed48a43913c23428f0964e20086f8af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_PasswordSuccess), @"mvc.1.0.view", @"/Views/Home/PasswordSuccess.cshtml")]
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
#nullable restore
#line 1 "C:\Users\TKansa\source\repos\ViewData\ViewData\Views\_ViewImports.cshtml"
using ViewData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TKansa\source\repos\ViewData\ViewData\Views\_ViewImports.cshtml"
using ViewData.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"172a0940fed48a43913c23428f0964e20086f8af", @"/Views/Home/PasswordSuccess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b94d1591353bd55b2c75db4b64ff5ae9acee03c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_PasswordSuccess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PasswordModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\TKansa\source\repos\ViewData\ViewData\Views\Home\PasswordSuccess.cshtml"
  
    ViewData["Title"] = "Password Success";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nCongrats! Your passwords: ");
#nullable restore
#line 6 "C:\Users\TKansa\source\repos\ViewData\ViewData\Views\Home\PasswordSuccess.cshtml"
                     Write(Model.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral(" and ");
#nullable restore
#line 6 "C:\Users\TKansa\source\repos\ViewData\ViewData\Views\Home\PasswordSuccess.cshtml"
                                         Write(Model.PasswordConfirmation);

#line default
#line hidden
#nullable disable
            WriteLiteral(" match!");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PasswordModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
