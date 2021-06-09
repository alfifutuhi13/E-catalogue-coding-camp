#pragma checksum "C:\Users\alfat\Documents\GitHub\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\Candidate\Education.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "490d197c7f4e707ae9a71f30a9918b1054d81bef"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"490d197c7f4e707ae9a71f30a9918b1054d81bef", @"/Views/Candidate/Education.cshtml")]
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
#line 1 "C:\Users\alfat\Documents\GitHub\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\Candidate\Education.cshtml"
   ViewData["Title"] = "E-Catalogue Coding Camp";
    Layout = "/Views/Shared/_LayoutCandidate.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"card-body\">\n    <h1 class=\"product-title\"><strong>Update Education</strong></h1><br />\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "490d197c7f4e707ae9a71f30a9918b1054d81bef4793", async() => {
                WriteLiteral(@"
        <!--Id-->
        <input type=""hidden"" class=""form-control"" id=""id"" name=""id"">
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
            <div class=""in");
                WriteLiteral(@"valid-feedback"">
                Degree is required
            </div>
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
            WriteLiteral("\n</div>\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js""></script>
    <script>
        $(document).ready(function () {
            $(""#registerForm"").submit(function (e) {
                e.preventDefault();
            });

            $.ajax({
                type: ""GET"",
                url: `/Candidate/GetEduId/`,
                success: (data) => {
                    console.log(data);
                    var obj = JSON.parse(data);
                    console.log(obj);

                    if (obj[0]) {
                        $(""#id"").val(`${obj[0].Id}`);
                        $(""#major"").val(`${obj[0].MajorName}`);
                        $(""#univ"").val(`${obj[0].UniversityName}`);
                        $(""#degree"").val(`${obj[0].Degree}`);
                        $(""#gpa"").val(`${obj[0].GPA}`);
                    }
                },
                error: (data) => {
                    console.log(""error"");
                    console.log(JSON.stringify(data));
 ");
                WriteLiteral(@"               }
            })

        })

        $(""#submit"").click(function () {
            let obj = new Object();
            obj.Id = $(""#id"").val();
            obj.Major = $(""#major"").val();
            obj.University = $(""#univ"").val();
            obj.Degree = $(""#degree"").val();
            obj.GPA = $(""#gpa"").val();

            if (obj.Major == """" || obj.University == """" || obj.Degree == """" || obj.GPA == """") {
                sAlertNull();
            } else {
                if (obj.Id == """") {
                    InsertEdu(obj);
                }
                else {
                    UpdateEdu(obj);
                }
            }
        })

        let InsertEdu = (Obj) => {
            console.log(JSON.stringify(Obj));
            alert(JSON.stringify(Obj));
            $.ajax({
                url: '/Candidate/InsertEducation',
                type: 'POST',
                data: Obj
            }).done((result) => {
                console.log(result);
                sAlertAdd();
 ");
                WriteLiteral(@"           }).fail((result) => {
                console.log(result);
                alert(""Failed to Add Data!"");
            });
        }

        let UpdateEdu = (obj) => {
            $.ajax({
                url: ""/Candidate/UpdateEducation"",
                type: ""PUT"",
                data: obj
            }).done((result) => {
                console.log(result);
                if (result == 200) {
                    sAlertPut();
                }
                else {
                    alert(""status code: "" + result);
                }

            }).fail((error) => {
                console.log(error);
                alert(""Data can't be updated."");
            })
        }

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

        let sAlertPut = () => {
");
                WriteLiteral(@"            swal({
                title: ""Done"",
                text: ""Data successfully updated."",
                icon: ""success"",
                button: ""Ok"",
            }).then(() => {
                location.reload(true);
            });
        }

        let sAlertNull = () => {
            swal({
                title: ""Empty Data"",
                text: ""All fields should not be empty."",
                icon: ""warning"",
                button: ""Ok"",
            })
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
