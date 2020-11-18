using GestionDocs.Data.Abstraction.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GestionDocs.Data.Abstraction
{
    public interface IDocumentRepository: IRepository<Document>
    {
        Task<ICollection<Document>> GetByDocument();
    }
}
