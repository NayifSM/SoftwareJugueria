#pragma checksum "D:\Projects\Shop.Web\Views\Pedidos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7747c7de91e362927fe40f3b3c3c15a5600cb9fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pedidos_Index), @"mvc.1.0.view", @"/Views/Pedidos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pedidos/Index.cshtml", typeof(AspNetCore.Views_Pedidos_Index))]
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
#line 1 "D:\Projects\Shop.Web\Views\_ViewImports.cshtml"
using Shop.Web;

#line default
#line hidden
#line 2 "D:\Projects\Shop.Web\Views\_ViewImports.cshtml"
using Shop.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7747c7de91e362927fe40f3b3c3c15a5600cb9fb", @"/Views/Pedidos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"035954cda10be0d952b92ea82d8938510ef6a34b", @"/Views/_ViewImports.cshtml")]
    public class Views_Pedidos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ventas.Web.Data.Entities.Pedido>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Deliver", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnDeliver"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("btnDelete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\Shop.Web\Views\Pedidos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(96, 32, true);
            WriteLiteral("\r\n\r\n<h2>Orders</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(128, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "31f38a7c54014ace8bca17b4145bf22c", async() => {
                BeginContext(175, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(189, 58, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n");
            EndContext();
#line 16 "D:\Projects\Shop.Web\Views\Pedidos\Index.cshtml"
             if (this.User.IsInRole("Admin"))
            {

#line default
#line hidden
            BeginContext(309, 10, true);
            WriteLiteral("<th>\r\n    ");
            EndContext();
            BeginContext(320, 59, false);
#line 19 "D:\Projects\Shop.Web\Views\Pedidos\Index.cshtml"
Write(Html.DisplayNameFor(model => model.Usuarios.NombreCompleto));

#line default
#line hidden
            EndContext();
            BeginContext(379, 19, true);
            WriteLiteral("\r\n</th>            ");
            EndContext();
#line 20 "D:\Projects\Shop.Web\Views\Pedidos\Index.cshtml"
                 }

#line default
#line hidden
            BeginContext(401, 34, true);
            WriteLiteral("            <th>\r\n                ");
            EndContext();
            BeginContext(436, 51, false);
#line 22 "D:\Projects\Shop.Web\Views\Pedidos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaOrdenLocal));

#line default
#line hidden
            EndContext();
            BeginContext(487, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(543, 49, false);
#line 25 "D:\Projects\Shop.Web\Views\Pedidos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DeliveryFecha));

#line default
#line hidden
            EndContext();
            BeginContext(592, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(648, 42, false);
#line 28 "D:\Projects\Shop.Web\Views\Pedidos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Lineas));

#line default
#line hidden
            EndContext();
            BeginContext(690, 57, true);
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(748, 44, false);
#line 32 "D:\Projects\Shop.Web\Views\Pedidos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(792, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(848, 41, false);
#line 35 "D:\Projects\Shop.Web\Views\Pedidos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(889, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 41 "D:\Projects\Shop.Web\Views\Pedidos\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1024, 6, true);
            WriteLiteral("<tr>\r\n");
            EndContext();
#line 44 "D:\Projects\Shop.Web\Views\Pedidos\Index.cshtml"
     if (this.User.IsInRole("Admin"))
    {

#line default
#line hidden
            BeginContext(1076, 10, true);
            WriteLiteral("<th>\r\n    ");
            EndContext();
            BeginContext(1087, 58, false);
#line 47 "D:\Projects\Shop.Web\Views\Pedidos\Index.cshtml"
Write(Html.DisplayFor(modelItem => item.Usuarios.NombreCompleto));

#line default
#line hidden
            EndContext();
            BeginContext(1145, 7, true);
            WriteLiteral("\r\n</th>");
            EndContext();
#line 48 "D:\Projects\Shop.Web\Views\Pedidos\Index.cshtml"
     }

#line default
#line hidden
            BeginContext(1155, 18, true);
            WriteLiteral("    <td>\r\n        ");
            EndContext();
            BeginContext(1174, 50, false);
#line 50 "D:\Projects\Shop.Web\Views\Pedidos\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.FechaOrdenLocal));

#line default
#line hidden
            EndContext();
            BeginContext(1224, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(1256, 48, false);
#line 53 "D:\Projects\Shop.Web\Views\Pedidos\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.DeliveryFecha));

#line default
#line hidden
            EndContext();
            BeginContext(1304, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(1336, 41, false);
#line 56 "D:\Projects\Shop.Web\Views\Pedidos\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Lineas));

#line default
#line hidden
            EndContext();
            BeginContext(1377, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(1409, 43, false);
#line 59 "D:\Projects\Shop.Web\Views\Pedidos\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(1452, 31, true);
            WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");
            EndContext();
            BeginContext(1484, 40, false);
#line 62 "D:\Projects\Shop.Web\Views\Pedidos\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
            EndContext();
            BeginContext(1524, 20, true);
            WriteLiteral("\r\n    </td>\r\n    <td");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1544, "\"", 1557, 1);
#line 64 "D:\Projects\Shop.Web\Views\Pedidos\Index.cshtml"
WriteAttributeValue("", 1549, item.Id, 1549, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1558, 11, true);
            WriteLiteral(">\r\n        ");
            EndContext();
            BeginContext(1569, 96, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40d38576c66a4df4b53e9089f8fd634e", async() => {
                BeginContext(1654, 7, true);
                WriteLiteral("Deliver");
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
#line 65 "D:\Projects\Shop.Web\Views\Pedidos\Index.cshtml"
                                  WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1665, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1675, 95, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4a24638dc6a42e3a80f8c3cece9d3fa", async() => {
                BeginContext(1760, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 66 "D:\Projects\Shop.Web\Views\Pedidos\Index.cshtml"
                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1770, 20, true);
            WriteLiteral("\r\n    </td>\r\n\r\n</tr>");
            EndContext();
#line 69 "D:\Projects\Shop.Web\Views\Pedidos\Index.cshtml"
     }

#line default
#line hidden
            BeginContext(1793, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ventas.Web.Data.Entities.Pedido>> Html { get; private set; }
    }
}
#pragma warning restore 1591