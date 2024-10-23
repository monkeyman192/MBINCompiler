using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCAEEB9A363FB90E6, NameHash = 0xA7953289)]
    public class GcInventoryBaseStatBonus : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcStatsTypes StatType;
        [NMS(Index = 1)]
        /* 0x4 */ public bool LessIsBetter;
    }
}
