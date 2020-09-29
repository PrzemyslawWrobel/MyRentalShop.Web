using System;
using System.Collections.Generic;
using System.Text;

namespace MyRentalShopMVC.Domain.Model
{
    public class Item
    {
        /// <summary>
        /// Id produktu autoinkrementacja na bazie
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Nazwa produktu
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// rozszerzona nazwa produktu
        /// </summary>
        public string SecondName { get; set; }
        
        /// <summary>
        /// jakiego typu jest produkt
        /// </summary>
        public string TypeId { get; set; }
 
        /// <summary>
        /// Nr inwentarzowy np kod kreskowy, lub nr rejestracyjny pojazdu
        /// </summary>
        public int InventoryNumber { get; set; }


        /// <summary>
        /// Pole do sprawdzania jakiego typu jest produkt i do 
        /// </summary>
        public virtual Type Type { get; set; }

        


}
}
