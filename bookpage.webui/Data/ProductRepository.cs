using System.Collections.Generic;
using System.Linq;
using bookpage.webui.Models;

namespace bookpage.webui.Data
{
    public class ProductRepository
    {
        private static List<Product> _product=null;
        static ProductRepository()
        {
            _product=new List<Product>
            {
             new Product{ProductId=1,CategoryId=1,Door="Aklı başında hiçbir insan ömrünün üçte birini yastığa bağışlamaz",Moduls1="60 yıl yaşadığı varsayılan sıradan bir insan, ömrünün 15 yılını çocuklukta, 15 yılını ıvır zıvır işlerde, 20 yılını da uykuda geçirmektedir ki bu hesapla geriye 10 yıl kalır.",Moduls2="Ancak bu aynı sıradan insan, 8 saat yerine 4 saat uyursa, ömrünün sadece 10 yılını uykuda geçirecek ve böylece 10 sene daha fazla yaşamış olacaktır. Bunu başardığında ise sıradanlığı sona erecek ve sıra dışı başarılar elde edecektir",Moduls3="çünkü sıra dışı başarılar elde edenler tüm başarılarını bu ikinci 10 yıla borçludurlar. Keops, Da Vinci, Edison, Newton, Dostoyevski, Armstrong gibi..." ,Name="Sadece Aptallar 8 Saat Uyur",Author="Erdal Demirkıran", Pages=200,Description="Çok iyi",IsApproved=true,ImageUrl="1.jpg.jpg"},
             new Product{ProductId=2,CategoryId=3 ,Name="Ruhsal Zeka",Author="Muhammed Bozdağ", Pages=100,Description="Çok iyi",IsApproved=true,ImageUrl="2.jpg.jpg"},
             new Product{ProductId=3,CategoryId=3 ,Name="İrade Terbiyesi",Author="Jules Paylot", Pages=100,Description="Çok iyi",IsApproved=true,ImageUrl="3.jpg.jpg"},
             new Product{ProductId=4,CategoryId=3 ,Name="Ben Dünyanın En Akıllı İnsanıyım",Author="Erdal Demirkıran", Pages=300,Description="Çok iyi",IsApproved=true,ImageUrl="4.jpg.jpg"},
             new Product{ProductId=5,CategoryId=2 ,Name="Mutlu Beyin",Author="Daniel Segiol", Pages=400,Description="Çok iyi",IsApproved=true,ImageUrl="5.jpg"},
             new Product{ProductId=6,CategoryId=2 ,Name="Nefes",Author="Ted Chiang", Pages=100,Description="Çok iyi",IsApproved=true,ImageUrl="6.jpg"},

            };
        }

        public static List<Product> Products{
            get{
                return _product;
            }
        }

        public static void AddProduct(Product product)
        {
            _product.Add(product);
        }
        public static Product GetProductById(int Id)
        {
            return _product.FirstOrDefault(i => i.ProductId == Id);
        }

        public static void EditProduct(Product product)
        {
            foreach (var p in _product)
            {
                if(p.ProductId==product.ProductId)
                {
                    p.Name=product.Name;
                    p.Author=product.Author;
                    p.Pages=product.Pages;
                    p.Description=product.Description;
                    p.Door=product.Door;
                    p.Moduls1=product.Moduls1;
                    p.Moduls2=product.Moduls2;
                    p.Moduls3=product.Moduls3;
                    p.Moduls4=product.Moduls4;
                    p.ImageUrl=product.ImageUrl;
                    p.IsApproved=product.IsApproved;
                    p.CategoryId=product.CategoryId;
                }
            }

        }

        public static void DeleteProduct(int id)
        {
            var product=GetProductById(id);
            if(product!=null)
            {
                _product.Remove(product);
            }
        }

        
    }
}