#pragma checksum "C:\Users\alfat\Documents\GitHub\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\Home\InterviewClient.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2af060282ffd645d40173c4a2076ed9bf92fa9bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_InterviewClient), @"mvc.1.0.view", @"/Views/Home/InterviewClient.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2af060282ffd645d40173c4a2076ed9bf92fa9bb", @"/Views/Home/InterviewClient.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_InterviewClient : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\alfat\Documents\GitHub\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\Home\InterviewClient.cshtml"
   ViewData["Title"] = "E-Catalogue Coding Camp";
    Layout = "/Views/Shared/_Layout.cshtml"; 

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
                <th>Actions</th>
            </tr>
        </thead>
        <tbody>
        </tbody>
    </table>
</div>

<div class=""modal fade"" id=""reschedule"" tabindex=""-1"" role=""dialog"" aria-labelledby=""add"" aria-hidden=""true"">
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2af060282ffd645d40173c4a2076ed9bf92fa9bb5355", async() => {
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
                                Please fill the salary.
                            </div>
                        </div>
                    </div>

                    <div class=""form-group row"">
                        <label for=""interviewdate"" class=""col-sm-2 col-form-label"">Interview Date</label>
                        <div class=""col-sm-10"">
                            <input type=""da");
                WriteLiteral(@"te"" class=""form-control"" id=""interviewdate"" name=""interviewdate"" placeholder=""Place your Inteview Date"" required>
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
            WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            getClient();
        });

        let getCandidateById = id => {
            $('#table_id').DataTable({
                ajax: {
                    url: `GetCandidate/${id}`,
                    dataSrc: ''
                },
                columns: [
                    { data: 'Name' },
                    {
                        data: 'Email',
                        orderable: false,
                        searchable: false
                    },
                    {
                        data: 'Phone',
                        orderable: false,
                        searchable: false
                    },
                    { data: 'BidSalary' },
                    {
                        render: function (data, type, row) {
                            var date = moment(row['Schedule']).format('DD MMMM YYYY');
                            return date;
                        }
                    }");
                WriteLiteral(@",
                    {
                        data: null,
                        render: function (data, type, row) {
                            return `<button type=""button"" class=""btn btn-success"">Accepted</button> <button type=""button"" class=""btn btn-warning"" data-toggle=""modal"" data-target=""#reschedule"">Reschedule</button> <button type=""button"" class=""btn btn-danger"" onclick=""rejected(${row[""CandidateId""]})"">Rejected</button>`
                        }
                    }
                ]
            });
        }

        let rejected = id => {
            $.ajax({
                type: 'DELETE',
                url: `Rejected/${id}`
            }).done(result => {
                console.log(result);
            }).fail(result => {
                console.log(result);
            })
        }

        let getClient = () => {
            $.ajax({
                type: 'GET',
                url: `GetClientId`
            }).done(result => {
                let json = JSO");
                WriteLiteral("N.parse(result);\r\n                getCandidateById(json[0].Id);\r\n            }).fail(result => {\r\n                console.log(result);\r\n            })\r\n        }\r\n    </script>\r\n");
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
