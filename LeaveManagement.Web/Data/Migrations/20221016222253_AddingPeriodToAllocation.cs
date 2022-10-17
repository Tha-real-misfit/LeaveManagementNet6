using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "16fb17b6-4534-410c-892b-4c98d0b9a095", true, "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEKlNz20aWf2+fvCAzuBcbTEKNqPzXywlgYlBue4nBQZ+hwlA519pXJi72jBhv/UH/Q==", "7259ad96-3043-4aa9-9449-aa9ad173c0b1", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7ee3d04-0f61-3662-b249-57110f40fc56",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "ef586fa6-b189-4fff-9ffc-29a72fe4a5ad", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEH76KmaOVRtpPPsnaDxY0HQbUXsza2EQIZdoUJT3Y4HlNrexE3ImRKr3ExVv683nOg==", "7ac66225-9c3e-4f73-8e28-20e5a86826b6", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a9bc3h04-0b88-4959-f144-57430d36bb56",
                column: "ConcurrencyStamp",
                value: "321d205a-7276-4ee0-8406-d40ea35b21e9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7dd3d04-0b88-4959-b277-57110d40bf56",
                column: "ConcurrencyStamp",
                value: "8d9b9e3a-4863-4023-a59b-90f8e1c7a942");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4aa3d07-0c88-3332-d24d-57110f40fc56",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "fcaa64e8-cac6-4272-9ae8-9042c3f43dd5", false, null, "AQAAAAEAACcQAAAAEN5NqpnJFzdAuMsKlPPdBDbFOZXwOSySdlNA9VyuxFi+1OJRraMnM22RYB70GP9sjg==", "146743e5-dd56-486b-ad10-045b09b0232f", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7ee3d04-0f61-3662-b249-57110f40fc56",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7aab2001-25ac-4e84-8d54-32a372253c68", false, null, "AQAAAAEAACcQAAAAEPkXY8wub3+3WXhFc4M+NAjVCaHNUV6tOFnQQExWHzOaQgzOvGb5M+/0D0+rQ0adBA==", "c96f021b-1b98-4716-b3d7-cb9d03708416", null });
        }
    }
}
