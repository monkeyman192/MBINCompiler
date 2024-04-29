using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x37A9323647E3813D, NameHash = 0xFCC8749007B86A54)]
    public class GcSettlementJobDetails : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A InTextTitle;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x20A PerkTitle;
        [NMS(Index = 2)]
        /* 0x40 */ public GcSettlementStatType Stat;
    }
}
