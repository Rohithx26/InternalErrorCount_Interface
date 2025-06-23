using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Int_Err_Count.Migrations
{
    /// <inheritdoc />
    public partial class addPrimary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ErrorCount",
                table: "ErrorCount");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ErrorCount",
                table: "ErrorCount",
                columns: new[] { "Id_Name", "Date" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ErrorCount",
                table: "ErrorCount");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ErrorCount",
                table: "ErrorCount",
                column: "Id_Name");
        }
    }
}
