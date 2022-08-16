using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
    public interface IRepository<T> 
    {
        Task<T> Insert(T item);
        Task<T> Update(T item);
        Task<bool> Delete(int id);
        Task<T> select(int id);
        Task<List<T>> Select();
    }
}
