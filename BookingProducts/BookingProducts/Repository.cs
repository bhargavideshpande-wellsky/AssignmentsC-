using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProducts
{
    class Repository 
    {
       public Irepository GetStorageType(string storageType)
        {
            switch (storageType)
            {
                case "file": return new ProductsInFile();
                default: return new ProductsInFile();
            }
        }

        
    }
}
