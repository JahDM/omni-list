using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OmniAPI.Data.Migrations
{
    /// <inheritdoc />
    public partial class initMoviesData_MovieImgFromBitToLink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Movies",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Games",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Photo",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(byte[]),
                oldType: "varbinary(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "EpisodesOverall", "ExternalLink", "Name", "Photo", "Rating", "ReleaseDate" },
                values: new object[,]
                {
                    { 1, 1, "https://fmovies.to/movie/the-lord-of-the-rings-the-fellowship-of-the-ring-extended-80ln/1-1", "Władca Pierścieni", "https://static.posters.cz/image/750webp/11723.webp", 9.9m, (short)0 },
                    { 2, 1, "https://fmovies.to/movie/the-northman-qz8kn/1-1", "The Northman", "https://static.bunnycdn.ru/i/cache/images/9/9f/9f3cd9f37c5ee354e2151109a89d2278.jpg", 8m, (short)0 },
                    { 3, 1, "https://fmovies.to/movie/valhalla-rising-z903/1-1", "Valhalla Rising", "https://static.bunnycdn.ru/i/cache/images/5/5d/5d8a4e3ce83a18d1642db937ff600710.jpg", 7m, (short)0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Photo",
                table: "Movies",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Photo",
                table: "Games",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Photo",
                table: "Books",
                type: "varbinary(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
