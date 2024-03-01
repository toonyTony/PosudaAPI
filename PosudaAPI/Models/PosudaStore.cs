using System;
using static PosudaAPI.Models.PosudaModel;

namespace PosudaAPI.Models
{
    public class PosudaStore
    {
        public static List<PriceList> posudaList = new List<PriceList>
        {
            new PriceList {Id=1, DishCode =01,  DishName="Tarelka", Price=100 },
            new PriceList {Id=2, DishCode= 02, DishName="Kastulya", Price=1000 }
        };
        public static List<SalesRegistration> saleList = new List<SalesRegistration>
        {
            new SalesRegistration {Id=1, SaleDate=DateTime.Now, DishCode =01,  DishName="Tarelka", QuantitySold=10, TotalCost=1000},
            new SalesRegistration {Id=2, SaleDate=DateTime.Now, DishCode =02,  DishName="Kastulya", QuantitySold=40, TotalCost=40000}
        };
        
            
    }
}
