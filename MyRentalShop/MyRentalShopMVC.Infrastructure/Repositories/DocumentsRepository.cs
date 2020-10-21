using MyRentalShopMVC.Domain.Interfaces;
using MyRentalShopMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyRentalShopMVC.Infrastructure.Repositories
{
    class DocumentsRepository : IDocumentsRepository
    {
        private readonly Context _context;
        public DocumentsRepository(Context context)
        {
            _context = context;
        }

        public Context Context { get; }

        public int AddDocument(Document document)
        {
            _context.Add(document);
            _context.SaveChanges();
            return document.Id;
        }

        public void DeleteDocument(int deleteDocumentId)
        {
            var documentForDelete = _context.Documents.Find(deleteDocumentId);
            if(documentForDelete != null)
            {
                _context.Remove(documentForDelete);
                _context.SaveChanges();
            }
        }

        public IQueryable<Document> GetAllDocuments()
        {
            var documentList = _context.Documents;
            return documentList;
        }

        public Document GetDocumentByTypeId(int documentTypeId)
        {
            var document = _context.Documents.FirstOrDefault(i => i.Id == documentTypeId);
            return document;
        }

        public Document UpdataDocument(int documentTypeID)
        {
            throw new NotImplementedException();
        }
    }
}
