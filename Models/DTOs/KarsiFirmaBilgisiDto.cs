using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace TaskMvc.Models.DTOs
{
    [XmlRoot("KarsiFirmaBilgisi")]
    public class KarsiFirmaBilgisiDto
    {
        public int FaturaID { get; set; }

        [XmlElement("VergiKimlikNo")]
        public string VergiKimlikNo { get; set; }

        [XmlElement("VergiDairesi")]
        public string VergiDairesi { get; set; }

        [XmlElement("AdiUnvani")]
        public string AdiUnvani { get; set; }

        [XmlElement("Adresi")]
        public string Adresi { get; set; }

        [XmlElement("Ulke")]
        public string Ulke { get; set; }

        [XmlElement("Telefon1")]
        public string Telefon1 { get; set; }

        [XmlElement("Telefon2")]
        public string Telefon2 { get; set; }

        [XmlElement("Telefon3")]
        public string Telefon3 { get; set; }

        [XmlElement("Faks1")]
        public string Faks1 { get; set; }

        [XmlElement("Faks2")]
        public string Faks2 { get; set; }

        [XmlElement("WebAdresi")]
        public string WebAdresi { get; set; }

        [XmlElement("EPosta")]
        public string EPosta { get; set; }
    }
}
