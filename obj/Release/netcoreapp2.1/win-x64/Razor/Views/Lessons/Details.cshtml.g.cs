#pragma checksum "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "733126db045f3461267cc3b1c2c4dafc2c9a8af1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lessons_Details), @"mvc.1.0.view", @"/Views/Lessons/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Lessons/Details.cshtml", typeof(AspNetCore.Views_Lessons_Details))]
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
#line 1 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\_ViewImports.cshtml"
using Lessons_Learned_Database;

#line default
#line hidden
#line 2 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\_ViewImports.cshtml"
using Lessons_Learned_Database.Models;

#line default
#line hidden
#line 1 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"733126db045f3461267cc3b1c2c4dafc2c9a8af1", @"/Views/Lessons/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b44e32a45c90ab7a49507df3124d84ae18ac4176", @"/Views/_ViewImports.cshtml")]
    public class Views_Lessons_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lessons_Learned_Database.Models.Lesson>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:13px; margin-top:-15px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(184, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var total = (Model.DateEnd - Model.DateStart).TotalDays;


#line default
#line hidden
            BeginContext(340, 55, true);
            WriteLiteral("\r\n\r\n    <div>\r\n\r\n        <h2 style=\"color:#0A5389;\"><b>");
            EndContext();
            BeginContext(396, 43, false);
#line 16 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Details.cshtml"
                                 Write(Html.DisplayFor(model => model.LessonTitle));

#line default
#line hidden
            EndContext();
            BeginContext(439, 69, true);
            WriteLiteral("</b></h2>\r\n        <i><h5 style=\"font-size:16px; margin-top:-5px\"><b>");
            EndContext();
            BeginContext(509, 43, false);
#line 17 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Details.cshtml"
                                                     Write(Html.DisplayFor(model => model.ProjectName));

#line default
#line hidden
            EndContext();
            BeginContext(552, 19, true);
            WriteLiteral("</b> - Total days: ");
            EndContext();
            BeginContext(572, 5, false);
#line 17 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Details.cshtml"
                                                                                                                    Write(total);

#line default
#line hidden
            EndContext();
            BeginContext(577, 61, true);
            WriteLiteral("</h5></i>\r\n        <h5 style=\"font-size:14px;\">\r\n            ");
            EndContext();
            BeginContext(639, 41, false);
#line 19 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateStart));

#line default
#line hidden
            EndContext();
            BeginContext(680, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(684, 39, false);
#line 19 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Details.cshtml"
                                                    Write(Html.DisplayFor(model => model.DateEnd));

#line default
#line hidden
            EndContext();
            BeginContext(723, 8, true);
            WriteLiteral(" &nbsp; ");
            EndContext();
#line 19 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Details.cshtml"
                                                                                                          if (User.Identity.IsAuthenticated)
        {

#line default
#line hidden
            BeginContext(779, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(791, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "543b24c6bdee4989a8ab746639d4d10f", async() => {
                BeginContext(885, 11, true);
                WriteLiteral("<b>Edit</b>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 21 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Details.cshtml"
                                                                             WriteLiteral(Model.LessonId);

#line default
#line hidden
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
            EndContext();
            BeginContext(900, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 22 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Details.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(938, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(950, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1dd4709aa84c4b83b998df7c283b2a56", async() => {
                BeginContext(1041, 21, true);
                WriteLiteral("<b>Log in to edit</b>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1066, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 26 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(1079, 159, true);
            WriteLiteral("        </h5>\r\n\r\n\r\n        <hr />\r\n        <div style=\"background-color:#F5F6F7; padding:5px 5px 5px 5px;\">\r\n            <h6><b>Abstract</b></h6>\r\n            ");
            EndContext();
            BeginContext(1239, 40, false);
#line 33 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Details.cshtml"
       Write(Html.DisplayFor(model => model.Abstract));

#line default
#line hidden
            EndContext();
            BeginContext(1279, 98, true);
            WriteLiteral("\r\n            <br />\r\n            <br />\r\n            <h6><b>Lesson Learned</b></h6>\r\n            ");
            EndContext();
            BeginContext(1378, 46, false);
#line 37 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Details.cshtml"
       Write(Html.DisplayFor(model => model.LessonsLearned));

#line default
#line hidden
            EndContext();
            BeginContext(1424, 88, true);
            WriteLiteral("\r\n            <br />\r\n            <br />\r\n            <h6><b>Risks identifed during the ");
            EndContext();
            BeginContext(1513, 43, false);
#line 40 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Details.cshtml"
                                         Write(Html.DisplayFor(model => model.ProjectName));

#line default
#line hidden
            EndContext();
            BeginContext(1556, 31, true);
            WriteLiteral(" Project</b></h6>\r\n            ");
            EndContext();
            BeginContext(1588, 36, false);
#line 41 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Details.cshtml"
       Write(Html.DisplayFor(model => model.Risk));

#line default
#line hidden
            EndContext();
            BeginContext(1624, 177, true);
            WriteLiteral("\r\n            <br />\r\n\r\n\r\n\r\n            <hr />\r\n\r\n\r\n            <div class=\"container\">\r\n                <p style=\"font-weight:bold;\" class=\"text-center\">Project properties of: ");
            EndContext();
            BeginContext(1802, 43, false);
#line 50 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Details.cshtml"
                                                                                   Write(Html.DisplayFor(model => model.ProjectName));

#line default
#line hidden
            EndContext();
            BeginContext(1845, 171, true);
            WriteLiteral("</p>\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm\">\r\n\r\n                        <p class=\"text-center\" style=\"font-size:12px;\"><b>Budget:</b> ");
            EndContext();
            BeginContext(2017, 38, false);
#line 54 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Details.cshtml"
                                                                                 Write(Html.DisplayFor(model => model.Budget));

#line default
#line hidden
            EndContext();
            BeginContext(2055, 174, true);
            WriteLiteral("</p>\r\n\r\n                    </div>\r\n\r\n                    <div class=\"col-sm\">\r\n\r\n                        <p class=\"text-center\" style=\"font-size:12px;\"><b>Organization:</b> ");
            EndContext();
            BeginContext(2230, 44, false);
#line 60 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Details.cshtml"
                                                                                       Write(Html.DisplayFor(model => model.Organization));

#line default
#line hidden
            EndContext();
            BeginContext(2274, 174, true);
            WriteLiteral("</p>\r\n\r\n\r\n                    </div>\r\n\r\n                    <div class=\"col-sm\">\r\n\r\n                        <p class=\"text-center\" style=\"font-size:12px;\"><b>Technology:</b> ");
            EndContext();
            BeginContext(2449, 42, false);
#line 67 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Details.cshtml"
                                                                                     Write(Html.DisplayFor(model => model.Technology));

#line default
#line hidden
            EndContext();
            BeginContext(2491, 239, true);
            WriteLiteral("</p>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm\">\r\n\r\n                        <p class=\"text-center\" style=\"font-size:12px;\"><b>Persons Involved:</b> ");
            EndContext();
            BeginContext(2731, 36, false);
#line 76 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Details.cshtml"
                                                                                           Write(Html.DisplayFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(2767, 177, true);
            WriteLiteral("</p>\r\n\r\n                    </div>\r\n\r\n                    <div class=\"col-sm\">\r\n\r\n                        <p class=\"text-center\" style=\"font-size:12px;\"><b>Project Outcome:</b> ");
            EndContext();
            BeginContext(2945, 52, false);
#line 82 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Details.cshtml"
                                                                                          Write(Html.DisplayFor(model => model.ObjectiveAchievement));

#line default
#line hidden
            EndContext();
            BeginContext(2997, 176, true);
            WriteLiteral("</p>\r\n\r\n\r\n                    </div>\r\n\r\n                    <div class=\"col-sm\">\r\n\r\n                        <p class=\"text-center\" style=\"font-size:12px;\"><b>Stakeholders:</b> ");
            EndContext();
            BeginContext(3174, 43, false);
#line 89 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Details.cshtml"
                                                                                       Write(Html.DisplayFor(model => model.Stakeholder));

#line default
#line hidden
            EndContext();
            BeginContext(3217, 153, true);
            WriteLiteral("</p>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n        <div>\r\n            <center>\r\n                ");
            EndContext();
            BeginContext(3370, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b0b70f12a3c49838dbed1e25136250c", async() => {
                BeginContext(3392, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3408, 57, true);
            WriteLiteral("\r\n            </center>\r\n        </div>\r\n\r\n    </div>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lessons_Learned_Database.Models.Lesson> Html { get; private set; }
    }
}
#pragma warning restore 1591
