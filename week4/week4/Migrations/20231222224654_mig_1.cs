using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace week4.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Kullanicis",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciAdi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SaglikDurumus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Durum = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaglikDurumus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SosyalEtkilesims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Turu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SosyalEtkilesims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EvcilHayvans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Isim = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KullaniciId = table.Column<int>(type: "int", nullable: false),
                    SaglikDurumuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvcilHayvans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EvcilHayvans_Kullanicis_KullaniciId",
                        column: x => x.KullaniciId,
                        principalTable: "Kullanicis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EvcilHayvans_SaglikDurumus_SaglikDurumuId",
                        column: x => x.SaglikDurumuId,
                        principalTable: "SaglikDurumus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Aktivites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EvcilHayvanId = table.Column<int>(type: "int", nullable: false),
                    AktiviteAdi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aktivites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Aktivites_EvcilHayvans_EvcilHayvanId",
                        column: x => x.EvcilHayvanId,
                        principalTable: "EvcilHayvans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Besins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Miktar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EvcilHayvanId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Besins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Besins_EvcilHayvans_EvcilHayvanId",
                        column: x => x.EvcilHayvanId,
                        principalTable: "EvcilHayvans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Egitims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EvcilHayvanId = table.Column<int>(type: "int", nullable: false),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Egitims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Egitims_EvcilHayvans_EvcilHayvanId",
                        column: x => x.EvcilHayvanId,
                        principalTable: "EvcilHayvans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvcilHayvanSosyalEtkilesim",
                columns: table => new
                {
                    KatilanEvcilHayvanlarId = table.Column<int>(type: "int", nullable: false),
                    SosyalEtkilesimlerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvcilHayvanSosyalEtkilesim", x => new { x.KatilanEvcilHayvanlarId, x.SosyalEtkilesimlerId });
                    table.ForeignKey(
                        name: "FK_EvcilHayvanSosyalEtkilesim_EvcilHayvans_KatilanEvcilHayvanlarId",
                        column: x => x.KatilanEvcilHayvanlarId,
                        principalTable: "EvcilHayvans",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EvcilHayvanSosyalEtkilesim_SosyalEtkilesims_SosyalEtkilesimlerId",
                        column: x => x.SosyalEtkilesimlerId,
                        principalTable: "SosyalEtkilesims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aktivites_EvcilHayvanId",
                table: "Aktivites",
                column: "EvcilHayvanId");

            migrationBuilder.CreateIndex(
                name: "IX_Besins_EvcilHayvanId",
                table: "Besins",
                column: "EvcilHayvanId");

            migrationBuilder.CreateIndex(
                name: "IX_Egitims_EvcilHayvanId",
                table: "Egitims",
                column: "EvcilHayvanId");

            migrationBuilder.CreateIndex(
                name: "IX_EvcilHayvans_KullaniciId",
                table: "EvcilHayvans",
                column: "KullaniciId");

            migrationBuilder.CreateIndex(
                name: "IX_EvcilHayvans_SaglikDurumuId",
                table: "EvcilHayvans",
                column: "SaglikDurumuId");

            migrationBuilder.CreateIndex(
                name: "IX_EvcilHayvanSosyalEtkilesim_SosyalEtkilesimlerId",
                table: "EvcilHayvanSosyalEtkilesim",
                column: "SosyalEtkilesimlerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Aktivites");

            migrationBuilder.DropTable(
                name: "Besins");

            migrationBuilder.DropTable(
                name: "Egitims");

            migrationBuilder.DropTable(
                name: "EvcilHayvanSosyalEtkilesim");

            migrationBuilder.DropTable(
                name: "EvcilHayvans");

            migrationBuilder.DropTable(
                name: "SosyalEtkilesims");

            migrationBuilder.DropTable(
                name: "Kullanicis");

            migrationBuilder.DropTable(
                name: "SaglikDurumus");
        }
    }
}
