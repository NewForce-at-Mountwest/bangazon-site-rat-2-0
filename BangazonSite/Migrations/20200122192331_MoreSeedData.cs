using Microsoft.EntityFrameworkCore.Migrations;

namespace BangazonSite.Migrations
{
    public partial class MoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "06e0c1a8-9581-43a5-bb11-1bc0d04f5b9a", "AQAAAAEAACcQAAAAEB8uyMVzETQdrFTfzZGN9mSzlGQ0Go+h1qqpK36KRQh/l6S30eXDzLFphRr2zIOVIQ==" });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "OrderProductId", "OrderId", "ProductId" },
                values: new object[] { 7, 1, 4 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Archived", "City", "Description", "LocalDelivery", "Price", "ProductImage", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[,]
                {
                    { 9, false, "Ashland", "Yeti", false, 25.0, null, 3, 50, "Coffee Cup", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 6, true, "Huntington", "Women's Size Small, Winnie the Pooh", false, 18.0, null, 1, 25, "Pajamas", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 7, false, "Ironton", "Dell Touch Screen All-In-One", true, 320.0, null, 2, 5, "Computer", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 8, true, "Argillite", "Khaki, the Best", true, 25.0, null, 4, 36, "Pants", "00000000-ffff-ffff-ffff-ffffffffffff" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderProducts",
                keyColumn: "OrderProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

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
        }
    }
}
