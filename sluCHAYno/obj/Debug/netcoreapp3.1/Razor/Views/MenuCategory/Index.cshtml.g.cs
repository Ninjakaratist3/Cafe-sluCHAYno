#pragma checksum "C:\Users\Егор\source\repos\sluCHAYno\sluCHAYno\Views\MenuCategory\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff2758d7c512f7faf15142a658607b654fc4ba37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MenuCategory_Index), @"mvc.1.0.view", @"/Views/MenuCategory/Index.cshtml")]
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
#line 1 "C:\Users\Егор\source\repos\sluCHAYno\sluCHAYno\Views\_ViewImports.cshtml"
using sluCHAYno;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Егор\source\repos\sluCHAYno\sluCHAYno\Views\_ViewImports.cshtml"
using sluCHAYno.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Егор\source\repos\sluCHAYno\sluCHAYno\Views\_ViewImports.cshtml"
using sluCHAYno.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff2758d7c512f7faf15142a658607b654fc4ba37", @"/Views/MenuCategory/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbccea933e169e79001d969e12bf5b36222b5812", @"/Views/_ViewImports.cshtml")]
    public class Views_MenuCategory_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sluCHAYno.ViewModels.MenuCategoryVm>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Егор\source\repos\sluCHAYno\sluCHAYno\Views\MenuCategory\Index.cshtml"
   
    ViewData["Title"] = Model.Name;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h2>");
#nullable restore
#line 7 "C:\Users\Егор\source\repos\sluCHAYno\sluCHAYno\Views\MenuCategory\Index.cshtml"
   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    \r\n    <ul class=\"card-list\">\r\n");
#nullable restore
#line 10 "C:\Users\Егор\source\repos\sluCHAYno\sluCHAYno\Views\MenuCategory\Index.cshtml"
         foreach (var item in Model.menuItems)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Егор\source\repos\sluCHAYno\sluCHAYno\Views\MenuCategory\Index.cshtml"
       Write(await Html.PartialAsync("_partialMenuItem", item));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Егор\source\repos\sluCHAYno\sluCHAYno\Views\MenuCategory\Index.cshtml"
                                                              
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sluCHAYno.ViewModels.MenuCategoryVm> Html { get; private set; }
    }
}
#pragma warning restore 1591
