using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDEA890BD07BB5AF9, NameHash = 0xD0217E81661C9C1D)]
    public class GcBackgroundSpaceEncounterSpawnConditions : NMSTemplate
    {
        /* 0x0 */ public bool NeedsEmptySystem;
        /* 0x1 */ public bool NeedsAbandonedSystem;
        /* 0x2 */ public bool NeedsPirateSystem;
        /* 0x3 */ public bool NeedsAsteroidField;
    }
}
