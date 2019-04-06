using System;
using System.Collections.Generic;

namespace WineBook.Models
{
    public class Allocation 
    {
        public virtual Distributor Distributor { get; set; }
        public DateTime SignUpDate { get; set; }
        public DateTime GrantedDate { get; set; }
        public virtual ICollection<ReleaseSchedule> ReleaseSchedule { get; set; }
        public virtual ICollection<Purchase> Purchases { get; set; }
    }
}
