using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProducts
{
    class Program
    {
        
        static void Main(string[] args)
        {
            productFactory obj = new productFactory();
            Repository obj1 = new Repository();
            Console.WriteLine("Enter Product which you want to book or save:");
            string productName = Console.ReadLine();
            Iproduct prod = obj.GetProduct(productName);

            string product = prod.GetTypeOfProduct();

            Console.WriteLine("Enter the storage type ");
            string storageType = Console.ReadLine();
            Irepository storage = obj1.GetStorageType(storageType); 
            
            Console.WriteLine("Enter your choice\n1.save "+product+"\n2.Book "+product);
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    prod.Save();
                    break;
                case 2:
                    prod.Book(prod,storage);
                    break;

            }
           
        }
    }
}
