using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Site_Api.Migrations
{
    /// <inheritdoc />
    public partial class ChangedActorsToList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Actors",
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
                column: "Actors",
                value: "[\"Sam Worthington\",\"Zoe Saldana\",\"Sigourney Weaver\",\"Stephen Lang\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 2,
                column: "Actors",
                value: "[\"Will Smith\",\"Alice Braga\",\"Charlie Tahan\",\"Salli Richardson-Whitfield\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 3,
                column: "Actors",
                value: "[\"Gerard Butler\",\"Lena Headey\",\"Dominic West\",\"David Wenham\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 4,
                column: "Actors",
                value: "[\"Robert Downey Jr.\",\"Chris Evans\",\"Mark Ruffalo\",\"Chris Hemsworth\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 5,
                column: "Actors",
                value: "[\"Leonardo DiCaprio\",\"Jonah Hill\",\"Margot Robbie\",\"Matthew McConaughey\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 6,
                column: "Actors",
                value: "[\"Ellen Burstyn\",\"Matthew McConaughey\",\"Mackenzie Foy\",\"John Lithgow\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 7,
                column: "Actors",
                value: "[\"Peter Dinklage\",\"Lena Headey\",\"Emilia Clarke\",\"Kit Harington\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 8,
                column: "Actors",
                value: "[\"Travis Fimmel\",\"Clive Standen\",\"Gustaf Skarsg\\uFFFDrd\",\"Katheryn Winnick\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 9,
                column: "Actors",
                value: "[\"Ben McKenzie\",\"Donal Logue\",\"David Mazouz\",\"Sean Pertwee\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 10,
                column: "Actors",
                value: "[\"Omari Hardwick\",\"Joseph Sikora\",\"Andy Bean\",\"Lela Loren\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 11,
                column: "Actors",
                value: "[\"Wagner Moura\",\"Boyd Holbrook\",\"Pedro Pascal\",\"Joanna Christie\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 12,
                column: "Actors",
                value: "[\"Bryan Cranston\",\"Anna Gunn\",\"Aaron Paul\",\"Dean Norris\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 13,
                column: "Actors",
                value: "[\"Rachel McAdams\",\"Benedict Cumberbatch\",\"Mads Mikkelsen\",\"Tilda Swinton\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 14,
                column: "Actors",
                value: "[\"Felicity Jones\",\"Riz Ahmed\",\"Mads Mikkelsen\",\"Ben Mendelsohn\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 15,
                column: "Actors",
                value: "[\"Michael Fassbender\",\"Michael Kenneth Williams\",\"Marion Cotillard\",\"Jeremy Irons\"]");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 16,
                column: "Actors",
                value: "[\"Mahershala Ali\",\"Mike Colter\",\"Frankie Faison\",\"Erik LaRay Harvey\"]");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEAXaGyy3SwjLpr1wdzU7Df+NXtCfHgNTk3rRz6NZjy14VMCxUoAFtM6bYFZgLcGmUg==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Actors",
                table: "Shows",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 1,
                column: "Actors",
                value: "Sam Worthington, Zoe Saldana, Sigourney Weaver, Stephen Lang");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 2,
                column: "Actors",
                value: "Will Smith, Alice Braga, Charlie Tahan, Salli Richardson-Whitfield");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 3,
                column: "Actors",
                value: "Gerard Butler, Lena Headey, Dominic West, David Wenham");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 4,
                column: "Actors",
                value: "Robert Downey Jr., Chris Evans, Mark Ruffalo, Chris Hemsworth");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 5,
                column: "Actors",
                value: "Leonardo DiCaprio, Jonah Hill, Margot Robbie, Matthew McConaughey");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 6,
                column: "Actors",
                value: "Ellen Burstyn, Matthew McConaughey, Mackenzie Foy, John Lithgow");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 7,
                column: "Actors",
                value: "Peter Dinklage, Lena Headey, Emilia Clarke, Kit Harington");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 8,
                column: "Actors",
                value: "Travis Fimmel, Clive Standen, Gustaf Skarsg�rd, Katheryn Winnick");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 9,
                column: "Actors",
                value: "Ben McKenzie, Donal Logue, David Mazouz, Sean Pertwee");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 10,
                column: "Actors",
                value: "Omari Hardwick, Joseph Sikora, Andy Bean, Lela Loren");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 11,
                column: "Actors",
                value: "Wagner Moura, Boyd Holbrook, Pedro Pascal, Joanna Christie");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 12,
                column: "Actors",
                value: "Bryan Cranston, Anna Gunn, Aaron Paul, Dean Norris");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 13,
                column: "Actors",
                value: "Rachel McAdams, Benedict Cumberbatch, Mads Mikkelsen, Tilda Swinton");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 14,
                column: "Actors",
                value: "Felicity Jones, Riz Ahmed, Mads Mikkelsen, Ben Mendelsohn");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 15,
                column: "Actors",
                value: "Michael Fassbender, Michael Kenneth Williams, Marion Cotillard, Jeremy Irons");

            migrationBuilder.UpdateData(
                table: "Shows",
                keyColumn: "ShowId",
                keyValue: 16,
                column: "Actors",
                value: "Mahershala Ali, Mike Colter, Frankie Faison, Erik LaRay Harvey");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "Password",
                value: "AQAAAAIAAYagAAAAEEwt4ZO33FyjhcpOMSchadGfnaEDDbv1b8pV+XMSj7xlzaOeUCJuZXc1hlSuRNVKBA==");
        }
    }
}
