using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9BDB48699BA799AD, NameHash = 0x978A21D1)]
    public class GcCostDifficultyGroundCombat : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A CostStringCantAfford;
        [NMS(Index = 1)]
        /* 0x20 */ public GcCombatTimerDifficultyOption GroundCombatTimers;
        [NMS(Index = 0)]
        /* 0x24 */ public TkEqualityEnum Test;
    }
}
