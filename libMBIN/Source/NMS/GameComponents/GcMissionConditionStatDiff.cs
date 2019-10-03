using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0xD327EBA3598181D5, NameHash = 0x4315517EE11B4860)]
    public class GcMissionConditionStatDiff : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string CurrentStat;
        [NMS(Size = 0x10)]
        /* 0x10 */ public string TargetStat;
        /* 0x20 */ public int AmountPastTarget;
        /* 0x24 */ public TkEqualityEnum Test;
    }
}
