using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CiftciSatis.Migrations
{
    public partial class databasebuild : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ciftcis",
                columns: table => new
                {
                    CiftciId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CiftciEmail = table.Column<string>(nullable: true),
                    CiftciSifre = table.Column<string>(nullable: true),
                    CiftciAd = table.Column<string>(nullable: true),
                    CiftciSoyad = table.Column<string>(nullable: true),
                    CiftciAdres = table.Column<string>(nullable: true),
                    CiftciBakiye = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ciftcis", x => x.CiftciId);
                });

            migrationBuilder.CreateTable(
                name: "Musteris",
                columns: table => new
                {
                    MusteriId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MusteriEmail = table.Column<string>(nullable: true),
                    MusteriSifre = table.Column<string>(nullable: true),
                    MusteriAd = table.Column<string>(nullable: true),
                    MusteriSoyad = table.Column<string>(nullable: true),
                    MusteriAdres = table.Column<string>(nullable: true),
                    MusteriBakiye = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musteris", x => x.MusteriId);
                });

            migrationBuilder.CreateTable(
                name: "Siparislers",
                columns: table => new
                {
                    SiparisId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SiparisMiktar = table.Column<int>(nullable: false),
                    SiparisTutar = table.Column<double>(nullable: false),
                    SiparisKTarih = table.Column<DateTime>(nullable: false),
                    CiftciId = table.Column<int>(nullable: false),
                    MusteriId = table.Column<int>(nullable: false),
                    UrunId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparislers", x => x.SiparisId);
                    table.ForeignKey(
                        name: "FK_Siparislers_Ciftcis_CiftciId",
                        column: x => x.CiftciId,
                        principalTable: "Ciftcis",
                        principalColumn: "CiftciId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Urunlers",
                columns: table => new
                {
                    UrunId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UrunAd = table.Column<string>(nullable: true),
                    UrunFiyat = table.Column<double>(nullable: false),
                    UrunTur = table.Column<string>(nullable: true),
                    UrunMiktar = table.Column<int>(nullable: false),
                    UrunRenk = table.Column<string>(nullable: true),
                    UrunRandıman = table.Column<int>(nullable: false),
                    UrunKTarih = table.Column<DateTime>(nullable: false),
                    CiftciId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Urunlers", x => x.UrunId);
                    table.ForeignKey(
                        name: "FK_Urunlers_Ciftcis_CiftciId",
                        column: x => x.CiftciId,
                        principalTable: "Ciftcis",
                        principalColumn: "CiftciId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Siparislers_CiftciId",
                table: "Siparislers",
                column: "CiftciId");

            migrationBuilder.CreateIndex(
                name: "IX_Urunlers_CiftciId",
                table: "Urunlers",
                column: "CiftciId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Musteris");

            migrationBuilder.DropTable(
                name: "Siparislers");

            migrationBuilder.DropTable(
                name: "Urunlers");

            migrationBuilder.DropTable(
                name: "Ciftcis");
        }
    }
}
