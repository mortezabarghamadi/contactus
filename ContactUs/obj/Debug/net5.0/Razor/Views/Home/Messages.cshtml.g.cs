#pragma checksum "D:\posheh darsi\c#\ContactUs-CodeYad\ContactUs\Views\Home\Messages.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7a90644267c7850572bba7ab119bd389ea277da64f2903a36a395d1244474a8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Messages), @"mvc.1.0.view", @"/Views/Home/Messages.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7a90644267c7850572bba7ab119bd389ea277da64f2903a36a395d1244474a8c", @"/Views/Home/Messages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"3b2f939ce52683e1d2904956632b99afbaacb559e0ea647aa11a6c6586a1cae5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Messages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ContactUs.Models.Message>>
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
        private global::ContactUs.TagHelpers.PhoneTagHelper __ContactUs_TagHelpers_PhoneTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\posheh darsi\c#\ContactUs-CodeYad\ContactUs\Views\Home\Messages.cshtml"
  
    var counter = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\posheh darsi\c#\ContactUs-CodeYad\ContactUs\Views\Home\Messages.cshtml"
  
    var message = TempData["succsed"];

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\posheh darsi\c#\ContactUs-CodeYad\ContactUs\Views\Home\Messages.cshtml"
  
    ViewData["titel"] = "لیست پیام ها";

#line default
#line hidden
#nullable disable
            DefineSection("Style", async() => {
                WriteLiteral(@"
    <style>
        thead th {
            text-align: right;
        }

        thead {
            box-shadow: 0 0 2px 0 gray;
            background: #0000000d;
        }

        body {
            background-image: url('/images/bg-01.jpg');
            background-size: cover;
        }
    </style>
");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 30 "D:\posheh darsi\c#\ContactUs-CodeYad\ContactUs\Views\Home\Messages.cshtml"
 if (message !=null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        شماره به درستی ثبت شد\r\n    </div>\r\n");
#nullable restore
#line 35 "D:\posheh darsi\c#\ContactUs-CodeYad\ContactUs\Views\Home\Messages.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        error\r\n    </div>\r\n");
#nullable restore
#line 41 "D:\posheh darsi\c#\ContactUs-CodeYad\ContactUs\Views\Home\Messages.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"card mt-5\">\r\n        <div class=\"card-header\">\r\n            <h5>  لیست پیام ها ");
#nullable restore
#line 46 "D:\posheh darsi\c#\ContactUs-CodeYad\ContactUs\Views\Home\Messages.cshtml"
                          Write(ViewData["names"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
        </div>
        <div class=""card-body"">
            <table class=""table text-right table-bordered table-hover "">
                <thead>

                    <tr>
                        <th>
                            #
                        </th>
                        <th>عنوان</th>
                        <th>تماس با ما</th>
                        <th>نام و نام خانوادگی</th>
                        <th>پیام</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 63 "D:\posheh darsi\c#\ContactUs-CodeYad\ContactUs\Views\Home\Messages.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 66 "D:\posheh darsi\c#\ContactUs-CodeYad\ContactUs\Views\Home\Messages.cshtml"
                           Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 67 "D:\posheh darsi\c#\ContactUs-CodeYad\ContactUs\Views\Home\Messages.cshtml"
                           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("call", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a90644267c7850572bba7ab119bd389ea277da64f2903a36a395d1244474a8c6465", async() => {
            }
            );
            __ContactUs_TagHelpers_PhoneTagHelper = CreateTagHelper<global::ContactUs.TagHelpers.PhoneTagHelper>();
            __tagHelperExecutionContext.Add(__ContactUs_TagHelpers_PhoneTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "D:\posheh darsi\c#\ContactUs-CodeYad\ContactUs\Views\Home\Messages.cshtml"
                                        WriteLiteral(item.PhoneNumber);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __ContactUs_TagHelpers_PhoneTagHelper.PhoneNumber = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("phone-number", __ContactUs_TagHelpers_PhoneTagHelper.PhoneNumber, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </td>\r\n                            <td>");
#nullable restore
#line 71 "D:\posheh darsi\c#\ContactUs-CodeYad\ContactUs\Views\Home\Messages.cshtml"
                           Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 72 "D:\posheh darsi\c#\ContactUs-CodeYad\ContactUs\Views\Home\Messages.cshtml"
                           Write(item.MessageBody);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 74 "D:\posheh darsi\c#\ContactUs-CodeYad\ContactUs\Views\Home\Messages.cshtml"

                        counter += 1;
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ContactUs.Models.Message>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
