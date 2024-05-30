using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD6C8A1185C100BC7, NameHash = 0xB2890EFB7222A4E4)]
    public class GcMaintenanceOverride : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public GcMaintenanceComponentData Data;
        [NMS(Index = 0)]
        /* 0x3F0 */ public NMSString0x10 ID;
    }
}
