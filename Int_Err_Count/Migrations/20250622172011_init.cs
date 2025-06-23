using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Int_Err_Count.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ErrorCount",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MASTIntegration_Shipment = table.Column<int>(type: "int", nullable: false),
                    OneVision_B2BASN = table.Column<int>(type: "int", nullable: false),
                    RPIntegration_US_ExceptionReport = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorCount", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ErrorCount");
        }
    }
}
