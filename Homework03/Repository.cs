namespace Homework03;
public record Product(int Id,string Name,decimal Price);
public interface IProductRepository { IReadOnlyList<Product> GetAll(); void Add(Product product); }
public sealed class InMemoryProductRepository:IProductRepository { private readonly List<Product> items=new(){new(1,"Клавиатура",3500),new(2,"Мышь",1800)}; public IReadOnlyList<Product> GetAll()=>items; public void Add(Product p)=>items.Add(p); }
