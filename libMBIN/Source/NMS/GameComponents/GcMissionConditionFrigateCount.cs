using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x42E0633334CE0FFD, NameHash = 0x81D792A0622C83B1)]
    public class GcMissionConditionFrigateCount : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int FrigateCount;
        [NMS(Index = 1)]
        /* 0x4 */ public TkEqualityEnum Test;
    }
}
