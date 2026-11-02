namespace Homework06;
public class FavoriteCats { private readonly HashSet<int> ids=new(); public void Add(int id)=>ids.Add(id); public void Remove(int id)=>ids.Remove(id); public bool Contains(int id)=>ids.Contains(id); public IReadOnlyCollection<int> All=>ids; }
