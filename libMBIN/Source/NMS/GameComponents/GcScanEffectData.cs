namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1D30CF3BCBA8A73D, NameHash = 0xCB9E3018E759F166)]
    public class GcScanEffectData : NMSTemplate
    {
        /* 0x00 */ public Colour Colour;
        /* 0x10 */ public NMSString0x10 Id;
        /* 0x20 */ public float BasecolourIntensity;
        /* 0x24 */ public float FadeInTime;
        /* 0x28 */ public float FadeOutTime;
        /* 0x2C */ public float FresnelIntensity;
        /* 0x30 */ public float GlowIntensity;
        // size: 0x5
        public enum ScanEffectTypeEnum : uint {
            Building,
            TargetShip,
            Creature,
            Ground,
            Objects,
        }
        /* 0x34 */ public ScanEffectTypeEnum ScanEffectType;
        /* 0x38 */ public float ScanlinesSeparation;
        /* 0x3C */ public float WaveOffset;
        /* 0x40 */ public bool FixedUpAxis;
        /* 0x41 */ public bool ModelFade;
        /* 0x42 */ public bool Transparent;
        /* 0x43 */ public bool WaveActive;
    }
}
