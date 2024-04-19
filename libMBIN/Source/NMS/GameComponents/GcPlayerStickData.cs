namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA27F3C30CF0E4213, NameHash = 0x3375DA42DA55F3B3)]
    public class GcPlayerStickData : NMSTemplate
    {
        /* 0x00 */ public float Accelerate;
        /* 0x04 */ public float AccelerateAngle;
        /* 0x08 */ public float AcceleratorMinTime;
        /* 0x0C */ public float AcceleratorStickPoint;
        /* 0x10 */ public float StickyFactor;
        /* 0x14 */ public float Turn;
        /* 0x18 */ public float TurnFast;
    }
}
