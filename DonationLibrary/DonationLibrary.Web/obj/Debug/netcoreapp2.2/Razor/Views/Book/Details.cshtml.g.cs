#pragma checksum "D:\.Net Developement\DonationLibrary\DonationLibrary.Web\Views\Book\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08faa089f07a4c0fb42ee2c0c33c690fca450717"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_Details), @"mvc.1.0.view", @"/Views/Book/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Book/Details.cshtml", typeof(AspNetCore.Views_Book_Details))]
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
#line 1 "D:\.Net Developement\DonationLibrary\DonationLibrary.Web\Views\_ViewImports.cshtml"
using DonationLibrary.Web;

#line default
#line hidden
#line 2 "D:\.Net Developement\DonationLibrary\DonationLibrary.Web\Views\_ViewImports.cshtml"
using DonationLibrary.Web.Models;

#line default
#line hidden
#line 3 "D:\.Net Developement\DonationLibrary\DonationLibrary.Web\Views\_ViewImports.cshtml"
using DonationLibrary.Web.ViewModels;

#line default
#line hidden
#line 4 "D:\.Net Developement\DonationLibrary\DonationLibrary.Web\Views\_ViewImports.cshtml"
using DonationLibrary.Web.BindingModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08faa089f07a4c0fb42ee2c0c33c690fca450717", @"/Views/Book/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db20d64d1ce92482dea673f6bddfb504a629dcbb", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DonationLibrary.Web.ViewModels.BookDetailsViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Book", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Donate", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\.Net Developement\DonationLibrary\DonationLibrary.Web\Views\Book\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(103, 85, true);
            WriteLiteral("\r\n<div class=\"container-fluid row text-light\">\r\n    <div class=\"col-4\">\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 188, "\"", 223, 1);
#line 8 "D:\.Net Developement\DonationLibrary\DonationLibrary.Web\Views\Book\Details.cshtml"
WriteAttributeValue("", 194, Model.Book.BookCoverImageUrl, 194, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(224, 25, true);
            WriteLiteral(" height=\"500\" width=\"300\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 249, "\"", 272, 1);
#line 8 "D:\.Net Developement\DonationLibrary\DonationLibrary.Web\Views\Book\Details.cshtml"
WriteAttributeValue("", 255, Model.Book.Title, 255, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(273, 54, true);
            WriteLiteral(" />\r\n    </div>\r\n    <div class=\"col-8\">\r\n        <h1>");
            EndContext();
            BeginContext(328, 16, false);
#line 11 "D:\.Net Developement\DonationLibrary\DonationLibrary.Web\Views\Book\Details.cshtml"
       Write(Model.Book.Title);

#line default
#line hidden
            EndContext();
            BeginContext(344, 38, true);
            WriteLiteral("</h1>\r\n        <p>by <span class=\"h5\">");
            EndContext();
            BeginContext(383, 22, false);
#line 12 "D:\.Net Developement\DonationLibrary\DonationLibrary.Web\Views\Book\Details.cshtml"
                          Write(Model.Book.Author.Name);

#line default
#line hidden
            EndContext();
            BeginContext(405, 38, true);
            WriteLiteral("</span></p>\r\n        <p>\r\n            ");
            EndContext();
            BeginContext(444, 22, false);
#line 14 "D:\.Net Developement\DonationLibrary\DonationLibrary.Web\Views\Book\Details.cshtml"
       Write(Model.Book.Description);

#line default
#line hidden
            EndContext();
            BeginContext(466, 84, true);
            WriteLiteral("\r\n        </p>\r\n\r\n        <p><span class=\"font-weight-bold\">Donation Status: </span>");
            EndContext();
            BeginContext(551, 25, false);
#line 17 "D:\.Net Developement\DonationLibrary\DonationLibrary.Web\Views\Book\Details.cshtml"
                                                             Write(Model.Book.DonationStatus);

#line default
#line hidden
            EndContext();
            BeginContext(576, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
#line 19 "D:\.Net Developement\DonationLibrary\DonationLibrary.Web\Views\Book\Details.cshtml"
          
            if (Model.Book.DonationStatus == "For Donation")
            {

#line default
#line hidden
            BeginContext(673, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(689, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "08faa089f07a4c0fb42ee2c0c33c690fca4507177622", async() => {
                BeginContext(788, 6, true);
                WriteLiteral("Donate");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "D:\.Net Developement\DonationLibrary\DonationLibrary.Web\Views\Book\Details.cshtml"
                                                               WriteLiteral(Model.Book.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(798, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "D:\.Net Developement\DonationLibrary\DonationLibrary.Web\Views\Book\Details.cshtml"
            }
            else if (Model.Book.DonationStatus != "Not for Donation")
            {

#line default
#line hidden
            BeginContext(901, 60, true);
            WriteLiteral("                <p>Thank you for your donnation. You donate ");
            EndContext();
            BeginContext(962, 23, false);
#line 26 "D:\.Net Developement\DonationLibrary\DonationLibrary.Web\Views\Book\Details.cshtml"
                                                       Write(Model.Book.DonatedPrice);

#line default
#line hidden
            EndContext();
            BeginContext(985, 9, true);
            WriteLiteral(" leva to ");
            EndContext();
            BeginContext(995, 19, false);
#line 26 "D:\.Net Developement\DonationLibrary\DonationLibrary.Web\Views\Book\Details.cshtml"
                                                                                        Write(Model.RecipientName);

#line default
#line hidden
            EndContext();
            BeginContext(1014, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 27 "D:\.Net Developement\DonationLibrary\DonationLibrary.Web\Views\Book\Details.cshtml"
            }
        

#line default
#line hidden
            BeginContext(1046, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DonationLibrary.Web.ViewModels.BookDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
