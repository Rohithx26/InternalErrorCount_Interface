using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Int_Err_Count.Migrations
{
    /// <inheritdoc />
    public partial class addPK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ErrorCount",
                newName: "Id_Name");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "ErrorCount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "ErrorCount",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "ErrorCount",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "ErrorCount",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "ErrorCount");

            migrationBuilder.RenameColumn(
                name: "Id_Name",
                table: "ErrorCount",
                newName: "Id");
        }
    }
}
