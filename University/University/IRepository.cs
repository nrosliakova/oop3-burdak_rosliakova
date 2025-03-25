namespace University;

public interface IRepository<T>
{
    void Add(T item);
    T Delete(T item);
    List<T> GetAll();
    int Count();
    IEnumerable<T> SortBy<TProperty>(Func<T, TProperty> keySelector);

}
