#pragma checksum "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Exercises\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e6e6357352e5e8d6903100dd79d9f5dae1a3951"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exercises_Index), @"mvc.1.0.view", @"/Views/Exercises/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Exercises/Index.cshtml", typeof(AspNetCore.Views_Exercises_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e6e6357352e5e8d6903100dd79d9f5dae1a3951", @"/Views/Exercises/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bae3dac0dc5d195cfb606d7b7ac9ff8ae977575d", @"/Views/_ViewImports.cshtml")]
    public class Views_Exercises_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<StudentExercisesMVC.Models.Exercise>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Exercises\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(100, 29, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(129, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e6e6357352e5e8d6903100dd79d9f5dae1a39513998", async() => {
                BeginContext(152, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(166, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(259, 46, false);
#line 16 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Exercises\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ExerciseId));

#line default
#line hidden
            EndContext();
            BeginContext(305, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(361, 48, false);
#line 19 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Exercises\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ExerciseName));

#line default
#line hidden
            EndContext();
            BeginContext(409, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(465, 44, false);
#line 22 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Exercises\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Language));

#line default
#line hidden
            EndContext();
            BeginContext(509, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 28 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Exercises\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(627, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(676, 45, false);
#line 31 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Exercises\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ExerciseId));

#line default
#line hidden
            EndContext();
            BeginContext(721, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(777, 47, false);
#line 34 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Exercises\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ExerciseName));

#line default
#line hidden
            EndContext();
            BeginContext(824, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(880, 43, false);
#line 37 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Exercises\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Language));

#line default
#line hidden
            EndContext();
            BeginContext(923, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(979, 61, false);
#line 40 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Exercises\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = item.ExerciseId }));

#line default
#line hidden
            EndContext();
            BeginContext(1040, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1061, 67, false);
#line 41 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Exercises\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = item.ExerciseId }));

#line default
#line hidden
            EndContext();
            BeginContext(1128, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1149, 65, false);
#line 42 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Exercises\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.ExerciseId }));

#line default
#line hidden
            EndContext();
            BeginContext(1214, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 45 "C:\Users\NewForce\workspace\StudentExercisesMVC\StudentExercisesMVC\StudentExercisesMVC\Views\Exercises\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1253, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<StudentExercisesMVC.Models.Exercise>> Html { get; private set; }
    }
}
#pragma warning restore 1591
