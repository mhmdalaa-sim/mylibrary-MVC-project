using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace mylibraryproject.Migrations
{
    /// <inheritdoc />
    public partial class jkjkjk : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "GenreId", "Title", "year" },
                values: new object[,]
                {
                    { 1, 1, 1, "The Great Gatsby", 1925 },
                    { 2, 2, 2, "To Kill a Mockingbird", 1960 },
                    { 3, 3, 3, "1984", 1949 },
                    { 4, 4, 4, "The Catcher in the Rye", 1951 },
                    { 5, 5, 5, "Pride and Prejudice", 1813 },
                    { 6, 6, 1, "The Hobbit", 1937 },
                    { 7, 6, 1, "The Lord of the Rings", 1954 },
                    { 8, 7, 3, "The Hitchhiker's Guide to the Galaxy", 1979 },
                    { 9, 8, 3, "Brave New World", 1932 },
                    { 10, 9, 2, "Frankenstein", 1818 },
                    { 11, 10, 2, "Dracula", 1897 },
                    { 12, 11, 3, "The War of the Worlds", 1898 },
                    { 13, 11, 3, "The Time Machine", 1895 },
                    { 14, 12, 6, "The Adventures of Sherlock Holmes", 1892 },
                    { 15, 13, 7, "The Picture of Dorian Gray", 1890 },
                    { 16, 14, 8, "The Sun Also Rises", 1926 },
                    { 17, 14, 8, "The Old Man and the Sea", 1952 },
                    { 18, 15, 9, "The Sound and the Fury", 1929 },
                    { 19, 16, 10, "One Hundred Years of Solitude", 1967 },
                    { 20, 16, 10, "Love in the Time of Cholera", 1985 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
