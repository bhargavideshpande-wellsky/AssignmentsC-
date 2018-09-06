using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProducts
{
    class Hotel:Iproduct
    {
        string productName = "Hotel";
        bool isBooked;
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }
        public bool IsBooked
        {
            get { return isBooked; }
            set { isBooked = value; }
        }
        public  void Save()
        {
            Console.WriteLine("Hotel Saved");
        }

        public  void Book(Iproduct product, Irepository storageType)
        {
            Console.WriteLine("Booked Hotel");
        }

        public string GetTypeOfProduct()
        {
            return "Hotel";
        }
    }
}
