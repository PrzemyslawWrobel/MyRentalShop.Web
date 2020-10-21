using Microsoft.EntityFrameworkCore.Storage;
using MyRentalShopMVC.Domain.Interfaces;
using MyRentalShopMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Type = MyRentalShopMVC.Domain.Model.Type;

namespace MyRentalShopMVC.Infrastructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly Context _context;
        public ItemRepository(Context context)
        {
            _context = context;
        }

        /// <summary>
        /// Dodaje rzecz do wypożyczenia
        /// </summary>
        /// <param name="itemId"></param>
        public void DeleteItem(int itemId)
        {
            var item = _context.Items.Find(itemId);
            if(item !=null)
            {
                _context.Items.Remove(item);
                _context.SaveChanges();
            }
        }


        /// <summary>
        /// usuwa rzecz z listy rzeczy do wpożyczenia
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int AddItem(Item item)
        {
            _context.Add(item);
            _context.SaveChanges();
            return item.Id;
        }

        /// <summary>
        /// Pobranie listy rzeczy po typie
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public IQueryable<Item> GetItemsByTypeId(int typeId)
        {
            var items = _context.Items.Where(i => i.TypeId == typeId);
            return items;
        }

        /// <summary>
        /// pobranie rzeczy po id
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public Item GetItemById(int itemId)
        {
            var item = _context.Items.FirstOrDefault(i => i.Id == itemId);
            return item;
        }

        ///TODO metoda update do implementacji
        public Item UpdateItem(int itemId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Tag> GetAllTags()
        {
            var tags = _context.Tags;
            return tags;
        }


        /// <summary>
        /// PObranie wszystkich typów rzeczy np samochody, kosiarki ...
        /// </summary>
        /// <returns></returns>
        public IQueryable<Type> GetAllTypes()
        {
            var types = _context.Types;
            return types;
        }

    }
}
