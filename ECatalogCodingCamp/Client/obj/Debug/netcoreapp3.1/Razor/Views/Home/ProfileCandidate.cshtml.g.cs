#pragma checksum "C:\Users\alfat\Documents\GitHub\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\Home\ProfileCandidate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "511d18c8ef298d72a2cb7a44490706df6bcce5c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ProfileCandidate), @"mvc.1.0.view", @"/Views/Home/ProfileCandidate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"511d18c8ef298d72a2cb7a44490706df6bcce5c5", @"/Views/Home/ProfileCandidate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3332004e6f18ccbec22253d7e177fe1fd5f40969", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ProfileCandidate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#line 1 "C:\Users\alfat\Documents\GitHub\E-catalogue-coding-camp\ECatalogCodingCamp\Client\Views\Home\ProfileCandidate.cshtml"
   ViewData["Title"] = "E-Catalogue Coding Camp";
    Layout = "/Views/Shared/_LayoutCandidate.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"card-body\">\n\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "511d18c8ef298d72a2cb7a44490706df6bcce5c54729", async() => {
                WriteLiteral(@"
        <!--Id-->
        <input type=""hidden"" class=""form-control"" id=""id"" name=""id"">
        <!--Name-->
        <div class=""form-group"">
            <label for=""name"">Name</label>
            <input id=""name"" type=""text"" class=""form-control"" name=""name"" placeholder=""Ex: Steve Jobs"" required autofocus>
            <div class=""invalid-feedback"">
                Name is required
            </div>
        </div>
        <!--Email-->
        <div class=""form-group"">
            <label for=""email"">Email</label>
            <input id=""email"" type=""email"" class=""form-control"" name=""email"" placeholder=""Ex: youremail@gmail.com"" required>
            <div class=""invalid-feedback"">
                Email is required
            </div>
        </div>
        <!--Phone-->
        <div class=""form-group"">
            <label for=""phone"">Phone</label>
            <input id=""phone"" type=""text"" class=""form-control"" name=""phone"" placeholder=""Ex: 08123456789"" required data-eye>
            <div class=""invalid-feedback"">
     ");
                WriteLiteral("           Degree is required\n            </div>\n        </div>\n\n        <button type=\"submit\" class=\"btn btn-primary btn-block\" id=\"submit\">Submit</button>\n\n    ");
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
    <script>
        $(document).ready(function () {
            $(""#registerForm"").submit(function (e) {
                e.preventDefault();
            });

            $.ajax({
                type: ""GET"",
                url: `/Home/GetUserId/`,
                success: (data) => {
                    console.log(data);
                    var obj = JSON.parse(data);
                    console.log(obj);

                    $(""#id"").val(`${obj[0].Id}`);
                    $(""#name"").val(`${obj[0].Name}`);
                    $(""#email"").val(`${obj[0].Email}`);
                    $(""#phone"").val(`${obj[0].Phone}`);

                },
                error: (data) => {
                    console.log(""error"");
                    console.log(JSON.stringify(data));
                }
            })

        })


        $(""#submit"").click(function () {
            let obj = new Object();

            obj.Id = $(""#id"").val();
            obj.Name = $(""#name"").val();
            obj.Email = $(""#email"").val");
                WriteLiteral(@"();
            obj.Phone = $(""#phone"").val();

            UpdateProfile(obj);


        });



        let UpdateProfile = (obj) => {
            $.ajax({
                url: ""/Home/UpdateProfile"",
                type: ""PUT"",
                data: obj
            }).done((result) => {
                console.log(result);
                if (result == 200) {
                    alert(""Data updated."");
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
                WriteLiteral(@"       swal({
                title: ""Done"",
                text: ""Data successfully updated."",
                icon: ""success"",
                button: ""Ok"",
            }).then(() => {
                location.reload(true);
            });
        }</script>

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
