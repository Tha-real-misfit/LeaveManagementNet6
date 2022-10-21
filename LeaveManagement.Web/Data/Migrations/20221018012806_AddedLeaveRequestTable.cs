using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedLeaveRequestTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LeaveRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    DateRequested = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RequestComments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Approved = table.Column<bool>(type: "bit", nullable: true),
                    Cancelled = table.Column<bool>(type: "bit", nullable: false),
                    RequestingEmployeeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LeaveRequests_LeaveTypes_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRequests_LeaveTypeId",
                table: "LeaveRequests",
                column: "LeaveTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LeaveRequests");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9bc3h04-0b88-4959-f144-57430d36bb56",
                column: "ConcurrencyStamp",
                value: "b2c198a7-ef13-41ea-a058-7e1bd1290edc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7dd3d04-0b88-4959-b277-57110d40bf56",
                column: "ConcurrencyStamp",
                value: "f50fda48-c1b8-4be6-b61a-f33fea5e561b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4aa3d07-0c88-3332-d24d-57110f40fc56",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16fb17b6-4534-410c-892b-4c98d0b9a095", "AQAAAAEAACcQAAAAEKlNz20aWf2+fvCAzuBcbTEKNqPzXywlgYlBue4nBQZ+hwlA519pXJi72jBhv/UH/Q==", "7259ad96-3043-4aa9-9449-aa9ad173c0b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7ee3d04-0f61-3662-b249-57110f40fc56",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef586fa6-b189-4fff-9ffc-29a72fe4a5ad", "AQAAAAEAACcQAAAAEH76KmaOVRtpPPsnaDxY0HQbUXsza2EQIZdoUJT3Y4HlNrexE3ImRKr3ExVv683nOg==", "7ac66225-9c3e-4f73-8e28-20e5a86826b6" });
        }
    }
}
