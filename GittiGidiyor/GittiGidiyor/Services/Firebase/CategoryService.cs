using GittiGidiyor.Models;
using GittiGidiyor.Services.Firebase.FireBaseConnect;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GittiGidiyor.Services.Firebase
{
    public class CategoryService
    {

        public static CategoryService _instance;

        public static CategoryService Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CategoryService();

                return _instance;
            }
        }
        public List<Category> GetAllCategorys()
        {

            FirebaseDB firebaseDB = new FirebaseDB("https://gittigidiyor-2e746-default-rtdb.firebaseio.com/-MaFhVtN1IViIcVXHiIs/ProductCollectionStats/Filters/0/values");
            FirebaseResponse getResponse = firebaseDB.Get();

            var result = JsonConvert.DeserializeObject<List<Category>>(getResponse.JSONContent);

            return result;
        }

        public async Task<Category> GetCategory(string ad)
        {
            var allCategorys = GetAllCategorys();

            return allCategorys.Where(a => a.text == ad).FirstOrDefault();
        }

        public async Task<List<Category>> GetSubAllCategorys(string ad)
        {
            var allCategorys = GetAllCategorys();

            if (allCategorys.Where(a => a.text == ad).FirstOrDefault() != null)
                //return allCategorys.Where(a => a.name == ad).FirstOrDefault().subCategories;
                return null;
            else
                return allCategorys;
        }
    }

}



//await firebase
//    .Child("Category")
//    .PostAsync(new Category()
//    {
//        ID = 1,
//        Ad = "Bilgisayar, Tablet",
//        Aciklama = "",
//        SubCategories = new List<Category>() {
//                        new Category() { ID = 2, Ad = "Dizüstü Bilgisayar (Laptop)", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 3, Ad = "Dizüstü Bilgisayar (Laptop) Aksesuar", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 4, Ad = "Masaüstü (Desktop) Bilgisayar", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 5, Ad = "Çevre Birimleri", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 6, Ad = "Bilgisayar Bileşenleri", Aciklama = "", SubCategories = null}}
//    });

//await firebase
//    .Child("Category")
//    .PostAsync(new Category()
//    {
//        ID = 7,
//        Ad = "Beyaz Eşya & Küçük Ev Aletleri",
//        Aciklama = "",
//        SubCategories = new List<Category>() {
//                        new Category() { ID = 8, Ad = "Beyaz Eşya", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 9, Ad = "Elektrikli Ev Aletleri", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 10, Ad = "Elektrikli Mutfak Aletleri", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 11, Ad = "Isıtma, Soğutma Sistemi", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 12, Ad = "Ev Güvenlik Sistemleri", Aciklama = "", SubCategories = null}}
//    });

//await firebase
//    .Child("Category")
//    .PostAsync(new Category()
//    {
//        ID = 13,
//        Ad = "TV, Ses ve Görüntü Sistemleri",
//        Aciklama = "",
//        SubCategories = new List<Category>() {
//                        new Category() { ID = 14, Ad = "Televizyon", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 15, Ad = "Televizyon Aksesuar, Yedek Parça", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 16, Ad = "Uydu Alıcısı, Aksesuar", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 17, Ad = "Projeksiyon Cihazı, Aksesuar", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 18, Ad = "Görüntü, Ses Aktarıcı", Aciklama = "", SubCategories = null}}
//    });

//await firebase
//    .Child("Category")
//    .PostAsync(new Category()
//    {
//        ID = 19,
//        Ad = "Fotoğraf & Kamera",
//        Aciklama = "",
//        SubCategories = new List<Category>() {
//                        new Category() { ID = 20, Ad = "Dijital Fotoğraf Makinesi", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 21, Ad = "Filmli Fotoğraf Makinesi", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 22, Ad = "Video Kamera", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 23, Ad = "Lens (Objektif), Filtre", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 24, Ad = "Tripod, Monopod", Aciklama = "", SubCategories = null}}
//    });

//await firebase
//    .Child("Category")
//    .PostAsync(new Category()
//    {
//        ID = 25,
//        Ad = "Spor ve Outdoor",
//        Aciklama = "",
//        SubCategories = new List<Category>() {
//                        new Category() { ID = 26, Ad = "Ayakkabı", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 27, Ad = "Kadın Giyim, Aksesuar", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 28, Ad = "Erkek Giyim, Aksesuar", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 29, Ad = "Çocuk Giyim, Aksesuar", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 30, Ad = "Bebek Giyim, Aksesuar", Aciklama = "", SubCategories = null}}
//    });

//await firebase
//    .Child("Category")
//    .PostAsync(new Category()
//    {
//        ID = 31,
//        Ad = "Mücevher, Takı, Saat",
//        Aciklama = "",
//        SubCategories = new List<Category>() {
//                        new Category() { ID = 32, Ad = "Saat", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 33, Ad = "Yüzük", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 34, Ad = "Kolye", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 35, Ad = "Kolye", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 36, Ad = "Küpe", Aciklama = "", SubCategories = null}}
//    });

//await firebase
//    .Child("Category")
//    .PostAsync(new Category()
//    {
//        ID = 37,
//        Ad = "Kozmetik & Kişisel Bakım",
//        Aciklama = "",
//        SubCategories = new List<Category>() {
//                        new Category() { ID = 38, Ad = "Parfüm", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 39, Ad = "Parfüm Seti", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 40, Ad = "Deodorant", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 41, Ad = "Makyaj", Aciklama = "", SubCategories = null},
//                        new Category() { ID = 42, Ad = "Saç Bakımı", Aciklama = "", SubCategories = null}}
//    });
