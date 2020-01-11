using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AddressBookService.Migrations
{
    public partial class StaticStartingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AddressBooks",
                columns: new[] { "Id", "FirstName", "LastName" },
                values: new object[,]
                {
                    { new Guid("384497a7-4e3b-4f91-b248-0fd250ef0b69"), "John", "Smith" },
                    { new Guid("abfb6a4f-6dd2-45f7-b712-e270f5c5ab6d"), "Jane", "Doe" },
                    { new Guid("515f5a89-0002-437c-9cdd-a55bd31769c7"), "Tim", "Jones" },
                    { new Guid("1eada19b-7b8c-4b50-97a0-0322db5fc969"), "David", "Jones" },
                    { new Guid("c1aefccf-c057-4a20-a407-8b007801a9fe"), "Any", "Body" },
                    { new Guid("9cc2ff2e-77cc-4e09-8450-2cacd84500ff"), "Any", "Body" }
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "AddressBookId", "City", "Country", "StreetAddress" },
                values: new object[,]
                {
                    { new Guid("74babd01-e17c-4804-9396-843682aeac7c"), new Guid("384497a7-4e3b-4f91-b248-0fd250ef0b69"), "London", "England", "Test St 1" },
                    { new Guid("8a92a38e-5e85-488d-b20d-1d34bd8037f2"), new Guid("abfb6a4f-6dd2-45f7-b712-e270f5c5ab6d"), "london", "England", "Test St 2" },
                    { new Guid("b0a02e8e-fb78-41d1-b35d-5658a20fc31c"), new Guid("515f5a89-0002-437c-9cdd-a55bd31769c7"), "New York", "USA", "Test St 3" },
                    { new Guid("826d8e11-ee0d-4e99-934f-5e742ef28164"), new Guid("1eada19b-7b8c-4b50-97a0-0322db5fc969"), "New york", "USA", "Test St 4" },
                    { new Guid("b9791e7f-4d85-437f-a0ca-cdfec73d199e"), new Guid("c1aefccf-c057-4a20-a407-8b007801a9fe"), "London", "England", "Test St 4" },
                    { new Guid("52dbd833-fc25-482d-9ac4-73c1962074fa"), new Guid("9cc2ff2e-77cc-4e09-8450-2cacd84500ff"), "boston", "USA", "1765 Long street" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("52dbd833-fc25-482d-9ac4-73c1962074fa"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("74babd01-e17c-4804-9396-843682aeac7c"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("826d8e11-ee0d-4e99-934f-5e742ef28164"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("8a92a38e-5e85-488d-b20d-1d34bd8037f2"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b0a02e8e-fb78-41d1-b35d-5658a20fc31c"));

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: new Guid("b9791e7f-4d85-437f-a0ca-cdfec73d199e"));

            migrationBuilder.DeleteData(
                table: "AddressBooks",
                keyColumn: "Id",
                keyValue: new Guid("1eada19b-7b8c-4b50-97a0-0322db5fc969"));

            migrationBuilder.DeleteData(
                table: "AddressBooks",
                keyColumn: "Id",
                keyValue: new Guid("384497a7-4e3b-4f91-b248-0fd250ef0b69"));

            migrationBuilder.DeleteData(
                table: "AddressBooks",
                keyColumn: "Id",
                keyValue: new Guid("515f5a89-0002-437c-9cdd-a55bd31769c7"));

            migrationBuilder.DeleteData(
                table: "AddressBooks",
                keyColumn: "Id",
                keyValue: new Guid("9cc2ff2e-77cc-4e09-8450-2cacd84500ff"));

            migrationBuilder.DeleteData(
                table: "AddressBooks",
                keyColumn: "Id",
                keyValue: new Guid("abfb6a4f-6dd2-45f7-b712-e270f5c5ab6d"));

            migrationBuilder.DeleteData(
                table: "AddressBooks",
                keyColumn: "Id",
                keyValue: new Guid("c1aefccf-c057-4a20-a407-8b007801a9fe"));
        }
    }
}
