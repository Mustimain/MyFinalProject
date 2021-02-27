using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {

        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Bakım Zamanı";
        public static string ProductListed = "Ürünler Listelendi";
        public static string ProductCountOfCategoryError = "Kategorideki ürün sayisi en fazla 10 olabilir";
        public static string ProductNameAlreadyExist = "Bu isimde ürün mevcut";
        public static string CategoryLimitExceded = "Kategori limiti asildi";

        public static string AuthorizationDenied = "Yetkiniz Yok.";
    }
}
