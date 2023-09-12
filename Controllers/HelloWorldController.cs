using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace CaesarMovie.Controllers;

public class HelloWorldController : Controller
{
    public string Index()
    {
        return "This is Emmanuel";
    }

    public string Welcome()
    {
        return "My Data ";
    }
}