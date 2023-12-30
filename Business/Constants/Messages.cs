using Core.Entities.Concretes;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime ="Sistem bakımda";
        public static string ProductsListed ="Ürünler listelendi";
        public static string ProductCountOfCategoryError ="Bu kategorideki maksimum ürün sayısı aşıldı";
        public static string ProductNameAlreadyExists ="Bu isimde zaten başka bir ürün var";
        public static string CategoryLimitExceded = "Kategori limiti aşıldığı için yeni ürün eklenemiyor.";
        public static string AuthorizationDenied = "Yetkiniz yok.";
		internal static string PasswordError="Şifre hatalı.";
		internal static string UserNotFound="Kullanıcı bulunamadı.";
		internal static string UserRegistered="Kullanıcı kaydı başarılı.";
        public static string AccessTokenCreated = "Erişim tokeni oluşturuldu";
        public static string UserAlreadyExists = "Bu kullanıcı zaten var";
        public static string SuccessfulLogin = "Başarılı giriş";
	}
}
