using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x88056CE9C02E9601, NameHash = 0x39C7A4F372F6707C)]
    public class GcBountySpawnInfo : NMSTemplate
    {
        /* 0x000 */ public GcAIShipSpawnData Data;
        /* 0x1C0 */ public NMSString0x20A Label;
        /* 0x1E0 */ public NMSString0x10 AttackData;
        /* 0x1F0 */ public NMSString0x10 Id;
        /* 0x200 */ public TkTextureResource Icon;
    }
}
