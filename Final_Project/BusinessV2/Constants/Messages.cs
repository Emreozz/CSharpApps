using CoreV2.Entities.Concrete;
using EntitiesV2.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace BusinessV2.Constants
{
    public static class Messages
    {
         
        public static string ProductAdded = "Urun eklendi";
        public static string ProductNameInvalid = "Urun ismi gecersiz";
        public static string ProductsListed = "Urunler listelendi";
        public static string MaintenanceTime = "Sistem bakimda";
        public static string ProductCountCategoryError = "Bir kategoride en fazla 10 urun olabilir";
        public static string categoryLimitExceed = "Kategori limiti 15'i asti";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserRegistered = "Kullanici kayit oldu";
        public static string UserNotFound = "Kullanici bulunamadi";
        public static string PasswordError = "Sifre hatali";
        public static string SuccessfulLogin = "Giris basarili";
        public static string UserAlreadyExists = "Kullanici kayitli";
        public static string AccessTokenCreated = "Token olusturuldu";
    }
}
