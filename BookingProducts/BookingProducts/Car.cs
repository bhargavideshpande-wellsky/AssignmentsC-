using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProducts
{
    class Car : Iproduct
    {
        string productName = "car";
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
            product.IsBooked = true;
            storageType.AddProductDetailsToFile(product);
        }

        public string GetTypeOfProduct()
        {
            return "car";
        }

        public void Save()
        {
            Console.WriteLine("Car saved");
        }
    }
}
