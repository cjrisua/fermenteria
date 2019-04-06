using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WineBook.Models
{
    public class Producer
    {
        public int ProducerId { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Producer Name")]
        public string ProducerName { get; set; }

        [StringLength(50)]
        public string Website { get; set; }

        public virtual ICollection<Container> Bottles { get; set; }
    }
}
