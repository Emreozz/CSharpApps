using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Urun eklendi";
        public static string ProductNameInvalid = "Urun ismi gecersiz";

        public static string ProductsListed = "Urunler listelendi";

        public static string MaintenanceTime = "Sistem bakimda";
        public static string RentalAdded = "Kiralama yapildi";
        public static string RentInvalid = "Kiralanacak arac teslim edilmedi";

        public static string CustomerAdded = "Musteri eklendi";

        public static string CustomerDeleted = "Musteri silindi";

        public static string CustomerUpdated = "Musteri guncellendi";

        public static string RentCountOfCategoryError = "Bir musteri cok sayida kiralama yapti";

        public static string RentalDeleted = "Customer'daki rental silindi";

        public static string ImageAdded = "Resim eklendi";

        public static string ImageDeleted = "Resim silindi";

        public static string ImageUploaded = "Resim yuklendi";
    }
}
