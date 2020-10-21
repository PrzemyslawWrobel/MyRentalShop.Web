using MyRentalShopMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyRentalShopMVC.Domain.Interfaces
{
    public interface IDocumentsRepository
    {
        int AddDocument(Document Document);
        void DeleteDocument(int deleteDocumentId);
        IQueryable<Document> GetAllDocuments();
        Document GetDocumentByTypeId(int documentTypeId);
        Document UpdataDocument(int documentTypeID);

    }
}
