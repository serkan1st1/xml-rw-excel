using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TaskMvc.Models.DTOs;

namespace TaskMvc.Models.Entities
{
    public class KarsiFirmaBilgisi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("FaturaBilgileri")]
        public int FaturaID { get; set; }

        [MaxLength(20)]
        public string VergiKimlikNo { get; set; }

        [MaxLength(100)]
        public string VergiDairesi { get; set; }

        [MaxLength(255)]
        public string AdiUnvani { get; set; }

        [MaxLength(500)]
        public string Adresi { get; set; }

        [MaxLength(100)]
        public string Ulke { get; set; }

        [MaxLength(15)]
        public string Telefon1 { get; set; }

        [MaxLength(15)]
        public string Telefon2 { get; set; }

        [MaxLength(15)]
        public string Telefon3 { get; set; }

        [MaxLength(20)]
        public string Faks1 { get; set; }

        [MaxLength(20)]
        public string Faks2 { get; set; }

        [MaxLength(255)]
        public string WebAdresi { get; set; }

        [MaxLength(255)]
        [EmailAddress(ErrorMessage = "Geçersiz e-posta adresi.")]
        public string EPosta { get; set; }

        public virtual FaturaBilgileri FaturaBilgileri { get; set; }
    }
}
