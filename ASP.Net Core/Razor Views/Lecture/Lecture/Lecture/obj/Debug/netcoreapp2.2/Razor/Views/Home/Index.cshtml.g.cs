#pragma checksum "D:\.Net Developement\ASP.Net Core\Razor Views\Lecture\Lecture\Lecture\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0450ee2866833891940bb7e436dc51aab20912d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\.Net Developement\ASP.Net Core\Razor Views\Lecture\Lecture\Lecture\Views\_ViewImports.cshtml"
using Lecture;

#line default
#line hidden
#line 2 "D:\.Net Developement\ASP.Net Core\Razor Views\Lecture\Lecture\Lecture\Views\_ViewImports.cshtml"
using Lecture.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0450ee2866833891940bb7e436dc51aab20912d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0db0d87f27675381b31528781b611e9b99c0698a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lecture.Models.Home.IndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\.Net Developement\ASP.Net Core\Razor Views\Lecture\Lecture\Lecture\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(88, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\.Net Developement\ASP.Net Core\Razor Views\Lecture\Lecture\Lecture\Views\Home\Index.cshtml"
 foreach (var item in this.Model.Usernames)
{

#line default
#line hidden
            BeginContext(138, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(146, 4, false);
#line 8 "D:\.Net Developement\ASP.Net Core\Razor Views\Lecture\Lecture\Lecture\Views\Home\Index.cshtml"
  Write(item);

#line default
#line hidden
            EndContext();
            BeginContext(150, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 9 "D:\.Net Developement\ASP.Net Core\Razor Views\Lecture\Lecture\Lecture\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lecture.Models.Home.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591