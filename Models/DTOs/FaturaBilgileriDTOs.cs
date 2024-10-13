using System.Xml.Serialization;
using TaskMvc.Models.Entities;

namespace TaskMvc.Models.DTOs
{
    [XmlRoot("FaturaBilgileri")]
    public class FaturaBilgileriDTOs
    {
        [XmlElement("Fatura")]
        public FaturaDTOs Fatura { get; set; }
    }

    public class FaturaDTOs
    {
        [XmlElement("FaturaTuru")]
        public string FaturaTuru { get; set; }

        [XmlElement("FaturaTarih")]
        public string FaturaTarih { get; set; }

        [XmlElement("FaturaNo")]
        public string FaturaNo { get; set; }

        [XmlElement("TeslimAdresi")]
        public TeslimAdresi TeslimAdresi { get; set; }

        [XmlElement("KarsiFirmaBilgisi")]
        public KarsiFirmaBilgisi KarsiFirmaBilgisi { get; set; }

        [XmlElement("OdemeSekli")]
        public string OdemeSekli { get; set; }

        [XmlElement("FaturaTeslimSekli")]
        public string FaturaTeslimSekli { get; set; }

        [XmlElement("FaturaTutari")]
        public decimal FaturaTutari { get; set; }

        [XmlElement("FaturaParaBirimi")]
        public string FaturaParaBirimi { get; set; }

        public DateTime? FaturaDate { get; set; }
    }
}
