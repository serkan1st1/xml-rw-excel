using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace TaskMvc.Models.Entities
{
    [Table("GenelBilgiler")]
    public class GenelBilgiler
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(255)]
        public string BelgeNo { get; set; }

        [MaxLength(255)]
        public string SerbestBolgeAdi { get; set; }

        [MaxLength(255)]
        public DateTime KayitTarihi { get; set; }

        [MaxLength(255)]
        public string DisReferansNo { get; set; }

        [MaxLength(255)]
        public string GumrukId { get; set; }

        [MaxLength(255)]
        public string FormDurumu { get; set; }

        [MaxLength(255)]
        public string FirmaTicaretUnvani { get; set; }

        [MaxLength(255)]
        public string FirmaFaaliyetRuhsatiNo { get; set; }

        [MaxLength(255)]
        public string FirmaFaaliyetRuhsatiKonusu { get; set; }

        [MaxLength(255)]
        public string? DepoKullanimBelgeliFirma { get; set; }

        public int DepoKullanimBelgeNo { get; set; } 

        [MaxLength(255)]
        public string FormuDolduraninAdi { get; set; }

        [MaxLength(255)]
        public string? FirmaTelefonu { get; set; }

        [MaxLength(255)]
        public string IslemYonu { get; set; }

        [MaxLength(255)]
        public string IslemTuru { get; set; }

        [MaxLength(255)]
        public string IslemKonusu { get; set; }

        [MaxLength(255)]
        public string IslemKonusuTicari { get; set; }

        [MaxLength(255)]
        public string? IslemKonusuTicariOlmayan { get; set; }

        [MaxLength(255)]
        public string SevkiyatSekliAdi { get; set; }

    }

}
