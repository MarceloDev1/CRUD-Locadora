#pragma checksum "C:\Users\MARCELOROCHA\OneDrive - UXComex Tecnologia LTDA\Área de Trabalho\CRUD Locadora\CRUDLocadora\CRUDLocadora\Views\Locadora\ListarLocadora.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f68cf8b4fd43812e1259c05f485b1ec28a80432"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Locadora_ListarLocadora), @"mvc.1.0.view", @"/Views/Locadora/ListarLocadora.cshtml")]
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
#line 1 "C:\Users\MARCELOROCHA\OneDrive - UXComex Tecnologia LTDA\Área de Trabalho\CRUD Locadora\CRUDLocadora\CRUDLocadora\Views\_ViewImports.cshtml"
using CRUDLocadora;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MARCELOROCHA\OneDrive - UXComex Tecnologia LTDA\Área de Trabalho\CRUD Locadora\CRUDLocadora\CRUDLocadora\Views\_ViewImports.cshtml"
using CRUDLocadora.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f68cf8b4fd43812e1259c05f485b1ec28a80432", @"/Views/Locadora/ListarLocadora.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0449f88cb78da6646077078610e0ccb867ea9d41", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Locadora_ListarLocadora : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CRUDLocadora.Models.FiltroLocadoraModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CadastrarLocadora", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-block btn-info btn-social"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("BuscarLocadora"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExcluirLocadora", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\MARCELOROCHA\OneDrive - UXComex Tecnologia LTDA\Área de Trabalho\CRUD Locadora\CRUDLocadora\CRUDLocadora\Views\Locadora\ListarLocadora.cshtml"
  
    ViewData["Title"] = "Locadora";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f68cf8b4fd43812e1259c05f485b1ec28a804326046", async() => {
                WriteLiteral("\r\n    <section class=\"content\">\r\n        <section class=\"content-header\">\r\n            <h4>Locadoras</h4>\r\n        </section>\r\n        <div class=\"box\">\r\n            ");
#nullable restore
#line 11 "C:\Users\MARCELOROCHA\OneDrive - UXComex Tecnologia LTDA\Área de Trabalho\CRUD Locadora\CRUDLocadora\CRUDLocadora\Views\Locadora\ListarLocadora.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            <div class=\"box-body\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f68cf8b4fd43812e1259c05f485b1ec28a804326851", async() => {
                    WriteLiteral(@"
                    <div class=""row"">
                        <div class=""col-sm-12 col-md-4"">
                            <div class=""form-group"">
                                <label for=""Locadora"">Locadora</label>
                                ");
#nullable restore
#line 18 "C:\Users\MARCELOROCHA\OneDrive - UXComex Tecnologia LTDA\Área de Trabalho\CRUD Locadora\CRUDLocadora\CRUDLocadora\Views\Locadora\ListarLocadora.cshtml"
                           Write(Html.TextBoxFor(x => x.NomeFantasia, new { @class = "form-control", placeholder = "Locadora" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-sm-12 col-md-4"">
                            <div class=""form-group"">
                                <label for=""CNPJ"">CNPJ</label>
                                ");
#nullable restore
#line 24 "C:\Users\MARCELOROCHA\OneDrive - UXComex Tecnologia LTDA\Área de Trabalho\CRUD Locadora\CRUDLocadora\CRUDLocadora\Views\Locadora\ListarLocadora.cshtml"
                           Write(Html.TextBoxFor(x => x.CNPJ, new { @class = "form-control", placeholder = "CNPJ" }));

#line default
#line hidden
#nullable disable
                    WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-sm-12 col-md-2"">
                            <label class=""control-label"">&nbsp;</label>
                            <button type=""submit"" class=""btn btn-block btn-info btn-social""><i class=""fa fa-search""></i> Buscar</button>
                        </div>
                        <div class=""col-sm-12 col-md-2"">
                            <label class=""control-label"">&nbsp;</label>
                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f68cf8b4fd43812e1259c05f485b1ec28a804329003", async() => {
                        WriteLiteral("<i class=\"fa fa-search\"></i> Nova Locadora");
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
                    WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>
        </div>
        <div>
            <table class=""table"">
                <thead>
                    <tr>
                        <th>Locadora</th>
                        <th>CNPJ</th>
                        <th>Telefone</th>
                        <th>E-mail</th>
                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 51 "C:\Users\MARCELOROCHA\OneDrive - UXComex Tecnologia LTDA\Área de Trabalho\CRUD Locadora\CRUDLocadora\CRUDLocadora\Views\Locadora\ListarLocadora.cshtml"
                     foreach (var locadora in Model.ListaLocadora)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 54 "C:\Users\MARCELOROCHA\OneDrive - UXComex Tecnologia LTDA\Área de Trabalho\CRUD Locadora\CRUDLocadora\CRUDLocadora\Views\Locadora\ListarLocadora.cshtml"
                           Write(locadora.NomeFantasia);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 55 "C:\Users\MARCELOROCHA\OneDrive - UXComex Tecnologia LTDA\Área de Trabalho\CRUD Locadora\CRUDLocadora\CRUDLocadora\Views\Locadora\ListarLocadora.cshtml"
                           Write(locadora.CNPJ);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 56 "C:\Users\MARCELOROCHA\OneDrive - UXComex Tecnologia LTDA\Área de Trabalho\CRUD Locadora\CRUDLocadora\CRUDLocadora\Views\Locadora\ListarLocadora.cshtml"
                           Write(locadora.Telefone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 57 "C:\Users\MARCELOROCHA\OneDrive - UXComex Tecnologia LTDA\Área de Trabalho\CRUD Locadora\CRUDLocadora\CRUDLocadora\Views\Locadora\ListarLocadora.cshtml"
                           Write(locadora.Email);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>\r\n                                <a");
                BeginWriteAttribute("href", " href=\"", 2670, "\"", 2733, 2);
                WriteAttributeValue("", 2677, "/Locadora/EditarLocadora?idLocadora=", 2677, 36, true);
#nullable restore
#line 59 "C:\Users\MARCELOROCHA\OneDrive - UXComex Tecnologia LTDA\Área de Trabalho\CRUD Locadora\CRUDLocadora\CRUDLocadora\Views\Locadora\ListarLocadora.cshtml"
WriteAttributeValue("", 2713, locadora.IdLocadora, 2713, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\" target=\"_blank\">Editar</a>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f68cf8b4fd43812e1259c05f485b1ec28a8043214790", async() => {
                    WriteLiteral("Excluir");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-idLocadora", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\MARCELOROCHA\OneDrive - UXComex Tecnologia LTDA\Área de Trabalho\CRUD Locadora\CRUDLocadora\CRUDLocadora\Views\Locadora\ListarLocadora.cshtml"
                                                                          WriteLiteral(locadora.IdLocadora);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idLocadora"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idLocadora", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idLocadora"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 63 "C:\Users\MARCELOROCHA\OneDrive - UXComex Tecnologia LTDA\Área de Trabalho\CRUD Locadora\CRUDLocadora\CRUDLocadora\Views\Locadora\ListarLocadora.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </section>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CRUDLocadora.Models.FiltroLocadoraModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
