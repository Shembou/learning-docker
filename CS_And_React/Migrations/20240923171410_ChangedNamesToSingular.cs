using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Site_Api.Migrations
{
    /// <inheritdoc />
    public partial class ChangedNamesToSingular : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEOYoe+cfiBr9i0decM2JsWJie6SAU1Ri6ZnKMZ6Uox+kcCR19SiKvkLEQ26L1gqFGQ==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEM8R9Oeb20F3uAYMaKNPMj7eTia0moXBd6suuCxmtP00HOw4okOz18t5UGBeH5lZvg==");
        }
    }
}
