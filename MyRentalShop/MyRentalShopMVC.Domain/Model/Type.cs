using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Domain.Model
{
    public class Type
    {
        public int Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// relacja z Itemem, ktora mówi o tym ile Item należy do danego typu, jest to kolekcja
        /// 1 Item może być tylko jednego typu
        /// 1 typmoże mieć wiele Itemów
        /// </summary>
        public virtual ICollection<Item> Items { get; set; }
    }
}
