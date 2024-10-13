using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskMvc.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GenelBilgiler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BelgeNo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    SerbestBolgeAdi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    KayitTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DisReferansNo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    GumrukId = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FormDurumu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FirmaTicaretUnvani = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FirmaFaaliyetRuhsatiNo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FirmaFaaliyetRuhsatiKonusu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DepoKullanimBelgeliFirma = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DepoKullanimBelgeNo = table.Column<int>(type: "int", nullable: false),
                    FormuDolduraninAdi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FirmaTelefonu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IslemYonu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IslemTuru = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IslemKonusu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IslemKonusuTicari = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IslemKonusuTicariOlmayan = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    SevkiyatSekliAdi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenelBilgiler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FaturaBilgileri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenelBilgilerID = table.Column<int>(type: "int", nullable: false),
                    FaturaTuru = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FaturaTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FaturaNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OdemeSekli = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FaturaTeslimSekli = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FaturaTutari = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FaturaParaBirimi = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FaturaBilgileri", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FaturaBilgileri_GenelBilgiler_GenelBilgilerID",
                        column: x => x.GenelBilgilerID,
                        principalTable: "GenelBilgiler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SbifBilgiFisi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenelBilgilerID = table.Column<int>(type: "int", nullable: false),
                    FonDekontDekontNo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FonDekontTarih = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FonDekontTutar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FonDekontTutarPB = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FonDekontKullanilan = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FonDekontKullanilanPB = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FonDekontKullanilanDolar = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SbifBilgiFisi", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SbifBilgiFisi_GenelBilgiler_GenelBilgilerID",
                        column: x => x.GenelBilgilerID,
                        principalTable: "GenelBilgiler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TalepEdilenIsleticiHizmetleri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenelBilgilerID = table.Column<int>(type: "int", nullable: false),
                    OrtakDepo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Kantar = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    YuklemeBosaltma = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsMakinasi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Ellecleme = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    KoordinasyonHizmeti = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DigerTalepEdilenHizmetler = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TalepEdilenIsleticiHizmetleri", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TalepEdilenIsleticiHizmetleri_GenelBilgiler_GenelBilgilerID",
                        column: x => x.GenelBilgilerID,
                        principalTable: "GenelBilgiler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KarsiFirmaBilgisi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaturaID = table.Column<int>(type: "int", nullable: false),
                    VergiKimlikNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    VergiDairesi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AdiUnvani = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Adresi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Ulke = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefon1 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Telefon2 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Telefon3 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Faks1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Faks2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    WebAdresi = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    EPosta = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KarsiFirmaBilgisi", x => x.ID);
                    table.ForeignKey(
                        name: "FK_KarsiFirmaBilgisi_FaturaBilgileri_FaturaID",
                        column: x => x.FaturaID,
                        principalTable: "FaturaBilgileri",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MalKalemBilgileri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaturaID = table.Column<int>(type: "int", nullable: false),
                    SiraNo = table.Column<int>(type: "int", nullable: false),
                    GumrukSiraNo = table.Column<int>(type: "int", nullable: false),
                    MalKalemId = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    gtip = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Cins = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Mensei = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    GeldigiGidecegiUlke = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BirinciMiktar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BirinciBirim = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KapTuru = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    KapAdedi = table.Column<int>(type: "int", nullable: false),
                    MalBedeli = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MalBedeliParaBirimi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NavlunBedeli = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NavlunBedeliParaBirimi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SigortaBedeli = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SigortaBedeliParaBirimi = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BrutAgirlik = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MalKalemTeslimSekli = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MalKalemBilgileri", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MalKalemBilgileri_FaturaBilgileri_FaturaID",
                        column: x => x.FaturaID,
                        principalTable: "FaturaBilgileri",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeslimAdresi",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FaturaID = table.Column<int>(type: "int", nullable: false),
                    AdiTicaretUnvani = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Adresi = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PostaKodu = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Ulke = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Il = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Ilce = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Telefon1 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Telefon2 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Telefon3 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Faks1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Faks2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EPosta = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeslimAdresi", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TeslimAdresi_FaturaBilgileri_FaturaID",
                        column: x => x.FaturaID,
                        principalTable: "FaturaBilgileri",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FaturaBilgileri_GenelBilgilerID",
                table: "FaturaBilgileri",
                column: "GenelBilgilerID");

            migrationBuilder.CreateIndex(
                name: "IX_KarsiFirmaBilgisi_FaturaID",
                table: "KarsiFirmaBilgisi",
                column: "FaturaID");

            migrationBuilder.CreateIndex(
                name: "IX_MalKalemBilgileri_FaturaID",
                table: "MalKalemBilgileri",
                column: "FaturaID");

            migrationBuilder.CreateIndex(
                name: "IX_SbifBilgiFisi_GenelBilgilerID",
                table: "SbifBilgiFisi",
                column: "GenelBilgilerID");

            migrationBuilder.CreateIndex(
                name: "IX_TalepEdilenIsleticiHizmetleri_GenelBilgilerID",
                table: "TalepEdilenIsleticiHizmetleri",
                column: "GenelBilgilerID");

            migrationBuilder.CreateIndex(
                name: "IX_TeslimAdresi_FaturaID",
                table: "TeslimAdresi",
                column: "FaturaID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KarsiFirmaBilgisi");

            migrationBuilder.DropTable(
                name: "MalKalemBilgileri");

            migrationBuilder.DropTable(
                name: "SbifBilgiFisi");

            migrationBuilder.DropTable(
                name: "TalepEdilenIsleticiHizmetleri");

            migrationBuilder.DropTable(
                name: "TeslimAdresi");

            migrationBuilder.DropTable(
                name: "FaturaBilgileri");

            migrationBuilder.DropTable(
                name: "GenelBilgiler");
        }
    }
}
