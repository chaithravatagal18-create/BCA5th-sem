using Microsoft.AspNetCore.Mvc; 
using Microsoft.AspNetCore.Mvc.RazorPages; 
 
namespace ASP.Pages; 
 
public class IndexModel : PageModel 
{ 
    [BindProperty] 
    public string? StudentName { get; set; } 
 
    [BindProperty] 
    public int Age { get; set; } 
 
    public void OnPost() 
    { 
    } 
} 
 
File: Pages/Index.cshtml 
@page 
@model IndexModel 
 
<h2>Student Information Form</h2> 
 
<form method="post"> 
    <label>Enter Name:</label> 
    <input type="text" name="StudentName" required /> 
    <br /><br /> 
 
    <label>Enter Age:</label> 
    <input type="number" name="Age" required /> 
    <br /><br /> 
 
    <button type="submit">Submit</button> 
</form> 
 
@if (Model.StudentName != null) 
{ 
    <h3>Student Details</h3> 
    <p>Name: @Model.StudentName</p> 
    <p>Age: @Model.Age</p> 
}
