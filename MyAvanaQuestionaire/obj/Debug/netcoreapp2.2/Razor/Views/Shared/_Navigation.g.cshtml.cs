#pragma checksum "D:\Work2022\My Avana\MyavanaAdminV2\MyAvanaQuestionaire\MyAvanaQuestionaire\Views\Shared\_Navigation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0fa74a160eb17c01f668735eed75ce68f9610af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Navigation), @"mvc.1.0.view", @"/Views/Shared/_Navigation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Navigation.cshtml", typeof(AspNetCore.Views_Shared__Navigation))]
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
#line 1 "D:\Work2022\My Avana\MyavanaAdminV2\MyAvanaQuestionaire\MyAvanaQuestionaire\Views\_ViewImports.cshtml"
using MyAvanaQuestionaire;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0fa74a160eb17c01f668735eed75ce68f9610af", @"/Views/Shared/_Navigation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c37875464b153390b9fdddd027729aa0982cb99", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Navigation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/Myavana Logo Black.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 291, true);
            WriteLiteral(@"<nav class=""navbar-default navbar-static-side"" role=""navigation"">
    <div class=""sidebar-collapse"" id=""menu"">
        <ul class=""nav metismenu"" id=""side-menu"">
            <li class=""nav-header"">
                <div class=""dropdown profile-element dashboardlogo"">
                    ");
            EndContext();
            BeginContext(291, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a0fa74a160eb17c01f668735eed75ce68f9610af4172", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(349, 463, true);
            WriteLiteral(@"
                    <a data-toggle=""dropdown"" class=""dropdown-toggle text-dark"">
                        <span class=""block m-t-xs font-bold"">Customer</span>
                    </a>
                </div>
            </li>
            <li>
                <a onclick=""IfQuestionaireSubmitted()""><i class=""fa fa-list""></i> <span class=""nav-label"" data-i18n=""nav.metrics"">Questionnaire</span> </a>
            </li>

            <li>
                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 812, "\"", 861, 1);
#line 17 "D:\Work2022\My Avana\MyavanaAdminV2\MyAvanaQuestionaire\MyAvanaQuestionaire\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 819, Url.Action("CustomerHair", "HairProfile"), 819, 42, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(862, 159, true);
            WriteLiteral("><i class=\"fa fa-list\"></i> <span class=\"nav-label\" data-i18n=\"nav.metrics\">Hair Profile</span> </a>\r\n            </li>\r\n\r\n            <li>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1021, "\"", 1075, 1);
#line 21 "D:\Work2022\My Avana\MyavanaAdminV2\MyAvanaQuestionaire\MyAvanaQuestionaire\Views\Shared\_Navigation.cshtml"
WriteAttributeValue("", 1028, Url.Action("LiveSchedule", "LiveConsultation"), 1028, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1076, 364, true);
            WriteLiteral(@"><i class=""fa fa-list""></i> <span class=""nav-label"" data-i18n=""nav.metrics"">Schedule Live Consultation</span> </a>
            </li>

        </ul>
    </div>
</nav>
<script type=""text/javascript"">
    $('#menuCollapse').click(function () {
        $('#menuCollapse').toggleClass('showList');
	});

	function IfQuestionaireSubmitted()
	{
        if (""");
            EndContext();
            BeginContext(1441, 15, false);
#line 34 "D:\Work2022\My Avana\MyavanaAdminV2\MyAvanaQuestionaire\MyAvanaQuestionaire\Views\Shared\_Navigation.cshtml"
        Write(ViewBag.IsExist);

#line default
#line hidden
            EndContext();
            BeginContext(1456, 163, true);
            WriteLiteral("\" == \"True\") {\r\n            window.location.href = \"/Questionaire/Questionnaire\";\r\n\t\t}\r\n\t\telse\r\n\t\t\twindow.location.href = \"/Questionaire/start\";\r\n\t}\r\n\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591