using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3CC628DBF83F86AD, NameHash = 0xD2A73F296D17A20)]
    public class GcRefinerUnitComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        [NMS(Index = 1)]
        /* 0x3F0 */ public int NumInputs;
        [NMS(Index = 2)]
        /* 0x3F4 */ public bool IsCooker;
    }
}
