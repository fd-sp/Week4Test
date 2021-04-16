using System;
using System.Collections.Generic;
using System.Text;

namespace AnagraficaClienti.EntitiesLayer.IRepositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        bool DeleteById(int id);
        bool Create(T item);
        bool Update(int id, T item);
    }
}
