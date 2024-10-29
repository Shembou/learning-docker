using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Site_Api.Migrations
{
    /// <inheritdoc />
    public partial class RemovedResponse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Response",
                table: "Shows");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEM8R9Oeb20F3uAYMaKNPMj7eTia0moXBd6suuCxmtP00HOw4okOz18t5UGBeH5lZvg==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Response",
                table: "Shows",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 1,
                column: "Response",
                value: true);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 2,
                column: "Response",
                value: true);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 3,
                column: "Response",
                value: true);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 4,
                column: "Response",
                value: true);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 5,
                column: "Response",
                value: true);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 6,
                column: "Response",
                value: true);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 7,
                column: "Response",
                value: true);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 8,
                column: "Response",
                value: true);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 9,
                column: "Response",
                value: true);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 10,
                column: "Response",
                value: true);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 11,
                column: "Response",
                value: true);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 12,
                column: "Response",
                value: true);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 13,
                column: "Response",
                value: true);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 14,
                column: "Response",
                value: true);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 15,
                column: "Response",
                value: true);

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 16,
                column: "Response",
                value: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEI7F14LAELGxVPZkTqMRIQfqG2JZ7ce0IDtFGSlxLlVxFR9+qQ/fxxjLogx2n2kWPQ==");
        }
    }
}
