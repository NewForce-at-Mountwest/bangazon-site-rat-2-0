using Microsoft.EntityFrameworkCore.Migrations;

namespace BangazonSite.Migrations
{
    public partial class FixedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0dc24c07-f0ac-4d10-a189-301bf9df857c", "AQAAAAEAACcQAAAAECVmeKiGNMcq5crZjZFbBfqjmWYR+T3sKG3jXEzGIQstEshvQTX2Tv+gm32f1ZzorQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f81315b0-ebbb-42fd-9c66-b9ed4b53b261", "AQAAAAEAACcQAAAAEJU+TQhUhZn9TkMpLyPL9nW+RIree9yELiwEfXT5YwLjnI/rj8QlbGMFQnXJ2d8U9g==" });
        }
    }
}
