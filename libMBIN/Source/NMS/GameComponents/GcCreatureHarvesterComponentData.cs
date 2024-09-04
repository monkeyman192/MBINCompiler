using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2D86E111A0BD4358, NameHash = 0x1DA81BEB)]
    public class GcCreatureHarvesterComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        [NMS(Index = 1)]
        /* 0x3F0 */ public int NumSlots;
    }
}
