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


        /// <summary>
        /// Dodaje dokument osoby reprezentującej klienta, lub dokument klienta indywidualnego
        /// </summary>
        /// <param name="document"></param>
        /// <returns></returns>
        public int AddDocument(Document document)
        {
            _context.Add(document);
            _context.SaveChanges();
            return document.Id;
        }

        /// <summary>
        /// Usuwa dokument
        /// </summary>
        /// <param name="deleteDocumentId"></param>
        public void DeleteDocument(int deleteDocumentId)
        {
            var documentForDelete = _context.Documents.Find(deleteDocumentId);
            if(documentForDelete != null)
            {
                _context.Remove(documentForDelete);
                _context.SaveChanges();
            }
        }

        /// <summary>
        /// Pobiera wszytkie dokumenty osoby reprezentującej klienta, lub dokumenty klienta indywidualnego
        /// </summary>
        /// <returns></returns>
        public IQueryable<Document> GetAllDocuments()
        {
            var documentList = _context.Documents;
            return documentList;
        }

        /// <summary>
        /// Pobiera dokument wg typu
        /// </summary>
        /// <param name="documentTypeId"></param>
        /// <returns></returns>
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
