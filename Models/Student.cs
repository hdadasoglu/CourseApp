using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class Student
    {
        [Required(ErrorMessage = "İsim Bilgisi Boş Bırakılamaz")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email Bilgisi Boş Bırakılamaz")]
        [EmailAddress(ErrorMessage = "Mail adresi istenilen formatta değil")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Telefon Bilgisi Boş Bırakılamaz")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Lütfen Katılma Durumunuzu seçiniz")]
        public bool? Confirm { get; set; }
    }
}