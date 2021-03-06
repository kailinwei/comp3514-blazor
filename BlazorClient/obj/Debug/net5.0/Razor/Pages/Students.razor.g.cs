#pragma checksum "/Users/kailinwei/Downloads/School/BlazorClient/Pages/Students.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c924420ac577915d34ce3000dfef9778289d03f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/kailinwei/Downloads/School/BlazorClient/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/kailinwei/Downloads/School/BlazorClient/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/kailinwei/Downloads/School/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/kailinwei/Downloads/School/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/kailinwei/Downloads/School/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/kailinwei/Downloads/School/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/kailinwei/Downloads/School/BlazorClient/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/kailinwei/Downloads/School/BlazorClient/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/kailinwei/Downloads/School/BlazorClient/_Imports.razor"
using BlazorClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/kailinwei/Downloads/School/BlazorClient/_Imports.razor"
using BlazorClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/kailinwei/Downloads/School/BlazorClient/_Imports.razor"
using SchoolLibrary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/students")]
    public partial class Students : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Students</h1>");
#nullable restore
#line 6 "/Users/kailinwei/Downloads/School/BlazorClient/Pages/Students.razor"
 if (students == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 9 "/Users/kailinwei/Downloads/School/BlazorClient/Pages/Students.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<a href=\"/AddPage\" class=\"btn btn-success btn-sm\">Add</a>");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table table-hover");
            __builder.AddMarkupContent(5, "<thead><tr><th>ID</th>\r\n            <th>First Name</th>\r\n            <th>Last Name</th>\r\n            <th>School</th></tr></thead>\r\n    ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 25 "/Users/kailinwei/Downloads/School/BlazorClient/Pages/Students.razor"
         foreach (var item in students)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
            __builder.AddContent(9, 
#nullable restore
#line 28 "/Users/kailinwei/Downloads/School/BlazorClient/Pages/Students.razor"
                         item.StudentId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                    ");
            __builder.OpenElement(11, "td");
            __builder.AddContent(12, 
#nullable restore
#line 29 "/Users/kailinwei/Downloads/School/BlazorClient/Pages/Students.razor"
                         item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 30 "/Users/kailinwei/Downloads/School/BlazorClient/Pages/Students.razor"
                         item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 31 "/Users/kailinwei/Downloads/School/BlazorClient/Pages/Students.razor"
                         item.School

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                    ");
            __builder.OpenElement(20, "td");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "href", "/EditPage/" + (
#nullable restore
#line 32 "/Users/kailinwei/Downloads/School/BlazorClient/Pages/Students.razor"
                                            item.StudentId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "class", "btn btn-success btn-sm");
            __builder.AddContent(24, "edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "td");
            __builder.OpenElement(27, "a");
            __builder.AddAttribute(28, "href", "/DeletePage/" + (
#nullable restore
#line 33 "/Users/kailinwei/Downloads/School/BlazorClient/Pages/Students.razor"
                                              item.StudentId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "class", "btn btn-danger btn-sm");
            __builder.AddContent(30, "del");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "/Users/kailinwei/Downloads/School/BlazorClient/Pages/Students.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "/Users/kailinwei/Downloads/School/BlazorClient/Pages/Students.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "/Users/kailinwei/Downloads/School/BlazorClient/Pages/Students.razor"
           
    private Student student = new Student();

    Student[] students;
    string baseUrl = "http://localhost:9709/"; // URL of our API service

    protected override async Task OnInitializedAsync()
    {
        await load();
    }

    protected async Task load()
    {
        students = await httpClient.GetFromJsonAsync<Student[]>($"{baseUrl}api/students");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
