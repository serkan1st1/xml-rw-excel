using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System.Text;
using TaskMvc.Business;
using TaskMvc.Data;
using TaskMvc.Interface;
using TaskMvc.Interface.Repository;
using TaskMvc.Repository;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

builder.Services.AddAutoMapper(typeof(TaskMvc.Mappings.SBIFMappingProfile));

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DbConnection")));

builder.Services.AddScoped<FileUploadService>();
builder.Services.AddScoped<IFileUploadService, FileUploadService>();
builder.Services.AddScoped<IFileSaveService, FileSaveService>();
builder.Services.AddScoped<IExcelExportService, ExcelService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();



ExcelPackage.LicenseContext = LicenseContext.NonCommercial;


var app = builder.Build();


Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");

    app.UseHsts();
}



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
