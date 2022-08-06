using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4F4457FDB9B16E09, NameHash = 0xC455782DFAD32032)]
    public class GcBoidData : NMSTemplate
    {
        /* 0x000 */ public float Coherence;             // 3F000000
        /* 0x004 */ public float Alignment;             // 3E4CCCCD
        /* 0x008 */ public float Separation;            // 3F800000
        /* 0x00C */ public float Spacing;               // 41200000
        /* 0x010 */ public float Follow;                // 3F000000
        /* 0x014 */ public float DirectionBrake;        // 40000000
        /* 0x018 */ public float MaxSpeed;              // 43960000
        /* 0x01C */ public float InitTime;              // 3F800000
        /* 0x020 */ public float InitOffset;            // 3DCCCCCD
        /* 0x024 */ public float InitFacingOffset;      // 3F800000
        /* 0x028 */ public float LeadTime;              // 3F800000
    }
}