#pragma checksum "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3431e69437de1a5e8137e61fcd7d01f9e5dfefc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instructors_Details), @"mvc.1.0.view", @"/Views/Instructors/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Instructors/Details.cshtml", typeof(AspNetCore.Views_Instructors_Details))]
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
#line 1 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\_ViewImports.cshtml"
using StudentExercisesMVC;

#line default
#line hidden
#line 2 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\_ViewImports.cshtml"
using StudentExercisesMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3431e69437de1a5e8137e61fcd7d01f9e5dfefc8", @"/Views/Instructors/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bae3dac0dc5d195cfb606d7b7ac9ff8ae977575d", @"/Views/_ViewImports.cshtml")]
    public class Views_Instructors_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StudentExercisesMVC.Models.Instructor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(91, 133, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Instructor</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(225, 38, false);
#line 14 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(263, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(327, 34, false);
#line 17 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Details.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(361, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(424, 45, false);
#line 20 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(469, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(533, 41, false);
#line 23 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Details.cshtml"
       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(574, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(637, 44, false);
#line 26 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(681, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(745, 40, false);
#line 29 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(785, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(848, 47, false);
#line 32 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SlackHandle));

#line default
#line hidden
            EndContext();
            BeginContext(895, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(959, 43, false);
#line 35 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Details.cshtml"
       Write(Html.DisplayFor(model => model.SlackHandle));

#line default
#line hidden
            EndContext();
            BeginContext(1002, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1065, 44, false);
#line 38 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CohortId));

#line default
#line hidden
            EndContext();
            BeginContext(1109, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1173, 40, false);
#line 41 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Details.cshtml"
       Write(Html.DisplayFor(model => model.CohortId));

#line default
#line hidden
            EndContext();
            BeginContext(1213, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1261, 54, false);
#line 46 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Instructors\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(1315, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1323, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3431e69437de1a5e8137e61fcd7d01f9e5dfefc89169", async() => {
                BeginContext(1345, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1361, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StudentExercisesMVC.Models.Instructor> Html { get; private set; }
    }
}
#pragma warning restore 1591
