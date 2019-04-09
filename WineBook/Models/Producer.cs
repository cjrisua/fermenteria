using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

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

        [Display(Name = "Open to Public")]
        public Enums.YesNo IsOpenToPublic { get; set; }

        public virtual ICollection<Container> Bottles { get; set; }

        public Enums.ProductionType ProductionType { get; set; }
    }
}
