using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace vending_machine.Migrations
{
    public partial class DBVendig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            //migrationBuilder.Sql( "INSERT INTO catalogodb.drinks(DrinkId,Name,Price,Date,Stock) VALUES(2,'Vodka',99.2,'2020-08-17 16:28:17.000000',2.1)");

            migrationBuilder.CreateTable(
                name: "Drinks",
                columns: table => new
                {
                    DrinkId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 80, nullable: false),
                    Price = table.Column<decimal>(type: "Decimal(8,1)", nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Stock = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drinks", x => x.DrinkId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropTable("Delete from Drinks" );
            migrationBuilder.DropTable(
                name: "Drinks");
        }
    }
}
