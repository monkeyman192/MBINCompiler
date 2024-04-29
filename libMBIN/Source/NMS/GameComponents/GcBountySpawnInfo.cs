using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x509604DE2B001503, NameHash = 0x39C7A4F372F6707C)]
    public class GcBountySpawnInfo : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public GcAIShipSpawnData Data;
        [NMS(Index = 4)]
        /* 0x1C0 */ public NMSString0x20A Label;
        [NMS(Index = 2)]
        /* 0x1E0 */ public NMSString0x10 AttackData;
        [NMS(Index = 0)]
        /* 0x1F0 */ public NMSString0x10 Id;
        [NMS(Index = 3)]
        /* 0x200 */ public TkTextureResource Icon;
    }
}
