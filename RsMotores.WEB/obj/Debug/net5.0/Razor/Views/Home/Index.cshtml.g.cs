#pragma checksum "C:\Users\21558\Desktop\Visual Studio\RS MOTORES 09-06-22\RsMotores\RsMotores.WEB\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdff96be50990ae1a119041e0bec753a33627c21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\21558\Desktop\Visual Studio\RS MOTORES 09-06-22\RsMotores\RsMotores.WEB\Views\_ViewImports.cshtml"
using RsMotores.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\21558\Desktop\Visual Studio\RS MOTORES 09-06-22\RsMotores\RsMotores.WEB\Views\_ViewImports.cshtml"
using RsMotores.WEB.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdff96be50990ae1a119041e0bec753a33627c21", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e173621eea024fc620804c64a2adbbeebca619", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RsMotores.WEB.Models.Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Token", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n\r\n<div class=\"text-center\">\r\n    <h1");
            BeginWriteAttribute("style", " style= \"", 77, "\"", 106, 2);
            WriteAttributeValue("", 86, "color:", 86, 6, true);
#nullable restore
#line 6 "C:\Users\21558\Desktop\Visual Studio\RS MOTORES 09-06-22\RsMotores\RsMotores.WEB\Views\Home\Index.cshtml"
WriteAttributeValue("", 92, ViewBag.Color, 92, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 6 "C:\Users\21558\Desktop\Visual Studio\RS MOTORES 09-06-22\RsMotores\RsMotores.WEB\Views\Home\Index.cshtml"
                                 Write(ViewBag.Msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <p>Bem vindo ");
#nullable restore
#line 7 "C:\Users\21558\Desktop\Visual Studio\RS MOTORES 09-06-22\RsMotores\RsMotores.WEB\Views\Home\Index.cshtml"
            Write(Model.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdff96be50990ae1a119041e0bec753a33627c214826", async() => {
                WriteLiteral("Voltar ao in??cio");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<script>\r\n    Swal.fire({\r\n        icon: \'");
#nullable restore
#line 12 "C:\Users\21558\Desktop\Visual Studio\RS MOTORES 09-06-22\RsMotores\RsMotores.WEB\Views\Home\Index.cshtml"
          Write(ViewBag.Icon);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n        title: \'");
#nullable restore
#line 13 "C:\Users\21558\Desktop\Visual Studio\RS MOTORES 09-06-22\RsMotores\RsMotores.WEB\Views\Home\Index.cshtml"
           Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n        text: \'");
#nullable restore
#line 14 "C:\Users\21558\Desktop\Visual Studio\RS MOTORES 09-06-22\RsMotores\RsMotores.WEB\Views\Home\Index.cshtml"
          Write(ViewBag.Msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'\r\n    })\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RsMotores.WEB.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
