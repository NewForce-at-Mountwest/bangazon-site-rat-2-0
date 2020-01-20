using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BangazonSite.Migrations
{
    public partial class SeedData1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Archived",
                table: "Products",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ProductTypeId",
                table: "Products",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "AccountCreated",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastActive",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardNumber = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PaymentTypes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentTypeId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateCompleted = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_PaymentTypes_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    OrderProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => x.OrderProductId);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "AccountCreated", "FirstName", "LastActive", "LastName", "StreetAddress" },
                values: new object[] { "00000000-ffff-ffff-ffff-ffffffffffff", 0, "d76d8a08-f40b-413d-9b52-e28692228e49", "ApplicationUser", "admin@admin.com", true, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEFjtUMksBYcJPEBHwI+LjmaTrg5eeObDawWW3MxJy1hy45lXFPt3YzSLiMvSg08dpw==", null, false, "7f434309-a4d9-48e9-9ebb-8803db794577", false, "admin@admin.com", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stinky", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Piere", "123 tra la la Lane" });

            migrationBuilder.InsertData(
                table: "ProductTypes",
                columns: new[] { "Id", "Category" },
                values: new object[,]
                {
                    { 1, "Toys" },
                    { 2, "Appliances" },
                    { 3, "Sporting Goods" },
                    { 4, "Home Decor" }
                });

            migrationBuilder.InsertData(
                table: "PaymentTypes",
                columns: new[] { "Id", "CardNumber", "DateCreated", "IsActive", "Name", "UserId" },
                values: new object[,]
                {
                    { 1, "4560857498651258", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Chase Visa", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 2, "8599665525897845", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Mastercard", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 3, "8500451278453287", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "American Express", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 4, "8700450012005487", new DateTime(2020, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Visa", "00000000-ffff-ffff-ffff-ffffffffffff" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Archived", "City", "Description", "LocalDelivery", "Price", "ProductImage", "ProductTypeId", "Quantity", "Title", "UserId" },
                values: new object[,]
                {
                    { 2, false, "Huntington", "To infinity and beyond", false, 20.0, null, 1, 50, "Buzz Lightyear", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 3, false, "Ironton", "Washes dishes", false, 250.0, null, 2, 50, "Dishwasher", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 1, false, "Ashland", "Aluminum", false, 30.0, null, 3, 50, "Baseball bat", "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 4, false, "Argillite", "Looks fierce, but will not bite", false, 200.0, null, 4, 32, "Bear rug", "00000000-ffff-ffff-ffff-ffffffffffff" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DateCompleted", "DateCreated", "PaymentTypeId", "UserId" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 4, null, new DateTime(2020, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 2, null, new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "00000000-ffff-ffff-ffff-ffffffffffff" },
                    { 3, null, new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "00000000-ffff-ffff-ffff-ffffffffffff" }
                });

            migrationBuilder.InsertData(
                table: "OrderProducts",
                columns: new[] { "OrderProductId", "OrderId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 4, 4, 4 },
                    { 2, 2, 2 },
                    { 3, 3, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_OrderId",
                table: "OrderProducts",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_ProductId",
                table: "OrderProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PaymentTypeId",
                table: "Orders",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentTypes_UserId",
                table: "PaymentTypes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeId",
                table: "Products",
                column: "ProductTypeId",
                principalTable: "ProductTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductTypes_ProductTypeId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropTable(
                name: "ProductTypes");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropIndex(
                name: "IX_Products_ProductTypeId",
                table: "Products");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff");

            migrationBuilder.DropColumn(
                name: "Archived",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "ProductTypeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "AccountCreated",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastActive",
                table: "AspNetUsers");
        }
    }
}
