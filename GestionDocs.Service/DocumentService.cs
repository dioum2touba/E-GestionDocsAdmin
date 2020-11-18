using GestionDocs.Data.Abstraction;
using GestionDocs.Data.Abstraction.Models;
using GestionDocs.Service.Abstraction.CollectionViewModels;
using GestionDocs.Service.Abstraction.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDocs.Service
{
    public class DocumentService : IDocumentService
    {
        private readonly IRepository<Document> documentRepository;
        public IDocumentRepository _documentRepository;

        public DocumentService(IRepository<Document> documentRepository, IDocumentRepository _documentRepository)
            => (this.documentRepository, this._documentRepository) = (documentRepository, _documentRepository);

        public async Task<ICollection<DocumentVM>> GetAllAsync()
        {
            var res = await documentRepository.GetAllAsync();
            var result = new List<DocumentVM>();
            res.ToList().ForEach(elt =>
            {
                result.Add(new DocumentVM()
                {

                });
            });
            return result;
        }

        public Task<DocumentVM> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
