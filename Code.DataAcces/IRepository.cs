using CodeAcademy.Core.Interfaces;
using System.ComponentModel;

namespace Code.DataAcces;

public interface IRepository<T> where T : IEntity
{
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    T Get(int id);
    List<T> GetAll();
    T GetByName(string name);
    List<T> GetAllByName(string name);
}
