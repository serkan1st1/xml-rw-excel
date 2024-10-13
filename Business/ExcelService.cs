using OfficeOpenXml;
using TaskMvc.Data;
using TaskMvc.Interface;
using TaskMvc.Models.Entities;

namespace TaskMvc.Business
{
    public class ExcelService : IExcelExportService
    {

        private readonly AppDbContext _dbContext;

        public ExcelService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public byte[] CreateExcelFile()
        {
            var genelBilgiler = _dbContext.GenelBilgiler.ToList();
            var faturaBilgileri = _dbContext.FaturaBilgileri.ToList();
            var malKalemBilgileri = _dbContext.MalKalemBilgileri.ToList();
            var talepEdilenIsleticiHizmetleri = _dbContext.TalepEdilenIsleticiHizmetleri.ToList();
            var sbifGumrukBilgileri = _dbContext.SbifBilgiFisi.ToList();

            using (var package = new ExcelPackage())
            {

                var worksheetGenelBilgiler = package.Workbook.Worksheets.Add("Genel Bilgiler");
                var propertiesGenel = typeof(GenelBilgiler).GetProperties();
                for (int i = 0; i < propertiesGenel.Length; i++)
                {
                    worksheetGenelBilgiler.Cells[1, i + 1].Value = propertiesGenel[i].Name;
                }
                for (int i = 0; i < genelBilgiler.Count; i++)
                {
                    for (int j = 0; j < propertiesGenel.Length; j++)
                    {
                        var value = propertiesGenel[j].GetValue(genelBilgiler[i]);
                        worksheetGenelBilgiler.Cells[i + 2, j + 1].Value = value;

                        if (value is DateTime)
                        {
                            worksheetGenelBilgiler.Cells[i + 2, j + 1].Style.Numberformat.Format = "dd.MM.yyyy HH:mm:ss";
                        }
                    }
                }

                var worksheetFaturaBilgileri = package.Workbook.Worksheets.Add("Fatura Bilgileri");
                var propertiesFatura = typeof(FaturaBilgileri).GetProperties();
                for (int i = 0; i < propertiesFatura.Length; i++)
                {
                    worksheetFaturaBilgileri.Cells[1, i + 1].Value = propertiesFatura[i].Name;
                }
                for (int i = 0; i < faturaBilgileri.Count; i++)
                {
                    for (int j = 0; j < propertiesFatura.Length; j++)
                    {
                        var value = propertiesFatura[j].GetValue(faturaBilgileri[i]);
                        worksheetFaturaBilgileri.Cells[i + 2, j + 1].Value = value;

                        if (value is DateTime)
                        {
                            worksheetFaturaBilgileri.Cells[i + 2, j + 1].Style.Numberformat.Format = "dd.MM.yyyy HH:mm:ss";
                        }
                    }
                }


                var worksheetMalKalemBilgileri = package.Workbook.Worksheets.Add("Mal Kalem Bilgileri");
                var propertiesMalKalem = typeof(MalKalemBilgileri).GetProperties();
                for (int i = 0; i < propertiesMalKalem.Length; i++)
                {
                    worksheetMalKalemBilgileri.Cells[1, i + 1].Value = propertiesMalKalem[i].Name;
                }
                for (int i = 0; i < malKalemBilgileri.Count; i++)
                {
                    for (int j = 0; j < propertiesMalKalem.Length; j++)
                    {
                        worksheetMalKalemBilgileri.Cells[i + 2, j + 1].Value = propertiesMalKalem[j].GetValue(malKalemBilgileri[i]);
                    }
                }


                var worksheetTalepEdilen = package.Workbook.Worksheets.Add("Talep Edilen İşletici Hizmetleri");
                var propertiesTalepEdilen = typeof(TalepEdilenIsleticiHizmetleri).GetProperties();
                for (int i = 0; i < propertiesTalepEdilen.Length; i++)
                {
                    worksheetTalepEdilen.Cells[1, i + 1].Value = propertiesTalepEdilen[i].Name;
                }
                for (int i = 0; i < talepEdilenIsleticiHizmetleri.Count; i++)
                {
                    for (int j = 0; j < propertiesTalepEdilen.Length; j++)
                    {
                        worksheetTalepEdilen.Cells[i + 2, j + 1].Value = propertiesTalepEdilen[j].GetValue(talepEdilenIsleticiHizmetleri[i]);
                    }
                }

                var worksheetSbifGumruk = package.Workbook.Worksheets.Add("SBİF Gümrük Bilgileri");
                var propertiesSbifGumruk = typeof(SbifBilgiFisi).GetProperties();
                for (int i = 0; i < propertiesSbifGumruk.Length; i++)
                {
                    worksheetSbifGumruk.Cells[1, i + 1].Value = propertiesSbifGumruk[i].Name;
                }
                for (int i = 0; i < sbifGumrukBilgileri.Count; i++)
                {
                    for (int j = 0; j < propertiesSbifGumruk.Length; j++)
                    {
                        var value = propertiesSbifGumruk[j].GetValue(sbifGumrukBilgileri[i]);
                        worksheetSbifGumruk.Cells[i + 2, j + 1].Value = value;

                        if (value is DateTime)
                        {
                            worksheetSbifGumruk.Cells[i + 2, j + 1].Style.Numberformat.Format = "dd.MM.yyyy HH:mm:ss";
                        }
                    }
                }

                var stream = new MemoryStream();
                package.SaveAs(stream);
                var content = stream.ToArray();
                return content;
            }
        }
    }
}
