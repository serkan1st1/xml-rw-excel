using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Serialization;

namespace TaskMvc.Models.DTOs
{
    [XmlRoot("TalepEdilenIsleticiHizmetleri")]
    public class TalepEdilenIsleticiHizmetleriDTOs
    {

       
        public int GenelBilgilerID { get; set; }

        [XmlElement("OrtakDepo")]
        public string? OrtakDepo { get; set; }

        [XmlElement("Kantar")]
        public string? Kantar { get; set; }

        [XmlElement("YuklemeBosaltma")]
        public string? YuklemeBosaltma { get; set; }

        [XmlElement("IsMakinasi")]
        public string? IsMakinasi { get; set; }

        [XmlElement("Ellecleme")]
        public string? Ellecleme { get; set; }

        [XmlElement("KoordinasyonHizmeti")]
        public string? KoordinasyonHizmeti { get; set; }

        [XmlElement("DigerTalepEdilenHizmetler")]
        public string? DigerTalepEdilenHizmetler { get; set; }
    }
}
