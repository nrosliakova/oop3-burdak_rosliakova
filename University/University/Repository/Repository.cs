namespace University;

public class Repository<T> : IRepository<T> where T : HasId
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

    public T FindById(int id)
    {
        T item = _items.SingleOrDefault(s => s.Id == id);
        if (item == null)
        {
            throw new Exception("Елемента з таким id не існує");
        }

        return item;
    }
}