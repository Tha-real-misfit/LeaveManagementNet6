using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdatedRequestsComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9bc3h04-0b88-4959-f144-57430d36bb56",
                column: "ConcurrencyStamp",
                value: "be720124-a574-4a11-99e9-4a461d854d16");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7dd3d04-0b88-4959-b277-57110d40bf56",
                column: "ConcurrencyStamp",
                value: "c72f3282-acbf-49d2-a6c4-49c8976bdd62");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4aa3d07-0c88-3332-d24d-57110f40fc56",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2025402-5636-4fec-96f9-523129a5bb57", "AQAAAAEAACcQAAAAEPdfm9tKQa8Kk7jaCV4PCJCkCdcU2tPZbaiQdjqnpjYwYyO4xTORDVoRKEARqb0GKQ==", "016a36ba-7c97-440e-8d7c-77add4ca2463" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7ee3d04-0f61-3662-b249-57110f40fc56",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a06734d5-fadb-4bcb-9c7f-6ddead6ad1ee", "AQAAAAEAACcQAAAAELHtE5PGZSatzBo6GtpPt6PSirL3+U5UXNvVGK5f72H7DHiXKoUrLvM5dRWulUunlw==", "19f28c42-de52-4df0-bd9b-bf64da1eb6ee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9bc3h04-0b88-4959-f144-57430d36bb56",
                column: "ConcurrencyStamp",
                value: "d4314901-fed1-4ed2-b42d-f170dbd45b88");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7dd3d04-0b88-4959-b277-57110d40bf56",
                column: "ConcurrencyStamp",
                value: "93a32f51-7eb3-480b-9b71-e36ab252d955");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4aa3d07-0c88-3332-d24d-57110f40fc56",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5de2222f-904c-4866-b85b-d0ee97956c9d", "AQAAAAEAACcQAAAAEJK2Bp9NA+7aoRjZZ3AzjDwpzComiIzMub0LYxG7mmuuw69Z6YUSjiQfXKZj3qmLJw==", "a7514be1-93dc-4085-85b9-dfcf7109957e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7ee3d04-0f61-3662-b249-57110f40fc56",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30e4f981-119d-4398-971e-9553c9f98b0e", "AQAAAAEAACcQAAAAEDgI3pJQDgj60gGZCihkd65DMNQ7kGkIMnaw17BSI4lamBgPvdyjjrkpcLwfz3YHQA==", "a000d7d1-38c4-4bd6-b361-5d6ac86d89f9" });
        }
    }
}
