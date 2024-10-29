using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Site_Api.Migrations
{
    /// <inheritdoc />
    public partial class ShowDataTypeChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Shows",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "[]",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                columns: new[] { "Genre", "Poster" },
                values: new object[] { "[\"Drama\",\"Horror\",\"Sci-Fi\"]", "https://m.media-amazon.com/images/M/MV5BMGE1OWZkZmItNmVhMC00YzAxLTgxOTctNjg3NWExM2RmOWJkXkEyXkFqcGc@._V1_FMjpg_UX1000_.jpg" });

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
                value: "AQAAAAIAAYagAAAAEJhqazeaTnizJk5dQLNfWYYgYjEYUR/OHszVWFYkM/QwCzAt1K6k++5FtuI8rfSjbQ==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Shows",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 1,
                column: "Genre",
                value: "Action, Adventure, Fantasy");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 2,
                columns: new[] { "Genre", "Poster" },
                values: new object[] { "Drama, Horror, Sci-Fi", "http://ia.media-imdb.com/images/M/MV5BMTU4NzMyNDk1OV5BMl5BanBnXkFtZTcwOTEwMzU1MQ@@._V1_SX300.jpg" });

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 3,
                column: "Genre",
                value: "Action, Drama, Fantasy");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 4,
                column: "Genre",
                value: "Action, Sci-Fi, Thriller");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 5,
                column: "Genre",
                value: "Biography, Comedy, Crime");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 6,
                column: "Genre",
                value: "Adventure, Drama, Sci-Fi");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 7,
                column: "Genre",
                value: "Adventure, Drama, Fantasy");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 8,
                column: "Genre",
                value: "Action, Drama, History");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 9,
                column: "Genre",
                value: "Action, Crime, Drama");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 10,
                column: "Genre",
                value: "Crime, Drama");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 11,
                column: "Genre",
                value: "Biography, Crime, Drama");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 12,
                column: "Genre",
                value: "Crime, Drama, Thriller");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 13,
                column: "Genre",
                value: "Action, Adventure, Fantasy");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 14,
                column: "Genre",
                value: "Action, Adventure, Sci-Fi");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 15,
                column: "Genre",
                value: "Action, Adventure, Fantasy");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 16,
                column: "Genre",
                value: "Action, Crime, Drama");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEOYoe+cfiBr9i0decM2JsWJie6SAU1Ri6ZnKMZ6Uox+kcCR19SiKvkLEQ26L1gqFGQ==");
        }
    }
}
