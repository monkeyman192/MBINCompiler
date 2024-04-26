using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x91E93EDA5AE87025, NameHash = 0x470EE61C4698CBB9)]
    public class GcMissionConditionIsPlayerWanted : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int Level;
        [NMS(Index = 1)]
        /* 0x4 */ public TkEqualityEnum Test;
    }
}
