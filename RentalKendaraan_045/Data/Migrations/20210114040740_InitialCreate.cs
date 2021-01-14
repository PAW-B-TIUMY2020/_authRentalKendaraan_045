using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentalKendaraan_045.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    ID_Gender = table.Column<int>(nullable: false),
                    Nama_Gender = table.Column<string>(unicode: false, maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.ID_Gender);
                });

            migrationBuilder.CreateTable(
                name: "Jaminan",
                columns: table => new
                {
                    ID_Jaminan = table.Column<int>(nullable: false),
                    Nama_Jaminan = table.Column<string>(unicode: false, maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jaminan", x => x.ID_Jaminan);
                });

            migrationBuilder.CreateTable(
                name: "Jenis_Kendaraan",
                columns: table => new
                {
                    ID_Jenis_Kendaraan = table.Column<int>(nullable: false),
                    Nama_Jenis_Kendaraan = table.Column<string>(unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jenis_Kendaraan", x => x.ID_Jenis_Kendaraan);
                });

            migrationBuilder.CreateTable(
                name: "Kondisi_Kendaraan",
                columns: table => new
                {
                    ID_Kondisi = table.Column<int>(nullable: false),
                    Nama_Kondisi = table.Column<string>(unicode: false, maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kondisi_Kendaraan", x => x.ID_Kondisi);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID_Customer = table.Column<int>(nullable: false),
                    Nama_Customer = table.Column<string>(unicode: false, maxLength: 30, nullable: false),
                    NIK = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    Alamat = table.Column<string>(unicode: false, maxLength: 150, nullable: false),
                    No_HP = table.Column<string>(unicode: false, maxLength: 13, nullable: false),
                    ID_Gender = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID_Customer);
                    table.ForeignKey(
                        name: "FK_Customer_Gender",
                        column: x => x.ID_Gender,
                        principalTable: "Gender",
                        principalColumn: "ID_Gender",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Kendaraan",
                columns: table => new
                {
                    ID_Kendaraan = table.Column<int>(nullable: false),
                    Nama_Kendaraan = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    No_Polisi = table.Column<string>(unicode: false, maxLength: 15, nullable: false),
                    No_STNK = table.Column<string>(unicode: false, maxLength: 8, nullable: false),
                    ID_Jenis_kendaraan = table.Column<int>(nullable: false),
                    Ketersediaan = table.Column<string>(unicode: false, maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kendaraan", x => x.ID_Kendaraan);
                    table.ForeignKey(
                        name: "FK_Kendaraan_Jenis_Kendaraan",
                        column: x => x.ID_Jenis_kendaraan,
                        principalTable: "Jenis_Kendaraan",
                        principalColumn: "ID_Jenis_Kendaraan",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Peminjaman",
                columns: table => new
                {
                    ID_Peminjaman = table.Column<int>(nullable: false),
                    Tgl_Peminjaman = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_Kendaraan = table.Column<int>(nullable: false),
                    ID_Customer = table.Column<int>(nullable: false),
                    ID_Jaminan = table.Column<int>(nullable: false),
                    Biaya = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peminjaman", x => x.ID_Peminjaman);
                    table.ForeignKey(
                        name: "FK_Peminjaman_Customer",
                        column: x => x.ID_Customer,
                        principalTable: "Customer",
                        principalColumn: "ID_Customer",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Peminjaman_Jaminan",
                        column: x => x.ID_Jaminan,
                        principalTable: "Jaminan",
                        principalColumn: "ID_Jaminan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Peminjaman_Kendaraan",
                        column: x => x.ID_Kendaraan,
                        principalTable: "Kendaraan",
                        principalColumn: "ID_Kendaraan",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pengembalian",
                columns: table => new
                {
                    ID_Pengembalian = table.Column<int>(nullable: false),
                    Tgl_Pengembalian = table.Column<DateTime>(type: "datetime", nullable: false),
                    ID_Peminjaman = table.Column<int>(nullable: false),
                    ID_Kondisi = table.Column<int>(nullable: false),
                    Denda = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pengembalian", x => x.ID_Pengembalian);
                    table.ForeignKey(
                        name: "FK_Pengembalian_Kondisi_Kendaraan",
                        column: x => x.ID_Kondisi,
                        principalTable: "Kondisi_Kendaraan",
                        principalColumn: "ID_Kondisi",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pengembalian_Peminjaman",
                        column: x => x.ID_Peminjaman,
                        principalTable: "Peminjaman",
                        principalColumn: "ID_Peminjaman",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customer_ID_Gender",
                table: "Customer",
                column: "ID_Gender");

            migrationBuilder.CreateIndex(
                name: "IX_Kendaraan_ID_Jenis_kendaraan",
                table: "Kendaraan",
                column: "ID_Jenis_kendaraan");

            migrationBuilder.CreateIndex(
                name: "IX_Peminjaman_ID_Customer",
                table: "Peminjaman",
                column: "ID_Customer");

            migrationBuilder.CreateIndex(
                name: "IX_Peminjaman_ID_Jaminan",
                table: "Peminjaman",
                column: "ID_Jaminan");

            migrationBuilder.CreateIndex(
                name: "IX_Peminjaman_ID_Kendaraan",
                table: "Peminjaman",
                column: "ID_Kendaraan");

            migrationBuilder.CreateIndex(
                name: "IX_Pengembalian_ID_Kondisi",
                table: "Pengembalian",
                column: "ID_Kondisi");

            migrationBuilder.CreateIndex(
                name: "IX_Pengembalian_ID_Peminjaman",
                table: "Pengembalian",
                column: "ID_Peminjaman");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pengembalian");

            migrationBuilder.DropTable(
                name: "Kondisi_Kendaraan");

            migrationBuilder.DropTable(
                name: "Peminjaman");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Jaminan");

            migrationBuilder.DropTable(
                name: "Kendaraan");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "Jenis_Kendaraan");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
