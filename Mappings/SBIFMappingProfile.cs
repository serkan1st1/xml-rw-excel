using AutoMapper;
using TaskMvc.Models.DTOs;
using TaskMvc.Models.Entities;

namespace TaskMvc.Mappings
{
    public class SBIFMappingProfile : Profile
    {
        public SBIFMappingProfile()
        {
            CreateMap<GenelBilgilerDTOs, GenelBilgiler>()
             .ForMember(dest => dest.KayitTarihi, opt => opt.MapFrom(src => src.KayitDate))
             .ForMember(dest => dest.IslemYonu, opt => opt.MapFrom(src => src.IslemYonuBilgileriDTOs.IslemYonu))
             .ForMember(dest => dest.IslemTuru, opt => opt.MapFrom(src => src.IslemTuruBilgileriDTOs.IslemTuru))
             .ForMember(dest => dest.IslemKonusu, opt => opt.MapFrom(src => src.IslemKonusuBilgileriDTOs.IslemKonusu))
             .ForMember(dest => dest.IslemKonusuTicari, opt => opt.MapFrom(src => src.IslemKonusuBilgileriDTOs.IslemKonusuTicari))
             .ForMember(dest => dest.IslemKonusuTicariOlmayan, opt => opt.MapFrom(src => src.IslemKonusuBilgileriDTOs.IslemKonusuTicariOlmayan))
             .ForMember(dest => dest.SevkiyatSekliAdi, opt => opt.MapFrom(src => src.SevkiyatSekliDTOs.SevkiyatSekliAdi));

            CreateMap<FaturaBilgileriDTOs, FaturaBilgileri>();
            CreateMap<FaturaDTOs, FaturaBilgileri>()
              .ForMember(dest => dest.FaturaTarih, opt => opt.MapFrom(src => src.FaturaDate));

            CreateMap<KarsiFirmaBilgisiDto, KarsiFirmaBilgisi>();

            CreateMap<TeslimAdresiDTOs, TeslimAdresi>();

            CreateMap<MalKalemBilgileriDTOs, MalKalemBilgileri>();
            CreateMap<MalKalemDTOs, MalKalemBilgileri>();

            CreateMap<TalepEdilenIsleticiHizmetleriDTOs, TalepEdilenIsleticiHizmetleri>();

            CreateMap<SbifBilgiFisiDTOs, SbifBilgiFisi>();
            CreateMap<FonDekontDTOs, SbifBilgiFisi>()
            .ForMember(dest => dest.FonDekontTarih, opt => opt.MapFrom(src => src.FonDekontDate));
        }

    }
}
