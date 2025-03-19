namespace University;

public interface IRepository<T>
{
    void Add(T item);
    void Delete(T item);
    List<T> GetAll();

    
}
