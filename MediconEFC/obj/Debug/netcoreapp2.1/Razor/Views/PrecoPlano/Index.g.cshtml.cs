#pragma checksum "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\PrecoPlano\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e83a3ea4e70fdd3bd6c0344de881bfde112255aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PrecoPlano_Index), @"mvc.1.0.view", @"/Views/PrecoPlano/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/PrecoPlano/Index.cshtml", typeof(AspNetCore.Views_PrecoPlano_Index))]
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
#line 1 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\_ViewImports.cshtml"
using MediconEFC;

#line default
#line hidden
#line 2 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\_ViewImports.cshtml"
using MediconEFC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e83a3ea4e70fdd3bd6c0344de881bfde112255aa", @"/Views/PrecoPlano/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d29e30e773b761a40083bcc1afbf2547a9061d5", @"/Views/_ViewImports.cshtml")]
    public class Views_PrecoPlano_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MediconEFC.Models.PrecoPlanoViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary carregar hidden-print"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info carregar hidden-print"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\PrecoPlano\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(149, 204, true);
            WriteLiteral("\r\n\r\n<div class=\"panel panel-primary \">\r\n    <div class=\"panel-heading panel panel-primary text-center small\">\r\n        <h3 class=\"panel-title\">Equipe</h3>\r\n    </div>\r\n    <p class=\"pCreateNew\">\r\n        ");
            EndContext();
            BeginContext(353, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16268ac4ff8b42c3a6c7627b6bc21f13", async() => {
                BeginContext(400, 11, true);
                WriteLiteral("Nova equipe");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(415, 442, true);
            WriteLiteral(@"
    </p>
    <hr />
    <div class=""row-fluid"">
        <!-- block -->
        <div class=""block"">
            <div class=""block-content collapse in"">
                <div class=""span12"">
                    <table class=""table table-hover table-striped table-bordered"" id=""tabelaOrdenada"">
                        <thead>
                            <tr>
                                <th>
                                    ");
            EndContext();
            BeginContext(858, 58, false);
#line 26 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\PrecoPlano\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.precoPlano.FaixaEtaria));

#line default
#line hidden
            EndContext();
            BeginContext(916, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(1032, 61, false);
#line 29 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\PrecoPlano\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.precoPlano.TipoAcomodacao));

#line default
#line hidden
            EndContext();
            BeginContext(1093, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(1209, 63, false);
#line 32 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\PrecoPlano\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.precoPlano.AbrangenciaPlano));

#line default
#line hidden
            EndContext();
            BeginContext(1272, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(1388, 59, false);
#line 35 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\PrecoPlano\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.precoPlano.TipoContrato));

#line default
#line hidden
            EndContext();
            BeginContext(1447, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(1563, 56, false);
#line 38 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\PrecoPlano\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.precoPlano.TipoPlano));

#line default
#line hidden
            EndContext();
            BeginContext(1619, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(1735, 52, false);
#line 41 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\PrecoPlano\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.precoPlano.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1787, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(1903, 57, false);
#line 44 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\PrecoPlano\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.precoPlano.Observacao));

#line default
#line hidden
            EndContext();
            BeginContext(1960, 115, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
            EndContext();
            BeginContext(2076, 52, false);
#line 47 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\PrecoPlano\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.precoPlano.Ativo));

#line default
#line hidden
            EndContext();
            BeginContext(2128, 186, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th></th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 53 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\PrecoPlano\Index.cshtml"
                             foreach (var item in Model)
                            {


#line default
#line hidden
            BeginContext(2405, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2514, 67, false);
#line 58 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\PrecoPlano\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.precoPlano.FaixaEtaria.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(2581, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2697, 65, false);
#line 61 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\PrecoPlano\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.precoPlano.TipoAcomodacao.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(2762, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2878, 67, false);
#line 64 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\PrecoPlano\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.precoPlano.AbrangenciaPlano.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(2945, 147, true);
            WriteLiteral("\r\n                                </td>                                \r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3093, 63, false);
#line 67 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\PrecoPlano\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.precoPlano.TipoContrato.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(3156, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3272, 60, false);
#line 70 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\PrecoPlano\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.precoPlano.TipoPlano.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(3332, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3448, 51, false);
#line 73 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\PrecoPlano\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.precoPlano.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(3499, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3615, 56, false);
#line 76 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\PrecoPlano\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.precoPlano.Observacao));

#line default
#line hidden
            EndContext();
            BeginContext(3671, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3787, 51, false);
#line 79 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\PrecoPlano\Index.cshtml"
                               Write(Html.DisplayFor(modelItem => item.precoPlano.Ativo));

#line default
#line hidden
            EndContext();
            BeginContext(3838, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3953, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f575b6d2e08e4399a0316c899815d601", async() => {
                BeginContext(4055, 7, true);
                WriteLiteral("Alterar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 82 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\PrecoPlano\Index.cshtml"
                                                           WriteLiteral(item.precoPlano.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4066, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(4104, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44e0c97688884a24ab5978a7a71e379c", async() => {
                BeginContext(4206, 9, true);
                WriteLiteral("Histórico");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 83 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\PrecoPlano\Index.cshtml"
                                                              WriteLiteral(item.precoPlano.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(4219, 88, true);
            WriteLiteral("\r\n                                    <input type=\"button\" id=\"btnDelete\" value=\"Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 4307, "\"", 4341, 1);
#line 84 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\PrecoPlano\Index.cshtml"
WriteAttributeValue("", 4322, item.precoPlano.Id, 4322, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4342, 112, true);
            WriteLiteral(" class=\"btn btn-danger cssDelete\" />\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 87 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\PrecoPlano\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(4485, 142, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MediconEFC.Models.PrecoPlanoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
