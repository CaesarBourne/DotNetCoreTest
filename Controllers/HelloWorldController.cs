using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace CaesarMovie.Controllers;

public class HelloWorldController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Welcome(string name, int clicked = 1)
    {

        ViewData["Message"] = "Hello this is user {name}";
        ViewData["NumberValue"] = clicked;
        return View();
        // return HtmlEncoder.Default.Encode($"This is user new name {name} this is the name  {clicked}");
    }
}