using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class AddPasswords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("054c82cf-e72f-4559-a07b-0e6277e063b2"), "drinks", "London", new DateTime(2022, 12, 21, 12, 10, 7, 228, DateTimeKind.Local).AddTicks(416), "Activity 3 months in future", "Future Activity 3", "Another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("141d0229-b85e-479f-9563-9c2b527f5fb8"), "culture", "Paris", new DateTime(2022, 8, 21, 12, 10, 7, 228, DateTimeKind.Local).AddTicks(402), "Activity 1 month ago", "Past Activity 2", "Louvre" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("1a136b89-2815-46e7-a93a-449d675f34bf"), "drinks", "London", new DateTime(2023, 2, 21, 12, 10, 7, 228, DateTimeKind.Local).AddTicks(429), "Activity 5 months in future", "Future Activity 5", "Just another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("20a0231a-4f1f-4df6-a37e-3b124c1a64ac"), "travel", "London", new DateTime(2023, 4, 21, 12, 10, 7, 228, DateTimeKind.Local).AddTicks(436), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("2b1da20b-3366-428d-8672-af0b1cbf0bb7"), "music", "London", new DateTime(2022, 11, 21, 12, 10, 7, 228, DateTimeKind.Local).AddTicks(412), "Activity 2 months in future", "Future Activity 2", "O2 Arena" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("346d0dba-cd95-4356-a8a3-d5dfe5b60828"), "drinks", "London", new DateTime(2023, 1, 21, 12, 10, 7, 228, DateTimeKind.Local).AddTicks(424), "Activity 4 months in future", "Future Activity 4", "Yet another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("5712c5d7-f179-41f5-b23a-790176df1e1e"), "drinks", "London", new DateTime(2022, 7, 21, 12, 10, 7, 228, DateTimeKind.Local).AddTicks(334), "Activity 2 months ago", "Past Activity 1", "Pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("69acbe26-6880-478a-bf6a-e448446d8f13"), "culture", "London", new DateTime(2022, 10, 21, 12, 10, 7, 228, DateTimeKind.Local).AddTicks(408), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("842bbc79-8bf2-435c-9577-f71e47d5f105"), "music", "London", new DateTime(2023, 3, 21, 12, 10, 7, 228, DateTimeKind.Local).AddTicks(432), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("d417ba71-d3e3-4734-86b8-acba9f017a8b"), "film", "London", new DateTime(2023, 5, 21, 12, 10, 7, 228, DateTimeKind.Local).AddTicks(440), "Activity 8 months in future", "Future Activity 8", "Cinema" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "30f99dfa-3889-4712-a70d-25785375eb6f", 0, "test", "61a2d05d-23bd-4398-80b9-2867c2ae9852", "Kasia", "kasia@test.com", false, false, null, null, null, "P@@sword", null, false, "120bd698-740a-479a-a56c-62a94ce7c6b4", false, "kasia" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ca4a47b4-bded-4fa5-8eca-6d368c28b754", 0, "test", "4956181f-3229-45d0-81a6-38af46d46356", "Tomek", "tomek@test.com", false, false, null, null, null, "P@@sword", null, false, "dbb35f48-bf22-462b-9492-02fdcbd8f446", false, "tomek" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "fecb2c37-4ea3-4dbf-8c27-819e619981b5", 0, "test", "32c8059a-8c9f-4b78-ac61-92fb91fb05a6", "Jan", "jan@test.com", false, false, null, null, null, "P@@sword", null, false, "d6f2fbe0-d81e-43ed-97f3-7bc3992d309b", false, "jan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("054c82cf-e72f-4559-a07b-0e6277e063b2"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("141d0229-b85e-479f-9563-9c2b527f5fb8"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("1a136b89-2815-46e7-a93a-449d675f34bf"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("20a0231a-4f1f-4df6-a37e-3b124c1a64ac"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("2b1da20b-3366-428d-8672-af0b1cbf0bb7"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("346d0dba-cd95-4356-a8a3-d5dfe5b60828"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("5712c5d7-f179-41f5-b23a-790176df1e1e"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("69acbe26-6880-478a-bf6a-e448446d8f13"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("842bbc79-8bf2-435c-9577-f71e47d5f105"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("d417ba71-d3e3-4734-86b8-acba9f017a8b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30f99dfa-3889-4712-a70d-25785375eb6f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca4a47b4-bded-4fa5-8eca-6d368c28b754");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fecb2c37-4ea3-4dbf-8c27-819e619981b5");

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
    }
}
