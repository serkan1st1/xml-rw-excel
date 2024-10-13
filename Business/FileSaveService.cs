using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Xml.Serialization;
using TaskMvc.Data;
using TaskMvc.Interface;
using TaskMvc.Models.DTOs;
using TaskMvc.Models.Entities;

namespace TaskMvc.Business
{
    public class FileSaveService : IFileSaveService
    {
        private readonly IMapper _mapper;
        private readonly DbContextOptions<AppDbContext> _dbContext;

        public FileSaveService(IMapper mapper, DbContextOptions<AppDbContext> dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<SBIFDTOs> DeserializeXmlAsync(string filePath)
        {
            
            XmlSerializer serializer = new XmlSerializer(typeof(SBIFDTOs));
            using (StreamReader reader = new StreamReader(filePath, Encoding.GetEncoding("ISO-8859-9")))//karakter sorunu düzeltilecek
            {
                var sbif = (SBIFDTOs)await Task.Run(() => serializer.Deserialize(reader));

                DateConvert dateConvert = new DateConvert();
                var convertedDate = (DateTime?)null;

                //String tipindeki tarih bilgisini DateTime tipine cevirme islemi
                convertedDate = dateConvert.ConvertToDate(sbif.GenelBilgilerDTOs.KayitTarihi);
                sbif.GenelBilgilerDTOs.KayitDate = convertedDate;

                convertedDate = dateConvert.ConvertToDate(sbif.FaturaBilgileriDTOs.Fatura.FaturaTarih);
                sbif.FaturaBilgileriDTOs.Fatura.FaturaDate = convertedDate;

                convertedDate = dateConvert.ConvertToDate(sbif.SbifBilgiFisiDTOs.FonDekont.FonDekontTarih);
                sbif.SbifBilgiFisiDTOs.FonDekont.FonDekontDate = convertedDate;

                using (var context = new Data.AppDbContext(_dbContext))
                {
                    var genelBilgiler = _mapper.Map<GenelBilgiler>(sbif.GenelBilgilerDTOs);
                    context.GenelBilgiler.Add(genelBilgiler);
                    await context.SaveChangesAsync();

                    var faturaBilgiler = _mapper.Map<FaturaBilgileri>(sbif.FaturaBilgileriDTOs.Fatura);
                    faturaBilgiler.GenelBilgilerID = genelBilgiler.ID;
                    context.FaturaBilgileri.Add(faturaBilgiler);
                    await context.SaveChangesAsync();

                    var teslimAdresi = _mapper.Map<TeslimAdresi>(sbif.FaturaBilgileriDTOs.Fatura.TeslimAdresi);
                    teslimAdresi.FaturaID = faturaBilgiler.ID;
                    context.TeslimAdresi.Add(teslimAdresi);
                    await context.SaveChangesAsync();

                    var karsiFirmaBilgisi = _mapper.Map<KarsiFirmaBilgisi>(sbif.FaturaBilgileriDTOs.Fatura.KarsiFirmaBilgisi);
                    karsiFirmaBilgisi.FaturaID = faturaBilgiler.ID;
                    context.KarsiFirmaBilgisi.Add(karsiFirmaBilgisi);
                    await context.SaveChangesAsync();

                    var malKalemBilgiler = _mapper.Map<MalKalemBilgileri>(sbif.MalKalemBilgileriDTOs.MalKalem);
                    malKalemBilgiler.FaturaID = faturaBilgiler.ID;
                    context.MalKalemBilgileri.Add(malKalemBilgiler);
                    await context.SaveChangesAsync();


                    var talepEdilenIsleticiHizmetleri = _mapper.Map<TalepEdilenIsleticiHizmetleri>(sbif.TalepEdilenIsleticiHizmetleriDTOs);
                    talepEdilenIsleticiHizmetleri.GenelBilgilerID = genelBilgiler.ID;
                    context.TalepEdilenIsleticiHizmetleri.Add(talepEdilenIsleticiHizmetleri);
                    await context.SaveChangesAsync();

                    var sbifBilgiFisi = _mapper.Map<SbifBilgiFisi>(sbif.SbifBilgiFisiDTOs.FonDekont);
                    sbifBilgiFisi.GenelBilgilerID = genelBilgiler.ID;
                    context.SbifBilgiFisi.Add(sbifBilgiFisi);
                    await context.SaveChangesAsync();

                }
                return sbif;

            }
                        
        }
    }
}
