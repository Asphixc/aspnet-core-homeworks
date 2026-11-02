using FluentValidation;
namespace Homework07.Models;
public record CatForm(string Name,int Age,string Color);
public sealed class CatFormValidator:AbstractValidator<CatForm> { public CatFormValidator(){ RuleFor(x=>x.Name).NotEmpty().Length(2,40); RuleFor(x=>x.Age).InclusiveBetween(0,30); RuleFor(x=>x.Color).NotEmpty(); } }

