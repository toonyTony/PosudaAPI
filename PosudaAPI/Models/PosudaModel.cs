namespace PosudaAPI.Models
{
    public class PosudaModel
    {
        public class PriceList
        {
            public int Id { get; set; }
            public int DishCode { get; set; }
            public string DishName { get; set; }
            public int Price { get; set; }
        }
        public class SalesRegistration
        {
            public int Id { get; set; }
            public DateTime SaleDate { get; set; }
            public int DishCode { get; set; }
            public string DishName { get; set; }
            public int QuantitySold { get; set; }
            public int TotalCost { get; set; }
        }

    }
}
