namespace MyRentalShopMVC.Domain.Model
{
    public class DocumentDetailType
    {
        public int Id { get; set; }

        //TODO do refaktoryzacji na enum
        /// <summary>
        /// Przechowuje informacje czy to jest dowód osobisty, paszport, prawo jazdy
        /// </summary>
        public string Name { get; set; }
    }
}