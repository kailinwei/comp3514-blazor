// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/DeletePage/{studentId}")]
    public partial class DeletePage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "/Users/kailinwei/Downloads/School/BlazorClient/Pages/DeletePage.razor"
      


    [Parameter]

    public String StudentId { get; set; }
    private Student student = new Student();

    Student s;

   // Student[] students;
    string baseUrl = "http://localhost:9709/";//URL OF OUR API SERVICE


    protected async Task ShowDelete(string id)
    {
        s = await httpClient.GetFromJsonAsync<Student>($"{baseUrl}api/students/{id}");
        student.StudentId = s.StudentId;
        student.FirstName = s.FirstName;
        student.LastName = s.LastName;
        student.School = s.School;

    }


    

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "/Users/kailinwei/Downloads/School/BlazorClient/Pages/DeletePage.razor"
           

    private void returnToStudentpage()
    {
        NavManager.NavigateTo("/");
    }


    protected override async Task OnInitializedAsync()
    {
        await ShowDelete(StudentId);
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "/Users/kailinwei/Downloads/School/BlazorClient/Pages/DeletePage.razor"
            protected async void HandleDelete()
        {
            string endpoint = $"{baseUrl}api/students/{student.StudentId}";
            await httpClient.DeleteAsync(endpoint);
            await httpClient.PutAsJsonAsync(endpoint, student);
            returnToStudentpage();

        } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
