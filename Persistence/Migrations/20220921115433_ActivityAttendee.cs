using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class ActivityAttendee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ActivityAppUser",
                columns: table => new
                {
                    ActivitiesId = table.Column<Guid>(type: "TEXT", nullable: false),
                    AttendeesId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityAppUser", x => new { x.ActivitiesId, x.AttendeesId });
                    table.ForeignKey(
                        name: "FK_ActivityAppUser_Activities_ActivitiesId",
                        column: x => x.ActivitiesId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityAppUser_AspNetUsers_AttendeesId",
                        column: x => x.AttendeesId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("0b4e8a56-67ac-40ca-b3b0-fcab7615b4ee"), "film", "London", new DateTime(2023, 5, 21, 13, 54, 31, 622, DateTimeKind.Local).AddTicks(2909), "Activity 8 months in future", "Future Activity 8", "Cinema" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("33648ada-f4b0-4e70-b7a1-769f02e86a44"), "culture", "Paris", new DateTime(2022, 8, 21, 13, 54, 31, 622, DateTimeKind.Local).AddTicks(2815), "Activity 1 month ago", "Past Activity 2", "Louvre" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("4a6125fc-9ce0-451e-afb9-c6fe623006ef"), "drinks", "London", new DateTime(2023, 2, 21, 13, 54, 31, 622, DateTimeKind.Local).AddTicks(2883), "Activity 5 months in future", "Future Activity 5", "Just another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("8171db48-d8c8-401c-ba50-7652efab25fc"), "music", "London", new DateTime(2023, 3, 21, 13, 54, 31, 622, DateTimeKind.Local).AddTicks(2892), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("909b3c8a-cb7c-494b-abfb-c629fced9335"), "drinks", "London", new DateTime(2023, 1, 21, 13, 54, 31, 622, DateTimeKind.Local).AddTicks(2874), "Activity 4 months in future", "Future Activity 4", "Yet another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("a4688923-84fb-496a-bbbb-af1e29de0e9c"), "drinks", "London", new DateTime(2022, 7, 21, 13, 54, 31, 622, DateTimeKind.Local).AddTicks(2760), "Activity 2 months ago", "Past Activity 1", "Pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("b564c6ad-1a81-4b58-b9f9-87de421f2bfc"), "travel", "London", new DateTime(2023, 4, 21, 13, 54, 31, 622, DateTimeKind.Local).AddTicks(2901), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("b8a8a6a9-e2b9-427b-8906-f46a8fa5210e"), "culture", "London", new DateTime(2022, 10, 21, 13, 54, 31, 622, DateTimeKind.Local).AddTicks(2829), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("d7922dbb-7b49-4e1c-9a7e-16a0bec1ecaf"), "music", "London", new DateTime(2022, 11, 21, 13, 54, 31, 622, DateTimeKind.Local).AddTicks(2853), "Activity 2 months in future", "Future Activity 2", "O2 Arena" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("e7a86c7a-2997-4d3a-bc65-86ce2e65ed77"), "drinks", "London", new DateTime(2022, 12, 21, 13, 54, 31, 622, DateTimeKind.Local).AddTicks(2865), "Activity 3 months in future", "Future Activity 3", "Another pub" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "87c7434c-d5ea-4eaa-90a0-8666b8794f14", 0, "test", "a36c3ce0-d9ec-4a68-b961-ae74820abcc4", "Jan", "jan@test.com", false, false, null, null, null, "P@@sword", null, false, "51c7c785-ace2-4edc-ac73-6044bf0279c3", false, "jan" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bceeeec4-ca52-47b0-b593-e0a1dac5c1c1", 0, "test", "687c378f-0d59-4ce5-9a2c-87452d46760e", "Tomek", "tomek@test.com", false, false, null, null, null, "P@@sword", null, false, "3da18645-bda0-4a20-8e88-a91289d1a55f", false, "tomek" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "eafd1b7e-a955-4a91-b038-8ce8e308e70e", 0, "test", "7fdac27c-0c00-442f-99c0-d3441f4e4fe0", "Kasia", "kasia@test.com", false, false, null, null, null, "P@@sword", null, false, "d77d7136-888c-49b3-b9ac-aed73b221fbe", false, "kasia" });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityAppUser_AttendeesId",
                table: "ActivityAppUser",
                column: "AttendeesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityAppUser");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("0b4e8a56-67ac-40ca-b3b0-fcab7615b4ee"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("33648ada-f4b0-4e70-b7a1-769f02e86a44"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("4a6125fc-9ce0-451e-afb9-c6fe623006ef"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("8171db48-d8c8-401c-ba50-7652efab25fc"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("909b3c8a-cb7c-494b-abfb-c629fced9335"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("a4688923-84fb-496a-bbbb-af1e29de0e9c"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b564c6ad-1a81-4b58-b9f9-87de421f2bfc"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("b8a8a6a9-e2b9-427b-8906-f46a8fa5210e"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("d7922dbb-7b49-4e1c-9a7e-16a0bec1ecaf"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("e7a86c7a-2997-4d3a-bc65-86ce2e65ed77"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "87c7434c-d5ea-4eaa-90a0-8666b8794f14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bceeeec4-ca52-47b0-b593-e0a1dac5c1c1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eafd1b7e-a955-4a91-b038-8ce8e308e70e");

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
    }
}
