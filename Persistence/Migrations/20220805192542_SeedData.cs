using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("1f767678-4036-4e15-8e8d-5c9dba2c4744"), "drinks", "London", new DateTime(2023, 1, 5, 21, 25, 42, 278, DateTimeKind.Local).AddTicks(8434), "Activity 5 months in future", "Future Activity 5", "Just another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("42b8e77e-1cd4-419a-8e7b-31e4627579b1"), "music", "London", new DateTime(2022, 10, 5, 21, 25, 42, 278, DateTimeKind.Local).AddTicks(8409), "Activity 2 months in future", "Future Activity 2", "O2 Arena" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("4747e354-70e5-4ecf-b1e5-8e68ae63833d"), "drinks", "London", new DateTime(2022, 11, 5, 21, 25, 42, 278, DateTimeKind.Local).AddTicks(8426), "Activity 3 months in future", "Future Activity 3", "Another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("54b6d885-2212-4187-87b8-a4fcdd4de3bd"), "drinks", "London", new DateTime(2022, 6, 5, 21, 25, 42, 278, DateTimeKind.Local).AddTicks(8359), "Activity 2 months ago", "Past Activity 1", "Pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("86925162-2ff7-42b3-bd9e-a8846ce36d43"), "travel", "London", new DateTime(2023, 3, 5, 21, 25, 42, 278, DateTimeKind.Local).AddTicks(8442), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("962875e6-7a89-4fa8-8777-a669577e1a6b"), "drinks", "London", new DateTime(2022, 12, 5, 21, 25, 42, 278, DateTimeKind.Local).AddTicks(8430), "Activity 4 months in future", "Future Activity 4", "Yet another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("9e927783-d21e-4124-800d-51c7a52bab2b"), "music", "London", new DateTime(2023, 2, 5, 21, 25, 42, 278, DateTimeKind.Local).AddTicks(8438), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("a55ff768-6453-4474-8e4c-969e5cb19cb9"), "film", "London", new DateTime(2023, 4, 5, 21, 25, 42, 278, DateTimeKind.Local).AddTicks(8446), "Activity 8 months in future", "Future Activity 8", "Cinema" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("e250f169-8e54-4c19-89a8-f78304f06bf1"), "culture", "Paris", new DateTime(2022, 7, 5, 21, 25, 42, 278, DateTimeKind.Local).AddTicks(8400), "Activity 1 month ago", "Past Activity 2", "Louvre" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("e61f6340-e5f0-4bc9-8bb9-27f8a01887d0"), "culture", "London", new DateTime(2022, 9, 5, 21, 25, 42, 278, DateTimeKind.Local).AddTicks(8405), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("1f767678-4036-4e15-8e8d-5c9dba2c4744"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("42b8e77e-1cd4-419a-8e7b-31e4627579b1"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("4747e354-70e5-4ecf-b1e5-8e68ae63833d"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("54b6d885-2212-4187-87b8-a4fcdd4de3bd"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("86925162-2ff7-42b3-bd9e-a8846ce36d43"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("962875e6-7a89-4fa8-8777-a669577e1a6b"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("9e927783-d21e-4124-800d-51c7a52bab2b"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("a55ff768-6453-4474-8e4c-969e5cb19cb9"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("e250f169-8e54-4c19-89a8-f78304f06bf1"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("e61f6340-e5f0-4bc9-8bb9-27f8a01887d0"));
        }
    }
}
