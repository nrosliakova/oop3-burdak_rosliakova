namespace University;

public interface IRepository<T> where T : HasId
{
    
    void Add(T item);
    T Delete(T item);
    List<T> GetAll();
    int Count();
    IEnumerable<T> SortBy<TProperty>(Func<T, TProperty> keySelector);

    T FindById(int id);

}
