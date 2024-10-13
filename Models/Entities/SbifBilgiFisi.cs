using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskMvc.Models.Entities
{
    public class SbifBilgiFisi
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("GenelBilgiler")]
        public int GenelBilgilerID { get; set; }

        [MaxLength(255)]
        public string? FonDekontDekontNo { get; set; }

        public DateTime? FonDekontTarih { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Fatura tutarı negatif olamaz.")]
        public decimal FonDekontTutar { get; set; }

        [MaxLength(255)]
        public string? FonDekontTutarPB { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Fatura tutarı negatif olamaz.")]
        public decimal FonDekontKullanilan { get; set; }

        [MaxLength(255)]
        public string? FonDekontKullanilanPB { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Fatura tutarı negatif olamaz.")]
        public decimal FonDekontKullanilanDolar { get; set; }



        public virtual GenelBilgiler GenelBilgiler { get; set; }
    }
}
