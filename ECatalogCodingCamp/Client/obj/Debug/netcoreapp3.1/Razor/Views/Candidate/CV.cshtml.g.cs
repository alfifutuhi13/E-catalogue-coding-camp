#pragma checksum "D:\Visual Studio Source\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\Candidate\CV.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e28a5d9f8a2657166abe2b18489448110c1a51b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidate_CV), @"mvc.1.0.view", @"/Views/Candidate/CV.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e28a5d9f8a2657166abe2b18489448110c1a51b2", @"/Views/Candidate/CV.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_Candidate_CV : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "D:\Visual Studio Source\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\Candidate\CV.cshtml"
  
    ViewData["Title"] = "E-Catalogue Coding Camp";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card-body\">\r\n    <h4 class=\"card-title\">Update Experiences</h4>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e28a5d9f8a2657166abe2b18489448110c1a51b24651", async() => {
                WriteLiteral(@"
        <!--List Organization-->
        <div class=""form-group"">
            <div class=""field_wrapperOrg"">
                <div>
                    <label for=""organization0"">Organization</label><br />
                    <input id=""organization0"" type=""text"" class=""form-control"" name=""organization0""");
                BeginWriteAttribute("value", " value=\"", 519, "\"", 527, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Ex: Himpunan"" required /><br />
                    <div class=""invalid-feedback"">
                        Organization is required
                    </div>
                    <label for=""roleorganization0"">Role Organization</label><br />
                    <input id=""roleorganization0"" type=""text"" class=""form-control"" name=""roleorganization0""");
                BeginWriteAttribute("value", " value=\"", 896, "\"", 904, 0);
                EndWriteAttribute();
                WriteLiteral(@" placeholder=""Ex: Ketua"" required /><br />
                    <div class=""invalid-feedback"">
                        Role Organization is required
                    </div>
                    <a href=""javascript:void(0);"" class=""add_buttonOrg"" title=""Add field"">Add More Organization and Role Organization</a> <br />
                </div>
            </div>
        </div>
        <!--List Skill-->
        <div class=""form-group"">
            <div class=""field_wrapperSkill"">
                <div>
                    <label for=""skill0"">Skill</label>
                    <input id=""skill0"" type=""text"" class=""form-control"" name=""skill0"" placeholder=""Ex: Python"" required><br />
                    <div class=""invalid-feedback"">
                        Skill is required
                    </div>
                    <a href=""javascript:void(0);"" class=""add_buttonSkill"" title=""Add field"">Add More Skills</a> <br />
                </div>
            </div>
        </div>
        <!--List Work--");
                WriteLiteral(@">
        <div class=""form-group"">
            <div class=""field_wrapperWork"">
                <div>
                    <label for=""work0"">Work Experience</label>
                    <input id=""work0"" type=""text"" class=""form-control"" name=""work0"" placeholder=""Ex: Metrodata"" required><br />
                    <div class=""invalid-feedback"">
                        Work is required
                    </div>
                    <a href=""javascript:void(0);"" class=""add_buttonWork"" title=""Add field"">Add More Works</a><br />
                </div>
            </div>
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

            $.ajax({
                type: ""GET"",
                url: `/Candidate/GetCVId/`,
                dataSrc: '',
                success: (data) => {
                    console.log(data);
                    var obj = JSON.parse(data);
                    console.log(obj);

                    $(""#organization0"").val(`${obj.organizations[0].OrganizationName}`);
                    $(""#roleorganization0"").val(`${obj.organizations[0].RoleOrganization}`);
                    $(""#skill0"").val(`${obj.skills[0].SkillName}`);
                    $(""#work0"").val(`${obj.works[0].WorkName}`);

                    for (let ij = 1; ij < obj.organizations.length; ij++) {
                        $(wrapperOrg).append(`<div><label for=""organi");
                WriteLiteral(@"zation${ij}"">Organization</label><br /><input id=""organization${ij}"" type=""text"" class=""form-control"" name=""organization${ij}"" value="""" placeholder=""Ex: Himpunan"" required /><br /><div class=""invalid-feedback"">Organization is required</div><label for=""roleorganization${ij}"">Role Organization</label><br /><input id=""roleorganization${ij}"" type=""text"" class=""form-control"" name=""roleorganization${ij}"" value="""" placeholder=""Ex: Ketua"" required /><br /><div class=""invalid-feedback"">Role Organization is required</div> <a href=""javascript:void(0);"" class=""remove_button"">Remove Organization and Role Organization Field</a></div>`); //add field html
                        countOrg = ij; //increment field counter

                        $(`#organization${ij}`).val(`${obj.organizations[ij].OrganizationName}`);
                        $(`#roleorganization${ij}`).val(`${obj.organizations[ij].RoleOrganization}`);
                    }

                    for (let ik = 1; ik < obj.skills.length; ik++) {
          ");
                WriteLiteral(@"              $(wrapperSkill).append(`<div><label for=""skill${ik}"">Skill</label><input id=""skill${ik}"" type=""text"" class=""form-control"" name=""skill${ik}"" placeholder=""Ex: Python"" required><br /><div class=""invalid-feedback"">Skill is required</div> <a href=""javascript:void(0);"" class=""remove_button"">Remove Skill Field</a></div>`); //add field html
                        countSkill = ik; //increment field counter

                        $(`#skill${ik}`).val(`${obj.skills[ik].SkillName}`);
                    }

                    for (let il = 1; il < obj.works.length; il++) {
                        $(wrapperWork).append(`<div><label for=""work${il}"" >Work Experience</label><input id=""work${il}"" type=""text"" class=""form-control"" name=""work${il}"" placeholder=""Ex: Metrodata"" required><br /><div class=""invalid-feedback"">Work is required</div> <a href=""javascript:void(0);"" class=""remove_button"">Remove Work Field</a></div>`); //add field html
                        countWork = il; //increment field counte");
                WriteLiteral(@"r

                        $(`#work${il}`).val(`${obj.works[il].WorkName}`);
                    }
  
                },
                error: (data) => {
                    console.log(JSON.stringify(data));
                }
            });

            //dynamic input Experiences Fields
            var maxField = 10; //input fields increment limitation

            //Organization Inputs
            var addButtonOrg = $('.add_buttonOrg');//add button Org
            var wrapperOrg = $('.field_wrapperOrg');//input field wrapper

            var countOrg = 1; //initial field counter Organization

            //Once add button is clicked
            $(addButtonOrg).click(function () {
                //check maximum number of input fields
                if (countOrg < maxField) {
                    $(wrapperOrg).append(`<div><label for=""organization${countOrg}"">Organization</label><br /><input id=""organization${countOrg}"" type=""text"" class=""form-control"" name=""organization${countOrg");
                WriteLiteral(@"}"" value="""" placeholder=""Ex: Himpunan"" required /><br /><div class=""invalid-feedback"">Organization is required</div><label for=""roleorganization${countOrg}"">Role Organization</label><br /><input id=""roleorganization${countOrg}"" type=""text"" class=""form-control"" name=""roleorganization${countOrg}"" value="""" placeholder=""Ex: Ketua"" required /><br /><div class=""invalid-feedback"">Role Organization is required</div> <a href=""javascript:void(0);"" class=""remove_button"">Remove Organization and Role Organization Field</a></div>`); //add field html
                    countOrg++; //increment field counter
                }
            });

            //Once remove button is clicked
            $(wrapperOrg).on('click', '.remove_button', function (e) {
                e.preventDefault();
                $(this).parent('div').remove(); //remove field html
                countOrg--; //decrement field counter
            });

            //Skill inputs
            var wrapperSkill = $('.field_wrapperSkill');//i");
                WriteLiteral(@"nput field wrapper
            var addButtonSkill = $('.add_buttonSkill');//add button Skill

            var countSkill = 1; //initial field counter Skills

            //Once add button is clicked
            $(addButtonSkill).click(function () {
                //check maximum number of input fields
                if (countSkill < maxField) {
                    $(wrapperSkill).append(`<div><label for=""skill${countSkill}"">Skill</label><input id=""skill${countSkill}"" type=""text"" class=""form-control"" name=""skill${countSkill}"" placeholder=""Ex: Python"" required><br /><div class=""invalid-feedback"">Skill is required</div> <a href=""javascript:void(0);"" class=""remove_button"">Remove Skill Field</a></div>`); //add field html
                    countSkill++; //increment field counter
                }
            });

            //Once remove button is clicked
            $(wrapperSkill).on('click', '.remove_button', function (e) {
                e.preventDefault();
                $(this).parent(");
                WriteLiteral(@"'div').remove(); //remove field html
                countSkill--; //decrement field counter
            });

            //Work inputs
            var wrapperWork = $('.field_wrapperWork');//input field wrapper
            var addButtonWork = $('.add_buttonWork');//add button Skill

            var countWork = 1; //initial field counter Works

            //Once add button is clicked
            $(addButtonWork).click(function () {
                //check maximum number of input fields
                if (countWork < maxField) {
                    $(wrapperWork).append(`<div><label for=""work${countWork}"" >Work Experience</label><input id=""work${countWork}"" type=""text"" class=""form-control"" name=""work${countWork}"" placeholder=""Ex: Metrodata"" required><br /><div class=""invalid-feedback"">Work is required</div> <a href=""javascript:void(0);"" class=""remove_button"">Remove Work Field</a></div>`); //add field html
                    countWork++; //increment field counter
                }
          ");
                WriteLiteral(@"  });

            //Once remove button is clicked
            $(wrapperWork).on('click', '.remove_button', function (e) {
                e.preventDefault();
                $(this).parent('div').remove(); //remove field html
                countWork--; //decrement field counter
            });

            let InsertCV = () => {
                let Obj = new Object();
                Obj.Organizations = [];
                Obj.Skills = [];
                Obj.Works = [];

                for (let i = 0; i < countOrg; i++) {
                    Obj.Organizations[i] = new Object();
                    Obj.Organizations[i].OrganizationName = $(`#organization${i}`).val();
                    Obj.Organizations[i].RoleOrganization = $(`#roleorganization${i}`).val();
                }
                for (let j = 0; j < countSkill; j++) {
                    Obj.Skills[j] = new Object();
                    Obj.Skills[j].SkillName = $(`#skill${j}`).val();
                }
                ");
                WriteLiteral(@"for (let k = 0; k < countWork; k++) {
                    Obj.Works[k] = new Object();
                    Obj.Works[k].WorkName = $(`#work${k}`).val();
                }
                console.log(Obj);
                console.log(JSON.stringify(Obj));
                alert(JSON.stringify(Obj));
                $.ajax({
                    url: '/Candidate/InsertCV',
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

            $(""#submit"").click(function () {
                InsertCV();
            })

            let sAlertAdd = () => {
                swal({
                    title: ""Done"",
                    text: ""Data successfully added."",
                    icon: ""success"",
         ");
                WriteLiteral("           button: \"Ok\",\r\n                }).then(() => {\r\n                    location.reload(true);\r\n                });\r\n            }\r\n\r\n\r\n        });\r\n       \r\n    </script>\r\n");
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
