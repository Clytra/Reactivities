using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class JoinTableConfig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "ActivityAttendees",
                columns: table => new
                {
                    AppUserId = table.Column<string>(type: "TEXT", nullable: false),
                    ActivityId = table.Column<Guid>(type: "TEXT", nullable: false),
                    IsHost = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityAttendees", x => new { x.AppUserId, x.ActivityId });
                    table.ForeignKey(
                        name: "FK_ActivityAttendees_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityAttendees_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("0a8579c0-fef4-4f89-9d88-4745715fb19b"), "travel", "London", new DateTime(2023, 4, 21, 14, 3, 49, 926, DateTimeKind.Local).AddTicks(6514), "Activity 2 months ago", "Future Activity 7", "Somewhere on the Thames" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("1b447095-a91a-435d-b6ed-6e5d924d8e7e"), "film", "London", new DateTime(2023, 5, 21, 14, 3, 49, 926, DateTimeKind.Local).AddTicks(6528), "Activity 8 months in future", "Future Activity 8", "Cinema" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("2987bf1e-a052-450a-ada7-aa50bcea805d"), "culture", "Paris", new DateTime(2022, 8, 21, 14, 3, 49, 926, DateTimeKind.Local).AddTicks(6409), "Activity 1 month ago", "Past Activity 2", "Louvre" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("3ae32160-d002-416c-9758-51f448f039bd"), "drinks", "London", new DateTime(2022, 7, 21, 14, 3, 49, 926, DateTimeKind.Local).AddTicks(6363), "Activity 2 months ago", "Past Activity 1", "Pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("4df81821-df70-4f0e-a010-48b54fb8f3d2"), "culture", "London", new DateTime(2022, 10, 21, 14, 3, 49, 926, DateTimeKind.Local).AddTicks(6418), "Activity 1 month in future", "Future Activity 1", "Natural History Museum" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("a6ab5139-bb1d-4cd2-946d-fe953f03f958"), "music", "London", new DateTime(2023, 3, 21, 14, 3, 49, 926, DateTimeKind.Local).AddTicks(6487), "Activity 6 months in future", "Future Activity 6", "Roundhouse Camden" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("bbca5c1c-ca08-4932-8a11-454c48c4f8c5"), "drinks", "London", new DateTime(2023, 2, 21, 14, 3, 49, 926, DateTimeKind.Local).AddTicks(6454), "Activity 5 months in future", "Future Activity 5", "Just another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("d675cff8-cd92-4a7b-bf4d-16045eede1f7"), "drinks", "London", new DateTime(2022, 12, 21, 14, 3, 49, 926, DateTimeKind.Local).AddTicks(6441), "Activity 3 months in future", "Future Activity 3", "Another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("e460e2cf-c108-4ce0-ad83-cb1171a34d96"), "drinks", "London", new DateTime(2023, 1, 21, 14, 3, 49, 926, DateTimeKind.Local).AddTicks(6447), "Activity 4 months in future", "Future Activity 4", "Yet another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "Title", "Venue" },
                values: new object[] { new Guid("ec07f3b8-fd9b-49e7-b8cb-abea3130c920"), "music", "London", new DateTime(2022, 11, 21, 14, 3, 49, 926, DateTimeKind.Local).AddTicks(6433), "Activity 2 months in future", "Future Activity 2", "O2 Arena" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0523b1e3-0407-4f50-87ae-76c89132868f", 0, "test", "ac6ba0fe-6686-465c-93fe-c601e9a5ec64", "Tomek", "tomek@test.com", false, false, null, null, null, "P@@sword", null, false, "30b15ffe-81fa-4bf4-ac5b-0d3de1e033f1", false, "tomek" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "055583da-2175-48b1-a30d-84dfbafc98bd", 0, "test", "7ebf8554-b5c5-42fe-a94d-5df7d413b692", "Kasia", "kasia@test.com", false, false, null, null, null, "P@@sword", null, false, "fa307f34-ccad-4b17-99e9-4b9a17f6f830", false, "kasia" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9d2ffd26-bb7f-4e8d-a8a6-f0f6f6890ede", 0, "test", "46c49afb-6a1e-4e9b-9662-2d3502325bec", "Jan", "jan@test.com", false, false, null, null, null, "P@@sword", null, false, "e57df806-778d-4539-b720-dedafd538eb9", false, "jan" });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityAttendees_ActivityId",
                table: "ActivityAttendees",
                column: "ActivityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityAttendees");

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("0a8579c0-fef4-4f89-9d88-4745715fb19b"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("1b447095-a91a-435d-b6ed-6e5d924d8e7e"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("2987bf1e-a052-450a-ada7-aa50bcea805d"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("3ae32160-d002-416c-9758-51f448f039bd"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("4df81821-df70-4f0e-a010-48b54fb8f3d2"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("a6ab5139-bb1d-4cd2-946d-fe953f03f958"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("bbca5c1c-ca08-4932-8a11-454c48c4f8c5"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("d675cff8-cd92-4a7b-bf4d-16045eede1f7"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("e460e2cf-c108-4ce0-ad83-cb1171a34d96"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("ec07f3b8-fd9b-49e7-b8cb-abea3130c920"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0523b1e3-0407-4f50-87ae-76c89132868f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "055583da-2175-48b1-a30d-84dfbafc98bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9d2ffd26-bb7f-4e8d-a8a6-f0f6f6890ede");

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
    }
}
