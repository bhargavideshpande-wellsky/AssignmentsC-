using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProducts
{
    class ProductsInFile : Irepository
    {
        public void AddProductDetailsToFile(Iproduct product)
        {
            string pathString = @"C:\ProductDetails.txt";
            
                using (StreamWriter sw = File.AppendText(pathString))
                {
                    sw.WriteLine("Product Name: "+ product.ProductName);
                    sw.WriteLine("Product Status: " + product.IsBooked);
                }
          
        }

    }
}

