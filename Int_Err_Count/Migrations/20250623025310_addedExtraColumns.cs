using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Int_Err_Count.Migrations
{
    /// <inheritdoc />
    public partial class addedExtraColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "1CIntegration_All_Exceptions",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ASN_Integration_Hamble_ASN",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ASN_Integration_SV_ASN",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AgileVeeva_Integration_All_Exceptions",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EBS3PLIntegration_ID_Salesorder_Reprocessing",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EBS3PLIntegration_TR_Salesorder_Reprocessing",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EBSHungaryIntegrations_HTA_Files",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EBSJDA_Integration_UK_All_Exceptions",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EBSJDA_Integration_US_All_Exceptions",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EBSMAST3PLIntegration_INVONHANDFromMY3PLTOEBS",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EBSPTBIntegration_Inspection_EBS_to_SAMM",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EDICOM_MX_Invoice_Inbound",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EDICOM_MY_All_Exceptions",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GPSIntegrations_UK_All_Exceptions",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GPSIntegrations_US_All_Exceptions",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HCMIntegration_All_Exceptions",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "JDAKNAPPIntegration_JDA_KNAPP",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MASTIntegration_MY_Invoice",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MASTIntegration_MY_LotReprocessing",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MASTIntegration_MY_Salesorder_Reprocessing",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MASTIntegration_SG_Invoice",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MASTIntegration_SG_Salesorder_Reprocessing",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RPIntegration_Inventory_Adjustment",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RPIntegration_Inventory_Reconcilation",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RPIntegration_Inventory_Transefer",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RPIntegration_LotReprocessing",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RPIntegration_Receipt_Authorization",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RPIntegration_Salesorder_Reprocessing",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SFDC_All_Exceptions",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Visidot_Integration_JDADP",
                table: "ErrorCount",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "1CIntegration_All_Exceptions",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "ASN_Integration_Hamble_ASN",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "ASN_Integration_SV_ASN",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "AgileVeeva_Integration_All_Exceptions",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "EBS3PLIntegration_ID_Salesorder_Reprocessing",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "EBS3PLIntegration_TR_Salesorder_Reprocessing",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "EBSHungaryIntegrations_HTA_Files",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "EBSJDA_Integration_UK_All_Exceptions",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "EBSJDA_Integration_US_All_Exceptions",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "EBSMAST3PLIntegration_INVONHANDFromMY3PLTOEBS",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "EBSPTBIntegration_Inspection_EBS_to_SAMM",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "EDICOM_MX_Invoice_Inbound",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "EDICOM_MY_All_Exceptions",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "GPSIntegrations_UK_All_Exceptions",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "GPSIntegrations_US_All_Exceptions",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "HCMIntegration_All_Exceptions",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "JDAKNAPPIntegration_JDA_KNAPP",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "MASTIntegration_MY_Invoice",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "MASTIntegration_MY_LotReprocessing",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "MASTIntegration_MY_Salesorder_Reprocessing",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "MASTIntegration_SG_Invoice",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "MASTIntegration_SG_Salesorder_Reprocessing",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "RPIntegration_Inventory_Adjustment",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "RPIntegration_Inventory_Reconcilation",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "RPIntegration_Inventory_Transefer",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "RPIntegration_LotReprocessing",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "RPIntegration_Receipt_Authorization",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "RPIntegration_Salesorder_Reprocessing",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "SFDC_All_Exceptions",
                table: "ErrorCount");

            migrationBuilder.DropColumn(
                name: "Visidot_Integration_JDADP",
                table: "ErrorCount");
        }
    }
}
