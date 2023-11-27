using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace GymApp.Models
{
    public class ShippingDetailsViewModel
    {
        [Display(Name = "Ad Soyad")]
        [Required(ErrorMessage = "Adınızı ve Soyadınızı Giriniz")]
        public string FullName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email Giriniz")]
        public string Email { get; set; }

        [Display(Name = "Adres Baslik")]
        [Required(ErrorMessage = "Adres Başlığı giriniz")]
        public string AddressTitle { get; set; }

        [Display(Name = "Adres")]
        [Required(ErrorMessage = "Adres Giriniz")]
        public string Address { get; set; }

        [Display(Name = "Sehir")]
        [Required(ErrorMessage = "Sehir Giriniz")]
        public string City { get; set; }

        [Display(Name = "İlce")]
        [Required(ErrorMessage = "İlce Giriniz")]
        public string Region { get; set; }

        [Display(Name = "Posta Kodu")]
        [Required(ErrorMessage = "Posta Kodu Giriniz")]
        public string PostalCode { get; set; }
    }
}
