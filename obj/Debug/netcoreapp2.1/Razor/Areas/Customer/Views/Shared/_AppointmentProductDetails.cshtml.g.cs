#pragma checksum "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Customer\Views\Shared\_AppointmentProductDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48ff94d942f1099734cb3a786c16f968a72d2fbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Shared__AppointmentProductDetails), @"mvc.1.0.view", @"/Areas/Customer/Views/Shared/_AppointmentProductDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Customer/Views/Shared/_AppointmentProductDetails.cshtml", typeof(AspNetCore.Areas_Customer_Views_Shared__AppointmentProductDetails))]
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
#line 1 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Customer\Views\_ViewImports.cshtml"
using doan_cnpm;

#line default
#line hidden
#line 2 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Customer\Views\_ViewImports.cshtml"
using doan_cnpm.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48ff94d942f1099734cb3a786c16f968a72d2fbd", @"/Areas/Customer/Views/Shared/_AppointmentProductDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e78fbb5ac25b84f78000956bde6e4d064f449c59", @"/Areas/Customer/Views/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Shared__AppointmentProductDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<doan_cnpm.Models.ViewModel.CartItem>>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(170, 86, true);
            WriteLiteral("\r\n\r\n<br/><br /><br /><br />\r\n<h2>YOUR ORDER WERE SUBMIT - THANK YOU !!!</h2>\r\n<br />\r\n");
            EndContext();
#line 9 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Customer\Views\Shared\_AppointmentProductDetails.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
            BeginContext(284, 446, true);
            WriteLiteral(@"    <div class=""container rounded"" style="" padding :15px;"">
        <div class="" row"">
            <div class="" col-12"">
                <table class=""table-striped border"" style="" width:100%;"">
                    <thead>
                        <tr class=""table-info"">
                            <th style=""text-align:center; width:20%""></th>
                            <th style=""text-align:center;"">
                                ");
            EndContext();
            BeginContext(730, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7577c86ac3ab4d56bd8c5dcbce676d23", async() => {
                BeginContext(793, 4, true);
                WriteLiteral("Name");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 19 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Customer\Views\Shared\_AppointmentProductDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FirstOrDefault().itemCart.ProductName);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(805, 130, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th style=\"text-align:center;\">\r\n                                ");
            EndContext();
            BeginContext(935, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b65a812f7b14c479c6fe1901e7d1377", async() => {
                BeginContext(992, 5, true);
                WriteLiteral("Price");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 22 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Customer\Views\Shared\_AppointmentProductDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FirstOrDefault().itemCart.Price);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1005, 130, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th style=\"text-align:center;\">\r\n                                ");
            EndContext();
            BeginContext(1135, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "435feaf842a845fa9c73b83f51db1cab", async() => {
                BeginContext(1186, 8, true);
                WriteLiteral("Quantity");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 25 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Customer\Views\Shared\_AppointmentProductDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FirstOrDefault().quantity);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1202, 130, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th style=\"text-align:center;\">\r\n                                ");
            EndContext();
            BeginContext(1332, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7ad49f18a264b0896619d4b86ba9872", async() => {
                BeginContext(1395, 4, true);
                WriteLiteral("Size");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 28 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Customer\Views\Shared\_AppointmentProductDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FirstOrDefault().itemCart.ProductSize);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1407, 130, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th style=\"text-align:center;\">\r\n                                ");
            EndContext();
            BeginContext(1537, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dc22daf48c59460196b3cf466fdae7ed", async() => {
                BeginContext(1589, 5, true);
                WriteLiteral("Total");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 31 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Customer\Views\Shared\_AppointmentProductDetails.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.FirstOrDefault().totalItem);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1602, 127, true);
            WriteLiteral("\r\n                            </th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 36 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Customer\Views\Shared\_AppointmentProductDetails.cshtml"
                         foreach (var product in Model)
                        {

#line default
#line hidden
            BeginContext(1813, 152, true);
            WriteLiteral("                        <tr style=\"padding :50px;\">\r\n                            <td style=\"text-align:center;\">\r\n\r\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1965, "\"", 1994, 1);
#line 41 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Customer\Views\Shared\_AppointmentProductDetails.cshtml"
WriteAttributeValue("", 1971, product.itemCart.Image, 1971, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1995, 259, true);
            WriteLiteral(@" width=""100%"" style=""margin :auto; display: block ; border-radius:5px; border:1px solid #bbb9b9; "" />

                            </td>
                            <td style=""text-align:center;"">
                                <h5 class=""h5 text-black"">");
            EndContext();
            BeginContext(2255, 28, false);
#line 45 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Customer\Views\Shared\_AppointmentProductDetails.cshtml"
                                                     Write(product.itemCart.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(2283, 105, true);
            WriteLiteral("</h5>\r\n                            </td>\r\n\r\n                            <td style=\"text-align:center;\">\r\n");
            EndContext();
#line 49 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Customer\Views\Shared\_AppointmentProductDetails.cshtml"
                                 if (product.itemCart.newPrice != 0)
                                {
                                    

#line default
#line hidden
            BeginContext(2530, 49, false);
#line 51 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Customer\Views\Shared\_AppointmentProductDetails.cshtml"
                               Write(string.Format("{0:c}", product.itemCart.newPrice));

#line default
#line hidden
            EndContext();
#line 51 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Customer\Views\Shared\_AppointmentProductDetails.cshtml"
                                                                                      
                                }
                                else
                                {
                                    

#line default
#line hidden
            BeginContext(2726, 46, false);
#line 55 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Customer\Views\Shared\_AppointmentProductDetails.cshtml"
                               Write(string.Format("{0:c}", product.itemCart.Price));

#line default
#line hidden
            EndContext();
#line 55 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Customer\Views\Shared\_AppointmentProductDetails.cshtml"
                                                                                   
                                }

#line default
#line hidden
            BeginContext(2809, 154, true);
            WriteLiteral("                            </td>\r\n                            <td style=\"text-align:center;\">\r\n                                <h5 class=\"h5 text-black\">");
            EndContext();
            BeginContext(2964, 16, false);
#line 59 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Customer\Views\Shared\_AppointmentProductDetails.cshtml"
                                                     Write(product.quantity);

#line default
#line hidden
            EndContext();
            BeginContext(2980, 163, true);
            WriteLiteral("</h5>\r\n                            </td>\r\n\r\n                            <td style=\"text-align:center;\">\r\n                                <h5 class=\"h5 text-black\">");
            EndContext();
            BeginContext(3144, 28, false);
#line 63 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Customer\Views\Shared\_AppointmentProductDetails.cshtml"
                                                     Write(product.itemCart.ProductSize);

#line default
#line hidden
            EndContext();
            BeginContext(3172, 163, true);
            WriteLiteral("</h5>\r\n                            </td>\r\n\r\n                            <td style=\"text-align:center;\">\r\n                                <h5 class=\"h5 text-black\">");
            EndContext();
            BeginContext(3336, 17, false);
#line 67 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Customer\Views\Shared\_AppointmentProductDetails.cshtml"
                                                     Write(product.totalItem);

#line default
#line hidden
            EndContext();
            BeginContext(3353, 73, true);
            WriteLiteral("</h5>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 70 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Customer\Views\Shared\_AppointmentProductDetails.cshtml"
                        }

#line default
#line hidden
            BeginContext(3453, 110, true);
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n\r\n        </div>\r\n\r\n    </div>\r\n");
            EndContext();
#line 79 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Customer\Views\Shared\_AppointmentProductDetails.cshtml"
}

#line default
#line hidden
            BeginContext(3566, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<doan_cnpm.Models.ViewModel.CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
