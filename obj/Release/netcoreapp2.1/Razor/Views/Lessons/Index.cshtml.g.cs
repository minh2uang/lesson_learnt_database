#pragma checksum "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "498ef15fee0396ddc6b7a6209d2ad1b12633518d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lessons_Index), @"mvc.1.0.view", @"/Views/Lessons/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Lessons/Index.cshtml", typeof(AspNetCore.Views_Lessons_Index))]
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
#line 2 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"498ef15fee0396ddc6b7a6209d2ad1b12633518d", @"/Views/Lessons/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b44e32a45c90ab7a49507df3124d84ae18ac4176", @"/Views/_ViewImports.cshtml")]
    public class Views_Lessons_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lessons_Learned_Database.ViewModels.LessonIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_searchPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Lessons", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("font-size:20px; margin-top:-25px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ratings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(103, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
  
    ViewData["Title"] = "";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(286, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8bdc565372504839898c8411e4267ec7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(319, 70, true);
            WriteLiteral("\r\n<style>\r\n    a:hover {\r\n    text-decoration:none;\r\n    }\r\n</style>\r\n");
            EndContext();
#line 16 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
 foreach (var m in Model.lessons)
{
    double rate = 0;
    int yourRatingNumber =0 ;

    {
        double count = 0;
        foreach (var n in Model.ratings)
        {
            if (n.LessonId == m.LessonId)
            {
                rate = rate + (double)n.RatingNumber;
                count++;
            }

        }
        rate = System.Math.Round(rate / count, 2);
    }

#line default
#line hidden
            BeginContext(795, 217, true);
            WriteLiteral("    <div class=\"card\">\r\n        <div class=\"row no-gutters\">\r\n            \r\n            <div class=\"col-md-10 col-sm-10 col-xs-10\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\">");
            EndContext();
            BeginContext(1012, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d54f9865099145cab68c7d8998df5456", async() => {
                BeginContext(1104, 3, true);
                WriteLiteral("<b>");
                EndContext();
                BeginContext(1108, 13, false);
#line 39 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
                                                                                                                                     Write(m.LessonTitle);

#line default
#line hidden
                EndContext();
                BeginContext(1121, 4, true);
                WriteLiteral("</b>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
                                                                                             WriteLiteral(m.LessonId);

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
            BeginContext(1129, 102, true);
            WriteLiteral("</h5>\r\n                    <p style=\"margin-top:-10px; font-size:12px;\" class=\"card-text\">Project:<i> ");
            EndContext();
            BeginContext(1232, 13, false);
#line 40 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
                                                                                          Write(m.ProjectName);

#line default
#line hidden
            EndContext();
            BeginContext(1245, 77, true);
            WriteLiteral("</i></p>\r\n                    <p class=\"card-text\" style=\"margin-top:-10px;\">");
            EndContext();
            BeginContext(1323, 10, false);
#line 41 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
                                                              Write(m.Abstract);

#line default
#line hidden
            EndContext();
            BeginContext(1333, 106, true);
            WriteLiteral("</p>\r\n                    <div class=\"js-rate mr-5\" style=\"display:inline-flex\">\r\n                        ");
            EndContext();
            BeginContext(1439, 667, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ef7b2308aa14b93a46a49b7bb00991d", async() => {
                BeginContext(1585, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 44 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
                             for (int i = 0; i < 5; i++)
                            {
                                if (i < System.Math.Round(rate, 0))
                                {

#line default
#line hidden
                BeginContext(1780, 57, true);
                WriteLiteral("                                    <span>&#9733</span>\r\n");
                EndContext();
#line 49 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
                BeginContext(1945, 57, true);
                WriteLiteral("                                    <span>&#9734</span>\r\n");
                EndContext();
#line 53 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
                                }

                            }

#line default
#line hidden
                BeginContext(2068, 2, true);
                WriteLiteral(" (");
                EndContext();
                BeginContext(2071, 4, false);
#line 55 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
                          Write(rate);

#line default
#line hidden
                EndContext();
                BeginContext(2075, 27, true);
                WriteLiteral(")\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 43 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
                                                                                                        WriteLiteral(m.LessonId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 43 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
                                                                                                                                      Write(rate);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("data-rate", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2106, 32, true);
            WriteLiteral("\r\n                    </div>\r\n\r\n");
            EndContext();
#line 59 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
                      
                        var yourrating = Model.ratings.FirstOrDefault(c => c.LessonId == m.LessonId && c.IdentityUserId == UserManager.GetUserId(User));
                        if (yourrating != null)
                        {
                            yourRatingNumber = yourrating.RatingNumber;
                        }

                    

#line default
#line hidden
            BeginContext(2517, 39, true);
            WriteLiteral("                    <div data-islogin=\"");
            EndContext();
            BeginContext(2557, 30, false);
#line 67 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
                                  Write(SignInManager.IsSignedIn(User));

#line default
#line hidden
            EndContext();
            BeginContext(2587, 18, true);
            WriteLiteral("\" data-yourrating=");
            EndContext();
            BeginContext(2606, 16, false);
#line 67 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
                                                                                   Write(yourRatingNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2622, 16, true);
            WriteLiteral(" data-lessonId=\"");
            EndContext();
            BeginContext(2639, 10, false);
#line 67 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
                                                                                                                    Write(m.LessonId);

#line default
#line hidden
            EndContext();
            BeginContext(2649, 15, true);
            WriteLiteral("\" data-userId=\"");
            EndContext();
            BeginContext(2665, 27, false);
#line 67 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
                                                                                                                                              Write(UserManager.GetUserId(User));

#line default
#line hidden
            EndContext();
            BeginContext(2692, 21, true);
            WriteLiteral("\" asp-action=\"create\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 2713, "\"", 2739, 1);
#line 67 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
WriteAttributeValue("", 2728, m.LessonId, 2728, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2740, 31, true);
            WriteLiteral(" class=\"js-yourrate\" data-rate=");
            EndContext();
            BeginContext(2772, 4, false);
#line 67 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
                                                                                                                                                                                                                                                         Write(rate);

#line default
#line hidden
            EndContext();
            BeginContext(2776, 131, true);
            WriteLiteral(" asp-controller=\"ratings\" style=\"display:none; max-width:300px\">\r\n                        \r\n                        Your Rating :\r\n");
            EndContext();
#line 70 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
                         for (int i = 0; i < 5; i++)
                        {
                            if (i < yourRatingNumber)
                            {

#line default
#line hidden
            BeginContext(3074, 99, true);
            WriteLiteral("                                <a style=\"font-size:20px\" class=\"js-star mr-3\" href=\"\">&#9733</a>\r\n");
            EndContext();
#line 75 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(3269, 99, true);
            WriteLiteral("                                <a style=\"font-size:20px\" class=\"js-star mr-3\" href=\"\">&#9734</a>\r\n");
            EndContext();
#line 79 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"

                            }

                        }

#line default
#line hidden
            BeginContext(3430, 56, true);
            WriteLiteral("                    </div>\r\n                    <br />\r\n");
            EndContext();
#line 85 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
                     if (SignInManager.IsSignedIn(User))
                    {

#line default
#line hidden
            BeginContext(3567, 50, true);
            WriteLiteral("                        <a href=\"\" data-lesson-id=");
            EndContext();
            BeginContext(3618, 10, false);
#line 87 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
                                             Write(m.LessonId);

#line default
#line hidden
            EndContext();
            BeginContext(3628, 53, true);
            WriteLiteral(" class=\"card-link js-delete text-danger\">Delete</a>\r\n");
            EndContext();
#line 88 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"

                    }

#line default
#line hidden
            BeginContext(3706, 72, true);
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 94 "D:\Users\daimenrees\Source\Repos\damoenceno\Lessons-Learned-Database\Views\Lessons\Index.cshtml"
}

#line default
#line hidden
            BeginContext(3781, 2427, true);
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        $("".js-delete"").on(""click"", function (event) {
            event.preventDefault();
            var button = $(this);
            if (confirm(""Do you want to delete?"")) {
                $.ajax({
                    url: ""/lessons/delete/"" + $(this).attr(""data-lesson-id""),
                    method: ""DELETE"",
                    success: function () {
                        button.closest("".card"").remove();
                    }
                })
            }
        })

        $("".js-rate"").on(""click"", function (event) {
            event.preventDefault();
            $(this).parent("".card-body"").children("".js-yourrate"").toggle();

        });

        $("".js-star"").on(""mouseenter"", function (event) {
            var currentIndex = $(this).index();
            $(this).parent(""div"").children("".js-star"").each(function () {
                if ($(this).index() <= currentIndex) {
                    $(this).html(""&#9733"");
     ");
            WriteLiteral(@"           } else {
                    $(this).html(""&#9734"");
                }
            });

          
        })
     

        

        $("".js-yourrate"").on(""mouseleave"", function (event) {
            var yourrating =  $(this).attr(""data-yourrating"");
            $(this).children("".js-star"").each(function () {
                if ($(this).index() + 1 <= yourrating) {
                             $(this).html(""&#9733"");                 
                } else {
                    $(this).html(""&#9734"");
                }

            })

        })

       
        $("".js-star"").on(""click"", function (event) {
            event.preventDefault();
            if ($(this).parent(""div"").attr(""data-islogin"") == ""True"") {
                $.ajax({
                    url: ""/ratings/create"",
                    method: ""POST"",
                    data: { 'rating.RatingNumber': $(this).index() + 1, 'rating.LessonId': $(this).parent(""div"").attr(""data-lessonId""), 'rating.IdentityU");
            WriteLiteral(@"serId': $(this).parent(""div"").attr(""data-userId"") },
                    success: function () {
                        console.log(""success"");
                        location.reload();
                    }
                });

            } else {
                alert(""You must login first"");
            }
            
        })


    })




</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lessons_Learned_Database.ViewModels.LessonIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591