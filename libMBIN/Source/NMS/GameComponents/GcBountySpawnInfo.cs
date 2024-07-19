using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5758FA0146BBC449, NameHash = 0x4B2DD6D3)]
    public class GcBountySpawnInfo : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public GcAIShipSpawnData Data;
        [NMS(Index = 4)]
        /* 0x160 */ public NMSString0x20A Label;
        [NMS(Index = 3)]
        /* 0x180 */ public TkTextureResource Icon;
        [NMS(Index = 2)]
        /* 0x198 */ public NMSString0x10 AttackData;
        [NMS(Index = 0)]
        /* 0x1A8 */ public NMSString0x10 Id;
    }
}
