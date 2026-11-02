using Microsoft.AspNetCore.Mvc;
namespace Homework01.Controllers;
public class HomeController : Controller { public IActionResult Index() => View(new ProfileViewModel("Роман Старостин", "Веб-разработка", "ASP.NET Core")); }
public record ProfileViewModel(string Name,string Hobby,string Interest);
