#pragma checksum "C:\Users\edwar\Development\Mozilla Local Library - Projeto\MozillaLocalLibrary\MozillaLocalLibrary\Views\Catalog\Books.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e38f7e3a6de2f81f3a9d2a882c6fc1f636b4fecf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Books), @"mvc.1.0.view", @"/Views/Catalog/Books.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Catalog/Books.cshtml", typeof(AspNetCore.Views_Catalog_Books))]
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
#line 1 "C:\Users\edwar\Development\Mozilla Local Library - Projeto\MozillaLocalLibrary\MozillaLocalLibrary\Views\_ViewImports.cshtml"
using MozillaLocalLibrary;

#line default
#line hidden
#line 2 "C:\Users\edwar\Development\Mozilla Local Library - Projeto\MozillaLocalLibrary\MozillaLocalLibrary\Views\_ViewImports.cshtml"
using MozillaLocalLibrary.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e38f7e3a6de2f81f3a9d2a882c6fc1f636b4fecf", @"/Views/Catalog/Books.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e2848c34a98ffcdb84fd1c2251ba7de4f28d07c", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Books : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MozillaLocalLibrary.Models.BookAuthor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "catalogo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "bookdetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\edwar\Development\Mozilla Local Library - Projeto\MozillaLocalLibrary\MozillaLocalLibrary\Views\Catalog\Books.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(95, 65, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n    <h1>Book List</h1>\r\n\r\n    <ul>\r\n");
            EndContext();
#line 12 "C:\Users\edwar\Development\Mozilla Local Library - Projeto\MozillaLocalLibrary\MozillaLocalLibrary\Views\Catalog\Books.cshtml"
         foreach (var book in Model)
        {

#line default
#line hidden
            BeginContext(209, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(225, 201, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bce407ce3b0c4a089d8b6b8c8fe4571d", async() => {
                BeginContext(346, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(369, 15, false);
#line 17 "C:\Users\edwar\Development\Mozilla Local Library - Projeto\MozillaLocalLibrary\MozillaLocalLibrary\Views\Catalog\Books.cshtml"
               Write(book.Book.Title);

#line default
#line hidden
                EndContext();
                BeginContext(384, 2, true);
                WriteLiteral(" (");
                EndContext();
                BeginContext(387, 16, false);
#line 17 "C:\Users\edwar\Development\Mozilla Local Library - Projeto\MozillaLocalLibrary\MozillaLocalLibrary\Views\Catalog\Books.cshtml"
                                 Write(book.Author.Name);

#line default
#line hidden
                EndContext();
                BeginContext(403, 19, true);
                WriteLiteral(")\r\n                ");
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
#line 16 "C:\Users\edwar\Development\Mozilla Local Library - Projeto\MozillaLocalLibrary\MozillaLocalLibrary\Views\Catalog\Books.cshtml"
                     WriteLiteral(book.BookId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(426, 21, true);
            WriteLiteral("\r\n            </li>\r\n");
            EndContext();
#line 20 "C:\Users\edwar\Development\Mozilla Local Library - Projeto\MozillaLocalLibrary\MozillaLocalLibrary\Views\Catalog\Books.cshtml"
        }

#line default
#line hidden
            BeginContext(458, 19, true);
            WriteLiteral("    </ul>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MozillaLocalLibrary.Models.BookAuthor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
