using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3A674B1D349980A0, NameHash = 0xC9F9F1B2965E5228)]
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
