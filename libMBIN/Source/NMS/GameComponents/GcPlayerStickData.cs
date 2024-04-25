namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA27F3C30CF0E4213, NameHash = 0x3375DA42DA55F3B3)]
    public class GcPlayerStickData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public float Accelerate;
        [NMS(Index = 3)]
        /* 0x04 */ public float AccelerateAngle;
        [NMS(Index = 1)]
        /* 0x08 */ public float AcceleratorMinTime;
        [NMS(Index = 0)]
        /* 0x0C */ public float AcceleratorStickPoint;
        [NMS(Index = 6)]
        /* 0x10 */ public float StickyFactor;
        [NMS(Index = 4)]
        /* 0x14 */ public float Turn;
        [NMS(Index = 5)]
        /* 0x18 */ public float TurnFast;
    }
}
