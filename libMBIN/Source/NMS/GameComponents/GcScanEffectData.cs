namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAC56837AAE45570A, NameHash = 0xF2988209)]
    public class GcScanEffectData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Colour Colour;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Id;
        [NMS(Index = 3)]
        /* 0x20 */ public float BasecolourIntensity;
        [NMS(Index = 12)]
        /* 0x24 */ public float FadeInTime;
        [NMS(Index = 13)]
        /* 0x28 */ public float FadeOutTime;
        [NMS(Index = 5)]
        /* 0x2C */ public float FresnelIntensity;
        [NMS(Index = 6)]
        /* 0x30 */ public float GlowIntensity;
        // size: 0x5
        public enum ScanEffectTypeEnum : uint {
            Building,
            TargetShip,
            Creature,
            Ground,
            Objects,
        }
        [NMS(Index = 1)]
        /* 0x34 */ public ScanEffectTypeEnum ScanEffectType;
        [NMS(Index = 4)]
        /* 0x38 */ public float ScanlinesSeparation;
        [NMS(Index = 7)]
        /* 0x3C */ public float WaveOffset;
        [NMS(Index = 9)]
        /* 0x40 */ public bool FixedUpAxis;
        [NMS(Index = 11)]
        /* 0x41 */ public bool ModelFade;
        [NMS(Index = 10)]
        /* 0x42 */ public bool Transparent;
        [NMS(Index = 8)]
        /* 0x43 */ public bool WaveActive;
    }
}
