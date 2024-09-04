using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x69DCEC05AA13A42E, NameHash = 0xA7953289)]
    public class GcInventoryBaseStatBonus : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcStatsTypes StatType;
        [NMS(Index = 1)]
        /* 0x4 */ public bool LessIsBetter;
    }
}
