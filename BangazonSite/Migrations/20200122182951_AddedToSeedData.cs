using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BangazonSite.Migrations
{
    public partial class AddedToSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cdaaef6d-e97f-42fd-884b-bf1ebd42e6c4", "AQAAAAEAACcQAAAAEPa/8klspZkJG9g5tJPL8DfG10W4Nky4RyP6STXPusO5UOAksZWKPn/kwLJGD9W92w==" });

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "OrderProductId",
                keyValue: 2,
                column: "OrderId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "OrderProductId",
                keyValue: 3,
                column: "OrderId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "OrderProductId",
                keyValue: 4,
                column: "OrderId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCompleted",
                value: new DateTime(2020, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCompleted",
                value: new DateTime(2020, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCompleted",
                value: new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3dc9de78-e50c-4721-91ff-744b6065bc7e", "AQAAAAEAACcQAAAAEHWgWwoTCSLmyFFswP9uiIIzznmGYVJ4TMiRPE7v6Bm/4wFj7LJEAt1aQTf0wZ3YwQ==" });

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "OrderProductId",
                keyValue: 2,
                column: "OrderId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "OrderProductId",
                keyValue: 3,
                column: "OrderId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "OrderProducts",
                keyColumn: "OrderProductId",
                keyValue: 4,
                column: "OrderId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateCompleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateCompleted",
                value: null);

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateCompleted",
                value: null);
        }
    }
}
