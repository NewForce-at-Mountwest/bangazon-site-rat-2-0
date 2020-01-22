using Microsoft.EntityFrameworkCore.Migrations;

namespace BangazonSite.Migrations
{
    public partial class ChangingSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3dc9de78-e50c-4721-91ff-744b6065bc7e", "AQAAAAEAACcQAAAAEHWgWwoTCSLmyFFswP9uiIIzznmGYVJ4TMiRPE7v6Bm/4wFj7LJEAt1aQTf0wZ3YwQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0dc24c07-f0ac-4d10-a189-301bf9df857c", "AQAAAAEAACcQAAAAECVmeKiGNMcq5crZjZFbBfqjmWYR+T3sKG3jXEzGIQstEshvQTX2Tv+gm32f1ZzorQ==" });
        }
    }
}
