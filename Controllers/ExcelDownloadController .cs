using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using TaskMvc.Data;
using TaskMvc.Interface;
using TaskMvc.Models.Entities;

namespace TaskMvc.Controllers
{
    public class FileDownloadController : Controller
    {


        private readonly IExcelExportService _excelExport;



        public FileDownloadController(IExcelExportService excelExport)
        {
            _excelExport = excelExport;
        }


        public IActionResult DownloadExcel()
        {
            var content = _excelExport.CreateExcelFile();
            var fileName = "SBIF.xlsx";
            return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", fileName);
        }
    }
}
