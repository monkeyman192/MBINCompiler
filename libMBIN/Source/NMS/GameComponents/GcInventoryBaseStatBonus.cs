using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x65CA4A0E3CC2A972, NameHash = 0xCBEE12530E8A51CD)]
    public class GcInventoryBaseStatBonus : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcStatsTypes StatType;
        [NMS(Index = 1)]
        /* 0x4 */ public bool LessIsBetter;
    }
}
