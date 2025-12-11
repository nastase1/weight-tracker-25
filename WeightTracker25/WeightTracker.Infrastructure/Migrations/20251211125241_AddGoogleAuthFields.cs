using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WeightTracker.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddGoogleAuthFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "ExternalUserId",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LoginProvider",
                table: "Users",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "DeletedAt", "Email", "ExternalUserId", "LoginProvider", "PasswordHash", "UpdatedAt", "Username" },
                values: new object[,]
                {
                    { new Guid("52813db3-3d79-4af0-ae63-29342ed28f27"), new DateTime(2025, 10, 11, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(6856), null, "mike.johnson@example.com", null, null, "$2a$11$xh9TXJ4xtwOG/Jr0mebdzO3YinVaeN9un5O2HUBKX05QPM4xwQfnO", null, "mike_johnson" },
                    { new Guid("8f851f2a-6cdf-413d-80d9-4b5244c75f0a"), new DateTime(2025, 8, 11, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(6855), null, "jane.smith@example.com", null, null, "$2a$11$xh9TXJ4xtwOG/Jr0mebdzO3YinVaeN9un5O2HUBKX05QPM4xwQfnO", null, "jane_smith" },
                    { new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), new DateTime(2025, 6, 11, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(6839), null, "john.doe@example.com", null, null, "$2a$11$xh9TXJ4xtwOG/Jr0mebdzO3YinVaeN9un5O2HUBKX05QPM4xwQfnO", null, "john_doe" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "DeletedAt", "Email", "ExternalUserId", "IsAdmin", "LoginProvider", "PasswordHash", "UpdatedAt", "Username" },
                values: new object[] { new Guid("cacdde49-bb86-4104-9925-1ae1b32e4589"), new DateTime(2025, 11, 11, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(6857), null, "admin@email.com", null, true, null, "$2a$11$xh9TXJ4xtwOG/Jr0mebdzO3YinVaeN9un5O2HUBKX05QPM4xwQfnO", null, "admin_user" });

            migrationBuilder.InsertData(
                table: "Records",
                columns: new[] { "RecordId", "CreatedAt", "DeletedAt", "Height", "RecordDate", "UpdatedAt", "UserId", "Weight" },
                values: new object[,]
                {
                    { new Guid("061164ed-5be3-4037-9e91-135a4b937ae6"), new DateTime(2025, 12, 3, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, 182m, new DateTime(2025, 12, 3, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, new Guid("52813db3-3d79-4af0-ae63-29342ed28f27"), 86.23m },
                    { new Guid("06cbc73f-88be-4b45-b26b-c90d1c408878"), new DateTime(2025, 11, 20, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, 165m, new DateTime(2025, 11, 20, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, new Guid("8f851f2a-6cdf-413d-80d9-4b5244c75f0a"), 70.72m },
                    { new Guid("09122ffe-7b8f-4031-af8d-907cac46f4be"), new DateTime(2025, 10, 29, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 10, 29, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 78.91m },
                    { new Guid("11d42163-fe28-43d8-b54a-2704e4de07c0"), new DateTime(2025, 9, 17, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 9, 17, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 85.32m },
                    { new Guid("1348e6e3-5906-4ac1-a47f-8c17b52c0e91"), new DateTime(2025, 9, 11, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 9, 11, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 85.95m },
                    { new Guid("1aa4135b-55b9-42e6-9d75-0f4eacd27e6f"), new DateTime(2025, 11, 28, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 11, 28, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 73.75m },
                    { new Guid("22650119-a421-44d5-bfb7-e3591a1f2691"), new DateTime(2025, 10, 23, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, 165m, new DateTime(2025, 10, 23, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, new Guid("8f851f2a-6cdf-413d-80d9-4b5244c75f0a"), 69.04m },
                    { new Guid("259f8874-7811-4522-852e-06c806c9b177"), new DateTime(2025, 11, 4, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, 165m, new DateTime(2025, 11, 4, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, new Guid("8f851f2a-6cdf-413d-80d9-4b5244c75f0a"), 70.40m },
                    { new Guid("269bf952-e1c7-4f2b-99a3-6a34b59ec093"), new DateTime(2025, 11, 16, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, 165m, new DateTime(2025, 11, 16, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, new Guid("8f851f2a-6cdf-413d-80d9-4b5244c75f0a"), 71.77m },
                    { new Guid("278315b7-6e50-4627-a11b-069cd8515123"), new DateTime(2025, 11, 27, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, 182m, new DateTime(2025, 11, 27, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, new Guid("52813db3-3d79-4af0-ae63-29342ed28f27"), 89.89m },
                    { new Guid("2ef94088-46b2-4109-a813-6ea9b528c10e"), new DateTime(2025, 12, 1, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 12, 1, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 72.44m },
                    { new Guid("2f0a3abd-e2bb-4ec6-9625-b70765b37f2e"), new DateTime(2025, 11, 22, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 11, 22, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 74.38m },
                    { new Guid("3aaa3a97-87f2-4bde-85d9-a52d0fafee7b"), new DateTime(2025, 9, 29, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 9, 29, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 82.06m },
                    { new Guid("3f55e15f-9bbe-4564-88cb-116372f33ee4"), new DateTime(2025, 12, 9, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, 182m, new DateTime(2025, 12, 9, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, new Guid("52813db3-3d79-4af0-ae63-29342ed28f27"), 85.06m },
                    { new Guid("4f85a0f1-0ef9-4fe9-bcbc-5ea39c1db4a4"), new DateTime(2025, 11, 11, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, 182m, new DateTime(2025, 11, 11, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, new Guid("52813db3-3d79-4af0-ae63-29342ed28f27"), 92.99m },
                    { new Guid("50731aae-aeba-44f5-8dab-1d67646d3544"), new DateTime(2025, 10, 17, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 10, 17, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 80.17m },
                    { new Guid("54becfbf-443d-46d6-a498-a8f4503b1a01"), new DateTime(2025, 12, 7, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 12, 7, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 71.80m },
                    { new Guid("565bf3b0-3350-4b31-be2b-664f5f995108"), new DateTime(2025, 11, 12, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, 165m, new DateTime(2025, 11, 12, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, new Guid("8f851f2a-6cdf-413d-80d9-4b5244c75f0a"), 71.31m },
                    { new Guid("6401aba5-9d85-47cb-a9e3-3f85c359d656"), new DateTime(2025, 11, 8, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, 165m, new DateTime(2025, 11, 8, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, new Guid("8f851f2a-6cdf-413d-80d9-4b5244c75f0a"), 70.86m },
                    { new Guid("649fb5a7-eede-4a11-b0e0-bc5f086cd79e"), new DateTime(2025, 10, 11, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, 165m, new DateTime(2025, 10, 11, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, new Guid("8f851f2a-6cdf-413d-80d9-4b5244c75f0a"), 67.68m },
                    { new Guid("65284d36-9ada-4b68-94a1-7795c391b033"), new DateTime(2025, 11, 10, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 11, 10, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 75.64m },
                    { new Guid("67a6399e-fc72-4517-a77d-fa0f14ec031c"), new DateTime(2025, 11, 16, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 11, 16, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 75.01m },
                    { new Guid("6b7b1c43-3800-4f75-ba3d-d237da578ca3"), new DateTime(2025, 9, 14, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 9, 14, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 84.64m },
                    { new Guid("6b931919-9b4c-4bc5-b80c-c24dfb72e85e"), new DateTime(2025, 10, 20, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 10, 20, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 78.85m },
                    { new Guid("77841c36-c502-4091-abfd-67d224f81c4f"), new DateTime(2025, 10, 5, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 10, 5, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 81.43m },
                    { new Guid("78a54921-2eb8-4001-bba4-a5c53c76c224"), new DateTime(2025, 10, 14, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 10, 14, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 81.48m },
                    { new Guid("82517dba-ed14-47e9-9b58-dba2e446aa5d"), new DateTime(2025, 10, 31, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, 165m, new DateTime(2025, 10, 31, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, new Guid("8f851f2a-6cdf-413d-80d9-4b5244c75f0a"), 69.95m },
                    { new Guid("86ec0d23-9166-4642-90bd-9eff7c355b5d"), new DateTime(2025, 11, 28, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, 165m, new DateTime(2025, 11, 28, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, new Guid("8f851f2a-6cdf-413d-80d9-4b5244c75f0a"), 71.63m },
                    { new Guid("8711f2be-7f45-45e4-83e8-4be8abf492ca"), new DateTime(2025, 10, 19, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, 165m, new DateTime(2025, 10, 19, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, new Guid("8f851f2a-6cdf-413d-80d9-4b5244c75f0a"), 68.59m },
                    { new Guid("8cbad47a-5c48-4953-9d43-f1138cd6243f"), new DateTime(2025, 11, 4, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 11, 4, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 78.27m },
                    { new Guid("8f8f48db-a2f9-494f-a84d-8e67b9bfa54b"), new DateTime(2025, 9, 20, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 9, 20, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 84.01m },
                    { new Guid("93333d6d-f70f-4a39-90ef-91220b9058b8"), new DateTime(2025, 11, 15, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, 182m, new DateTime(2025, 11, 15, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, new Guid("52813db3-3d79-4af0-ae63-29342ed28f27"), 92.22m },
                    { new Guid("937c609f-2ba9-406a-a1a1-97bb18edc2c2"), new DateTime(2025, 12, 1, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, 182m, new DateTime(2025, 12, 1, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, new Guid("52813db3-3d79-4af0-ae63-29342ed28f27"), 86.61m },
                    { new Guid("9979db5a-bd1d-4782-9fc8-d12b0a338bfe"), new DateTime(2025, 11, 21, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, 182m, new DateTime(2025, 11, 21, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, new Guid("52813db3-3d79-4af0-ae63-29342ed28f27"), 91.05m },
                    { new Guid("99a3672e-7aa3-4f67-8529-36719aba681e"), new DateTime(2025, 11, 23, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, 182m, new DateTime(2025, 11, 23, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, new Guid("52813db3-3d79-4af0-ae63-29342ed28f27"), 90.66m },
                    { new Guid("9ac5dd86-fe65-4602-aa35-79d9a7f24dee"), new DateTime(2025, 10, 8, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 10, 8, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 82.11m },
                    { new Guid("9ca09276-bdf3-4db0-a3d1-694b2b8d674c"), new DateTime(2025, 12, 7, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, 182m, new DateTime(2025, 12, 7, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, new Guid("52813db3-3d79-4af0-ae63-29342ed28f27"), 85.45m },
                    { new Guid("a448e1b6-825e-4175-98cb-796c77cebd44"), new DateTime(2025, 9, 23, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 9, 23, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 84.69m },
                    { new Guid("a553c273-9a52-4b35-8da5-eedaa67e81b9"), new DateTime(2025, 12, 4, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 12, 4, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 73.12m },
                    { new Guid("a5f604cf-6c04-4c6f-9444-b2cba6918642"), new DateTime(2025, 11, 25, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 11, 25, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 75.07m },
                    { new Guid("a7ddd19d-94d9-4a82-a9aa-27e5a3614554"), new DateTime(2025, 11, 24, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, 165m, new DateTime(2025, 11, 24, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, new Guid("8f851f2a-6cdf-413d-80d9-4b5244c75f0a"), 71.18m },
                    { new Guid("b21338b1-e8ba-4825-b30f-79d9f839ff01"), new DateTime(2025, 12, 2, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, 165m, new DateTime(2025, 12, 2, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, new Guid("8f851f2a-6cdf-413d-80d9-4b5244c75f0a"), 72.09m },
                    { new Guid("b3d9e5ec-feec-49da-aac4-38ba323b6db3"), new DateTime(2025, 11, 19, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, 182m, new DateTime(2025, 11, 19, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, new Guid("52813db3-3d79-4af0-ae63-29342ed28f27"), 91.44m },
                    { new Guid("b40ff037-3662-4282-8274-b0159a1ac06e"), new DateTime(2025, 10, 2, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 10, 2, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 82.74m },
                    { new Guid("bac08e27-88b1-4c30-a9bf-dcffe50248e2"), new DateTime(2025, 11, 25, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, 182m, new DateTime(2025, 11, 25, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, new Guid("52813db3-3d79-4af0-ae63-29342ed28f27"), 90.28m },
                    { new Guid("bd075c31-01c2-4fd0-a877-3220076dd2cc"), new DateTime(2025, 12, 5, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, 182m, new DateTime(2025, 12, 5, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, new Guid("52813db3-3d79-4af0-ae63-29342ed28f27"), 85.84m },
                    { new Guid("c06f9435-62cc-4c6b-ab33-864b66340e84"), new DateTime(2025, 11, 13, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, 182m, new DateTime(2025, 11, 13, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, new Guid("52813db3-3d79-4af0-ae63-29342ed28f27"), 92.60m },
                    { new Guid("c6255fd6-fef9-4f41-ba6f-cc4c5df2bc9f"), new DateTime(2025, 10, 11, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 10, 11, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 80.80m },
                    { new Guid("cb044c29-cdf9-4c7b-9cff-f7171099c2c2"), new DateTime(2025, 10, 23, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 10, 23, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 79.54m },
                    { new Guid("cd6fecaa-21d3-4007-b533-bab451a7c03a"), new DateTime(2025, 10, 15, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, 165m, new DateTime(2025, 10, 15, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, new Guid("8f851f2a-6cdf-413d-80d9-4b5244c75f0a"), 68.13m },
                    { new Guid("d38f8d51-f2e4-4192-9a24-4f0c7f7cadcc"), new DateTime(2025, 11, 7, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 11, 7, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 76.96m },
                    { new Guid("d95b5184-5ab7-4274-a1f7-e9c4ce80adcb"), new DateTime(2025, 11, 19, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 11, 19, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 75.70m },
                    { new Guid("db2aaa2e-1fb0-4ded-9bd5-2fa84866cf4b"), new DateTime(2025, 11, 1, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 11, 1, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 77.59m },
                    { new Guid("db6e8e95-44fd-4ea0-a90c-56acd519907a"), new DateTime(2025, 9, 26, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 9, 26, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 83.38m },
                    { new Guid("dea8bf56-f3da-45cb-992e-457349640b4e"), new DateTime(2025, 11, 17, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, 182m, new DateTime(2025, 11, 17, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, new Guid("52813db3-3d79-4af0-ae63-29342ed28f27"), 91.83m },
                    { new Guid("e12bc4f4-643e-42b8-a67b-3571ce5e2716"), new DateTime(2025, 12, 6, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, 165m, new DateTime(2025, 12, 6, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, new Guid("8f851f2a-6cdf-413d-80d9-4b5244c75f0a"), 72.54m },
                    { new Guid("e82531f9-6a33-4ef9-a3dc-0155c1d985fa"), new DateTime(2025, 11, 29, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, 182m, new DateTime(2025, 11, 29, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8302), null, new Guid("52813db3-3d79-4af0-ae63-29342ed28f27"), 89.50m },
                    { new Guid("ef930129-d5fa-417b-b36c-6064320058ce"), new DateTime(2025, 11, 13, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 11, 13, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 76.33m },
                    { new Guid("efe9b67d-e68f-420e-a1a4-7b82a31fd4c4"), new DateTime(2025, 10, 26, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, 175m, new DateTime(2025, 10, 26, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(7430), null, new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"), 78.22m },
                    { new Guid("fcb1efad-6834-477f-9998-560adb4de843"), new DateTime(2025, 10, 27, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, 165m, new DateTime(2025, 10, 27, 12, 52, 41, 506, DateTimeKind.Utc).AddTicks(8086), null, new Guid("8f851f2a-6cdf-413d-80d9-4b5244c75f0a"), 69.50m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("061164ed-5be3-4037-9e91-135a4b937ae6"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("06cbc73f-88be-4b45-b26b-c90d1c408878"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("09122ffe-7b8f-4031-af8d-907cac46f4be"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("11d42163-fe28-43d8-b54a-2704e4de07c0"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("1348e6e3-5906-4ac1-a47f-8c17b52c0e91"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("1aa4135b-55b9-42e6-9d75-0f4eacd27e6f"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("22650119-a421-44d5-bfb7-e3591a1f2691"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("259f8874-7811-4522-852e-06c806c9b177"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("269bf952-e1c7-4f2b-99a3-6a34b59ec093"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("278315b7-6e50-4627-a11b-069cd8515123"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("2ef94088-46b2-4109-a813-6ea9b528c10e"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("2f0a3abd-e2bb-4ec6-9625-b70765b37f2e"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("3aaa3a97-87f2-4bde-85d9-a52d0fafee7b"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("3f55e15f-9bbe-4564-88cb-116372f33ee4"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("4f85a0f1-0ef9-4fe9-bcbc-5ea39c1db4a4"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("50731aae-aeba-44f5-8dab-1d67646d3544"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("54becfbf-443d-46d6-a498-a8f4503b1a01"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("565bf3b0-3350-4b31-be2b-664f5f995108"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("6401aba5-9d85-47cb-a9e3-3f85c359d656"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("649fb5a7-eede-4a11-b0e0-bc5f086cd79e"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("65284d36-9ada-4b68-94a1-7795c391b033"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("67a6399e-fc72-4517-a77d-fa0f14ec031c"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("6b7b1c43-3800-4f75-ba3d-d237da578ca3"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("6b931919-9b4c-4bc5-b80c-c24dfb72e85e"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("77841c36-c502-4091-abfd-67d224f81c4f"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("78a54921-2eb8-4001-bba4-a5c53c76c224"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("82517dba-ed14-47e9-9b58-dba2e446aa5d"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("86ec0d23-9166-4642-90bd-9eff7c355b5d"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("8711f2be-7f45-45e4-83e8-4be8abf492ca"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("8cbad47a-5c48-4953-9d43-f1138cd6243f"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("8f8f48db-a2f9-494f-a84d-8e67b9bfa54b"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("93333d6d-f70f-4a39-90ef-91220b9058b8"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("937c609f-2ba9-406a-a1a1-97bb18edc2c2"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("9979db5a-bd1d-4782-9fc8-d12b0a338bfe"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("99a3672e-7aa3-4f67-8529-36719aba681e"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("9ac5dd86-fe65-4602-aa35-79d9a7f24dee"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("9ca09276-bdf3-4db0-a3d1-694b2b8d674c"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("a448e1b6-825e-4175-98cb-796c77cebd44"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("a553c273-9a52-4b35-8da5-eedaa67e81b9"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("a5f604cf-6c04-4c6f-9444-b2cba6918642"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("a7ddd19d-94d9-4a82-a9aa-27e5a3614554"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("b21338b1-e8ba-4825-b30f-79d9f839ff01"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("b3d9e5ec-feec-49da-aac4-38ba323b6db3"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("b40ff037-3662-4282-8274-b0159a1ac06e"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("bac08e27-88b1-4c30-a9bf-dcffe50248e2"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("bd075c31-01c2-4fd0-a877-3220076dd2cc"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("c06f9435-62cc-4c6b-ab33-864b66340e84"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("c6255fd6-fef9-4f41-ba6f-cc4c5df2bc9f"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("cb044c29-cdf9-4c7b-9cff-f7171099c2c2"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("cd6fecaa-21d3-4007-b533-bab451a7c03a"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("d38f8d51-f2e4-4192-9a24-4f0c7f7cadcc"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("d95b5184-5ab7-4274-a1f7-e9c4ce80adcb"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("db2aaa2e-1fb0-4ded-9bd5-2fa84866cf4b"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("db6e8e95-44fd-4ea0-a90c-56acd519907a"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("dea8bf56-f3da-45cb-992e-457349640b4e"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("e12bc4f4-643e-42b8-a67b-3571ce5e2716"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("e82531f9-6a33-4ef9-a3dc-0155c1d985fa"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("ef930129-d5fa-417b-b36c-6064320058ce"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("efe9b67d-e68f-420e-a1a4-7b82a31fd4c4"));

            migrationBuilder.DeleteData(
                table: "Records",
                keyColumn: "RecordId",
                keyValue: new Guid("fcb1efad-6834-477f-9998-560adb4de843"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("cacdde49-bb86-4104-9925-1ae1b32e4589"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("52813db3-3d79-4af0-ae63-29342ed28f27"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("8f851f2a-6cdf-413d-80d9-4b5244c75f0a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("c3f2a699-fe97-48f6-a9fc-698c2d672209"));

            migrationBuilder.DropColumn(
                name: "ExternalUserId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LoginProvider",
                table: "Users");

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
    }
}
