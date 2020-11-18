using GestionDocs.Service.Abstraction.CollectionViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GestionDocs.Service.Abstraction.Document
{
    public interface IDocumentService
    {
        Task<ICollection<DocumentVM>> GetAllAsync();
        Task<DocumentVM> GetAsync(int id);
    }
}
