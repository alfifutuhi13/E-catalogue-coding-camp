#pragma checksum "C:\Users\alfat\Documents\GitHub\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\Candidate\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bde582bdd4351dd6103c1e3fbf9b4dad5cb3603d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidate_Details), @"mvc.1.0.view", @"/Views/Candidate/Details.cshtml")]
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
#line 1 "C:\Users\alfat\Documents\GitHub\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\_ViewImports.cshtml"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\alfat\Documents\GitHub\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\_ViewImports.cshtml"
using Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bde582bdd4351dd6103c1e3fbf9b4dad5cb3603d", @"/Views/Candidate/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_Candidate_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("my-login-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("novalidate", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("registerForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\alfat\Documents\GitHub\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\Candidate\Details.cshtml"
   ViewData["Title"] = "E-Catalogue Coding Camp";
    Layout = "/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>ID = ");
#nullable restore
#line 4 "C:\Users\alfat\Documents\GitHub\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\Candidate\Details.cshtml"
    Write(ViewData["candidateId"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<div class=\"card-body\">\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bde582bdd4351dd6103c1e3fbf9b4dad5cb3603d4973", async() => {
                WriteLiteral(@"
        <!--Id-->
        <!--Name-->
        <div class=""form-group"">
            <label for=""name"">Name</label>
            <input id=""name"" type=""text"" class=""form-control"">
            <div class=""invalid-feedback"">
                Name is required
            </div>
        </div>
        <!--Email-->
        <div class=""form-group"">
            <label for=""email"">Email</label>
            <input id=""email"" type=""email"" class=""form-control"">
            <div class=""invalid-feedback"">
                Email is required
            </div>
        </div>
        <!--Gender-->
        <div class=""form-group"">
            <label for=""gender"">Gender</label>
            <input id=""gender"" type=""text"" class=""form-control"">
            <div class=""invalid-feedback"">
                gender is required
            </div>
        </div>
        <!--Major-->
        <div class=""form-group"">
            <label for=""major"">Major</label>
            <input id=""major"" type=""text"" class=""form-control"" name=""major"">
      ");
                WriteLiteral(@"      <div class=""invalid-feedback"">
                Major is required
            </div>
        </div>
        <!--Univ-->
        <div class=""form-group"">
            <label for=""univ"">University</label>
            <input id=""univ"" type=""email"" class=""form-control"" name=""univ"">
            <div class=""invalid-feedback"">
                University is required
            </div>
        </div>
        <!--Degree-->
        <div class=""form-group"">
            <label for=""degree"">Degree</label>
            <input id=""degree"" type=""text"" class=""form-control"" name=""degree"">
            <div class=""invalid-feedback"">
                Degree is required
            </div>
        </div>
        <!--GPA-->
        <div class=""form-group"">
            <label for=""gpa"">GPA</label>
            <input id=""gpa"" type=""text"" class=""form-control"" name=""gpa"">
            <div class=""invalid-feedback"">GPA is required</div>
        </div>
        <!-------------------------------------------------------------------------->
 ");
                WriteLiteral(@"       <!--Organization-->
        <div class=""form-group"">
            <label for=""organization"">Major</label>
            <input id=""organization"" type=""text"" class=""form-control"" name=""organization"" readonly>
        </div>
        <!--Skill-->
        <div class=""form-group"">
            <label for=""skill"">Skill</label>
            <input id=""skill"" type=""email"" class=""form-control"" name=""skill"" readonly>
        </div>
        <!--Work-->
        <div class=""form-group"">
            <label for=""work"">Work Experience</label>
            <input id=""work"" type=""text"" class=""form-control"" name=""work"" readonly>
        </div>

    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(" \n    <script>\n        $(document).ready(function () {\n            $(\"#registerForm\").submit(function (e) {\n                e.preventDefault();\n            });\n\n            let candidateId = `");
#nullable restore
#line 90 "C:\Users\alfat\Documents\GitHub\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\Candidate\Details.cshtml"
                          Write(ViewData["candidateId"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`;

                $.ajax({
                    type: ""GET"",
                    url: `GetDetail/`,
                    data: candidateId,
                success: (data) => {
                    console.log(data);
                    var obj = JSON.parse(data);
                    console.log(obj);

                    $(""#name"").val(`${obj.Name}`);
                    $(""#email"").val(`${obj.Email}`);
                    $(""#gender"").val(`${obj.Gender}`);
                    $(""#degree"").val(`${obj.Degree}`);
                    $(""#gpa"").val(`${obj.GPA}`);
                    $(""#major"").val(`${obj.MajorName}`);
                    $(""#univ"").val(`${obj.UnivName}`);

                },
                error: (data) => {
                    console.log(""error"");
                    console.log(JSON.stringify(data));
                }
            })

        })
    </script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591