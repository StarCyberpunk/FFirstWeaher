#pragma checksum "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "179747057555bf3ab2db3ab976f523517f41be41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShowEx_Show), @"mvc.1.0.view", @"/Views/ShowEx/Show.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"179747057555bf3ab2db3ab976f523517f41be41", @"/Views/ShowEx/Show.cshtml")]
    #nullable restore
    public class Views_ShowEx_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShowEx", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Show", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-month", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
  
    ViewData["Title"] = "Show";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Show</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "179747057555bf3ab2db3ab976f523517f41be414308", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("<p></p>\r\n");
#nullable restore
#line 9 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
  
    for(int z = 0; z < 4; z++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "179747057555bf3ab2db3ab976f523517f41be415915", async() => {
                WriteLiteral("201");
#nullable restore
#line 12 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
                                                                                               Write(z);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-year", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
            WriteLiteral("201");
#nullable restore
#line 12 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
                                                            WriteLiteral(z);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["year"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-year", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["year"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-month", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["month"] = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p></p>\r\n");
#nullable restore
#line 15 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
    for(int j = 1; j <= 12; j++)
    { if(j<10){

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "179747057555bf3ab2db3ab976f523517f41be419572", async() => {
                WriteLiteral("0");
#nullable restore
#line 17 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
                                                                                                    Write(j);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-year", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
                                                            WriteLiteral(Model.year);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["year"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-year", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["year"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
                                                                                        WriteLiteral(j);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["month"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-month", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["month"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 18 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "179747057555bf3ab2db3ab976f523517f41be4113211", async() => {
                WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
                                                                                                    Write(j);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-year", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
                                                            WriteLiteral(Model.year);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["year"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-year", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["year"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 21 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
                                                                                        WriteLiteral(j);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["month"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-month", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["month"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 22 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
        }

    }
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
     if (Model.month < 10)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Данные за 0");
#nullable restore
#line 27 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
                   Write(Model.month);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 27 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
                                   Write(Model.year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 28 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Данные за ");
#nullable restore
#line 31 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
                  Write(Model.month);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 31 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
                                  Write(Model.year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 32 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
     

    for(int i = 0; i < @Model.weathers.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a>");
#nullable restore
#line 36 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
      Write(Model.weathers[i].Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n        <a> ");
#nullable restore
#line 37 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
       Write(Model.weathers[i].Time);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n<a>");
#nullable restore
#line 38 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
Write(Model.weathers[i].T);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n<a>");
#nullable restore
#line 39 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
Write(Model.weathers[i].Vlaga);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n<a>");
#nullable restore
#line 40 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
Write(Model.weathers[i].Td);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n<a>");
#nullable restore
#line 41 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
Write(Model.weathers[i].Ps);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n<a>");
#nullable restore
#line 42 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
Write(Model.weathers[i].NaprVet);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n<a>");
#nullable restore
#line 43 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
Write(Model.weathers[i].SpeedVetra);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n<a>");
#nullable restore
#line 44 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
Write(Model.weathers[i].Oblach);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n<a>");
#nullable restore
#line 45 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
Write(Model.weathers[i].h);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n<a>");
#nullable restore
#line 46 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
Write(Model.weathers[i].VV);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n<a>");
#nullable restore
#line 47 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
Write(Model.weathers[i].pogoda);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n");
            WriteLiteral("         <p></p>\r\n");
#nullable restore
#line 50 "C:\Users\notma\source\repos\FFirstWeaher\FFirstWeaher\Views\ShowEx\Show.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591