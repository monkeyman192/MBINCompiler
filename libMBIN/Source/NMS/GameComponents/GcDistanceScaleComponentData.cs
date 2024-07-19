namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x97C9FEF84459C10F, NameHash = 0x545566B9)]
    public class GcDistanceScaleComponentData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public float MaxDistance;
        [NMS(Index = 5)]
        /* 0x04 */ public float MaxHeight;
        [NMS(Index = 2)]
        /* 0x08 */ public float MinDistance;
        [NMS(Index = 4)]
        /* 0x0C */ public float MinHeight;
        [NMS(Index = 1)]
        /* 0x10 */ public float Scale;
        [NMS(Index = 6)]
        /* 0x14 */ public bool DisabledWhenOnFreighter;
        [NMS(Index = 0)]
        /* 0x15 */ public bool UseGlobals;
    }
}
