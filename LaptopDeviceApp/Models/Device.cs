using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopDeviceApp.Models
{
    public class Device
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Weight { get; set; }
        public string processor { get; set; }
        public string DisplaySize { get; set; }
        public string DisplayResullation { get; set; }
        public string RAM_SSDorHDD { get; set; }
        public string OS { get; set; }
        public string ShopNo { get; set; }
        public string Address { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Decimal Price { get; set; }      
        public string Image { get; set; }
        public string ReleasedOn { get => this.ReleaseDate.ToString("MMM yyyy"); }
    }
}
