#pragma checksum "/Users/brendanbutkus/Desktop/CSharp/ChefsNDishes/Views/Home/Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18aa2ba2af46f5dbafe8ee2faa73110c98bd01e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
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
#line 1 "/Users/brendanbutkus/Desktop/CSharp/ChefsNDishes/Views/_ViewImports.cshtml"
using ChefsNDishes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/brendanbutkus/Desktop/CSharp/ChefsNDishes/Views/_ViewImports.cshtml"
using ChefsNDishes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18aa2ba2af46f5dbafe8ee2faa73110c98bd01e9", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3683dbd783bea45b88d0b0d3ee52e8ec1e5d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""text-center"">
    <h1><a href=""/"">Chefs</a> | Dishes</h1><br>
    <h2>Yum, take a look at our tasty dishes!</h2>
    <h2>------------------------------------</h2>
</div><br>
<div class=""col-6"">
        <table class=""table table-striped"">
            <tr>
                <th>Name</th>
                <th>Chef</th>
                <th>Tastiness</th>
                <th>Calories</th>
            </tr>
");
#nullable restore
#line 15 "/Users/brendanbutkus/Desktop/CSharp/ChefsNDishes/Views/Home/Dishes.cshtml"
                  
                    foreach (var x in ViewBag.AllChefs)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "/Users/brendanbutkus/Desktop/CSharp/ChefsNDishes/Views/Home/Dishes.cshtml"
                         foreach(Dish d in x.MyDishes)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\n                            <td>");
#nullable restore
#line 21 "/Users/brendanbutkus/Desktop/CSharp/ChefsNDishes/Views/Home/Dishes.cshtml"
                           Write(d.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 22 "/Users/brendanbutkus/Desktop/CSharp/ChefsNDishes/Views/Home/Dishes.cshtml"
                           Write(x.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 22 "/Users/brendanbutkus/Desktop/CSharp/ChefsNDishes/Views/Home/Dishes.cshtml"
                                        Write(x.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 23 "/Users/brendanbutkus/Desktop/CSharp/ChefsNDishes/Views/Home/Dishes.cshtml"
                           Write(d.Tastiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                            <td>");
#nullable restore
#line 24 "/Users/brendanbutkus/Desktop/CSharp/ChefsNDishes/Views/Home/Dishes.cshtml"
                           Write(d.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        </tr>\n");
#nullable restore
#line 26 "/Users/brendanbutkus/Desktop/CSharp/ChefsNDishes/Views/Home/Dishes.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "/Users/brendanbutkus/Desktop/CSharp/ChefsNDishes/Views/Home/Dishes.cshtml"
                         
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\n</div><br>\n<a href=\"/dishes/new\">Add a Dish</a>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591