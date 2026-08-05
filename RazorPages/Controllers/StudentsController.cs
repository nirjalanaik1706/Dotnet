namespace RazorPages.Controllers;

using Microsoft.AspNetCore.Mvc;
using RazorPages.Models;
public class StudentsController: Controller
{
    public IActionResult Details()
    {
        Student student = new Student();

        student.Id = 1;
        student.Name = "Ravi";
        student.City = "Pune";

        return View(student);
    }
}