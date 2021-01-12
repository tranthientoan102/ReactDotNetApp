using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace ReactDotNetApp.Migrations
{
    public partial class InitCandidate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    fullName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    mobile = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    age = table.Column<int>(nullable: false),
                    bloodGroup = table.Column<string>(type: "nvarchar(5)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Candidates");
        }
    }
}
