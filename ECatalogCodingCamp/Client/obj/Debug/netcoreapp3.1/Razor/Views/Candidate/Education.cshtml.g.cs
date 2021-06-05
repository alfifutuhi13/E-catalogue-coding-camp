#pragma checksum "D:\Visual Studio Source\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\Candidate\Education.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d710f173e4675c5aa95959ac7e12c92c6d6c918"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidate_Education), @"mvc.1.0.view", @"/Views/Candidate/Education.cshtml")]
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
#line 1 "D:\Visual Studio Source\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\_ViewImports.cshtml"
using Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual Studio Source\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\_ViewImports.cshtml"
using Client.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d710f173e4675c5aa95959ac7e12c92c6d6c918", @"/Views/Candidate/Education.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_Candidate_Education : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "D:\Visual Studio Source\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\Candidate\Education.cshtml"
  
    ViewData["Title"] = "E-Catalogue Coding Camp";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card-body\">\r\n    <h4 class=\"card-title\">Update Education</h4>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4d710f173e4675c5aa95959ac7e12c92c6d6c9184691", async() => {
                WriteLiteral(@"
        <!--Major-->
        <div class=""form-group"">
            <label for=""name"">Major</label>
            <input id=""major"" type=""text"" class=""form-control"" name=""major"" placeholder=""Ex: Teknik Informatika"" required autofocus>
            <div class=""invalid-feedback"">
                Major is required
            </div>
        </div>
        <!--Univ-->
        <div class=""form-group"">
            <label for=""univ"">University</label>
            <input id=""univ"" type=""email"" class=""form-control"" name=""univ"" placeholder=""Ex: Institut Teknologi Bandung"" required>
            <div class=""invalid-feedback"">
                University is required
            </div>
        </div>
        <!--Degree-->
        <div class=""form-group"">
            <label for=""degree"">Degree</label>
            <input id=""degree"" type=""text"" class=""form-control"" name=""degree"" placeholder=""Ex: S1"" required data-eye>
            <div class=""invalid-feedback"">
                Degree is required
            ");
                WriteLiteral(@"</div>
        </div>
        <!--GPA-->
        <div class=""form-group"">
            <label for=""gpa"">GPA</label>
            <input id=""gpa"" type=""text"" class=""form-control"" name=""gpa"" placeholder=""Ex: 3.99"" required data-eye>
            <div class=""invalid-feedback"">GPA is required</div>
        </div>

        <button type=""submit"" class=""btn btn-primary btn-block"" id=""submit"">Update</button>

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
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js""></script>
    <script>
        $(document).ready(function () {
            $(""#registerForm"").submit(function (e) {
                e.preventDefault();
            });
        })

        let InsertEdu = () => {
            let Obj = new Object();
            Obj.Major = $(""#major"").val();
            Obj.University = $(""#univ"").val();
            Obj.Degree = $(""#degree"").val();
            Obj.GPA = $(""#gpa"").val();

            console.log(JSON.stringify(Obj));
            alert(JSON.stringify(Obj));
            $.ajax({
                url: '/Candidate/InsertEducation',
                type: 'POST',
                data: Obj
            }).done((result) => {
                console.log(result);
                sAlertAdd();
            }).fail((result) => {
                console.log(result);
                alert(""Failed to Add Data!"");
            });
        }

        $(""#submit"").click(");
                WriteLiteral(@"function () {
            InsertEdu();
        })

        let sAlertAdd = () => {
            swal({
                title: ""Done"",
                text: ""Data successfully added."",
                icon: ""success"",
                button: ""Ok"",
            }).then(() => {
                location.reload(true);
            });
        }


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
