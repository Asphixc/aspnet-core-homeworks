using Microsoft.AspNetCore.Mvc;
namespace Homework02.Controllers;
public class MathController : Controller { public IActionResult Plus(decimal a,decimal b)=>Json(new{a,b,result=a+b}); public IActionResult Minus(decimal a,decimal b)=>Json(new{a,b,result=a-b}); public IActionResult Multiply(decimal a,decimal b)=>Json(new{a,b,result=a*b}); public IActionResult Divide(decimal a,decimal b)=>b==0?BadRequest("Деление на ноль невозможно"):Json(new{a,b,result=a/b}); }
