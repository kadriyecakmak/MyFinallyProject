using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        internal static readonly string ProductNameAlreadyExists;
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime= "Sistem bakımda";
        public static string ProductListed = "Ürünler listelendi";
        public static string ProductCountOfCategoryError = "Ürün sayısı 10 u geçemez";
        public static string ProductNameAlreadyExis = "Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded ="Kategori limiti aşıldığı için yeni ürün eklenemiyor :(";
        public static string AuthorizationDenied = "Yetkiniz yoktur.";
        public static string UserRegistered = "Kayıt olundu";

        public static string UserNotFound = "Kullanıcı bulunamadı";

        public static string PasswordError = "ŞİFRE HATALI";

        public static string SuccessfulLogin = "Başarılı giriş";

        public static string UserAlreadyExists = "Kullanıcı mevcut";

        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
