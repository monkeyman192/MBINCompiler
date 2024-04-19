namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEE335C704F87FFA8, NameHash = 0xB150A87B0DD42807)]
    public class GcDistanceScaleComponentData : NMSTemplate
    {
        /* 0x00 */ public float MaxDistance;
        /* 0x04 */ public float MaxHeight;
        /* 0x08 */ public float MinDistance;
        /* 0x0C */ public float MinHeight;
        /* 0x10 */ public float Scale;
        /* 0x14 */ public bool DisabledWhenOnFreighter;
        /* 0x15 */ public bool UseGlobals;
    }
}
