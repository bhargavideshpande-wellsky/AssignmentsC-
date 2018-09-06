using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProducts
{

    class Default : Iproduct
    {
        string productName = "Air";
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
            Console.WriteLine("Wrong Credential");
        }

        public string GetTypeOfProduct()
        {
            return "Wrong Credential";
        }

        public void Save()
        {
            Console.WriteLine("Wrong Credential");
        }
    }
}
