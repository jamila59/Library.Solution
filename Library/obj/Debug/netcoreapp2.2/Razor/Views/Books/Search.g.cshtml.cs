#pragma checksum "/Users/Guest/Desktop/Library.Solution/Library/Views/Books/Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b856f77d3c4ac719a2f7fc256fc8539e1fcd36d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Search), @"mvc.1.0.view", @"/Views/Books/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Books/Search.cshtml", typeof(AspNetCore.Views_Books_Search))]
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
#line 1 "/Users/Guest/Desktop/Library.Solution/Library/Views/_ViewImports.cshtml"
using Library;

#line default
#line hidden
#line 2 "/Users/Guest/Desktop/Library.Solution/Library/Views/_ViewImports.cshtml"
using Library.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b856f77d3c4ac719a2f7fc256fc8539e1fcd36d", @"/Views/Books/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Library.Solution/Library/Views/Books/Search.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(55, 28, true);
            WriteLiteral("\n<h4>Search for a book</h4>\n");
            EndContext();
#line 8 "/Users/Guest/Desktop/Library.Solution/Library/Views/Books/Search.cshtml"
 using (Html.BeginForm("SearchDetails"))
{
    

#line default
#line hidden
            BeginContext(131, 38, false);
#line 10 "/Users/Guest/Desktop/Library.Solution/Library/Views/Books/Search.cshtml"
Write(Html.LabelFor(model => model.BookName));

#line default
#line hidden
            EndContext();
            BeginContext(175, 40, false);
#line 11 "/Users/Guest/Desktop/Library.Solution/Library/Views/Books/Search.cshtml"
Write(Html.TextBoxFor(model => model.BookName));

#line default
#line hidden
            EndContext();
            BeginContext(221, 50, true);
            WriteLiteral("    <input type=\"submit\" value=\"SearchDetails\" />\n");
            EndContext();
#line 14 "/Users/Guest/Desktop/Library.Solution/Library/Views/Books/Search.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591