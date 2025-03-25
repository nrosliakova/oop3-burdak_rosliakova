using System.Linq;


namespace University;

public class Repository<T> : IRepository<T> where T : HasId
{
    private readonly List<T> _items;
    public Repository(List<T> items)
    {
        _items = items;
    }
    public Repository()
    {
        _items = new List<T>();
    }
    public List<T> GetAll()
    {
        return _items;
    }

    public void Add(T item)
    {
        _items.Add(item);
    }

    public T Delete(T item)
    {
        _items.Remove(item);
        return item;
    }
    public int Count()
    {
        return _items.Count;
    }
    public IEnumerable<T> SortBy<TProperty>(Func<T, TProperty> keySelector)
    {
        return _items.OrderBy(keySelector);
    }
    public void Print()
    {
        foreach(T el in _items)
        {
            Console.WriteLine(el);
        }
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