using System;
namespace WineBook.Models
{
    public class Distributor
    {
        public int DistributorId { get; set; }
        public string DistributorName { get; set; }
        public Producer Producer { get; set; }
    }
}
