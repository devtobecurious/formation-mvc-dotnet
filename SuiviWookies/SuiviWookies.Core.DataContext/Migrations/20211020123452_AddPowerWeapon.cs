using Microsoft.EntityFrameworkCore.Migrations;

namespace SuiviWookies.Core.DataContext.Migrations
{
    public partial class AddPowerWeapon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Power",
                table: "Weapon",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Power",
                table: "Weapon");
        }
    }
}
