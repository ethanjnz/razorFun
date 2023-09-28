using Microsoft.AspNetCore.Mvc;
namespace firstWeb.Controllers;

public class HelloController : Controller
{
    [HttpGet("")]
    public string Index()
    {
        return "This is my Index!";
    }

    [HttpGet("projects")]
    public string Projects()
    {
        return "These are my projects";
    }

    [HttpGet("contact")]
    public string Contact()
    {
        return "This is my Contact";
    }

}