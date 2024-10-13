using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskMvc.Models.Entities
{
    public class FaturaBilgileri
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("GenelBilgiler")]
        public int GenelBilgilerID { get; set; }

        [MaxLength(255)]
        public string FaturaTuru { get; set; }

        [DataType(DataType.Date)]
        public DateTime FaturaTarih { get; set; }

        [MaxLength(50)]
        public string FaturaNo { get; set; }

        [MaxLength(50)]
        public string OdemeSekli { get; set; }

        [MaxLength(50)]
        public string FaturaTeslimSekli { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Fatura tutarı negatif olamaz.")]
        public decimal FaturaTutari { get; set; }

        [MaxLength(3)]
        public string FaturaParaBirimi { get; set; }

        public virtual GenelBilgiler GenelBilgiler { get; set; }
    }
}
