using GestionDocs.Data.Abstraction;
using GestionDocs.Data.Abstraction.Models;
using GestionDocs.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GestionDocs.Data
{
    public class DocumentRepository: Repository<Document>, IDocumentRepository
    {
        public readonly SampleworkflowengineContext _contextDb;

        public DocumentRepository(SampleworkflowengineContext context) : base(context)
            => _contextDb = context;

        public async Task<ICollection<Document>> GetByDocument()
            => await _contextDb.Set<Document>().ToListAsync();

    }
}
