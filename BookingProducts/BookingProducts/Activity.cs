using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProducts
{
    class Activity : Iproduct
    {
        string productName = "Activity";
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
        public void Book(Iproduct product, Irepository storageType)
        {
            Console.WriteLine("Activity Booked");
        }

        public string GetTypeOfProduct()
        {
            return "Activity";
        }

        public void Save()
        {
            Console.WriteLine("Activity saved");
        }
    }
}
