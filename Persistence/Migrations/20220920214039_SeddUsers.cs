using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class SeddUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("019b17be-5052-4827-b4d9-72d81f3b4e79"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("2a6a840b-cad9-4be6-a88e-50fc8e1592ef"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("6387c951-c624-4544-941b-114e677bba2f"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("6e730961-c8de-4e08-8d14-9bcc3d8bda0c"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("7ae35dd2-b4cf-4aa4-ac08-5e7a08565449"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("81d552fe-c2f4-4dd8-9b81-40d5b93ac230"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("8d082f70-e5d5-4e70-8f03-c96dcc81617f"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("dc3a0b5a-45ee-43c7-8d3a-da61139e218b"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("e11e5657-8036-428f-b68a-a581b9defe5c"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("ee86c7ce-c443-4612-9423-9141010b5b7a"));

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("130bebc8-8b6d-4da0-aeec-8a20dce065e8"), "music", "London", new DateTime(2023, 3, 20, 23, 40, 38, 307, DateTimeKind.Local).AddTicks(3448), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("190b1ff3-b03b-4c87-9ce5-3c2e9486f663"), "culture", "Paris", new DateTime(2022, 8, 20, 23, 40, 38, 307, DateTimeKind.Local).AddTicks(3415), "Activity 1 month ago", "Past Activity 2", "Louvre" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("236ac476-eb34-4e42-8481-3d1c04d4ec9e"), "drinks", "London", new DateTime(2023, 1, 20, 23, 40, 38, 307, DateTimeKind.Local).AddTicks(3439), "Activity 4 months in future", "Future Activity 4", "Yet another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("5118d909-0c34-45f0-ae3c-104733c05d14"), "drinks", "London", new DateTime(2023, 2, 20, 23, 40, 38, 307, DateTimeKind.Local).AddTicks(3443), "Activity 5 months in future", "Future Activity 5", "Just another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("7f1ee46e-ef3a-4cc8-855a-55aab0b053e5"), "culture", "London", new DateTime(2022, 10, 20, 23, 40, 38, 307, DateTimeKind.Local).AddTicks(3420), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("90a25d47-4e09-4db9-9e94-8a50ef305b9e"), "film", "London", new DateTime(2023, 5, 20, 23, 40, 38, 307, DateTimeKind.Local).AddTicks(3456), "Activity 8 months in future", "Future Activity 8", "Cinema" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("92b85e8b-133f-49f0-9b6a-871466a5a05e"), "travel", "London", new DateTime(2023, 4, 20, 23, 40, 38, 307, DateTimeKind.Local).AddTicks(3452), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("b33cd1df-9bf6-4278-b0b3-86d9732dd52f"), "drinks", "London", new DateTime(2022, 12, 20, 23, 40, 38, 307, DateTimeKind.Local).AddTicks(3430), "Activity 3 months in future", "Future Activity 3", "Another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("b6427bd8-2d55-4f78-b99b-3107377e6ebc"), "music", "London", new DateTime(2022, 11, 20, 23, 40, 38, 307, DateTimeKind.Local).AddTicks(3425), "Activity 2 months in future", "Future Activity 2", "O2 Arena" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("e4915ad9-88fa-4e27-8381-cc90233be472"), "drinks", "London", new DateTime(2022, 7, 20, 23, 40, 38, 307, DateTimeKind.Local).AddTicks(3372), "Activity 2 months ago", "Past Activity 1", "Pub" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1c2f0074-365c-49b6-b65f-079fde930a80", 0, "test", "ce3baf16-fa4a-4780-b1d4-c76b5cb2c46e", "Tomek", "tomek@test.com", false, false, null, null, null, null, null, false, "0d36b6d8-112c-46ad-9c37-cd14b3607dc0", false, "tomek" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3143654c-0b46-4d0a-b437-eccea597348d", 0, "test", "7144318e-8e17-425e-920d-e3a3cfebf3f1", "Jan", "jan@test.com", false, false, null, null, null, null, null, false, "af75aadf-ba68-4973-9bc7-780aa773e2ec", false, "jan" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "673de5d9-701d-4299-a62a-92997678d55b", 0, "test", "0d3385bd-0d9a-45c7-aef3-ed4b3602273d", "Kasia", "kasia@test.com", false, false, null, null, null, null, null, false, "4f7989b7-8075-4bda-9201-4dee967540ef", false, "kasia" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("130bebc8-8b6d-4da0-aeec-8a20dce065e8"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("190b1ff3-b03b-4c87-9ce5-3c2e9486f663"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("236ac476-eb34-4e42-8481-3d1c04d4ec9e"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("5118d909-0c34-45f0-ae3c-104733c05d14"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("7f1ee46e-ef3a-4cc8-855a-55aab0b053e5"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("90a25d47-4e09-4db9-9e94-8a50ef305b9e"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("92b85e8b-133f-49f0-9b6a-871466a5a05e"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b33cd1df-9bf6-4278-b0b3-86d9732dd52f"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b6427bd8-2d55-4f78-b99b-3107377e6ebc"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("e4915ad9-88fa-4e27-8381-cc90233be472"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c2f0074-365c-49b6-b65f-079fde930a80");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3143654c-0b46-4d0a-b437-eccea597348d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "673de5d9-701d-4299-a62a-92997678d55b");

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("019b17be-5052-4827-b4d9-72d81f3b4e79"), "travel", "London", new DateTime(2023, 4, 20, 23, 22, 34, 67, DateTimeKind.Local).AddTicks(6990), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("2a6a840b-cad9-4be6-a88e-50fc8e1592ef"), "drinks", "London", new DateTime(2023, 1, 20, 23, 22, 34, 67, DateTimeKind.Local).AddTicks(6972), "Activity 4 months in future", "Future Activity 4", "Yet another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("6387c951-c624-4544-941b-114e677bba2f"), "culture", "London", new DateTime(2022, 10, 20, 23, 22, 34, 67, DateTimeKind.Local).AddTicks(6960), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("6e730961-c8de-4e08-8d14-9bcc3d8bda0c"), "drinks", "London", new DateTime(2023, 2, 20, 23, 22, 34, 67, DateTimeKind.Local).AddTicks(6979), "Activity 5 months in future", "Future Activity 5", "Just another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("7ae35dd2-b4cf-4aa4-ac08-5e7a08565449"), "drinks", "London", new DateTime(2022, 12, 20, 23, 22, 34, 67, DateTimeKind.Local).AddTicks(6968), "Activity 3 months in future", "Future Activity 3", "Another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("81d552fe-c2f4-4dd8-9b81-40d5b93ac230"), "drinks", "London", new DateTime(2022, 7, 20, 23, 22, 34, 67, DateTimeKind.Local).AddTicks(6919), "Activity 2 months ago", "Past Activity 1", "Pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("8d082f70-e5d5-4e70-8f03-c96dcc81617f"), "music", "London", new DateTime(2022, 11, 20, 23, 22, 34, 67, DateTimeKind.Local).AddTicks(6964), "Activity 2 months in future", "Future Activity 2", "O2 Arena" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("dc3a0b5a-45ee-43c7-8d3a-da61139e218b"), "culture", "Paris", new DateTime(2022, 8, 20, 23, 22, 34, 67, DateTimeKind.Local).AddTicks(6956), "Activity 1 month ago", "Past Activity 2", "Louvre" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("e11e5657-8036-428f-b68a-a581b9defe5c"), "film", "London", new DateTime(2023, 5, 20, 23, 22, 34, 67, DateTimeKind.Local).AddTicks(6995), "Activity 8 months in future", "Future Activity 8", "Cinema" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("ee86c7ce-c443-4612-9423-9141010b5b7a"), "music", "London", new DateTime(2023, 3, 20, 23, 22, 34, 67, DateTimeKind.Local).AddTicks(6983), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" });
        }
    }
}
