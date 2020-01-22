using Microsoft.EntityFrameworkCore.Migrations;

namespace BangazonSite.Migrations
{
    public partial class AddedtoOrderProd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductId",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cf79fa30-18e8-43da-9829-42bbf350bb93", "AQAAAAEAACcQAAAAEBiFL+1DZ4DA6S5ErCGpqT/e5axWmc5bTLbwI9jmLRSricrEu3yy0cmWlYCBNVJ+vw==" });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "OrderProductId", "OrderId", "ProductId" },
                values: new object[] { 6, 1, 4 });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "OrderProductId", "OrderId", "ProductId" },
                values: new object[] { 5, 1, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cdaaef6d-e97f-42fd-884b-bf1ebd42e6c4", "AQAAAAEAACcQAAAAEPa/8klspZkJG9g5tJPL8DfG10W4Nky4RyP6STXPusO5UOAksZWKPn/kwLJGD9W92w==" });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "OrderProductId", "OrderId", "ProductId" },
                values: new object[] { 4, 1, 4 });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "OrderProductId", "OrderId", "ProductId" },
                values: new object[] { 3, 1, 3 });
        }
    }
}
