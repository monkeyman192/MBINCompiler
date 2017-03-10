namespace MBINCompiler.Models.Structs
{
    public class GcBoidData : NMSTemplate
    {
        /* 0x000 */ public float Coherence;
        /* 0x004 */ public float Alignment;
        /* 0x008 */ public float Separation;
        /* 0x00C */ public float Spacing;
        /* 0x010 */ public float Follow;
        /* 0x014 */ public float DirectionBrake;
        /* 0x018 */ public float MaxSpeed;
        /* 0x01C */ public float InitTime;
        /* 0x020 */ public float InitOffset;
        /* 0x024 */ public float InitFacingOffset;
        /* 0x028 */ public float LeadTime;
    }
}
