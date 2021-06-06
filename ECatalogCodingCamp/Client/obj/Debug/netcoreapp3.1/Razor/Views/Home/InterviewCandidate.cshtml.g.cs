#pragma checksum "D:\Visual Studio Source\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\Home\InterviewCandidate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ade6938da60120ed0ce72f390c2bd83c0b5433de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_InterviewCandidate), @"mvc.1.0.view", @"/Views/Home/InterviewCandidate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ade6938da60120ed0ce72f390c2bd83c0b5433de", @"/Views/Home/InterviewCandidate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_InterviewCandidate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formdata"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("needs-validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Visual Studio Source\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\Home\InterviewCandidate.cshtml"
   ViewData["Title"] = "E-Catalogue Coding Camp";
    Layout = "/Views/Shared/_LayoutCandidate.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <table id=""table_id"" class=""display"">
        <thead>
            <tr>
                <th>Name</th>
                <th>Email</th>
                <th>Phone</th>
                <th>Bid Salary</th>
                <th>Interview Schedule</th>
            </tr>
        </thead>
        <tbody>
            
        </tbody>
    </table>
</div>

<div class=""modal fade"" id=""book"" tabindex=""-1"" role=""dialog"" aria-labelledby=""add"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""intrequest"">Interview Request</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ade6938da60120ed0ce72f390c2bd83c0b5433de5324", async() => {
                WriteLiteral(@"
                    <input type=""hidden"" class=""form-control"" id=""id"">

                    <div class=""form-group row"">
                        <label for=""salary"" class=""col-sm-2 col-form-label"">Salary</label>
                        <div class=""col-sm-10"">
                            <input type=""text"" class=""form-control"" id=""salary"" name=""salary"" placeholder=""Bid Your Salary for this Candidate"" required>
                            <div class=""valid-feedback"">
                                Looks good!
                            </div>
                            <div class=""invalid-feedback"">
                                Please fill name.
                            </div>
                        </div>
                    </div>

                    <div class=""form-group row"">
                        <label for=""interviewdate"" class=""col-sm-2 col-form-label"">Interview Date</label>
                        <div class=""col-sm-10"">
                            <input type=""date"" cl");
                WriteLiteral(@"ass=""form-control"" id=""interviewdate"" name=""interviewdate"" placeholder=""Place your Inteview Date"" required>
                            <div class=""valid-feedback"">
                                Looks good!
                            </div>
                            <div class=""invalid-feedback"">
                                Please Choose Interview Date.
                            </div>
                        </div>
                    </div>

                    <div class=""modal-footer"">
                        <div class=""form-group row"">
                            <div class=""col-sm-10"">
                                <button id=""submit"" type=""button"" class=""btn btn-primary"">Save changes</button>
                            </div>
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
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            getCandidate();
        });

        let getClientById = id => {
            $('#table_id').DataTable({
                ajax: {
                    url: `GetClient/${id}`,
                    dataSrc: ''
                },
                columns: [
                    { data: 'Name' },
                    { data: 'Email' },
                    { data: 'Phone' },
                    { data: 'BidSalary' },
                    { data: 'Schedule' }
                    //{
                    //    ""render"": function (data, type, row) {
                    //        return `<button class=""btn btn-primary"" data-bs-toggle=""modal"" data-bs-target=""#yes"" onclick=""getId(' + row.id + ')"" data-toggle=""tooltip"" data-placement=""top"" title=""Confirm"">Confirm</button>`
                    //            +
                    //            /*` <button class=""btn btn-danger"" data-bs-toggle=""modal"" data-toggle=""tooltip"" onclick=""getById(${row.");
                WriteLiteral(@"id})"" data-placement=""top"" title=""Reschedule"">Reschedule</button>`;*/
                    //    },
                    //    ""orderable"": false,
                    //    ""searchable"": false
                    //},

                ]
            });
        }

        let getCandidate = () => {
            $.ajax({
                type: 'GET',
                url: `GetCandidateId`
            }).done(result => {
                let json = JSON.parse(result);
                getClientById(json[0].Id);
            }).fail(result => {
                console.log(result);
            })
        }

        let getById = id => {
            $.ajax({
                url: `GetById/`,
                type: `GET`,
                data: { ""id"": id },
                dataSrc: """",
                success: data => {
                    let jsonResult = JSON.parse(data);
                    $(`#id`).val(jsonResult.id);
                    let myModal = $(""#book"");
                    myModal");
                WriteLiteral(".modal(\"show\");\r\n                },\r\n                error: data => {\r\n                    console.log(data);\r\n                }\r\n            })\r\n        }\r\n    </script>\r\n\r\n");
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
