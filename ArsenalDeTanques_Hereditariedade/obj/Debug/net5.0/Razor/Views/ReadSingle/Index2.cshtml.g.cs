#pragma checksum "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cf5ac209375fd6c24039ecdc71ced7dde150d21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReadSingle_Index2), @"mvc.1.0.view", @"/Views/ReadSingle/Index2.cshtml")]
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
#line 1 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\_ViewImports.cshtml"
using ArsenalDeTanques;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\_ViewImports.cshtml"
using ArsenalDeTanques.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cf5ac209375fd6c24039ecdc71ced7dde150d21", @"/Views/ReadSingle/Index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f702f17e486ea7d3334dfc3b48691bd9b7f47cf", @"/Views/_ViewImports.cshtml")]
    public class Views_ReadSingle_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TanqueMedio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ReadSingle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateOne", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tanques", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left: 1vh;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ConfirmarDelete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
 if (ViewBag.itemAtualizado)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Item atualizado com sucesso! Woooho!</h1>\r\n");
#nullable restore
#line 11 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
 if (ViewBag.itemCriado)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Item criado com sucesso! Wooho!</h1>\r\n    <h5>\r\n        NENHUM DOS BOTÕES ABAIXO IRÃO FUNCIONAR SE VOCÊ ESTIVER VENDO ISSO! Por conta da criação ser local,\r\n        haverá erros ao tentar deletar/atualizar.\r\n    </h5>\r\n");
#nullable restore
#line 19 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--Tanques medios-->\r\n<p>");
#nullable restore
#line 21 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
Write(Html.DisplayNameFor(Model => Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 21 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
                                       Write(Html.DisplayFor(Model => Model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 22 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
Write(Html.DisplayNameFor(Model => Model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 22 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
                                         Write(Html.DisplayFor(Model => Model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>\r\n<p>");
#nullable restore
#line 23 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
Write(Html.DisplayNameFor(Model => Model.Calibre));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 23 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
                                            Write(Html.DisplayFor(Model => Model.Calibre));

#line default
#line hidden
#nullable disable
            WriteLiteral(" mm</p>\r\n<p>");
#nullable restore
#line 24 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
Write(Html.DisplayNameFor(Model => Model.PotenciaMotor));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 24 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
                                                  Write(Html.DisplayFor(Model => Model.PotenciaMotor));

#line default
#line hidden
#nullable disable
            WriteLiteral(" hp</p>\r\n<p>");
#nullable restore
#line 25 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
Write(Html.DisplayNameFor(Model => Model.QuantidadeTripulacao));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 25 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
                                                         Write(Html.DisplayFor(Model => Model.QuantidadeTripulacao));

#line default
#line hidden
#nullable disable
            WriteLiteral(" tripulantes</p>\r\n<p>");
#nullable restore
#line 26 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
Write(Html.DisplayNameFor(Model => Model.DataFabricacao));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 26 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
                                                   Write(Html.DisplayFor(Model => Model.DataFabricacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 27 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
Write(Html.DisplayNameFor(Model => Model.Velocidade));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 27 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
                                               Write(Html.DisplayFor(Model => Model.Velocidade));

#line default
#line hidden
#nullable disable
            WriteLiteral(" km/h</p>\r\n");
#nullable restore
#line 28 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
 if (Model.Autoloader)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 30 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
  Write(Html.DisplayNameFor(Model => Model.Autoloader));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 31 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Não possui carregador automático</p>\r\n");
#nullable restore
#line 35 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
 if (Model.MBT)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 38 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
  Write(Html.DisplayNameFor(Model => Model.MBT));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 39 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Não é um MBT</p>\r\n");
#nullable restore
#line 43 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cf5ac209375fd6c24039ecdc71ced7dde150d2111880", async() => {
                WriteLiteral("Atualizar informações");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
                                                                                    WriteLiteral(Model.Id);

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
            WriteLiteral("\r\n    <button type=\"button\" class=\"btn btn-primary\" data-toggle=\"modal\" data-target=\"#exampleModalCenter\" style=\"margin-left: 1vh;\">Deletar tanque (Usando modal)</button>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cf5ac209375fd6c24039ecdc71ced7dde150d2114556", async() => {
                WriteLiteral("Deletar tanque (Usando rota adicional)");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
                                                                              WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle"">CONFIRMAR DELEÇÃO</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ATENÇÃO! VOCÊ ESTÁ PRESTES A DELETAR UM REGISTRO, TEM CERTEZA DO QUE ESTÁ FAZENDO?
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1cf5ac209375fd6c24039ecdc71ced7dde150d2118090", async() => {
                WriteLiteral("Confirmar deleção");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\caio\Desktop\ArsenalDeTanques\Views\ReadSingle\Index2.cshtml"
                                                                                                   WriteLiteral(Model.Id);

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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TanqueMedio> Html { get; private set; }
    }
}
#pragma warning restore 1591