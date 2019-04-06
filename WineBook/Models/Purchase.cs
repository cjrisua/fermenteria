using System;
namespace WineBook.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public float Amount { get; set; }
        public DateTime DeliveredDate { get; set; } 
        public virtual Distributor Distributor { get; set;}
    }
}
