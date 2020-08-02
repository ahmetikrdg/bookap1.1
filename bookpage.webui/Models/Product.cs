using System.ComponentModel.DataAnnotations;

namespace bookpage.webui.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        [Required (ErrorMessage="Kitap Adını Girmelisiniz.")]//mutlaka girilsin
        public string Name { get; set; }
        [Required(ErrorMessage="Yazarı Girmelisiniz.")]
        public string Author { get; set; }
        [Required(ErrorMessage="Fiyat Girmelisiniz.")]
        public double? Pages { get; set; }//? koymasaydım 0 olarak alırdı ve işlevsel olmazdı
        [Required (ErrorMessage="Özeti Girmelisiniz Girmelisiniz.")]
        public string Description { get; set; }
        [Required (ErrorMessage="Giriş Kısmını Girmelisiniz.")]
        public string Door { get; set; }
        [Required(ErrorMessage="Birinici Bölümü Girmelisiniz.")]
        public string Moduls1 { get; set; }
        [Required(ErrorMessage="İkinci Bölümü Girmelisiniz.")]
        public string Moduls2 { get; set; }
        [Required(ErrorMessage="Üçüncü Bölümü Girmelisiniz.")]
        public string Moduls3 { get; set; }
        [Required(ErrorMessage="Dördüncü Bölümü Girmelisiniz.")]
        public string Moduls4 { get; set; }
        [Required(ErrorMessage="Fotoğraf Koymalısınız.")]
        public string ImageUrl { get; set; }
        public bool  IsApproved { get; set; }
        [Required(ErrorMessage="Kitap Kategorisini Seçmelisiniz.")]
        public int? CategoryId { get; set; }
    }
}