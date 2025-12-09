using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeightTracker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    IsAdmin = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: false),
                    Username = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "datetime('now')"),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "PasswordResetTokens",
                columns: table => new
                {
                    TokenId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    ResetCode = table.Column<string>(type: "TEXT", maxLength: 6, nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsUsed = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PasswordResetTokens", x => x.TokenId);
                    table.ForeignKey(
                        name: "FK_PasswordResetTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    RecordId = table.Column<Guid>(type: "TEXT", nullable: false),
                    UserId = table.Column<Guid>(type: "TEXT", nullable: false),
                    RecordDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false, defaultValueSql: "datetime('now')"),
                    UpdatedAt = table.Column<DateTime>(type: "TEXT", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.RecordId);
                    table.ForeignKey(
                        name: "FK_Records_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_PasswordResetTokens_UserId",
                table: "PasswordResetTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Records_UserId",
                table: "Records",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PasswordResetTokens");

            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
