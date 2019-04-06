using System;
namespace WineBook.Models
{
    public class Container
    {
        public int ContainerId { get; set; }
        public int ContainerName { get; set; }
        public virtual Producer Producer { get; set; }
    }
}
