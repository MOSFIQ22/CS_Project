using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopDeviceApp.Models
{
    public class CollectionOfDevice
    {
        ObservableCollection<Device> devices;
        public CollectionOfDevice()
        {
            this.devices = new ObservableCollection<Device>()
            {
                new Device{ Id=01, Name="Apple MacBook Pro 13", Weight="1.87kg", processor="Apple M1 Pro", DisplaySize="16.20Inche", DisplayResullation="3546x2246", RAM_SSDorHDD="RAM-32GB, SSD-512GB with HDD-2TB", Address="IDB Bhabhan ,Agargaon, Dhaka-1216" ,ShopNo="11/C", Price=148000.00M, ReleaseDate=new DateTime(2021, 10, 12), OS="Mac-OS", Image="Assets/Laptop_5.jpg"},
                 new Device{ Id=02, Name="MacBook Pro 14", Weight="1.77kg", processor="Apple M1 Pro", DisplaySize="16.20Inche", DisplayResullation="3546x2246", RAM_SSDorHDD="RAM-32GB, SSD-512GB with HDD-2TB", Address="ShubastoArcitechTower, EliphantRoad Dhaka-1216",ShopNo="505/F", Price=260000.00M, ReleaseDate=new DateTime(2017, 08, 04), OS="Mac-OS", Image="Assets/Laptop-7.jpg"},
                  new Device{ Id=03, Name="Apple MacBook air", Weight="2.00kg", processor="Apple M1 chip", DisplaySize="15.90Inche", DisplayResullation="3546x2246", RAM_SSDorHDD="RAM-16GB, SSD-1TB", Address="IDB Bhabhan ,Agargaon, Dhaka-1216" ,ShopNo="102/B", Price=105000.00M, ReleaseDate=new DateTime(2019, 12, 30), OS="Mac-OS", Image="Assets/Laptop-8.jpg"},
                   new Device{ Id=04, Name="Apple MacBook Pro 16", Weight="1.70kg", processor="Apple M1 ProMax", DisplaySize="17.20Inche", DisplayResullation="3546x2246", RAM_SSDorHDD="RAM-16GB, SSD-1TB", Address="MultiplanCity ,EliphantRoad, Dhaka-1216" ,ShopNo="101#/8", Price=262000.00M, ReleaseDate=new DateTime(2021, 05, 21), OS="Mac-OS", Image="Assets/Laptop-9.jpg"},
                    new Device{ Id=05, Name="Apple MacBook AirZ", Weight="2.20kg", processor="Apple M1 Pro", DisplaySize="17.20.20Inche", DisplayResullation="3546x2246", RAM_SSDorHDD="RAM-16GB, SSD-1TB", Address="IDB Bhabhan ,Agargaon, Dhaka-1216" ,ShopNo="18/H", Price=188000.00M, ReleaseDate=new DateTime(2020, 08, 18), OS="Mac-OS", Image="Assets/Laptop-16.jpg"},

                new Device{ Id=06, Name="HP ZBook-360", Weight="2.20kg", processor="core-i7 10thGen", DisplaySize="15.60", DisplayResullation="1920x1080", RAM_SSDorHDD="RAM-16GB, SSD-256GB with HDD-1TB", Address="ShubastoArcitechTower ,EliphantRoad, Dhaka-1216",ShopNo="401#/A",  Price=52000.00M, ReleaseDate=new DateTime(2017, 09, 27), OS="Linux", Image="Assets/Laptop_1.jpg"},
                 new Device{ Id=07, Name="HP ENVYx360 Convert", Weight="1.90kg", processor="core-i5 10thGen", DisplaySize="16.60", DisplayResullation="1920x1080", RAM_SSDorHDD="RAM-8GB, SSD-120GB with HDD-1TB", Address="MultiplanCity ,EliphantRoad, Dhaka-1216" ,ShopNo="111#/45", Price=41000.00M, ReleaseDate=new DateTime(2020, 09, 13), OS="Windows 10", Image="Assets/laptop_2.jpg"},
                  new Device{ Id=08, Name="HP-pavilionx360Convertable", Weight="2.40kg", processor="core-i5 11thGen", DisplaySize="16.20", DisplayResullation="1920x1080", RAM_SSDorHDD="RAM-16GB, SSD-500GB with HDD-1TB", Address="IDB Bhabhan ,Agargaon, Dhaka-1216" ,ShopNo="15/D", Price=78000.00M, ReleaseDate=new DateTime(2019, 07, 12), OS="Windows 10", Image="Assets/Laptop_3.jpg"},
                   new Device{ Id=09, Name="HP-ZBookS-60", Weight="1.85kg", processor="core-i5 9thGen", DisplaySize="16.60", DisplayResullation="1920x1080", RAM_SSDorHDD="RAM-8GB, SSD-256GB with HDD-1TB", Address="ShubastoArcitechTower ,EliphantRoad, Dhaka-1216",ShopNo="411#/A",  Price=52000.00M, ReleaseDate=new DateTime(2018, 09, 27), OS="Linux", Image="Assets/Laptop-14.jpg"},

                new Device{ Id=10, Name="Dell Inspiron14-5410 ", Weight="1.97kg", processor="core-i5 8thGen", DisplaySize="16.80", DisplayResullation="1920x1080", RAM_SSDorHDD="RAM-8GB, SSD-120GB with HDD-1TB", Address="MultiplanCity ,EliphantRoad, Dhaka-1216" ,ShopNo="114#/55", Price=65000.00M, ReleaseDate=new DateTime(2017, 04, 17), OS="Windows 10", Image="Assets/Laptop_4.jpg"},
                 new Device{ Id=11, Name="Dell Inspiron15-5502 ", Weight="2.25kg", processor="core-i5 10thGen", DisplaySize="16.83", DisplayResullation="1920x1080", RAM_SSDorHDD="RAM-16GB, SSD-256GB with HDD-500GB", Address="IDB Bhabhan ,Agargaon, Dhaka-1216" ,ShopNo="19/W", Price=55000.00M, ReleaseDate=new DateTime(2020, 01, 16), OS="Windows 10", Image="Assets/Laptop-10.jpg"},
                  new Device{ Id=12, Name="Dell Latitude14-5420 ", Weight="2.60kg", processor="core-i7 7thGen", DisplaySize="14.95", DisplayResullation="1920x1080", RAM_SSDorHDD="RAM-8GB, SSD-120GB with HDD-500TB", Address="IDB Bhabhan ,Agargaon , Dhaka-1216" ,ShopNo="17/W", Price=45000.00M, ReleaseDate=new DateTime(2021, 06, 15), OS="Linux", Image="Assets/Laptop-11.jpg"},
                   new Device{ Id=13, Name="Dell Inspiron15-6410 ", Weight="1.90kg", processor="core-i3 11thGen ", DisplaySize="17.00", DisplayResullation="1920x1080", RAM_SSDorHDD="RAM-8GB, HDD-1TB", Address="MultiplanCity ,EliphantRoad, Dhaka-1216" ,ShopNo="115#/55", Price=65000.00M, ReleaseDate=new DateTime(2018, 04, 17), OS="Windows 10", Image="Assets/Laptop-15.jpg"},

                new Device{ Id=14, Name="Lenovo IdeaPad Slim3i",Weight="1.90kg", processor="core-i7 10thGen", DisplaySize="15.80", DisplayResullation="1920x1080", RAM_SSDorHDD="RAM-16GB, SSD-256GB with HDD-500GB", Address="ShubastoArcitechTower ,EliphantRoad, Dhaka-1216",ShopNo="10/A", Price=51000.00M, ReleaseDate=new DateTime(2018, 10, 21), OS="Windows 11", Image="Assets/Laptop_6.jpg"},
                 new Device{ Id=15, Name="Lenovo IdeaPad-3", Weight="2.20kg", processor="core-i5 10thGen", DisplaySize="14.95", DisplayResullation="1920x1080", RAM_SSDorHDD="RAM-8GB, SSD-120GB with HDD-1TB",  Address="IDB Bhabhan ,Agargaon, Dhaka-1216" ,ShopNo="103/A", Price=61000.00M, ReleaseDate=new DateTime(2019, 02, 12), OS="Windows 10", Image="Assets/Laptop-12.jpg"},
                  new Device{ Id=16, Name="Lenovo ThinkPadE14", Weight="1.80kg", processor="core-i3 11thGen", DisplaySize="16.90", DisplayResullation="1920x1080", RAM_SSDorHDD="RAM-4GB, SSD-120 with HDD-500TB", Address="IDB Bhabhan ,Agargaon, Dhaka-1216" ,ShopNo="113/O", Price=44000.00M,  ReleaseDate=new DateTime(2021, 11, 22), OS="Manjaro", Image="Assets/Laptop-13.jpg"},
                   new Device{ Id=17, Name="Lenovo ThinkPadE12", Weight="2.30kg", processor="core-i3 9thGen", DisplaySize="16.90", DisplayResullation="1920x1080", RAM_SSDorHDD="RAM-8GB, HDD-1TB", Address="IDB Bhabhan ,Agargaon, Dhaka-1216" ,ShopNo="113/O", Price=44000.00M,  ReleaseDate=new DateTime(2021, 09, 30), OS="Manjaro", Image="Assets/Laptop-17.jpg"}
            };
        }
        public ObservableCollection<Device> Get()
        {
            return this.devices;
        }
        public Device Get(int id)
        {
            return this.devices.First(x => x.Id == id);
        }
    }
}
