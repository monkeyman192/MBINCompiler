using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9882AD139E4A982F, NameHash = 0xFCC8749007B86A54)]
    public class GcSettlementJobDetails : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A PerkTitle;
        /* 0x20 */ public NMSString0x20A InTextTitle;
        /* 0x40 */ public GcSettlementStatType Stat;
    }
}
