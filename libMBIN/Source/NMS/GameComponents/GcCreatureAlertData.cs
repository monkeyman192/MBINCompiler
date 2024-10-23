using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x99928BF01647BF2, NameHash = 0xC5BA1790)]
    public class GcCreatureAlertData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcCreatureTypes AlertInitiator;
        [NMS(Index = 0)]
        /* 0x04 */ public GcCreatureTypes AlertTarget;
        [NMS(Index = 5)]
        /* 0x08 */ public float FleeRange;
        [NMS(Index = 2)]
        /* 0x0C */ public float HearingRange;
        [NMS(Index = 4)]
        /* 0x10 */ public float SightAngle;
        [NMS(Index = 3)]
        /* 0x14 */ public float SightRange;
    }
}
