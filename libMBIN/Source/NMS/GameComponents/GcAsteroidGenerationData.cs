namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA2624B0255DB35E9, NameHash = 0xF401654236F18FA9)]
    public class GcAsteroidGenerationData : NMSTemplate
    {
        /* 0x00 */ public Vector2f NoiseRange;
        /* 0x08 */ public Vector2f ScaleVariance;
        /* 0x10 */ public float FadeRange;
        /* 0x14 */ public int Health;
        /* 0x18 */ public float NoiseScale;
        /* 0x1C */ public float Scale;
        /* 0x20 */ public float Spacing;
    }
}
