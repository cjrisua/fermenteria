using System;
namespace WineBook.Models
{
    public class ProducerViewModel
    {
        public Producer Producer { get; set; }
        public Winery Winery { get; set; }
        public Brewery Brewery { get; set; }

        public ProducerViewModel()
        {
            //this.Brewery = new Brewery();
            this.Producer = new Producer();
            //this.Winery = new Winery();
        }
    }
}
