using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Int_Err_Count.Models
{
    public class ErrorCount
    {
        //[Key]
        public string Id_Name { get; set; }
        public DateTime Date { get; set; }
        public int MASTIntegration_Shipment { get; set; }
        public int OneVision_B2BASN { get; set; }
        public int RPIntegration_US_ExceptionReport { get; set; }
        public int MASTIntegration_MY_Invoice { get; set; }
        public int MASTIntegration_SG_Invoice { get; set; }
        public int EBS3PLIntegration_ID_Salesorder_Reprocessing { get; set; }
        public int EBS3PLIntegration_TR_Salesorder_Reprocessing { get; set; }
        public int MASTIntegration_SG_Salesorder_Reprocessing { get; set; }
        public int MASTIntegration_MY_Salesorder_Reprocessing { get; set; }
        public int MASTIntegration_MY_LotReprocessing { get; set; }
        [Column("1CIntegration_All_Exceptions")]
        public int OneCIntegration_All_Exceptions { get; set; }
        public int EBSPTBIntegration_Inspection_EBS_to_SAMM { get; set; }
        public int EBSHungaryIntegrations_HTA_Files { get; set; }
        public int RPIntegration_Salesorder_Reprocessing { get; set; }
        public int RPIntegration_LotReprocessing { get; set; }
        public int RPIntegration_Receipt_Authorization { get; set; }
        public int RPIntegration_Inventory_Transefer { get; set; }
        public int RPIntegration_Inventory_Adjustment { get; set; }
        public int RPIntegration_Inventory_Reconcilation { get; set; }
        public int ASN_Integration_Hamble_ASN { get; set; }
        public int ASN_Integration_SV_ASN { get; set; }
        public int EDICOM_MY_All_Exceptions { get; set; }
        public int SFDC_All_Exceptions { get; set; }
        public int GPSIntegrations_US_All_Exceptions { get; set; }
        public int EBSJDA_Integration_US_All_Exceptions { get; set; }
        public int GPSIntegrations_UK_All_Exceptions { get; set; }
        public int EBSJDA_Integration_UK_All_Exceptions { get; set; }
        public int AgileVeeva_Integration_All_Exceptions { get; set; }
        public int HCMIntegration_All_Exceptions { get; set; }
        public int EDICOM_MX_Invoice_Inbound { get; set; }
        public int Visidot_Integration_JDADP { get; set; }
        public int JDAKNAPPIntegration_JDA_KNAPP  { get; set; }
        public int EBSMAST3PLIntegration_INVONHANDFromMY3PLTOEBS { get; set; }
        public DateTime Created { get; set; } = DateTime.UtcNow;
        public DateTime LastModified { get; set; } = DateTime.UtcNow;
        public string CreatedBy { get; set; } = "Rohith";
        public string LastModifiedBy { get; set; } = "Rohith";
    }   
}
