#pragma checksum "C:\Users\Yordan\Desktop\BookLibrary\BookLibrary.Web\Pages\Authors\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cc43531f36c1f2e66d60c6a435666e99ad84459"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BookLibrary.Web.Pages.Authors.Pages_Authors_Details), @"mvc.1.0.razor-page", @"/Pages/Authors/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Authors/Details.cshtml", typeof(BookLibrary.Web.Pages.Authors.Pages_Authors_Details), @"{id}")]
namespace BookLibrary.Web.Pages.Authors
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Yordan\Desktop\BookLibrary\BookLibrary.Web\Pages\_ViewImports.cshtml"
using BookLibrary.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cc43531f36c1f2e66d60c6a435666e99ad84459", @"/Pages/Authors/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85801afa7a636a61a879bd1768dacd9b9194b4a0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Authors_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Yordan\Desktop\BookLibrary\BookLibrary.Web\Pages\Authors\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(108, 45, true);
            WriteLiteral("\r\n<h2>Author Details</h2>\r\n<h3>TO DO</h3>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookLibrary.Web.Pages.Authors.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookLibrary.Web.Pages.Authors.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BookLibrary.Web.Pages.Authors.DetailsModel>)PageContext?.ViewData;
        public BookLibrary.Web.Pages.Authors.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
