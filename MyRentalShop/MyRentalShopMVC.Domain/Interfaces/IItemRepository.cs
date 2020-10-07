using MyRentalShopMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Type = MyRentalShopMVC.Domain.Model.Type;

namespace MyRentalShopMVC.Domain.Interfaces
{
    public interface IItemRepository
    {
        void DeleteItem(int itemId);

        int AddItem(Item item);

        IQueryable<Item> GetItemsByTypeId(int typeId);

        Item GetItemById(int itemId);

        Item UpdateItem(int itemId);

        IQueryable<Tag> GetAllTags();  

        IQueryable<Type> GetAllTypes();
    }
}
