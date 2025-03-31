namespace University;

public interface IRepository<T> where T : HasId
{
    
    void Add(T item);
    void Delete(T item);
    List<T> GetAll();

    T FindById(int id);
}
