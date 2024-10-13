using System.Xml.Serialization;
using TaskMvc.Models.Entities;

namespace TaskMvc.Models.DTOs
{
    [XmlRoot("SBIFBilgileri", Namespace = "")]
    public class SBIFDTOs
    {
        [XmlElement("GenelBilgiler")]
        public GenelBilgilerDTOs GenelBilgilerDTOs { get; set; }

        [XmlElement("FaturaBilgileri")]
        public FaturaBilgileriDTOs FaturaBilgileriDTOs { get; set; }

        [XmlElement("TeslimAdresi")]
        public TeslimAdresiDTOs TeslimAdresiDTOs { get; set; }

        [XmlElement("KarsiFirmaBilgisi")]
        public KarsiFirmaBilgisiDto KarsiFirmaBilgisiDTOs { get; set; }

        [XmlElement("MalKalemBilgileri")]
        public MalKalemBilgileriDTOs MalKalemBilgileriDTOs { get; set; }

        [XmlElement("TalepEdilenIsleticiHizmetleri")]
        public TalepEdilenIsleticiHizmetleriDTOs TalepEdilenIsleticiHizmetleriDTOs { get; set; }

        [XmlElement("SbifBilgiFisi")]
        public SbifBilgiFisiDTOs SbifBilgiFisiDTOs { get; set; }
    }
}
