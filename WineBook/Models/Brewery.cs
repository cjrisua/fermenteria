using System;
using System.Collections.Generic;

namespace WineBook.Models
{
    public class Brewery 
    {
        public int BreweryId { get; set; }
        public virtual Producer Producer { get; set; }
    }
}
