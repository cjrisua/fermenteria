using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WineBook.Models
{
    public class Winery 
    {
        public int WineryId { get; set; } 
        public string WineMakerName { get; set; }
        public virtual Producer Producer { get; set; }
    }
}
