using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace TaskMvc.Models.DTOs
{
    [XmlRoot("TeslimAdresi")]

    public class TeslimAdresiDTOs
    {
        public int FaturaID { get; set; }

        [XmlElement("AdiTicaretUnvani")]
        public string AdiTicaretUnvani { get; set; }

        [XmlElement("Adresi")]
        public string Adresi { get; set; }

        [XmlElement("PostaKodu")]
        public string PostaKodu { get; set; }

        [XmlElement("Ulke")]
        public string Ulke { get; set; }

        [XmlElement("Il")]
        public string Il { get; set; }

        [XmlElement("Ilce")]
        public string Ilce { get; set; }

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

        [XmlElement("EPosta")]
        public string EPosta { get; set; }
    }
}
