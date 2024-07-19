using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE051ED374C706CE3, NameHash = 0xEC38CA46)]
    public class GcStatsBonus : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float Bonus;
        [NMS(Index = 2)]
        /* 0x4 */ public int Level;
        [NMS(Index = 0)]
        /* 0x8 */ public GcStatsTypes Stat;
    }
}
