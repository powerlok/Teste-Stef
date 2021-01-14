using Microsoft.EntityFrameworkCore.Migrations;

namespace Examples.Charge.Infra.Data.Configuration.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "dbo",
                table: "Person",
                columns: new[] { "BusinessEntityID", "Name" },
                values: new object[] { 2, "User Two" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dbo",
                table: "Person",
                keyColumn: "BusinessEntityID",
                keyValue: 2);
        }
    }
}
