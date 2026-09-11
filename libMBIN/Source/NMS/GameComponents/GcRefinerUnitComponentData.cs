using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEA8CE7824AD3942C, NameHash = 0x77A67F2A)]
    public class GcRefinerUnitComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcMaintenanceComponentData MaintenanceData;
        [NMS(Index = 3)]
        /* 0x430 */ public Vector3f InputOffset;
        [NMS(Index = 4)]
        /* 0x440 */ public Vector3f OutputOffset;
        [NMS(Index = 1)]
        /* 0x450 */ public int NumInputs;
        [NMS(Index = 2)]
        /* 0x454 */ public bool IsCooker;
    }
}
