#pragma checksum "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Admin\Views\AdminUsers\CustomerIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d15253146dd7eb3146e9eac3c076d98a7b2bb89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminUsers_CustomerIndex), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminUsers/CustomerIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/AdminUsers/CustomerIndex.cshtml", typeof(AspNetCore.Areas_Admin_Views_AdminUsers_CustomerIndex))]
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
#line 1 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Admin\Views\_ViewImports.cshtml"
using doan_cnpm;

#line default
#line hidden
#line 2 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Admin\Views\_ViewImports.cshtml"
using doan_cnpm.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d15253146dd7eb3146e9eac3c076d98a7b2bb89", @"/Areas/Admin/Views/AdminUsers/CustomerIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e78fbb5ac25b84f78000956bde6e4d064f449c59", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_AdminUsers_CustomerIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<doan_cnpm.Models.ApplicationCustomerAccount>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Admin\Views\AdminUsers\CustomerIndex.cshtml"
  
    ViewData["Title"] = "CustomerIndex";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(173, 255, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\"> Customer Users List</h2>\r\n    </div>\r\n</div>\r\n\r\n<br />\r\n<div>\r\n    <table class=\"table table-striped border\">\r\n        <tr class=\"table-info\">\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(429, 32, false);
#line 18 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Admin\Views\AdminUsers\CustomerIndex.cshtml"
           Write(Html.DisplayNameFor(m => m.Name));

#line default
#line hidden
            EndContext();
            BeginContext(461, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(517, 35, false);
#line 21 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Admin\Views\AdminUsers\CustomerIndex.cshtml"
           Write(Html.DisplayNameFor(m => m.Address));

#line default
#line hidden
            EndContext();
            BeginContext(552, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(608, 33, false);
#line 24 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Admin\Views\AdminUsers\CustomerIndex.cshtml"
           Write(Html.DisplayNameFor(m => m.Email));

#line default
#line hidden
            EndContext();
            BeginContext(641, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(697, 39, false);
#line 27 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Admin\Views\AdminUsers\CustomerIndex.cshtml"
           Write(Html.DisplayNameFor(m => m.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(736, 124, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Disabled\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n\r\n");
            EndContext();
#line 35 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Admin\Views\AdminUsers\CustomerIndex.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(909, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(970, 31, false);
#line 39 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Admin\Views\AdminUsers\CustomerIndex.cshtml"
               Write(Html.DisplayFor(m => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1001, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1069, 34, false);
#line 42 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Admin\Views\AdminUsers\CustomerIndex.cshtml"
               Write(Html.DisplayFor(m => item.Address));

#line default
#line hidden
            EndContext();
            BeginContext(1103, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1171, 32, false);
#line 45 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Admin\Views\AdminUsers\CustomerIndex.cshtml"
               Write(Html.DisplayFor(m => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1203, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1271, 38, false);
#line 48 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Admin\Views\AdminUsers\CustomerIndex.cshtml"
               Write(Html.DisplayFor(m => item.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1309, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 51 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Admin\Views\AdminUsers\CustomerIndex.cshtml"
                     if (item.LockoutEnd != null && item.LockoutEnd > DateTime.Now)
                    {

#line default
#line hidden
            BeginContext(1464, 49, true);
            WriteLiteral("                        <label>Disabled</label>\r\n");
            EndContext();
#line 54 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Admin\Views\AdminUsers\CustomerIndex.cshtml"
                    }

#line default
#line hidden
            BeginContext(1536, 45, true);
            WriteLiteral("                </td>\r\n                <td>\r\n");
            EndContext();
#line 57 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Admin\Views\AdminUsers\CustomerIndex.cshtml"
                     if (item.LockoutEnd == null || item.LockoutEnd < DateTime.Now)
                    {

#line default
#line hidden
            BeginContext(1689, 64, true);
            WriteLiteral("                        <a type=\"button\" class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1753, "\"", 1790, 1);
#line 59 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Admin\Views\AdminUsers\CustomerIndex.cshtml"
WriteAttributeValue("", 1760, Url.Action("Edit/" + item.Id), 1760, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1791, 153, true);
            WriteLiteral(">\r\n                            <i class=\"fas fa-edit\"></i>\r\n                        </a>\r\n                        <a type=\"button\" class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1944, "\"", 1981, 1);
#line 62 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Admin\Views\AdminUsers\CustomerIndex.cshtml"
WriteAttributeValue("", 1951, Url.Action("Delete/"+item.Id), 1951, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1982, 95, true);
            WriteLiteral(">\r\n                            <i class=\"fas fa-trash-alt\"></i>\r\n                        </a>\r\n");
            EndContext();
#line 65 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Admin\Views\AdminUsers\CustomerIndex.cshtml"
                    }

#line default
#line hidden
            BeginContext(2100, 44, true);
            WriteLiteral("                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 69 "C:\Users\DELL\Desktop\Nhom 26_NgoVanHAi_17110292 VyChiHoa_17110407\17110292_NgoVanHai 17110407_VyChiHoa\Areas\Admin\Views\AdminUsers\CustomerIndex.cshtml"

        }

#line default
#line hidden
            BeginContext(2157, 24, true);
            WriteLiteral("    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<doan_cnpm.Models.ApplicationCustomerAccount>> Html { get; private set; }
    }
}
#pragma warning restore 1591
