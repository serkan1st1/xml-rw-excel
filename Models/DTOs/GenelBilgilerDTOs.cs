using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using TaskMvc.Models.Entities;

namespace TaskMvc.Models.DTOs
{
    [XmlRoot("GenelBilgiler")]
    public class GenelBilgilerDTOs
    {

        [XmlElement("BelgeNo")]
        public string BelgeNo { get; set; }

        [XmlElement("SerbestBolgeAdi")]
        public string SerbestBolgeAdi { get; set; }

        [XmlElement("KayitTarihi")]
        public string KayitTarihi { get; set; }

        [XmlElement("DisReferansNo")]
        public string DisReferansNo { get; set; }

        [XmlElement("GumrukId")]
        public string GumrukId { get; set; }

        [XmlElement("FormDurumu")]
        public string FormDurumu { get; set; }

        [XmlElement("FirmaTicaretUnvani")]
        public string FirmaTicaretUnvani { get; set; }

        [XmlElement("FirmaFaaliyetRuhsatiNo")]
        public string FirmaFaaliyetRuhsatiNo { get; set; }

        [XmlElement("FirmaFaaliyetRuhsatiKonusu")]
        public string FirmaFaaliyetRuhsatiKonusu { get; set; }

        [XmlElement("DepoKullanimBelgeliFirma")]
        public string? DepoKullanimBelgeliFirma { get; set; }

        [XmlElement("DepoKullanimBelgeNo")]
        public int DepoKullanimBelgeNo { get; set; }

        [XmlElement("FormuDolduraninAdi")]
        public string FormuDolduraninAdi { get; set; }

        [XmlElement("FirmaTelefonu")]
        public string? FirmaTelefonu { get; set; }

        [XmlElement("IslemYonuBilgileri")]
        public IslemYonuBilgileriDTOs IslemYonuBilgileriDTOs { get; set; }

        [XmlElement("IslemTuruBilgileri")]
        public IslemTuruBilgileriDTOs IslemTuruBilgileriDTOs { get; set; }

        [XmlElement("IslemKonusuBilgileri")]
        public IslemKonusuBilgileriDTOs IslemKonusuBilgileriDTOs { get; set; }

        [XmlElement("SevkiyatSekli")]
        public SevkiyatSekliDTOs SevkiyatSekliDTOs { get; set; }

        public DateTime? KayitDate { get; set; }
    }

    public class IslemYonuBilgileriDTOs
    {
        [XmlElement("IslemYonu")]
        public string IslemYonu { get; set; }
    }

    public class IslemTuruBilgileriDTOs
    {
        [XmlElement("IslemTuru")]
        public string IslemTuru { get; set; }
    }

    public class IslemKonusuBilgileriDTOs
    {
        [XmlElement("IslemKonusu")]
        public string IslemKonusu { get; set; }

        [XmlElement("IslemKonusuTicari")]
        public string IslemKonusuTicari { get; set; }

        [XmlElement("IslemKonusuTicariOlmayan")]
        public string IslemKonusuTicariOlmayan { get; set; }
    }

    public class SevkiyatSekliDTOs
    {
        [XmlElement("SevkiyatSekliAdi")]
        public string SevkiyatSekliAdi { get; set; }
    }
}
