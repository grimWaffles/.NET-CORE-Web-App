#pragma checksum "D:\Work\Dev\C#\WebApplication1\Views\Item\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "222b56efebabb03869b26ec86770012a62d64d48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Index), @"mvc.1.0.view", @"/Views/Item/Index.cshtml")]
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
#line 1 "D:\Work\Dev\C#\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Work\Dev\C#\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"222b56efebabb03869b26ec86770012a62d64d48", @"/Views/Item/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Item>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Work\Dev\C#\WebApplication1\Views\Item\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index - Borrowed Items</h1>\r\n\r\n");
#nullable restore
#line 8 "D:\Work\Dev\C#\WebApplication1\Views\Item\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <br />\r\n");
#nullable restore
#line 13 "D:\Work\Dev\C#\WebApplication1\Views\Item\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h5>Item ID: ");
#nullable restore
#line 15 "D:\Work\Dev\C#\WebApplication1\Views\Item\Index.cshtml"
                Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <br />\r\n        <h5>Item Borrower: ");
#nullable restore
#line 17 "D:\Work\Dev\C#\WebApplication1\Views\Item\Index.cshtml"
                      Write(item.Borrower);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <br />\r\n        <h5>Item Lender: ");
#nullable restore
#line 19 "D:\Work\Dev\C#\WebApplication1\Views\Item\Index.cshtml"
                    Write(item.Lender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <br />\r\n        <h5>Item: ");
#nullable restore
#line 21 "D:\Work\Dev\C#\WebApplication1\Views\Item\Index.cshtml"
             Write(item.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n        <br />\r\n        <br />\r\n");
#nullable restore
#line 24 "D:\Work\Dev\C#\WebApplication1\Views\Item\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\Work\Dev\C#\WebApplication1\Views\Item\Index.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591
