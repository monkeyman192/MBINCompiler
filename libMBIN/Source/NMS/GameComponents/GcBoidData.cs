namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBA401D0204B9962A, NameHash = 0xF368F056)]
    public class GcBoidData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public float Alignment;
        [NMS(Index = 0)]
        /* 0x04 */ public float Coherence;
        [NMS(Index = 5)]
        /* 0x08 */ public float DirectionBrake;
        [NMS(Index = 4)]
        /* 0x0C */ public float Follow;
        [NMS(Index = 9)]
        /* 0x10 */ public float InitFacingOffset;
        [NMS(Index = 8)]
        /* 0x14 */ public float InitOffset;
        [NMS(Index = 7)]
        /* 0x18 */ public float InitTime;
        [NMS(Index = 10)]
        /* 0x1C */ public float LeadTime;
        [NMS(Index = 6)]
        /* 0x20 */ public float MaxSpeed;
        [NMS(Index = 2)]
        /* 0x24 */ public float Separation;
        [NMS(Index = 3)]
        /* 0x28 */ public float Spacing;
    }
}
