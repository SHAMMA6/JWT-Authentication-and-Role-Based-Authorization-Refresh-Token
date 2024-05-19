using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JwtAuthAspNet7WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class _5th : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tokenApiModels");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tokenApiModels",
                columns: table => new
                {
                    TokenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    applicationUserId1 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AccessToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    applicationUserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tokenApiModels", x => x.TokenId);
                    table.ForeignKey(
                        name: "FK_tokenApiModels_AspNetUsers_applicationUserId1",
                        column: x => x.applicationUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tokenApiModels_applicationUserId1",
                table: "tokenApiModels",
                column: "applicationUserId1");
        }
    }
}
