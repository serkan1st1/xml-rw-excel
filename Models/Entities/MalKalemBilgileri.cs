using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TaskMvc.Models.DTOs;

namespace TaskMvc.Models.Entities
{
    public class MalKalemBilgileri
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("FaturaBilgileri")]
        public int FaturaID { get; set; }

        public int SiraNo { get; set; }

        public int GumrukSiraNo { get; set; }

        [MaxLength(50)]
        public string MalKalemId { get; set; }

        [MaxLength(20)]
        public string gtip { get; set; }

        [MaxLength(100)]
        public string Cins { get; set; }

        [MaxLength(100)]
        public string Mensei { get; set; }

        [MaxLength(100)]
        public string GeldigiGidecegiUlke { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Fatura tutarı negatif olamaz.")]
        public decimal BirinciMiktar { get; set; }

        [MaxLength(50)]
        public string BirinciBirim { get; set; }

        [MaxLength(50)]
        public string KapTuru { get; set; }

        public int KapAdedi { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Fatura tutarı negatif olamaz.")]
        public decimal MalBedeli { get; set; }

        [MaxLength(50)]
        public string MalBedeliParaBirimi { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Fatura tutarı negatif olamaz.")]
        public decimal NavlunBedeli { get; set; }

        [MaxLength(50)]
        public string NavlunBedeliParaBirimi { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Fatura tutarı negatif olamaz.")]
        public decimal SigortaBedeli { get; set; }

        [MaxLength(50)]
        public string SigortaBedeliParaBirimi { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Fatura tutarı negatif olamaz.")]
        public decimal BrutAgirlik { get; set; }

        [MaxLength(100)]
        public string MalKalemTeslimSekli { get; set; }


        public virtual FaturaBilgileri FaturaBilgileri { get; set; }
    }
}
