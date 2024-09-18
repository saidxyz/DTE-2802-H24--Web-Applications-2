using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentMVC.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Degrees",
                columns: table => new
                {
                    DegreeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Degrees", x => x.DegreeId);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    StudentId = table.Column<string>(type: "TEXT", maxLength: 8, nullable: false),
                    Firstname = table.Column<string>(type: "TEXT", nullable: true),
                    Lastname = table.Column<string>(type: "TEXT", nullable: true),
                    DegreeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Student_Degrees_DegreeId",
                        column: x => x.DegreeId,
                        principalTable: "Degrees",
                        principalColumn: "DegreeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Degrees",
                columns: new[] { "DegreeId", "Name" },
                values: new object[] { 1, "Bachelor" });

            migrationBuilder.InsertData(
                table: "Degrees",
                columns: new[] { "DegreeId", "Name" },
                values: new object[] { 2, "Master" });

            migrationBuilder.InsertData(
                table: "Degrees",
                columns: new[] { "DegreeId", "Name" },
                values: new object[] { 3, "Phd" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "DegreeId", "Firstname", "Lastname" },
                values: new object[] { "jbe123", 2, "Johnny", "BeGood" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "DegreeId", "Firstname", "Lastname" },
                values: new object[] { "lpr058", 3, "Linda", "Pravidin" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "DegreeId", "Firstname", "Lastname" },
                values: new object[] { "mla789", 1, "Morgan", "Larsen" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "DegreeId", "Firstname", "Lastname" },
                values: new object[] { "Ono456", 3, "Ola", "Nordmann" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "DegreeId", "Firstname", "Lastname" },
                values: new object[] { "rol000", 2, "Roy", "Olsen" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "StudentId", "DegreeId", "Firstname", "Lastname" },
                values: new object[] { "ssa171", 1, "Said", "Nasser" });

            migrationBuilder.CreateIndex(
                name: "IX_Student_DegreeId",
                table: "Student",
                column: "DegreeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Degrees");
        }
    }
}
