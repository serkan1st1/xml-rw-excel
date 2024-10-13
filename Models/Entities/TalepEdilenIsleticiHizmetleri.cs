using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TaskMvc.Models.Entities
{
    public class TalepEdilenIsleticiHizmetleri
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [ForeignKey("GenelBilgiler")]
        public int GenelBilgilerID { get; set; }

        [MaxLength(255)]
        public string? OrtakDepo { get; set; }

        [MaxLength(255)]
        public string? Kantar { get; set; }

        [MaxLength(255)]
        public string? YuklemeBosaltma { get; set; }

        [MaxLength(255)]
        public string? IsMakinasi { get; set; }

        [MaxLength(255)]
        public string? Ellecleme { get; set; }

        [MaxLength(255)]
        public string? KoordinasyonHizmeti { get; set; }

        [MaxLength(255)]
        public string? DigerTalepEdilenHizmetler { get; set; }



        public virtual GenelBilgiler GenelBilgiler { get; set; }
    }
}
