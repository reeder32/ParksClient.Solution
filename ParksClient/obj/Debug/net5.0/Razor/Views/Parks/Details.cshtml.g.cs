#pragma checksum "/Users/nicholasreeder/Desktop/epicodus/ParksClient.Solution/ParksClient/Views/Parks/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9d8531b10b9c6c2ffcb8fd43cbc7bc51f016793"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parks_Details), @"mvc.1.0.view", @"/Views/Parks/Details.cshtml")]
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
#line 1 "/Users/nicholasreeder/Desktop/epicodus/ParksClient.Solution/ParksClient/Views/_ViewImports.cshtml"
using ParksClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/nicholasreeder/Desktop/epicodus/ParksClient.Solution/ParksClient/Views/_ViewImports.cshtml"
using ParksClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9d8531b10b9c6c2ffcb8fd43cbc7bc51f016793", @"/Views/Parks/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8327325f17f21b77c043aaf63c0498ed7f92364e", @"/Views/_ViewImports.cshtml")]
    public class Views_Parks_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ParksClient.Models.Park>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/nicholasreeder/Desktop/epicodus/ParksClient.Solution/ParksClient/Views/Parks/Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h4>");
#nullable restore
#line 6 "/Users/nicholasreeder/Desktop/epicodus/ParksClient.Solution/ParksClient/Views/Parks/Details.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n<p> <em>State:</em> <b>");
#nullable restore
#line 8 "/Users/nicholasreeder/Desktop/epicodus/ParksClient.Solution/ParksClient/Views/Parks/Details.cshtml"
                  Write(Model.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\n<p><em>City: </em><b>");
#nullable restore
#line 9 "/Users/nicholasreeder/Desktop/epicodus/ParksClient.Solution/ParksClient/Views/Parks/Details.cshtml"
                Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\n<p><em>State: </em><b>");
#nullable restore
#line 10 "/Users/nicholasreeder/Desktop/epicodus/ParksClient.Solution/ParksClient/Views/Parks/Details.cshtml"
                 Write(Model.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\n<p><em>Zip Code: </em><b>");
#nullable restore
#line 11 "/Users/nicholasreeder/Desktop/epicodus/ParksClient.Solution/ParksClient/Views/Parks/Details.cshtml"
                    Write(Model.ZipCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\n<p><em>Type: </em><b>");
#nullable restore
#line 12 "/Users/nicholasreeder/Desktop/epicodus/ParksClient.Solution/ParksClient/Views/Parks/Details.cshtml"
                Write(Model.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\n");
#nullable restore
#line 13 "/Users/nicholasreeder/Desktop/epicodus/ParksClient.Solution/ParksClient/Views/Parks/Details.cshtml"
Write(Html.ActionLink("Back", "Index", "Parks"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 14 "/Users/nicholasreeder/Desktop/epicodus/ParksClient.Solution/ParksClient/Views/Parks/Details.cshtml"
Write(Html.ActionLink("Delete", "Delete", new {id = @Model.ParkId}));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ParksClient.Models.Park> Html { get; private set; }
    }
}
#pragma warning restore 1591
