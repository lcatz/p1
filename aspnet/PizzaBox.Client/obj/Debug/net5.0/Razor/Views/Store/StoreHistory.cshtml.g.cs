#pragma checksum "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Store/StoreHistory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fda10c855b1b10669135b7990d3ab3be9e4795ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_StoreHistory), @"mvc.1.0.view", @"/Views/Store/StoreHistory.cshtml")]
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
#line 1 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/_ViewImports.cshtml"
using PizzaBox.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/_ViewImports.cshtml"
using PizzaBox.Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fda10c855b1b10669135b7990d3ab3be9e4795ba", @"/Views/Store/StoreHistory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0869890531cd973fc94231944f02086ee7830497", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_StoreHistory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaBox.Client.Models.StoreModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div>\n");
#nullable restore
#line 4 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Store/StoreHistory.cshtml"
   if(@Model.Orders != null)
  {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Store/StoreHistory.cshtml"
     foreach (var item in @Model.Orders)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <label>Order Number: </label>\n      <label>");
#nullable restore
#line 9 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Store/StoreHistory.cshtml"
        Write(item.OrderID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n      <br>\n");
#nullable restore
#line 11 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Store/StoreHistory.cshtml"
       foreach (var i in @Model.Pizzas)
      {
        if(i.Order == item)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <label>");
#nullable restore
#line 15 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Store/StoreHistory.cshtml"
            Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n          <label>Price: </label>\n          <label>");
#nullable restore
#line 17 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Store/StoreHistory.cshtml"
            Write(i.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n          <br>\n");
#nullable restore
#line 19 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Store/StoreHistory.cshtml"
        }
      }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Store/StoreHistory.cshtml"
       
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Store/StoreHistory.cshtml"
     
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  <br>\n</div>\n<div>\n  <a href=\"/store/menu\" class=\"btn btn-secondary btn-lg active\" role=\"button\" aria-pressed=\"true\">Back To Menu</a>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaBox.Client.Models.StoreModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
