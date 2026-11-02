using Homework07.Models;
namespace Homework07.Tests;
public class CatFormValidatorTests
{
 private readonly CatFormValidator validator = new();
 [Fact] public void Normal_cat_is_valid(){ var result=validator.Validate(new CatForm("Мурзик",3,"рыжий")); Assert.True(result.IsValid); }
 [Fact] public void Empty_name_is_not_valid(){ var result=validator.Validate(new CatForm("",3,"рыжий")); Assert.False(result.IsValid); }
 [Fact] public void Too_big_age_is_not_valid(){ var result=validator.Validate(new CatForm("Барсик",31,"серый")); Assert.False(result.IsValid); }
 [Fact] public void Color_is_required(){ var result=validator.Validate(new CatForm("Луна",2,"")); Assert.False(result.IsValid); }
}
