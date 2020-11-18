using GestionDocs.Data.Abstraction;
using GestionDocs.Data.Option;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GestionDocs.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        private readonly ApiOption apiOptions;
        private readonly string path;
        public readonly SampleworkflowengineContext _context;
        protected string BASE_PATH => $"{this.apiOptions.Url}{this.path}";

        public Repository(SampleworkflowengineContext context)
            => _context = context;

        public async Task<ICollection<T>> GetAllAsync()
            => await _context.Set<T>().ToListAsync();

        public async Task<T> GetAsync(int id)
            => await _context.Set<T>().FindAsync(id);
    }
}
