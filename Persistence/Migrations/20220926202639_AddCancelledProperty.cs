using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class AddCancelledProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<bool>(
                name: "IsCancelled",
                table: "Activities",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "IsCancelled", "Title", "Venue" },
                values: new object[] { new Guid("0d89d38c-e029-4616-a6f1-84e04df64798"), "drinks", "London", new DateTime(2023, 2, 26, 22, 26, 38, 935, DateTimeKind.Local).AddTicks(4959), "Activity 5 months in future", false, "Future Activity 5", "Just another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "IsCancelled", "Title", "Venue" },
                values: new object[] { new Guid("196517ef-5980-4feb-81c7-daaf0c1e6a7a"), "culture", "London", new DateTime(2022, 10, 26, 22, 26, 38, 935, DateTimeKind.Local).AddTicks(4935), "Activity 1 month in future", false, "Future Activity 1", "Natural History Museum" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "IsCancelled", "Title", "Venue" },
                values: new object[] { new Guid("7cba65b7-1469-4263-abcc-a920f7b2240f"), "drinks", "London", new DateTime(2023, 1, 26, 22, 26, 38, 935, DateTimeKind.Local).AddTicks(4949), "Activity 4 months in future", false, "Future Activity 4", "Yet another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "IsCancelled", "Title", "Venue" },
                values: new object[] { new Guid("aa02e078-7b54-4bdc-a884-0a86304e9ecc"), "drinks", "London", new DateTime(2022, 12, 26, 22, 26, 38, 935, DateTimeKind.Local).AddTicks(4944), "Activity 3 months in future", false, "Future Activity 3", "Another pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "IsCancelled", "Title", "Venue" },
                values: new object[] { new Guid("cfe78eb8-576d-4e83-b141-99b8ef5f9a1a"), "culture", "Paris", new DateTime(2022, 8, 26, 22, 26, 38, 935, DateTimeKind.Local).AddTicks(4929), "Activity 1 month ago", false, "Past Activity 2", "Louvre" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "IsCancelled", "Title", "Venue" },
                values: new object[] { new Guid("e53ad2fe-78ef-4b94-b14f-ace7af1d26ae"), "drinks", "London", new DateTime(2022, 7, 26, 22, 26, 38, 935, DateTimeKind.Local).AddTicks(4863), "Activity 2 months ago", false, "Past Activity 1", "Pub" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "IsCancelled", "Title", "Venue" },
                values: new object[] { new Guid("f2d6b8ef-1451-4601-b70e-7db81d360ac5"), "travel", "London", new DateTime(2023, 4, 26, 22, 26, 38, 935, DateTimeKind.Local).AddTicks(4968), "Activity 2 months ago", false, "Future Activity 7", "Somewhere on the Thames" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "IsCancelled", "Title", "Venue" },
                values: new object[] { new Guid("f85846d5-1245-420a-8fb2-4f6f44ed3cbf"), "music", "London", new DateTime(2023, 3, 26, 22, 26, 38, 935, DateTimeKind.Local).AddTicks(4963), "Activity 6 months in future", false, "Future Activity 6", "Roundhouse Camden" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "IsCancelled", "Title", "Venue" },
                values: new object[] { new Guid("f94124b9-912f-44be-b6f3-77038e1af2e3"), "film", "London", new DateTime(2023, 5, 26, 22, 26, 38, 935, DateTimeKind.Local).AddTicks(4973), "Activity 8 months in future", false, "Future Activity 8", "Cinema" });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "Category", "City", "Date", "Description", "IsCancelled", "Title", "Venue" },
                values: new object[] { new Guid("fe40075a-ae38-40fd-989d-9169571bf7c7"), "music", "London", new DateTime(2022, 11, 26, 22, 26, 38, 935, DateTimeKind.Local).AddTicks(4940), "Activity 2 months in future", false, "Future Activity 2", "O2 Arena" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "27842560-67c7-43d6-bf92-37b84f95d0b9", 0, "test", "92752128-f07b-476e-9002-eb11b8ba913b", "Tomek", "tomek@test.com", false, false, null, null, null, "P@@sword", null, false, "f74c87fa-af6d-48ac-ab45-118a6959f8c9", false, "tomek" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3679b6b7-2092-4fd6-9103-33c07420293f", 0, "test", "8ca66306-7794-4bcc-920b-72c2392aaf53", "Kasia", "kasia@test.com", false, false, null, null, null, "P@@sword", null, false, "bd48738d-c82d-472f-99cc-5e701c54b13d", false, "kasia" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Bio", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7f51d10a-80b4-4260-b86e-f35cfd1f62c4", 0, "test", "747ffdb2-e746-441d-9c65-a4a46182a315", "Jan", "jan@test.com", false, false, null, null, null, "P@@sword", null, false, "31e51bea-8eb6-42e6-9744-18c5d3dd49fc", false, "jan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("0d89d38c-e029-4616-a6f1-84e04df64798"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("196517ef-5980-4feb-81c7-daaf0c1e6a7a"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("7cba65b7-1469-4263-abcc-a920f7b2240f"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("aa02e078-7b54-4bdc-a884-0a86304e9ecc"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("cfe78eb8-576d-4e83-b141-99b8ef5f9a1a"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("e53ad2fe-78ef-4b94-b14f-ace7af1d26ae"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("f2d6b8ef-1451-4601-b70e-7db81d360ac5"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("f85846d5-1245-420a-8fb2-4f6f44ed3cbf"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("f94124b9-912f-44be-b6f3-77038e1af2e3"));

            migrationBuilder.DeleteData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: new Guid("fe40075a-ae38-40fd-989d-9169571bf7c7"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27842560-67c7-43d6-bf92-37b84f95d0b9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3679b6b7-2092-4fd6-9103-33c07420293f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f51d10a-80b4-4260-b86e-f35cfd1f62c4");

            migrationBuilder.DropColumn(
                name: "IsCancelled",
                table: "Activities");

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
        }
    }
}
