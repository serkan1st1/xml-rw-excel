using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace TaskMvc.Models.DTOs
{
    [XmlRoot("SbifBilgiFisi")]
    public class SbifBilgiFisiDTOs
    {
        
        [XmlElement("FonDekont")]
        public FonDekontDTOs FonDekont { get; set; }
    }

    public class FonDekontDTOs
    {
        public int GenelBilgilerID { get; set; }

        [XmlElement("FonDekontDekontNo")]
        public string? FonDekontDekontNo { get; set; }

        [XmlElement("FonDekontTarih")]
        public string? FonDekontTarih { get; set; }

        [XmlElement("FonDekontTutar")]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Fatura tutarı negatif olamaz.")]
        public decimal FonDekontTutar { get; set; }

        [XmlElement("FonDekontTutarPB")]
        public string? FonDekontTutarPB { get; set; }

        [XmlElement("FonDekontKullanilan")]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Fatura tutarı negatif olamaz.")]
        public decimal FonDekontKullanilan { get; set; }

        [XmlElement("FonDekontKullanilanPB")]
        public string? FonDekontKullanilanPB { get; set; }

        [XmlElement("FonDekontKullanilanDolar")]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "Fatura tutarı negatif olamaz.")]
        public decimal FonDekontKullanilanDolar { get; set; }

        public DateTime? FonDekontDate { get; set; }
    }
}
