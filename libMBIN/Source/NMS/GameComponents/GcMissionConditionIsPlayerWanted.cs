using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF134BF0D75BA0E26, NameHash = 0x33B54D6)]
    public class GcMissionConditionIsPlayerWanted : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int Level;
        [NMS(Index = 1)]
        /* 0x4 */ public TkEqualityEnum Test;
    }
}
