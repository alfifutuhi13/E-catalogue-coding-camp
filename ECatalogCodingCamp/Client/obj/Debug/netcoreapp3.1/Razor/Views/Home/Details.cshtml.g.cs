#pragma checksum "D:\Visual Studio Source\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7d528c53d1932133edc81780daeb6f157ad40e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7d528c53d1932133edc81780daeb6f157ad40e3", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "D:\Visual Studio Source\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\Home\Details.cshtml"
   ViewData["Title"] = "E-Catalogue Coding Camp";
    Layout = "/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ID = ");
#nullable restore
#line 4 "D:\Visual Studio Source\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\Home\Details.cshtml"
    Write(ViewData["candidateId"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div class=\"card-body\">\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7d528c53d1932133edc81780daeb6f157ad40e34907", async() => {
                WriteLiteral(@"
        <!--Id-->
        <!--Name-->
        <div class=""form-group"">
            <label for=""name"">Name</label>
            <input id=""name"" type=""text"" class=""form-control"" readonly>
            <div class=""invalid-feedback"">
                Name is required
            </div>
        </div>
        <!--Email-->
        <div class=""form-group"">
            <label for=""email"">Email</label>
            <input id=""email"" type=""email"" class=""form-control"" readonly>
            <div class=""invalid-feedback"">
                Email is required
            </div>
        </div>
        <!--Gender-->
        <div class=""form-group"">
            <label for=""gender"">Gender</label>
            <input id=""gender"" type=""text"" class=""form-control"" readonly>
            <div class=""invalid-feedback"">
                gender is required
            </div>
        </div>
        <!--Major-->
        <div class=""form-group"">
            <label for=""major"">Major</label>
            <input id=""majo");
                WriteLiteral(@"r"" type=""text"" class=""form-control"" name=""major"" readonly>
            <div class=""invalid-feedback"">
                Major is required
            </div>
        </div>
        <!--Univ-->
        <div class=""form-group"">
            <label for=""univ"">University</label>
            <input id=""univ"" type=""email"" class=""form-control"" name=""univ"" readonly>
            <div class=""invalid-feedback"">
                University is required
            </div>
        </div>
        <!--Degree-->
        <div class=""form-group"">
            <label for=""degree"">Degree</label>
            <input id=""degree"" type=""text"" class=""form-control"" name=""degree"" readonly>
            <div class=""invalid-feedback"">
                Degree is required
            </div>
        </div>
        <!--GPA-->
        <div class=""form-group"">
            <label for=""gpa"">GPA</label>
            <input id=""gpa"" type=""text"" class=""form-control"" name=""gpa"" readonly>
            <div class=""invalid-feedback"">GPA is ");
                WriteLiteral(@"required</div>
        </div>
        <!-------------------------------------------------------------------------->
        <br />
        <h5 class=""product-title""><strong>Experiences</strong></h5><br /><br />
        <!--Organization-->
        <div class=""field_wrapperOrg"">
            <div class=""form-groupOrg"">
                <label for=""organization0"">Organization</label>
                <input id=""organization0"" type=""text"" class=""form-control"" name=""organization0"" readonly>
                <label for=""roleorganization0"">Role Organization</label>
                <input id=""roleorganization0"" type=""text"" class=""form-control"" name=""roleorganization0"" readonly><br />
            </div>
        </div>

        <!--Skill-->
        <div class=""field_wrapperSkill"">
            <div class=""form-groupSkill"">
                <label for=""skill0"">Skill</label>
                <input id=""skill0"" type=""text"" class=""form-control"" name=""skill0"" readonly><br />
            </div>
        </div>
");
                WriteLiteral(@"
        <!--Work-->
        <div class=""field_wrapperWork"">
            <div class=""form-groupWork"">
                <label for=""work0"">Work Experience</label>
                <input id=""work0"" type=""text"" class=""form-control"" name=""work0"" readonly><br />
            </div>

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
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\"#registerForm\").submit(function (e) {\r\n                e.preventDefault();\r\n            });\r\n\r\n            $.ajax({\r\n                type: \"GET\",\r\n                url: `GetDetail/");
#nullable restore
#line 106 "D:\Visual Studio Source\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\Home\Details.cshtml"
                           Write(ViewData["candidateId"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`,
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

            $.ajax({
                type: ""GET"",
                url: `GetDetailCV/");
#nullable restore
#line 129 "D:\Visual Studio Source\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\Home\Details.cshtml"
                             Write(ViewData["candidateId"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"`,
                success: (data) => {
                    console.log(data);
                    var obj = JSON.parse(data);
                    console.log(obj);

                    if (obj.organizations.length > 0) {
                        $(""#organization0"").val(`${obj.organizations[0].OrganizationName}`);
                        $(""#roleorganization0"").val(`${obj.organizations[0].RoleOrganization}`);
                        for (let ij = 1; ij < obj.organizations.length; ij++) {
                            $('.field_wrapperOrg').append(`<div class=""field_wrapperOrg""><div class=""form-groupOrg""><label for=""organization${ij}"">Organization</label><input id=""organization${ij}"" type=""text"" class=""form-control"" name=""organization${ij}"" readonly><label for=""roleorganization${ij}"">Role Organization</label><input id=""roleorganization${ij}"" type=""text"" class=""form-control"" name=""roleorganization${ij}"" readonly><br /></div></div>`); //add field html
                            console.log(ij);
       ");
                WriteLiteral(@"                     $(`#organization${ij}`).val(`${obj.organizations[ij].OrganizationName}`);
                            $(`#roleorganization${ij}`).val(`${obj.organizations[ij].RoleOrganization}`);
                        }
                    }

                    if (obj.skills.length > 0) {
                        $(""#skill0"").val(`${obj.skills[0].SkillName}`);
                        for (let ik = 1; ik < obj.skills.length; ik++) {
                            $('.field_wrapperSkill').append(`<div class=""field_wrapperSkill""><div class=""form-groupSkill""><label for=""skill${ik}"">Skill</label><input id=""skill${ik}"" type=""text"" class=""form-control"" name=""skill${ik}"" readonly><br /></div></div>`); //add field html
                            console.log(ik);
                            $(`#skill${ik}`).val(`${obj.skills[ik].SkillName}`);
                        }
                    }

                    if (obj.works.length > 0) {
                        $(""#work0"").val(`${obj.works[0].WorkN");
                WriteLiteral(@"ame}`);
                        for (let il = 1; il < obj.works.length; il++) {
                            $('.field_wrapperWork').append(`<div class=""field_wrapperWork""><div class=""form-groupWork""><label for=""work${il}"">Work Experience</label><input id=""work${il}"" type=""text"" class=""form-control"" name=""work${il}"" readonly><br /></div></div>`); //add field html
                            console.log(il);
                            $(`#work${il}`).val(`${obj.works[il].WorkName}`);
                        }
                    }
                    console.log(""Length masing masing"");
                    console.log(obj.organizations.length);
                    console.log(obj.skills.length);
                    console.log(obj.works.length);
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
