using Microsoft.EntityFrameworkCore.Migrations;

namespace cvMakerApi.Migrations
{
    public partial class ScriptA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    country = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "resumeMakers",
                columns: table => new
                {
                    ResumeMakerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Position = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    SocialorsiteA = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SocialorsiteB = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    SocialorsiteC = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    about = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    servicesA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    servicesB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    educationorcrouseA = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    educationorcrouseB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    educationorcrouseC = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    educationorcrouseD = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    picture = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_resumeMakers", x => x.ResumeMakerId);
                    table.ForeignKey(
                        name: "FK_resumeMakers_countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_resumeMakers_CountryId",
                table: "resumeMakers",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "resumeMakers");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "countries");
        }
    }
}
