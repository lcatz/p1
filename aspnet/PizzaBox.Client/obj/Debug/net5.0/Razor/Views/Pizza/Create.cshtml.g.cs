#pragma checksum "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e62900f30b2615b8a0d28dc32b90041651407e0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Create), @"mvc.1.0.view", @"/Views/Pizza/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e62900f30b2615b8a0d28dc32b90041651407e0a", @"/Views/Pizza/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0869890531cd973fc94231944f02086ee7830497", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaBox.Client.Models.PizzaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/pizza/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e62900f30b2615b8a0d28dc32b90041651407e0a3863", async() => {
                WriteLiteral("\n");
#nullable restore
#line 4 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\n<div>\n  <selct");
                BeginWriteAttribute("asp-for", " asp-for=\"", 129, "\"", 151, 1);
#nullable restore
#line 6 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
WriteAttributeValue("", 139, Model.Crust, 139, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\n");
#nullable restore
#line 7 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
     foreach (var item in @Model.CrustList)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("      <label>\n      ");
#nullable restore
#line 10 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
 Write(Html.RadioButtonFor(cm => cm.Size, @item.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
                                                Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n      </label>\n");
#nullable restore
#line 12 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("  </selct>\n  <br>\n</div>\n<div>\n");
#nullable restore
#line 17 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
   foreach (var item in @Model.SizeList)
  {

#line default
#line hidden
#nullable disable
                WriteLiteral("    <label>\n      ");
#nullable restore
#line 20 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
 Write(Html.RadioButtonFor(sm => sm.Size, @item.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
                                                Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    </label>\n");
#nullable restore
#line 22 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
  }

#line default
#line hidden
#nullable disable
                WriteLiteral("  <br>\n</div>\n<div>\n");
#nullable restore
#line 26 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
   for (int i = 0; i < @Model.Count; i++)
  {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
     if(i == 0)
    {
      

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
 Write(Html.CheckBoxFor(tm => tm.Topping1, true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
                                                ;

#line default
#line hidden
#nullable disable
                WriteLiteral("      <label>");
#nullable restore
#line 31 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
        Write(Model.Toppings[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n");
#nullable restore
#line 32 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
     if(i == 1)
    {
      

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
 Write(Html.CheckBoxFor(tm => tm.Topping2, true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
                                                ;

#line default
#line hidden
#nullable disable
                WriteLiteral("      <label>");
#nullable restore
#line 36 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
        Write(Model.Toppings[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n");
#nullable restore
#line 37 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
     if(i == 2)
    {
      

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
 Write(Html.CheckBoxFor(tm => tm.Topping3, true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
                                                ;

#line default
#line hidden
#nullable disable
                WriteLiteral("      <label>");
#nullable restore
#line 41 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
        Write(Model.Toppings[i]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\n");
#nullable restore
#line 42 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "/home/lawrence/revature/projects/p1/aspnet/PizzaBox.Client/Views/Pizza/Create.cshtml"
     
  }

#line default
#line hidden
#nullable disable
                WriteLiteral("  <br>\n</div>\n<div>\n  <button type=\"submit\">Create</button>\n</div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaBox.Client.Models.PizzaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
