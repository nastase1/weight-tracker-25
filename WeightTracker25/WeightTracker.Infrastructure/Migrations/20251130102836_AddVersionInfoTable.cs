using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeightTracker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddVersionInfoTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("0083a282-78d9-409c-81e4-ed383deba061"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("02dd1769-2bc7-4d74-8860-8fc1a35480ad"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("062cf1a9-cb8f-4588-96f9-9bb5d9d0ac2d"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("118c21a6-7d49-4398-aca9-c259784b5383"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("1a1da052-afb9-4379-8523-5f9b3ca8f6e8"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("1d8d0254-ef9f-47f8-8d48-c36e40e458ec"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("1eae73e2-3e8b-4855-94c1-92d24aca6327"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("1f1d7f44-83a4-4b57-9c38-0e8578a5ef0a"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("27641ca1-2520-493e-aaca-71383c52ca6c"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("27bbffbe-e285-494c-85d9-ccd437b307c2"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("2d5ec850-9f9b-4e90-84fe-27a740fb15fa"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("2f4fdfa7-83c4-45d7-b387-0af4cd96f31c"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("3cfea8da-8406-427e-a1f7-3fa0b6f3a6b3"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("3e3bac21-51ed-4496-b632-628edf087514"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("44713c4c-6829-48a5-aee9-d655a9abfa3f"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("4bdb3638-8d95-46b9-ae0a-9b6cba062d31"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("5995e7ef-b3a9-484e-aa2b-e899103e115b"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("5cfde34d-f58c-442f-9040-1b6ed94c58db"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("5dfc9967-c37c-4d4c-8af3-b54740ba23e0"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("5f154f3d-cc4d-419e-9783-6bf5201fab97"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("60b201df-777d-40ae-89bb-0987e1282508"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("610f9cf9-357a-4f9f-a88b-039b3d91b577"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("6c206bdc-7514-49c1-8f0f-1786bf8ee8c7"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("75db95f7-f8d6-4d11-8aff-07087602f089"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("770348a5-e689-40e9-96bb-e25b92e62373"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("78552527-e249-44c3-bee2-211fab51fcb4"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("7c570917-f223-4a46-b9c5-96ab83afb1de"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("7da30afa-1583-4d42-ba55-82201df2e405"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("813ef424-cb3c-479d-ac15-179f6d1c30a6"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("853915b9-4cc9-4888-89f8-121ab4960f81"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("8666c2ea-76d3-4c1b-b2d9-6341492be82c"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("8828f16f-bdfd-4ca6-a343-361193b5fa06"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("8947479d-c6fd-4ed1-ad61-310342cb6e44"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("93ae7c44-29ed-4296-b299-fe4fd00d35df"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("9ac3e71e-019d-4efb-9478-a3c798a27051"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("9baf8cb0-fa20-4134-ac9c-3cfda31a918b"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("a57c51e8-94d8-43ab-93a8-e66a8640a886"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("ac272af3-93fb-4010-9fb5-e05b512f1346"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("ac7c381c-dd6e-431b-8906-448c25c2a07a"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("ae416936-b4da-433a-a2be-7d1ea810e05f"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("b0370448-cd39-41f5-8488-c8e218a55e38"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("b1569284-6277-4aad-8e67-52eac6bb09f3"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("b6e4ad78-df00-4707-a99d-7e1bcf55adfd"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("ba878779-1fe3-4cae-a410-cfe4325b37e4"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("bb5275cf-6393-436f-8b03-2e159840cf87"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("bcfa1e63-25a3-4847-9c28-4d218743cdf3"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("c9c4cf23-c1dd-4dff-bce0-34ae83f063c8"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("cb6dfaa6-e9d5-45f3-8f08-96a4d2619acf"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("d6254ff5-09b2-4831-b584-511ceee354a3"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("dea02f65-67ca-40bd-845e-79f5312ec8cd"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("e8175413-4f75-46eb-ba25-c236e4678cf4"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("e9d70b83-48cf-49c6-8684-a2aa584c41db"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("eac43175-e048-405a-a798-1abb7be60cd0"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("eb5ce850-0501-47b6-aafa-4effc5d4b485"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("ee3974e9-46fc-4cf5-82be-987256e4f5ce"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("f0117242-dc66-479e-b2fb-0486aca4dc1b"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("f10e4ca3-91ac-463d-8e39-1f426e44cee9"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("f2d99120-68ff-45a0-a8f7-8fa063eb6f06"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("fbf32913-23b7-4586-b588-a9c9096282b4"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("fcaa68ad-07e3-46d3-ae2f-f144fa309c1b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b5c63ffc-d843-4909-9a59-3254b3be73b5"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("4b8e0024-46e3-49cd-ba14-c96224055200"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("e0ad6390-5c2e-4304-8f1c-576799d519bf"));

            migrationBuilder.CreateTable(
                name: "VersionHistory",
                columns: table => new
                {
                    VersionInfoId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ApplicationVersion = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    DatabaseVersion = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    DeployedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Environment = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    BuildNumber = table.Column<int>(type: "INTEGER", nullable: false),
                    CommitSha = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    HostName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    Notes = table.Column<string>(type: "TEXT", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VersionHistory", x => x.VersionInfoId);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "DeletedAt", "Email", "PasswordHash", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { new Guid("04cfe11d-8bdf-4cc7-b4ac-c9304be7f9d3"), new DateTime(2025, 9, 30, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(8308), null, "mike.johnson@example.com", "$2a$11$SDUcLaLfkzQL7OlzLhlhSORCX8VNsMiNdOrkx81UzuCILr9ugv5X.", null, "mike_johnson" },
                    { new Guid("4fb446ba-9962-4aae-8f59-8b296d22b949"), new DateTime(2025, 7, 30, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(8305), null, "jane.smith@example.com", "$2a$11$SDUcLaLfkzQL7OlzLhlhSORCX8VNsMiNdOrkx81UzuCILr9ugv5X.", null, "jane_smith" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "DeletedAt", "Email", "IsAdmin", "PasswordHash", "UpdatedAt", "Username" },
                values: new object[] { new Guid("c4248a1e-a005-4896-bc0f-7025e8afde47"), new DateTime(2025, 10, 30, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(8478), null, "admin@email.com", true, "$2a$11$SDUcLaLfkzQL7OlzLhlhSORCX8VNsMiNdOrkx81UzuCILr9ugv5X.", null, "admin_user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "DeletedAt", "Email", "PasswordHash", "UpdatedAt", "Username" },
                values: new object[] { new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), new DateTime(2025, 5, 30, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(8290), null, "john.doe@example.com", "$2a$11$SDUcLaLfkzQL7OlzLhlhSORCX8VNsMiNdOrkx81UzuCILr9ugv5X.", null, "john_doe" });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "RecordId", "CreatedAt", "DeletedAt", "Height", "RecordDate", "UpdatedAt", "UserId", "Weight" },
                values: new object[,]
                {
                    { new Guid("01736a3e-a98d-4fd8-ac3e-09cdf673f4ea"), new DateTime(2025, 11, 11, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, 182m, new DateTime(2025, 11, 11, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, new Guid("04cfe11d-8bdf-4cc7-b4ac-c9304be7f9d3"), 90.66m },
                    { new Guid("0311bfc2-7c34-410e-8979-ecc9393fed71"), new DateTime(2025, 10, 16, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, 165m, new DateTime(2025, 10, 16, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, new Guid("4fb446ba-9962-4aae-8f59-8b296d22b949"), 69.50m },
                    { new Guid("0c9b90c6-4ce3-4f65-8835-53e1312eb811"), new DateTime(2025, 11, 21, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, 165m, new DateTime(2025, 11, 21, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, new Guid("4fb446ba-9962-4aae-8f59-8b296d22b949"), 72.09m },
                    { new Guid("0f42f30d-703d-4fc8-b22b-fb1b14be5287"), new DateTime(2025, 11, 19, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, 182m, new DateTime(2025, 11, 19, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, new Guid("04cfe11d-8bdf-4cc7-b4ac-c9304be7f9d3"), 86.61m },
                    { new Guid("104b9adf-ad35-4ce5-be37-6a37b11bee5d"), new DateTime(2025, 10, 12, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, 165m, new DateTime(2025, 10, 12, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, new Guid("4fb446ba-9962-4aae-8f59-8b296d22b949"), 69.04m },
                    { new Guid("247a91ca-b6a1-4133-8eb8-91fb54a9f8d3"), new DateTime(2025, 11, 7, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 11, 7, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 75.70m },
                    { new Guid("27f0ac37-663d-45b0-92eb-12f5bcc369a8"), new DateTime(2025, 9, 17, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 9, 17, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 82.06m },
                    { new Guid("360253d6-44db-481f-aea8-a2a0bffed02b"), new DateTime(2025, 11, 10, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 11, 10, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 74.38m },
                    { new Guid("372541a5-f2ee-4217-ba96-fd7937819a2a"), new DateTime(2025, 11, 13, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, 165m, new DateTime(2025, 11, 13, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, new Guid("4fb446ba-9962-4aae-8f59-8b296d22b949"), 71.18m },
                    { new Guid("40eac4c9-b61e-4949-9ed5-f896f1774795"), new DateTime(2025, 11, 5, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, 165m, new DateTime(2025, 11, 5, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, new Guid("4fb446ba-9962-4aae-8f59-8b296d22b949"), 71.77m },
                    { new Guid("4678745d-c623-475e-8acd-6a353b7305e8"), new DateTime(2025, 11, 1, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 11, 1, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 76.33m },
                    { new Guid("4a0d3af8-063a-420a-923e-12f07a8a1788"), new DateTime(2025, 10, 8, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, 165m, new DateTime(2025, 10, 8, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, new Guid("4fb446ba-9962-4aae-8f59-8b296d22b949"), 68.59m },
                    { new Guid("5374fbc4-c0af-4d0a-8e04-120f267990a4"), new DateTime(2025, 9, 29, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 9, 29, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 80.80m },
                    { new Guid("54cd4972-ea9f-4306-a541-5176db5edfa7"), new DateTime(2025, 11, 5, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, 182m, new DateTime(2025, 11, 5, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, new Guid("04cfe11d-8bdf-4cc7-b4ac-c9304be7f9d3"), 91.83m },
                    { new Guid("54f3a369-cab5-4f3a-b295-7e0ddbe9fbee"), new DateTime(2025, 10, 24, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, 165m, new DateTime(2025, 10, 24, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, new Guid("4fb446ba-9962-4aae-8f59-8b296d22b949"), 70.40m },
                    { new Guid("55537c0d-e640-4dc9-bb74-bd12c7ecb52b"), new DateTime(2025, 11, 19, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 11, 19, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 72.44m },
                    { new Guid("56dae0f0-c48c-4c96-a9e1-59f9fc8f1d41"), new DateTime(2025, 11, 16, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 11, 16, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 73.75m },
                    { new Guid("5e801f1e-c74d-4418-a89e-c86e9fcfe08c"), new DateTime(2025, 11, 17, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, 165m, new DateTime(2025, 11, 17, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, new Guid("4fb446ba-9962-4aae-8f59-8b296d22b949"), 71.63m },
                    { new Guid("61c30cff-c920-412d-a4e3-a7e5411f6364"), new DateTime(2025, 10, 20, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 10, 20, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 77.59m },
                    { new Guid("6a9a6eaf-d7b1-4c63-9053-f40555ff3688"), new DateTime(2025, 10, 2, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 10, 2, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 81.48m },
                    { new Guid("70bf7613-2d84-4f48-ba01-d36556afb384"), new DateTime(2025, 10, 4, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, 165m, new DateTime(2025, 10, 4, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, new Guid("4fb446ba-9962-4aae-8f59-8b296d22b949"), 68.13m },
                    { new Guid("76a9b4de-7c07-4abf-817b-126b4636dc60"), new DateTime(2025, 9, 8, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 9, 8, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 84.01m },
                    { new Guid("779dc9e5-a548-471c-8543-2bfbf261ce10"), new DateTime(2025, 11, 21, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, 182m, new DateTime(2025, 11, 21, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, new Guid("04cfe11d-8bdf-4cc7-b4ac-c9304be7f9d3"), 86.23m },
                    { new Guid("797c6723-892c-48a3-8170-c066c2c39847"), new DateTime(2025, 10, 23, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 10, 23, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 78.27m },
                    { new Guid("7cf54841-776b-474e-b14b-125a06e041ee"), new DateTime(2025, 10, 26, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 10, 26, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 76.96m },
                    { new Guid("7f921c8b-616e-4bb5-ba98-099a93794d4e"), new DateTime(2025, 10, 17, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 10, 17, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 78.91m },
                    { new Guid("81780cdc-2a07-4187-b9ac-dac40779550c"), new DateTime(2025, 9, 26, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 9, 26, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 82.11m },
                    { new Guid("833fb3e7-fff5-46af-aaca-c9ebd80fcbc7"), new DateTime(2025, 10, 14, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 10, 14, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 78.22m },
                    { new Guid("83e2658f-30dd-456f-9901-791c36e16fa1"), new DateTime(2025, 8, 30, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 8, 30, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 85.95m },
                    { new Guid("85373136-7c0f-49bb-8b94-e9f3cab49381"), new DateTime(2025, 11, 25, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 11, 25, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 71.80m },
                    { new Guid("87bd51c9-bd2d-403a-8198-c7d4eaba1c58"), new DateTime(2025, 9, 5, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 9, 5, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 85.32m },
                    { new Guid("93dc53b7-d302-43bc-b156-d5373cf58dd4"), new DateTime(2025, 10, 30, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, 182m, new DateTime(2025, 10, 30, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, new Guid("04cfe11d-8bdf-4cc7-b4ac-c9304be7f9d3"), 92.99m },
                    { new Guid("9416b23f-448d-45f1-ab43-385c042f9cc4"), new DateTime(2025, 11, 25, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, 182m, new DateTime(2025, 11, 25, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, new Guid("04cfe11d-8bdf-4cc7-b4ac-c9304be7f9d3"), 85.45m },
                    { new Guid("9af545c5-c874-4535-b1ba-a709594ae38b"), new DateTime(2025, 11, 1, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, 182m, new DateTime(2025, 11, 1, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, new Guid("04cfe11d-8bdf-4cc7-b4ac-c9304be7f9d3"), 92.60m },
                    { new Guid("a00685ed-0a91-4345-b82f-87e10c792885"), new DateTime(2025, 10, 11, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 10, 11, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 79.54m },
                    { new Guid("a59fa099-58c3-40f7-aa5a-c1af2ea6bbb8"), new DateTime(2025, 11, 7, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, 182m, new DateTime(2025, 11, 7, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, new Guid("04cfe11d-8bdf-4cc7-b4ac-c9304be7f9d3"), 91.44m },
                    { new Guid("a78beff4-f1d4-4a9c-9ae3-290ba5ef02c2"), new DateTime(2025, 11, 23, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, 182m, new DateTime(2025, 11, 23, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, new Guid("04cfe11d-8bdf-4cc7-b4ac-c9304be7f9d3"), 85.84m },
                    { new Guid("a93039d7-7c64-4730-8e44-c936704eebe2"), new DateTime(2025, 9, 20, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 9, 20, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 82.74m },
                    { new Guid("b154aec4-f1f4-4d37-96a9-725d0765f9f2"), new DateTime(2025, 10, 29, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 10, 29, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 75.64m },
                    { new Guid("b2780c90-8a3a-436e-90ca-e6593d2c8b9f"), new DateTime(2025, 11, 15, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, 182m, new DateTime(2025, 11, 15, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, new Guid("04cfe11d-8bdf-4cc7-b4ac-c9304be7f9d3"), 89.89m },
                    { new Guid("b7603c2d-f869-4f8c-b0f1-b79bad3c7e78"), new DateTime(2025, 11, 25, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, 165m, new DateTime(2025, 11, 25, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, new Guid("4fb446ba-9962-4aae-8f59-8b296d22b949"), 72.54m },
                    { new Guid("b76a9b6a-7b93-4a74-9952-645b5a15c7a6"), new DateTime(2025, 9, 30, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, 165m, new DateTime(2025, 9, 30, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, new Guid("4fb446ba-9962-4aae-8f59-8b296d22b949"), 67.68m },
                    { new Guid("b8c87ce1-e411-4d10-b5a0-0db6aaf9f2a9"), new DateTime(2025, 11, 22, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 11, 22, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 73.12m },
                    { new Guid("c379fe1e-91bc-4bac-83e7-086ed24831b9"), new DateTime(2025, 11, 13, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, 182m, new DateTime(2025, 11, 13, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, new Guid("04cfe11d-8bdf-4cc7-b4ac-c9304be7f9d3"), 90.28m },
                    { new Guid("c7bb9611-6fdc-4680-8c69-b8589c1ba2ea"), new DateTime(2025, 9, 23, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 9, 23, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 81.43m },
                    { new Guid("ca215b05-8b44-4d4c-a410-1b85d073ed4b"), new DateTime(2025, 11, 13, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 11, 13, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 75.07m },
                    { new Guid("cd5bce8b-1b56-4403-94aa-2654e309fe1b"), new DateTime(2025, 11, 3, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, 182m, new DateTime(2025, 11, 3, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, new Guid("04cfe11d-8bdf-4cc7-b4ac-c9304be7f9d3"), 92.22m },
                    { new Guid("d1cf81f5-9613-4122-9cfe-72a94dd7dfc6"), new DateTime(2025, 11, 27, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, 182m, new DateTime(2025, 11, 27, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, new Guid("04cfe11d-8bdf-4cc7-b4ac-c9304be7f9d3"), 85.06m },
                    { new Guid("d46e4ed5-af9b-4bb3-8e6f-81dfc62f558b"), new DateTime(2025, 10, 5, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 10, 5, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 80.17m },
                    { new Guid("d654dd0a-eb76-4816-b337-80b62deffa46"), new DateTime(2025, 10, 20, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, 165m, new DateTime(2025, 10, 20, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, new Guid("4fb446ba-9962-4aae-8f59-8b296d22b949"), 69.95m },
                    { new Guid("dcb55d7b-d42a-4ab2-ba38-4d5d59f66f3f"), new DateTime(2025, 11, 9, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, 182m, new DateTime(2025, 11, 9, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, new Guid("04cfe11d-8bdf-4cc7-b4ac-c9304be7f9d3"), 91.05m },
                    { new Guid("df38bea7-1a8d-48a8-8f68-72314def0a15"), new DateTime(2025, 11, 9, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, 165m, new DateTime(2025, 11, 9, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, new Guid("4fb446ba-9962-4aae-8f59-8b296d22b949"), 70.72m },
                    { new Guid("e01c7163-06e2-4220-ba2d-47417b1f148b"), new DateTime(2025, 11, 1, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, 165m, new DateTime(2025, 11, 1, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, new Guid("4fb446ba-9962-4aae-8f59-8b296d22b949"), 71.31m },
                    { new Guid("e1f90509-51ba-4993-b709-4f2945b156dd"), new DateTime(2025, 9, 11, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 9, 11, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 84.69m },
                    { new Guid("e87c6b04-2eed-4fb7-9a2a-b70fd3467b86"), new DateTime(2025, 9, 2, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 9, 2, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 84.64m },
                    { new Guid("f0822e97-96a4-4d1e-83da-95fbdee14a28"), new DateTime(2025, 10, 28, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, 165m, new DateTime(2025, 10, 28, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9850), null, new Guid("4fb446ba-9962-4aae-8f59-8b296d22b949"), 70.86m },
                    { new Guid("f3905b21-a4be-4902-8404-872b4e480057"), new DateTime(2025, 10, 8, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 10, 8, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 78.85m },
                    { new Guid("f904e0e1-e627-4115-91ed-e77161dd3905"), new DateTime(2025, 11, 17, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, 182m, new DateTime(2025, 11, 17, 10, 28, 36, 53, DateTimeKind.Utc).AddTicks(62), null, new Guid("04cfe11d-8bdf-4cc7-b4ac-c9304be7f9d3"), 89.50m },
                    { new Guid("fbef0461-efaa-45d6-860c-450486430f40"), new DateTime(2025, 9, 14, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 9, 14, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 83.38m },
                    { new Guid("fde7b5e7-ecdb-48cd-91c0-713b846a9809"), new DateTime(2025, 11, 4, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, 175m, new DateTime(2025, 11, 4, 10, 28, 36, 52, DateTimeKind.Utc).AddTicks(9355), null, new Guid("f42718c1-552d-4015-8577-4d3d423f4766"), 75.01m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VersionHistory");

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("01736a3e-a98d-4fd8-ac3e-09cdf673f4ea"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("0311bfc2-7c34-410e-8979-ecc9393fed71"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("0c9b90c6-4ce3-4f65-8835-53e1312eb811"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("0f42f30d-703d-4fc8-b22b-fb1b14be5287"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("104b9adf-ad35-4ce5-be37-6a37b11bee5d"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("247a91ca-b6a1-4133-8eb8-91fb54a9f8d3"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("27f0ac37-663d-45b0-92eb-12f5bcc369a8"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("360253d6-44db-481f-aea8-a2a0bffed02b"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("372541a5-f2ee-4217-ba96-fd7937819a2a"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("40eac4c9-b61e-4949-9ed5-f896f1774795"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("4678745d-c623-475e-8acd-6a353b7305e8"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("4a0d3af8-063a-420a-923e-12f07a8a1788"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("5374fbc4-c0af-4d0a-8e04-120f267990a4"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("54cd4972-ea9f-4306-a541-5176db5edfa7"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("54f3a369-cab5-4f3a-b295-7e0ddbe9fbee"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("55537c0d-e640-4dc9-bb74-bd12c7ecb52b"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("56dae0f0-c48c-4c96-a9e1-59f9fc8f1d41"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("5e801f1e-c74d-4418-a89e-c86e9fcfe08c"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("61c30cff-c920-412d-a4e3-a7e5411f6364"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("6a9a6eaf-d7b1-4c63-9053-f40555ff3688"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("70bf7613-2d84-4f48-ba01-d36556afb384"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("76a9b4de-7c07-4abf-817b-126b4636dc60"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("779dc9e5-a548-471c-8543-2bfbf261ce10"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("797c6723-892c-48a3-8170-c066c2c39847"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("7cf54841-776b-474e-b14b-125a06e041ee"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("7f921c8b-616e-4bb5-ba98-099a93794d4e"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("81780cdc-2a07-4187-b9ac-dac40779550c"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("833fb3e7-fff5-46af-aaca-c9ebd80fcbc7"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("83e2658f-30dd-456f-9901-791c36e16fa1"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("85373136-7c0f-49bb-8b94-e9f3cab49381"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("87bd51c9-bd2d-403a-8198-c7d4eaba1c58"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("93dc53b7-d302-43bc-b156-d5373cf58dd4"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("9416b23f-448d-45f1-ab43-385c042f9cc4"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("9af545c5-c874-4535-b1ba-a709594ae38b"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("a00685ed-0a91-4345-b82f-87e10c792885"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("a59fa099-58c3-40f7-aa5a-c1af2ea6bbb8"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("a78beff4-f1d4-4a9c-9ae3-290ba5ef02c2"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("a93039d7-7c64-4730-8e44-c936704eebe2"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("b154aec4-f1f4-4d37-96a9-725d0765f9f2"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("b2780c90-8a3a-436e-90ca-e6593d2c8b9f"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("b7603c2d-f869-4f8c-b0f1-b79bad3c7e78"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("b76a9b6a-7b93-4a74-9952-645b5a15c7a6"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("b8c87ce1-e411-4d10-b5a0-0db6aaf9f2a9"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("c379fe1e-91bc-4bac-83e7-086ed24831b9"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("c7bb9611-6fdc-4680-8c69-b8589c1ba2ea"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("ca215b05-8b44-4d4c-a410-1b85d073ed4b"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("cd5bce8b-1b56-4403-94aa-2654e309fe1b"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("d1cf81f5-9613-4122-9cfe-72a94dd7dfc6"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("d46e4ed5-af9b-4bb3-8e6f-81dfc62f558b"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("d654dd0a-eb76-4816-b337-80b62deffa46"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("dcb55d7b-d42a-4ab2-ba38-4d5d59f66f3f"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("df38bea7-1a8d-48a8-8f68-72314def0a15"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("e01c7163-06e2-4220-ba2d-47417b1f148b"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("e1f90509-51ba-4993-b709-4f2945b156dd"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("e87c6b04-2eed-4fb7-9a2a-b70fd3467b86"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("f0822e97-96a4-4d1e-83da-95fbdee14a28"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("f3905b21-a4be-4902-8404-872b4e480057"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("f904e0e1-e627-4115-91ed-e77161dd3905"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("fbef0461-efaa-45d6-860c-450486430f40"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("fde7b5e7-ecdb-48cd-91c0-713b846a9809"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("c4248a1e-a005-4896-bc0f-7025e8afde47"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("04cfe11d-8bdf-4cc7-b4ac-c9304be7f9d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("4fb446ba-9962-4aae-8f59-8b296d22b949"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("f42718c1-552d-4015-8577-4d3d423f4766"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "DeletedAt", "Email", "PasswordHash", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { new Guid("4b8e0024-46e3-49cd-ba14-c96224055200"), new DateTime(2025, 9, 25, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(5704), null, "mike.johnson@example.com", "$2a$11$31qvDCOtFfebdx3YwBKXU.EvT4hqRPdwgxxuBcMhtFUKh9wLk7xXu", null, "mike_johnson" },
                    { new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), new DateTime(2025, 5, 25, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(5685), null, "john.doe@example.com", "$2a$11$31qvDCOtFfebdx3YwBKXU.EvT4hqRPdwgxxuBcMhtFUKh9wLk7xXu", null, "john_doe" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "DeletedAt", "Email", "IsAdmin", "PasswordHash", "UpdatedAt", "Username" },
                values: new object[] { new Guid("b5c63ffc-d843-4909-9a59-3254b3be73b5"), new DateTime(2025, 10, 25, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(5705), null, "admin@email.com", true, "$2a$11$31qvDCOtFfebdx3YwBKXU.EvT4hqRPdwgxxuBcMhtFUKh9wLk7xXu", null, "admin_user" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "DeletedAt", "Email", "PasswordHash", "UpdatedAt", "Username" },
                values: new object[] { new Guid("e0ad6390-5c2e-4304-8f1c-576799d519bf"), new DateTime(2025, 7, 25, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(5702), null, "jane.smith@example.com", "$2a$11$31qvDCOtFfebdx3YwBKXU.EvT4hqRPdwgxxuBcMhtFUKh9wLk7xXu", null, "jane_smith" });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "RecordId", "CreatedAt", "DeletedAt", "Height", "RecordDate", "UpdatedAt", "UserId", "Weight" },
                values: new object[,]
                {
                    { new Guid("0083a282-78d9-409c-81e4-ed383deba061"), new DateTime(2025, 10, 11, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, 165m, new DateTime(2025, 10, 11, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, new Guid("e0ad6390-5c2e-4304-8f1c-576799d519bf"), 69.50m },
                    { new Guid("02dd1769-2bc7-4d74-8860-8fc1a35480ad"), new DateTime(2025, 9, 27, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 9, 27, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 81.48m },
                    { new Guid("062cf1a9-cb8f-4588-96f9-9bb5d9d0ac2d"), new DateTime(2025, 10, 27, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 10, 27, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 76.33m },
                    { new Guid("118c21a6-7d49-4398-aca9-c259784b5383"), new DateTime(2025, 10, 21, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 10, 21, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 76.96m },
                    { new Guid("1a1da052-afb9-4379-8523-5f9b3ca8f6e8"), new DateTime(2025, 8, 28, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 8, 28, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 84.64m },
                    { new Guid("1d8d0254-ef9f-47f8-8d48-c36e40e458ec"), new DateTime(2025, 8, 25, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 8, 25, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 85.95m },
                    { new Guid("1eae73e2-3e8b-4855-94c1-92d24aca6327"), new DateTime(2025, 11, 10, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, 182m, new DateTime(2025, 11, 10, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, new Guid("4b8e0024-46e3-49cd-ba14-c96224055200"), 89.89m },
                    { new Guid("1f1d7f44-83a4-4b57-9c38-0e8578a5ef0a"), new DateTime(2025, 10, 3, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, 165m, new DateTime(2025, 10, 3, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, new Guid("e0ad6390-5c2e-4304-8f1c-576799d519bf"), 68.59m },
                    { new Guid("27641ca1-2520-493e-aaca-71383c52ca6c"), new DateTime(2025, 10, 15, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 10, 15, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 77.59m },
                    { new Guid("27bbffbe-e285-494c-85d9-ccd437b307c2"), new DateTime(2025, 11, 22, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, 182m, new DateTime(2025, 11, 22, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, new Guid("4b8e0024-46e3-49cd-ba14-c96224055200"), 85.06m },
                    { new Guid("2d5ec850-9f9b-4e90-84fe-27a740fb15fa"), new DateTime(2025, 10, 30, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 10, 30, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 75.01m },
                    { new Guid("2f4fdfa7-83c4-45d7-b387-0af4cd96f31c"), new DateTime(2025, 11, 4, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, 182m, new DateTime(2025, 11, 4, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, new Guid("4b8e0024-46e3-49cd-ba14-c96224055200"), 91.05m },
                    { new Guid("3cfea8da-8406-427e-a1f7-3fa0b6f3a6b3"), new DateTime(2025, 9, 30, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 9, 30, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 80.17m },
                    { new Guid("3e3bac21-51ed-4496-b632-628edf087514"), new DateTime(2025, 11, 16, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, 182m, new DateTime(2025, 11, 16, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, new Guid("4b8e0024-46e3-49cd-ba14-c96224055200"), 86.23m },
                    { new Guid("44713c4c-6829-48a5-aee9-d655a9abfa3f"), new DateTime(2025, 10, 31, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, 182m, new DateTime(2025, 10, 31, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, new Guid("4b8e0024-46e3-49cd-ba14-c96224055200"), 91.83m },
                    { new Guid("4bdb3638-8d95-46b9-ae0a-9b6cba062d31"), new DateTime(2025, 11, 6, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, 182m, new DateTime(2025, 11, 6, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, new Guid("4b8e0024-46e3-49cd-ba14-c96224055200"), 90.66m },
                    { new Guid("5995e7ef-b3a9-484e-aa2b-e899103e115b"), new DateTime(2025, 11, 20, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, 165m, new DateTime(2025, 11, 20, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, new Guid("e0ad6390-5c2e-4304-8f1c-576799d519bf"), 72.54m },
                    { new Guid("5cfde34d-f58c-442f-9040-1b6ed94c58db"), new DateTime(2025, 10, 3, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 10, 3, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 78.85m },
                    { new Guid("5dfc9967-c37c-4d4c-8af3-b54740ba23e0"), new DateTime(2025, 11, 12, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, 182m, new DateTime(2025, 11, 12, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, new Guid("4b8e0024-46e3-49cd-ba14-c96224055200"), 89.50m },
                    { new Guid("5f154f3d-cc4d-419e-9783-6bf5201fab97"), new DateTime(2025, 11, 2, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 11, 2, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 75.70m },
                    { new Guid("60b201df-777d-40ae-89bb-0987e1282508"), new DateTime(2025, 9, 24, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 9, 24, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 80.80m },
                    { new Guid("610f9cf9-357a-4f9f-a88b-039b3d91b577"), new DateTime(2025, 10, 24, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 10, 24, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 75.64m },
                    { new Guid("6c206bdc-7514-49c1-8f0f-1786bf8ee8c7"), new DateTime(2025, 10, 12, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 10, 12, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 78.91m },
                    { new Guid("75db95f7-f8d6-4d11-8aff-07087602f089"), new DateTime(2025, 9, 9, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 9, 9, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 83.38m },
                    { new Guid("770348a5-e689-40e9-96bb-e25b92e62373"), new DateTime(2025, 9, 21, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 9, 21, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 82.11m },
                    { new Guid("78552527-e249-44c3-bee2-211fab51fcb4"), new DateTime(2025, 10, 9, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 10, 9, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 78.22m },
                    { new Guid("7c570917-f223-4a46-b9c5-96ab83afb1de"), new DateTime(2025, 11, 8, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, 182m, new DateTime(2025, 11, 8, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, new Guid("4b8e0024-46e3-49cd-ba14-c96224055200"), 90.28m },
                    { new Guid("7da30afa-1583-4d42-ba55-82201df2e405"), new DateTime(2025, 10, 25, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, 182m, new DateTime(2025, 10, 25, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, new Guid("4b8e0024-46e3-49cd-ba14-c96224055200"), 92.99m },
                    { new Guid("813ef424-cb3c-479d-ac15-179f6d1c30a6"), new DateTime(2025, 9, 25, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, 165m, new DateTime(2025, 9, 25, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, new Guid("e0ad6390-5c2e-4304-8f1c-576799d519bf"), 67.68m },
                    { new Guid("853915b9-4cc9-4888-89f8-121ab4960f81"), new DateTime(2025, 11, 8, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, 165m, new DateTime(2025, 11, 8, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, new Guid("e0ad6390-5c2e-4304-8f1c-576799d519bf"), 71.18m },
                    { new Guid("8666c2ea-76d3-4c1b-b2d9-6341492be82c"), new DateTime(2025, 11, 2, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, 182m, new DateTime(2025, 11, 2, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, new Guid("4b8e0024-46e3-49cd-ba14-c96224055200"), 91.44m },
                    { new Guid("8828f16f-bdfd-4ca6-a343-361193b5fa06"), new DateTime(2025, 9, 12, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 9, 12, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 82.06m },
                    { new Guid("8947479d-c6fd-4ed1-ad61-310342cb6e44"), new DateTime(2025, 10, 15, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, 165m, new DateTime(2025, 10, 15, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, new Guid("e0ad6390-5c2e-4304-8f1c-576799d519bf"), 69.95m },
                    { new Guid("93ae7c44-29ed-4296-b299-fe4fd00d35df"), new DateTime(2025, 10, 31, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, 165m, new DateTime(2025, 10, 31, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, new Guid("e0ad6390-5c2e-4304-8f1c-576799d519bf"), 71.77m },
                    { new Guid("9ac3e71e-019d-4efb-9478-a3c798a27051"), new DateTime(2025, 10, 23, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, 165m, new DateTime(2025, 10, 23, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, new Guid("e0ad6390-5c2e-4304-8f1c-576799d519bf"), 70.86m },
                    { new Guid("9baf8cb0-fa20-4134-ac9c-3cfda31a918b"), new DateTime(2025, 10, 27, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, 165m, new DateTime(2025, 10, 27, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, new Guid("e0ad6390-5c2e-4304-8f1c-576799d519bf"), 71.31m },
                    { new Guid("a57c51e8-94d8-43ab-93a8-e66a8640a886"), new DateTime(2025, 11, 8, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 11, 8, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 75.07m },
                    { new Guid("ac272af3-93fb-4010-9fb5-e05b512f1346"), new DateTime(2025, 10, 18, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 10, 18, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 78.27m },
                    { new Guid("ac7c381c-dd6e-431b-8906-448c25c2a07a"), new DateTime(2025, 11, 12, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, 165m, new DateTime(2025, 11, 12, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, new Guid("e0ad6390-5c2e-4304-8f1c-576799d519bf"), 71.63m },
                    { new Guid("ae416936-b4da-433a-a2be-7d1ea810e05f"), new DateTime(2025, 11, 17, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 11, 17, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 73.12m },
                    { new Guid("b0370448-cd39-41f5-8488-c8e218a55e38"), new DateTime(2025, 10, 27, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, 182m, new DateTime(2025, 10, 27, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, new Guid("4b8e0024-46e3-49cd-ba14-c96224055200"), 92.60m },
                    { new Guid("b1569284-6277-4aad-8e67-52eac6bb09f3"), new DateTime(2025, 11, 5, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 11, 5, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 74.38m },
                    { new Guid("b6e4ad78-df00-4707-a99d-7e1bcf55adfd"), new DateTime(2025, 11, 4, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, 165m, new DateTime(2025, 11, 4, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, new Guid("e0ad6390-5c2e-4304-8f1c-576799d519bf"), 70.72m },
                    { new Guid("ba878779-1fe3-4cae-a410-cfe4325b37e4"), new DateTime(2025, 9, 18, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 9, 18, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 81.43m },
                    { new Guid("bb5275cf-6393-436f-8b03-2e159840cf87"), new DateTime(2025, 10, 7, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, 165m, new DateTime(2025, 10, 7, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, new Guid("e0ad6390-5c2e-4304-8f1c-576799d519bf"), 69.04m },
                    { new Guid("bcfa1e63-25a3-4847-9c28-4d218743cdf3"), new DateTime(2025, 9, 6, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 9, 6, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 84.69m },
                    { new Guid("c9c4cf23-c1dd-4dff-bce0-34ae83f063c8"), new DateTime(2025, 11, 18, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, 182m, new DateTime(2025, 11, 18, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, new Guid("4b8e0024-46e3-49cd-ba14-c96224055200"), 85.84m },
                    { new Guid("cb6dfaa6-e9d5-45f3-8f08-96a4d2619acf"), new DateTime(2025, 11, 14, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 11, 14, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 72.44m },
                    { new Guid("d6254ff5-09b2-4831-b584-511ceee354a3"), new DateTime(2025, 9, 3, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 9, 3, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 84.01m },
                    { new Guid("dea02f65-67ca-40bd-845e-79f5312ec8cd"), new DateTime(2025, 11, 11, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 11, 11, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 73.75m },
                    { new Guid("e8175413-4f75-46eb-ba25-c236e4678cf4"), new DateTime(2025, 10, 29, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, 182m, new DateTime(2025, 10, 29, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, new Guid("4b8e0024-46e3-49cd-ba14-c96224055200"), 92.22m },
                    { new Guid("e9d70b83-48cf-49c6-8684-a2aa584c41db"), new DateTime(2025, 9, 15, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 9, 15, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 82.74m },
                    { new Guid("eac43175-e048-405a-a798-1abb7be60cd0"), new DateTime(2025, 11, 20, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, 182m, new DateTime(2025, 11, 20, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, new Guid("4b8e0024-46e3-49cd-ba14-c96224055200"), 85.45m },
                    { new Guid("eb5ce850-0501-47b6-aafa-4effc5d4b485"), new DateTime(2025, 9, 29, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, 165m, new DateTime(2025, 9, 29, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, new Guid("e0ad6390-5c2e-4304-8f1c-576799d519bf"), 68.13m },
                    { new Guid("ee3974e9-46fc-4cf5-82be-987256e4f5ce"), new DateTime(2025, 10, 19, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, 165m, new DateTime(2025, 10, 19, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, new Guid("e0ad6390-5c2e-4304-8f1c-576799d519bf"), 70.40m },
                    { new Guid("f0117242-dc66-479e-b2fb-0486aca4dc1b"), new DateTime(2025, 8, 31, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 8, 31, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 85.32m },
                    { new Guid("f10e4ca3-91ac-463d-8e39-1f426e44cee9"), new DateTime(2025, 10, 6, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 10, 6, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 79.54m },
                    { new Guid("f2d99120-68ff-45a0-a8f7-8fa063eb6f06"), new DateTime(2025, 11, 20, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, 175m, new DateTime(2025, 11, 20, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6464), null, new Guid("5e5fd8e0-2dd1-47c5-b864-d00e8cbd3c64"), 71.80m },
                    { new Guid("fbf32913-23b7-4586-b588-a9c9096282b4"), new DateTime(2025, 11, 16, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, 165m, new DateTime(2025, 11, 16, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(6973), null, new Guid("e0ad6390-5c2e-4304-8f1c-576799d519bf"), 72.09m },
                    { new Guid("fcaa68ad-07e3-46d3-ae2f-f144fa309c1b"), new DateTime(2025, 11, 14, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, 182m, new DateTime(2025, 11, 14, 10, 46, 30, 365, DateTimeKind.Utc).AddTicks(7215), null, new Guid("4b8e0024-46e3-49cd-ba14-c96224055200"), 86.61m }
                });
        }
    }
}
