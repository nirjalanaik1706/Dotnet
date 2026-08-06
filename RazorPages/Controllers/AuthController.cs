using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;
using RazorPages.Models;
namespace ECommercePortal.Controllers;

public class AuthController : Controller
{
    [HttpGet]
    public IActionResult Login()
    {
        Credential c=new Credential();
        c.UserName="";
        c.Password="";
        return View(c);
    }

    [HttpPost]
    public IActionResult Login(Credential c)
    {
        if(c.UserName=="admin"&& c.Password == "nirjala")
        {
            return RedirectToAction("Welcome","Home");
        }
        else
        {
            return View();
        }
    }

    [HttpGet]
    public IActionResult Register()
    {
        Customer c=new Customer();
        c.Name="";
        c.Email="";
        c.Phone="";
        c.Id=2;

        return View(c);
    }

    [HttpPost]
    public IActionResult Register(Customer c)
    {
        Console.WriteLine($"new user registered: {c.Name},{c.Email},{c.Phone}");
        return RedirectToAction("Login");
    }

    public IActionResult ChangePassword()
    {
        return View();
    }
}