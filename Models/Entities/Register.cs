using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskMvc.Models.Entities
{
    public class Register
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required(ErrorMessage = "Ad alanı gereklidir.")]
        [StringLength(100, ErrorMessage = "Ad en fazla 100 karakter olmalıdır.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Soyad alanı gereklidir.")]
        [StringLength(100, ErrorMessage = "Soyad en fazla 100 karakter olmalıdır.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "E-posta alanı gereklidir.")]
        [EmailAddress(ErrorMessage = "Geçersiz e-posta adresi.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre alanı gereklidir.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Şifre en az 6 karakter olmalıdır.")]
        public string Password { get; set; }

        [NotMapped] // Bu özellik veritabanında saklanmayacak
        public IFormFile ProfileImage { get; set; }
        public string? ProfileImagePath { get; set; }
    }
}
