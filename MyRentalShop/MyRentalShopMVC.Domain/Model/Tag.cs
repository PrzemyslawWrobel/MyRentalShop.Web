using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Domain.Model
{
    /// <summary>
    /// klasa będzie służyć do wyszukiwania po tagach
    /// </summary>
    public class Tag
    {


        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ItemTag> ItemTags { get; set; }

    }
}
