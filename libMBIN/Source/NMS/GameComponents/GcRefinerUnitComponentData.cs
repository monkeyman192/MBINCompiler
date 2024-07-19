using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x71B38FD150E5C36C, NameHash = 0x77A67F2A)]
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
