#pragma checksum "C:\Users\caio\source\repos\ArsenalDeTanques\Views\Comprados\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3684ad152cd04f4ac837c5bddec0997b8f73023c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comprados_Index), @"mvc.1.0.view", @"/Views/Comprados/Index.cshtml")]
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
#line 1 "C:\Users\caio\source\repos\ArsenalDeTanques\Views\_ViewImports.cshtml"
using ArsenalDeTanques;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\caio\source\repos\ArsenalDeTanques\Views\_ViewImports.cshtml"
using ArsenalDeTanques.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\caio\source\repos\ArsenalDeTanques\Views\Comprados\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3684ad152cd04f4ac837c5bddec0997b8f73023c", @"/Views/Comprados/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f702f17e486ea7d3334dfc3b48691bd9b7f47cf", @"/Views/_ViewImports.cshtml")]
    public class Views_Comprados_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Compra>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-ord", "true", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Ordenar compras"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin:2vh;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("list-group-item list-group-item-action"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ReadSingle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\caio\source\repos\ArsenalDeTanques\Views\Comprados\Index.cshtml"
  
    ViewData["Title"] = "Compras";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Suas compras</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3684ad152cd04f4ac837c5bddec0997b8f73023c6458", async() => {
                WriteLiteral(@"
    <div class=""col col-md-6"">
        <input type=""text"" class=""form-control"" name=""busca"" placeholder=""Buscar compra..."" />
    </div>
    <div class=""col col-md-1"">
        <button type=""submit"" class=""btn btn-outline-dark"">Buscar</button>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 18 "C:\Users\caio\source\repos\ArsenalDeTanques\Views\Comprados\Index.cshtml"
     if (ViewBag.operacaoRealizada == "")
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\caio\source\repos\ArsenalDeTanques\Views\Comprados\Index.cshtml"
         if (ViewBag.ordenar)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"btn btn-outline-dark\" href=\"?ord=false\" style=\"margin:2vh;\">Desordenar compras</a>\r\n");
#nullable restore
#line 23 "C:\Users\caio\source\repos\ArsenalDeTanques\Views\Comprados\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a href=\"?ord=true\" class=\"btn btn-outline-dark\" value=\"Ordenar compras\" style=\"margin:2vh;\">Ordenar compras</a>\r\n");
#nullable restore
#line 27 "C:\Users\caio\source\repos\ArsenalDeTanques\Views\Comprados\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\caio\source\repos\ArsenalDeTanques\Views\Comprados\Index.cshtml"
         
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3684ad152cd04f4ac837c5bddec0997b8f73023c9375", async() => {
                WriteLiteral("Ordenar compras");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ord", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ord"] = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Users\caio\source\repos\ArsenalDeTanques\Views\Comprados\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 35 "C:\Users\caio\source\repos\ArsenalDeTanques\Views\Comprados\Index.cshtml"
 if (ViewBag.operacaoRealizada == "create")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Tanque comprado com sucesso.</h3>\r\n");
#nullable restore
#line 38 "C:\Users\caio\source\repos\ArsenalDeTanques\Views\Comprados\Index.cshtml"
}
else if (ViewBag.operacaoRealizada == "update")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Registro de compra atualizado com sucesso.</h3>\r\n");
#nullable restore
#line 42 "C:\Users\caio\source\repos\ArsenalDeTanques\Views\Comprados\Index.cshtml"
}
else if (ViewBag.operacaoRealizada == "delete")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Compra cancelada com sucesso.</h3>\r\n");
#nullable restore
#line 46 "C:\Users\caio\source\repos\ArsenalDeTanques\Views\Comprados\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>Você já investiu $");
#nullable restore
#line 48 "C:\Users\caio\source\repos\ArsenalDeTanques\Views\Comprados\Index.cshtml"
                Write(ViewBag.investido);

#line default
#line hidden
#nullable disable
            WriteLiteral(" em nossa loja!</p>\r\n\r\n<div class=\"list-group\">\r\n");
#nullable restore
#line 51 "C:\Users\caio\source\repos\ArsenalDeTanques\Views\Comprados\Index.cshtml"
     foreach (Compra comprado in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3684ad152cd04f4ac837c5bddec0997b8f73023c13104", async() => {
                WriteLiteral("\r\n        ");
#nullable restore
#line 54 "C:\Users\caio\source\repos\ArsenalDeTanques\Views\Comprados\Index.cshtml"
   Write(Html.DisplayFor(Model => comprado.DataCompra));

#line default
#line hidden
#nullable disable
                WriteLiteral(" - ");
#nullable restore
#line 54 "C:\Users\caio\source\repos\ArsenalDeTanques\Views\Comprados\Index.cshtml"
                                                    Write(comprado.tanque.Nome);

#line default
#line hidden
#nullable disable
                WriteLiteral(" - <img");
                BeginWriteAttribute("src", " src=\"", 1679, "\"", 1728, 1);
#nullable restore
#line 54 "C:\Users\caio\source\repos\ArsenalDeTanques\Views\Comprados\Index.cshtml"
WriteAttributeValue("", 1685, comprado.tanque.nacionalidade.linkBandeira, 1685, 43, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width:60px;height:30px;\" /> -\r\n        <img");
                BeginWriteAttribute("src", " src=\"", 1780, "\"", 1818, 1);
#nullable restore
#line 55 "C:\Users\caio\source\repos\ArsenalDeTanques\Views\Comprados\Index.cshtml"
WriteAttributeValue("", 1786, comprado.tanque.tipo.LinkImagem, 1786, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width:60px;height:30px;\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\caio\source\repos\ArsenalDeTanques\Views\Comprados\Index.cshtml"
                                                                                WriteLiteral(comprado.id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n");
#nullable restore
#line 57 "C:\Users\caio\source\repos\ArsenalDeTanques\Views\Comprados\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Compra>> Html { get; private set; }
    }
}
#pragma warning restore 1591