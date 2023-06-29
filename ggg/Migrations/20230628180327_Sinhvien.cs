using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ggg.Migrations
{
    /// <inheritdoc />
    public partial class Sinhvien : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sinhvien",
                columns: table => new
                {
                    masv = table.Column<string>(type: "TEXT", nullable: false),
                    hoten = table.Column<string>(type: "TEXT", nullable: false),
                    malop = table.Column<string>(type: "TEXT", nullable: false),
                    diachi = table.Column<string>(type: "TEXT", nullable: false)

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sinhvien", x => x.masv);
                    table.ForeignKey(
                        name: "FK_Sinhvien_Lophoc_malop",
                        column: x => x.malop,
                        principalTable: "Lophoc",
                        principalColumn: "malop",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Sinhvien_malop",
                table: "Sinhvien",
                column: "malop");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sinhvien");
        }
    }
}
