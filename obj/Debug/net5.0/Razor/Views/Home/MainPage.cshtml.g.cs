#pragma checksum "C:\Users\Kirill\Source\ReactExample\Views\Home\MainPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3152cbaa64347347e0b9df29e3f7272dab7577a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MainPage), @"mvc.1.0.view", @"/Views/Home/MainPage.cshtml")]
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
#line 2 "C:\Users\Kirill\Source\ReactExample\Views\_ViewImports.cshtml"
using React.AspNet;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3152cbaa64347347e0b9df29e3f7272dab7577a7", @"/Views/Home/MainPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0181a2e0c95555b1dad567390b98f8ddc200893", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MainPage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Kirill\Source\ReactExample\Views\Home\MainPage.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Public Sector";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Kirill\Source\ReactExample\Views\Home\MainPage.cshtml"
Write(Html.React("CommentBox", new{url = Url.Action("Comments","CommentsApi"),submitUrl = Url.Action("AddComment","CommentsApi")}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/react/16.13.0/umd/react.development.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/react-dom/16.13.0/umd/react-dom.development.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/prop-types/15.6.0/prop-types.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/remarkable/1.7.1/remarkable.min.js""></script>
<script");
                BeginWriteAttribute("src", " src=\"", 642, "\"", 686, 1);
#nullable restore
#line 14 "C:\Users\Kirill\Source\ReactExample\Views\Home\MainPage.cshtml"
WriteAttributeValue("", 648, Url.Content("~/js/realtimeClock.jsx"), 648, 38, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n<script");
                BeginWriteAttribute("src", " src=\"", 706, "\"", 747, 1);
#nullable restore
#line 15 "C:\Users\Kirill\Source\ReactExample\Views\Home\MainPage.cshtml"
WriteAttributeValue("", 712, Url.Content("~/js/commentBox.jsx"), 712, 35, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("></script>\r\n");
#nullable restore
#line 16 "C:\Users\Kirill\Source\ReactExample\Views\Home\MainPage.cshtml"
Write(Html.ReactInitJavaScript());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
