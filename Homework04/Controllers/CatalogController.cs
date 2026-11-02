using Microsoft.AspNetCore.Mvc;
namespace Homework04.Controllers;
public class CatalogController:Controller { [HttpGet] public IActionResult Index()=>View(new List<string>{"Книга","Ноутбук","Рюкзак"}); [HttpPost] public IActionResult Add(string name){ if(string.IsNullOrWhiteSpace(name)){ModelState.AddModelError("name","Название обязательно"); return View("Index",new List<string>());} return RedirectToAction(nameof(Index)); } }
