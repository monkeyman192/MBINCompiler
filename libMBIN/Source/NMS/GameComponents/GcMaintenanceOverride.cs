using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x32C5481ACF17A6FD, NameHash = 0xEEECBBD3)]
    public class GcMaintenanceOverride : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public GcMaintenanceComponentData Data;
        [NMS(Index = 0)]
        /* 0x3F0 */ public NMSString0x10 ID;
    }
}
