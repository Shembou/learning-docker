using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Site_Api.Migrations
{
    /// <inheritdoc />
    public partial class RevertedToGenre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Genres",
                table: "Shows",
                newName: "Genre");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 1,
                column: "Genre",
                value: "[\"Action\",\"Adventure\",\"Fantasy\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 2,
                column: "Genre",
                value: "[\"Drama\",\"Horror\",\"Sci-Fi\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 3,
                column: "Genre",
                value: "[\"Action\",\"Drama\",\"Fantasy\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 4,
                column: "Genre",
                value: "[\"Action\",\"Sci-Fi\",\"Thriller\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 5,
                column: "Genre",
                value: "[\"Biography\",\"Comedy\",\"Crime\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 6,
                column: "Genre",
                value: "[\"Adventure\",\"Drama\",\"Sci-Fi\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 7,
                column: "Genre",
                value: "[\"Adventure\",\"Drama\",\"Fantasy\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 8,
                column: "Genre",
                value: "[\"Action\",\"Drama\",\"History\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 9,
                column: "Genre",
                value: "[\"Action\",\"Crime\",\"Drama\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 10,
                column: "Genre",
                value: "[\"Crime\",\"Drama\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 11,
                column: "Genre",
                value: "[\"Biography\",\"Crime\",\"Drama\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 12,
                column: "Genre",
                value: "[\"Crime\",\"Drama\",\"Thriller\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 13,
                column: "Genre",
                value: "[\"Action\",\"Adventure\",\"Fantasy\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 14,
                column: "Genre",
                value: "[\"Action\",\"Adventure\",\"Sci-Fi\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 15,
                column: "Genre",
                value: "[\"Action\",\"Adventure\",\"Fantasy\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 16,
                column: "Genre",
                value: "[\"Action\",\"Crime\",\"Drama\"]");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEEwt4ZO33FyjhcpOMSchadGfnaEDDbv1b8pV+XMSj7xlzaOeUCJuZXc1hlSuRNVKBA==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Genre",
                table: "Shows",
                newName: "Genres");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 1,
                column: "Genres",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 2,
                column: "Genres",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 3,
                column: "Genres",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 4,
                column: "Genres",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 5,
                column: "Genres",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 6,
                column: "Genres",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 7,
                column: "Genres",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 8,
                column: "Genres",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 9,
                column: "Genres",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 10,
                column: "Genres",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 11,
                column: "Genres",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 12,
                column: "Genres",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 13,
                column: "Genres",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 14,
                column: "Genres",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 15,
                column: "Genres",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 16,
                column: "Genres",
                value: "[]");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEODAFyZ6ggUs9U2kI/cTt9jB4JhpUM+PTtqL+hp2Tn7Ei3mlyIYXuNZ7g2jNbqAKHg==");
        }
    }
}
