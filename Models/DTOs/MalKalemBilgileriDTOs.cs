using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace TaskMvc.Models.DTOs
{
    [XmlRoot("MalKalemBilgileri")]
    public class MalKalemBilgileriDTOs
    {
        [XmlElement("MalKalem")]
        public MalKalemDTOs MalKalem { get; set; }
    }

    public class MalKalemDTOs
    {
      
        public int FaturaID { get; set; }

        [XmlElement("SiraNo")]
        public int SiraNo { get; set; }

        [XmlElement("GumrukSiraNo")]
        public int GumrukSiraNo { get; set; }

        [XmlElement("MalKalemId")]
        public string MalKalemId { get; set; }

        [XmlElement("gtip")]
        public string gtip { get; set; }

        [XmlElement("Cins")]
        public string Cins { get; set; }

        [XmlElement("Mensei")]
        public string Mensei { get; set; }

        [XmlElement("GeldigiGidecegiUlke")]
        public string GeldigiGidecegiUlke { get; set; }

        [XmlElement("BirinciMiktar")]
        public decimal BirinciMiktar { get; set; }

        [XmlElement("BirinciBirim")]
        public string BirinciBirim { get; set; }

        [XmlElement("KapTuru")]
        public string KapTuru { get; set; }

        [XmlElement("KapAdedi")]
        public int KapAdedi { get; set; }

        [XmlElement("MalBedeli")]
        public decimal MalBedeli { get; set; }

        [XmlElement("MalBedeliParaBirimi")]
        public string MalBedeliParaBirimi { get; set; }

        [XmlElement("NavlunBedeli")]
        public decimal NavlunBedeli { get; set; }

        [XmlElement("NavlunBedeliParaBirimi")]
        public string NavlunBedeliParaBirimi { get; set; }

        [XmlElement("SigortaBedeli")]
        public decimal SigortaBedeli { get; set; }

        [XmlElement("SigortaBedeliParaBirimi")]
        public string SigortaBedeliParaBirimi { get; set; }

        [XmlElement("BrutAgirlik")]
        public decimal BrutAgirlik { get; set; }

        [XmlElement("MalKalemTeslimSekli")]
        public string MalKalemTeslimSekli { get; set; }
    }
}
