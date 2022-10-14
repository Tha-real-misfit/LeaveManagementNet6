using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a9bc3h04-0b88-4959-f144-57430d36bb56", "321d205a-7276-4ee0-8406-d40ea35b21e9", "User", "USER" },
                    { "f7dd3d04-0b88-4959-b277-57110d40bf56", "8d9b9e3a-4863-4023-a59b-90f8e1c7a942", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Datejoined", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "c4aa3d07-0c88-3332-d24d-57110f40fc56", 0, "fcaa64e8-cac6-4272-9ae8-9042c3f43dd5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEN5NqpnJFzdAuMsKlPPdBDbFOZXwOSySdlNA9VyuxFi+1OJRraMnM22RYB70GP9sjg==", null, false, "146743e5-dd56-486b-ad10-045b09b0232f", null, false, null },
                    { "e7ee3d04-0f61-3662-b249-57110f40fc56", 0, "7aab2001-25ac-4e84-8d54-32a372253c68", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEPkXY8wub3+3WXhFc4M+NAjVCaHNUV6tOFnQQExWHzOaQgzOvGb5M+/0D0+rQ0adBA==", null, false, "c96f021b-1b98-4716-b3d7-cb9d03708416", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a9bc3h04-0b88-4959-f144-57430d36bb56", "c4aa3d07-0c88-3332-d24d-57110f40fc56" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f7dd3d04-0b88-4959-b277-57110d40bf56", "e7ee3d04-0f61-3662-b249-57110f40fc56" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a9bc3h04-0b88-4959-f144-57430d36bb56", "c4aa3d07-0c88-3332-d24d-57110f40fc56" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f7dd3d04-0b88-4959-b277-57110d40bf56", "e7ee3d04-0f61-3662-b249-57110f40fc56" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9bc3h04-0b88-4959-f144-57430d36bb56");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7dd3d04-0b88-4959-b277-57110d40bf56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4aa3d07-0c88-3332-d24d-57110f40fc56");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7ee3d04-0f61-3662-b249-57110f40fc56");
        }
    }
}
