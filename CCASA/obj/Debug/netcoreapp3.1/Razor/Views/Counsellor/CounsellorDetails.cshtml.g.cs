#pragma checksum "C:\Users\Sameer Shahzad\source\repos\CCASA\CCASA\Views\Counsellor\CounsellorDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "630a662e1dc4711ed7ae0a8776ab265a9b9a35b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Counsellor_CounsellorDetails), @"mvc.1.0.view", @"/Views/Counsellor/CounsellorDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"630a662e1dc4711ed7ae0a8776ab265a9b9a35b6", @"/Views/Counsellor/CounsellorDetails.cshtml")]
    #nullable restore
    public class Views_Counsellor_CounsellorDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "630a662e1dc4711ed7ae0a8776ab265a9b9a35b62776", async() => {
                WriteLiteral("\r\n    <title>Personal Information Form</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "630a662e1dc4711ed7ae0a8776ab265a9b9a35b63790", async() => {
                WriteLiteral("\r\n    <h2>Personal Information Form</h2>\r\n    <form action=\"/Counsellor/addDetails\" method=\"post\">\r\n        <div>\r\n            <label for=\"religion\">Religion:</label>\r\n            <select id=\"religion\" name=\"religion\">\r\n                <option");
                BeginWriteAttribute("value", " value=\"", 312, "\"", 320, 0);
                EndWriteAttribute();
                WriteLiteral(@">Select Religion</option>
                <option value=""Hinduism"">Hinduism</option>
                <option value=""Islam"">Islam</option>
                <option value=""Christianity"">Christianity</option>
                <option value=""Buddhism"">Buddhism</option>
                <option value=""Others"">Others</option>
            </select>
        </div>
        <div>
            <label for=""gender"">Gender:</label>
            <select id=""gender"" name=""gender"">
                <option");
                BeginWriteAttribute("value", " value=\"", 820, "\"", 828, 0);
                EndWriteAttribute();
                WriteLiteral(@">Select Gender</option>
                <option value=""Male"">Male</option>
                <option value=""Female"">Female</option> 
                <option value=""Others"">Others</option>
            </select>
        </div>

        <div>
            <label for=""bloodGroup"">Blood Group:</label>
            <select id=""bloodGroup"" name=""blood"">
                <option");
                BeginWriteAttribute("value", " value=\"", 1207, "\"", 1215, 0);
                EndWriteAttribute();
                WriteLiteral(@">Select Blood Group</option>
                <option value=""A+"">A+</option>
                <option value=""A-"">A-</option>
                <option value=""B+"">B+</option>
                <option value=""B-"">B-</option>
                <option value=""O+"">O+</option>
                <option value=""O-"">O-</option>
                <option value=""AB+"">AB+</option>
                <option value=""AB-"">AB-</option>
            </select>
        </div> 

        <input type=""submit"" value=""Submit"">
    </form>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
