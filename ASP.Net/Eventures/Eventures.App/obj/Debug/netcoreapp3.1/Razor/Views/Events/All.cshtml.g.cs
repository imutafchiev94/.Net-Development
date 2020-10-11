#pragma checksum "D:\.Net Developement\ASP.Net\Eventures\Eventures.App\Views\Events\All.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a6e7efb20fadbb2cd8fc68a413042cd3aa6d10d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_All), @"mvc.1.0.view", @"/Views/Events/All.cshtml")]
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
#line 1 "D:\.Net Developement\ASP.Net\Eventures\Eventures.App\Views\_ViewImports.cshtml"
using Eventures.App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.Net Developement\ASP.Net\Eventures\Eventures.App\Views\_ViewImports.cshtml"
using Eventures.App.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a6e7efb20fadbb2cd8fc68a413042cd3aa6d10d", @"/Views/Events/All.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45e53abd41be8174d5e19ea6c9eaffdf4074ec5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_All : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Eventures.App.Commons.ViewModels.AllEventsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\.Net Developement\ASP.Net\Eventures\Eventures.App\Views\Events\All.cshtml"
  
    ViewData["Title"] = "All";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-center"">All Events</h1>

<table class=""table table-eventure"">
    <thead class=""thead-eventure"">
        <tr class=""row"">
            <th class=""col-1"">#</th>
            <th class=""col-3"">Name</th>
            <th class=""col-3"">Start</th>
            <th class=""col-3"">End</th>
            <th class=""col-2"">Place</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "D:\.Net Developement\ASP.Net\Eventures\Eventures.App\Views\Events\All.cshtml"
         foreach (var events in Model.Events)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr class=\"row\">\r\n            <td class=\"col-1\">");
#nullable restore
#line 23 "D:\.Net Developement\ASP.Net\Eventures\Eventures.App\Views\Events\All.cshtml"
                         Write(events.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-3\">");
#nullable restore
#line 24 "D:\.Net Developement\ASP.Net\Eventures\Eventures.App\Views\Events\All.cshtml"
                         Write(events.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-3\">");
#nullable restore
#line 25 "D:\.Net Developement\ASP.Net\Eventures\Eventures.App\Views\Events\All.cshtml"
                         Write(events.Start);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-3\">");
#nullable restore
#line 26 "D:\.Net Developement\ASP.Net\Eventures\Eventures.App\Views\Events\All.cshtml"
                         Write(events.End);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"col-2\">");
#nullable restore
#line 27 "D:\.Net Developement\ASP.Net\Eventures\Eventures.App\Views\Events\All.cshtml"
                         Write(events.Place);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 29 "D:\.Net Developement\ASP.Net\Eventures\Eventures.App\Views\Events\All.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<hr class=\"hr-eventure\"/>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Eventures.App.Commons.ViewModels.AllEventsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
