#pragma checksum "/Users/nicholasreeder/Desktop/epicodus/ParksClient.Solution/ParksClient/Views/Parks/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "817102c4ef3e18b34ac9136fcff93c6cb6a17614"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Parks_Delete), @"mvc.1.0.view", @"/Views/Parks/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"817102c4ef3e18b34ac9136fcff93c6cb6a17614", @"/Views/Parks/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8327325f17f21b77c043aaf63c0498ed7f92364e", @"/Views/_ViewImports.cshtml")]
    public class Views_Parks_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ParksClient.Models.Park>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/nicholasreeder/Desktop/epicodus/ParksClient.Solution/ParksClient/Views/Parks/Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Are you sure you want to delete this Park?</h2>\n\n");
#nullable restore
#line 7 "/Users/nicholasreeder/Desktop/epicodus/ParksClient.Solution/ParksClient/Views/Parks/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 7 "/Users/nicholasreeder/Desktop/epicodus/ParksClient.Solution/ParksClient/Views/Parks/Delete.cshtml"
                                      Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "/Users/nicholasreeder/Desktop/epicodus/ParksClient.Solution/ParksClient/Views/Parks/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Delete\" />\n");
#nullable restore
#line 11 "/Users/nicholasreeder/Desktop/epicodus/ParksClient.Solution/ParksClient/Views/Parks/Delete.cshtml"
}

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
