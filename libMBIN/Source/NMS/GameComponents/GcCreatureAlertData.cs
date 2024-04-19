using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD6760925854E6D79, NameHash = 0xFFF2D3D18F84C008)]
    public class GcCreatureAlertData : NMSTemplate
    {
        /* 0x00 */ public GcCreatureTypes AlertInitiator;
        /* 0x04 */ public GcCreatureTypes AlertTarget;
        /* 0x08 */ public float FleeRange;
        /* 0x0C */ public float HearingRange;
        /* 0x10 */ public float SightAngle;
        /* 0x14 */ public float SightRange;
    }
}
