#pragma checksum "/Users/Guest/Desktop/Library.Solution/Library/Views/Books/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0181584501e77db2ae88deb651a8856ec324267c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Index), @"mvc.1.0.view", @"/Views/Books/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Books/Index.cshtml", typeof(AspNetCore.Views_Books_Index))]
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
#line 5 "/Users/Guest/Desktop/Library.Solution/Library/Views/Books/Index.cshtml"
using Library.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0181584501e77db2ae88deb651a8856ec324267c", @"/Views/Books/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Library.Models.Book>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/Library.Solution/Library/Views/Books/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(85, 17, true);
            WriteLiteral("\n<h1>Books</h1>\n\n");
            EndContext();
#line 10 "/Users/Guest/Desktop/Library.Solution/Library/Views/Books/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(128, 41, true);
            WriteLiteral("  <h3>No books have been added yet!</h3>\n");
            EndContext();
#line 13 "/Users/Guest/Desktop/Library.Solution/Library/Views/Books/Index.cshtml"
} 

#line default
#line hidden
            BeginContext(172, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 15 "/Users/Guest/Desktop/Library.Solution/Library/Views/Books/Index.cshtml"
 foreach (Book book in Model)
{

#line default
#line hidden
            BeginContext(205, 11, true);
            WriteLiteral("  <li>\n    ");
            EndContext();
            BeginContext(217, 72, false);
#line 18 "/Users/Guest/Desktop/Library.Solution/Library/Views/Books/Index.cshtml"
Write(Html.ActionLink($"{book.BookName}", "Details", new { id = book.BookId }));

#line default
#line hidden
            EndContext();
            BeginContext(289, 9, true);
            WriteLiteral("\n  </li>\n");
            EndContext();
#line 20 "/Users/Guest/Desktop/Library.Solution/Library/Views/Books/Index.cshtml"
}

#line default
#line hidden
            BeginContext(300, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(304, 43, false);
#line 21 "/Users/Guest/Desktop/Library.Solution/Library/Views/Books/Index.cshtml"
Write(Html.ActionLink("Add a new book", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(347, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Library.Models.Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
