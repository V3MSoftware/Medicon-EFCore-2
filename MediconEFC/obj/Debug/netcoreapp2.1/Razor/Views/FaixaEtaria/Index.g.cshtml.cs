#pragma checksum "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\FaixaEtaria\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08c1f04bdefd7d788b60438691469785886ecf8a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FaixaEtaria_Index), @"mvc.1.0.view", @"/Views/FaixaEtaria/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/FaixaEtaria/Index.cshtml", typeof(AspNetCore.Views_FaixaEtaria_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08c1f04bdefd7d788b60438691469785886ecf8a", @"/Views/FaixaEtaria/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d29e30e773b761a40083bcc1afbf2547a9061d5", @"/Views/_ViewImports.cshtml")]
    public class Views_FaixaEtaria_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MediconEFC.Models.FaixaEtaria>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary carregar hidden-print"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info carregar hidden-print"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnDelete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger cssDeleteConfirm carregar hidden-print"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\FaixaEtaria\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(141, 210, true);
            WriteLiteral("\r\n\r\n<div class=\"panel panel-primary \">\r\n    <div class=\"panel-heading panel panel-primary text-center small\">\r\n        <h3 class=\"panel-title\">Faixa etária</h3>\r\n    </div>\r\n    <p class=\"pCreateNew\">\r\n        ");
            EndContext();
            BeginContext(351, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26d1059f67694564b0a6e34a04f55937", async() => {
                BeginContext(398, 17, true);
                WriteLiteral("Nova faixa etária");
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
            BeginContext(419, 454, true);
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
                                <th width=""60%"">
                                    ");
            EndContext();
            BeginContext(874, 45, false);
#line 26 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\FaixaEtaria\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(919, 186, true);
            WriteLiteral("\r\n                                </th>\r\n                                <th></th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
            EndContext();
#line 32 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\FaixaEtaria\Index.cshtml"
                             foreach (var item in Model)
                            {


#line default
#line hidden
            BeginContext(1196, 120, true);
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(1317, 44, false);
#line 37 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\FaixaEtaria\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Descricao));

#line default
#line hidden
            EndContext();
            BeginContext(1361, 129, true);
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n\r\n                                        ");
            EndContext();
            BeginContext(1490, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6f6d7b2ff694a7f8c1f875a4cfad17b", async() => {
                BeginContext(1581, 7, true);
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
#line 41 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\FaixaEtaria\Index.cshtml"
                                                               WriteLiteral(item.Id);

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
            BeginContext(1592, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(1634, 104, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "838b2f0ac8964292942a82e5ea1884bc", async() => {
                BeginContext(1725, 9, true);
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
#line 42 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\FaixaEtaria\Index.cshtml"
                                                                  WriteLiteral(item.Id);

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
            BeginContext(1738, 92, true);
            WriteLiteral("\r\n                                        <input type=\"button\" id=\"btnDelete\" value=\"Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1830, "\"", 1853, 1);
#line 43 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\FaixaEtaria\Index.cshtml"
WriteAttributeValue("", 1845, item.Id, 1845, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1854, 122, true);
            WriteLiteral(" class=\"btn btn-danger cssDelete\" />\r\n\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 47 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\FaixaEtaria\Index.cshtml"
                            }

#line default
#line hidden
            BeginContext(2007, 136, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
            BeginContext(2160, 568, true);
            WriteLiteral(@"</div>


<div class=""modal fade"" data-backdrop=""static"" id=""ModalDelete"" role=""dialog"">
    <div class=""modal-dialog"">

        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"">Mensagem de confirmação</h4>
            </div>
            <div class=""modal-body"">
                <input type=""hidden"" id=""idDelete"" value="""" />
                <p> Deseja realmente excluir a faixa etária?</p>
            </div>
            <div class=""modal-footer"">
                ");
            EndContext();
            BeginContext(2728, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a86ccbb5216d42cea0629383317cddb3", async() => {
                BeginContext(2828, 3, true);
                WriteLiteral("Sim");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2835, 798, true);
            WriteLiteral(@"
                <input type=""button"" id=""btnFecharModal"" value=""Não"" class=""btn btn-default"" />

            </div>
        </div>

    </div>
</div>

<!-- Modal -->
<div class=""modal fade"" data-backdrop=""static"" id=""ModalResult"" role=""dialog"">
    <div class=""modal-dialog"">

        <!-- Modal content-->
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""tipoMensagemResult""></h4>
            </div>
            <div class=""modal-body"">
                <p id=""MsgResult""></p>
            </div>
            <div class=""modal-footer"">
                <input type=""button"" id=""btnFecharModalResult"" value=""Fechar"" class=""btn btn-default"" />

            </div>
        </div>

    </div>
</div>


");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3650, 1210, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $('.cssDelete').on('click', function () {
            var id = $(this).attr(""asp-route-id"");
            $('.cssDeleteConfirm').attr('asp-route-id', id);
            $('#ModalDelete').modal(""show"");
        });

        $('#btnFecharModal').on('click', function () {
            $(""#ModalDelete"").modal(""hide"");
        });

        $(""body"").on(""click"", "".cssDeleteConfirm"", function (e) {
            e.preventDefault();

            $(""#ModalDelete"").modal(""hide"");

            var _id = $(this).attr(""asp-route-id"");
            $.ajax({
                contentType: 'application/json; charset=utf-8',
                dataType: 'json',
                type: 'GET',
                url: 'FaixaEtaria/ExcluirFaixaEtaria',
                data: { id: _id },
                success: function (data) {
                    $(""#tipoMensagemResult"").text(data.TituloMensagem);
                    $(""#MsgResult"").html(data.DescricaoMensagem);
           ");
                WriteLiteral("         $(\'#ModalResult\').modal(\"show\");\r\n                }\r\n            });\r\n        });\r\n\r\n        $(\"#btnFecharModalResult\").click(function () {\r\n            window.location.href = \'");
                EndContext();
                BeginContext(4861, 34, false);
#line 135 "C:\V3MSoftwareDev\MediconEFC\MediconEFC\Views\FaixaEtaria\Index.cshtml"
                               Write(Url.Action("Index", "FaixaEtaria"));

#line default
#line hidden
                EndContext();
                BeginContext(4895, 36, true);
                WriteLiteral("\';\r\n        });\r\n\r\n\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MediconEFC.Models.FaixaEtaria>> Html { get; private set; }
    }
}
#pragma warning restore 1591
