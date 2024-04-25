namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA2624B0255DB35E9, NameHash = 0xF401654236F18FA9)]
    public class GcAsteroidGenerationData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public Vector2f NoiseRange;
        [NMS(Index = 1)]
        /* 0x08 */ public Vector2f ScaleVariance;
        [NMS(Index = 5)]
        /* 0x10 */ public float FadeRange;
        [NMS(Index = 2)]
        /* 0x14 */ public int Health;
        [NMS(Index = 6)]
        /* 0x18 */ public float NoiseScale;
        [NMS(Index = 0)]
        /* 0x1C */ public float Scale;
        [NMS(Index = 3)]
        /* 0x20 */ public float Spacing;
    }
}
