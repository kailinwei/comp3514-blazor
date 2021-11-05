using Microsoft.EntityFrameworkCore.Migrations;

namespace SchoolAPI.Data.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "FirstName", "LastName", "School" },
                values: new object[,]
                {
                    { "7b296c7b-d1b6-4587-adb2-fd936a4bd47f", "Tom", "Day", "Physics" },
                    { "251c473d-fe21-4814-b4c0-e957b1ec16f2", "Ann", "Fox", "Geology" },
                    { "76828eea-a146-475f-a717-b5af49bdebb1", "Art", "Ash", "Nursing" },
                    { "ae991491-5bbe-41e9-8692-139989e6d159", "Mia", "Hay", "Science" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
