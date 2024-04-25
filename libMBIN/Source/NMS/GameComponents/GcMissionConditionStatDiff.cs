using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE7FB498200797448, NameHash = 0x4315517EE11B4860)]
    public class GcMissionConditionStatDiff : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 CurrentStat;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 TargetStat;
        [NMS(Index = 2)]
        /* 0x20 */ public int AmountPastTarget;
        [NMS(Index = 3)]
        /* 0x24 */ public TkEqualityEnum Test;
    }
}
