 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingProducts
{
    public interface Iproduct
    {
        string GetTypeOfProduct();
        void Save();
        void Book(Iproduct product, Irepository storageType);
        string ProductName { get; set; }
        bool IsBooked { get; set; }
    }
}
