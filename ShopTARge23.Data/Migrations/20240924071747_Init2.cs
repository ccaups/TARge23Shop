using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopTARge23.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TypeName",
                table: "Spaceships",
                newName: "Typename");

            migrationBuilder.RenameColumn(
                name: "CreaedAt",
                table: "Spaceships",
                newName: "CreatedAt");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Typename",
                table: "Spaceships",
                newName: "TypeName");

            migrationBuilder.RenameColumn(
                name: "CreatedAt",
                table: "Spaceships",
                newName: "CreaedAt");
        }
    }
}
