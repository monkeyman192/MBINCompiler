using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDB77A13A2CD159F0, NameHash = 0x59D1F229)]
    public class GcMissionSequenceModifyStat : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Stat;
        [NMS(Index = 1)]
        /* 0x10 */ public int Amount;
        [NMS(Index = 2)]
        /* 0x14 */ public GcStatModifyType ModifyType;
    }
}
