namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x16429DA59B50B8CC, NameHash = 0x62CC6B49)]
    public class GcAudioPulseDemo : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public Vector2f InWarp;
        [NMS(Index = 1)]
        /* 0x08 */ public Vector2f Planet;
        [NMS(Index = 2)]
        /* 0x10 */ public Vector2f Space;
        [NMS(Index = 3)]
        /* 0x18 */ public Vector2f SpaceStation;
        [NMS(Index = 5)]
        /* 0x20 */ public Vector2f Wanted;
        [NMS(Index = 0)]
        /* 0x28 */ public float MixRateSeconds;
    }
}
