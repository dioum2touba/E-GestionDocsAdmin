using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GestionDocs.Data.Abstraction
{
    public interface IRepository<T>
    {
        Task<T> GetAsync(int id);
        Task<ICollection<T>> GetAllAsync();
    }
}
