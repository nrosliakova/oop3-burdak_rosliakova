namespace University;

public class Repository<T> : IRepository<T>
{
    private readonly List<T> _items;
    public Repository(List<T> items)
    {
         _items = items;
    }
    public List<T> GetAll()
    {
        return _items;
    }

    public void Add(T item)
    {
        _items.Add(item);
    }

    public void Delete(T item)
    {
        _items.Remove(item);
    }

    
}