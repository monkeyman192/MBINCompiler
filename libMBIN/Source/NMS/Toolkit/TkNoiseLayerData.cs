namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC6E7F5301C2A5B2A, NameHash = 0x474596B01166F6A6)]
    public class TkNoiseLayerData : NMSTemplate
    {
        /* 0x00 */ public float FrequencyScaleY;
        /* 0x04 */ public float Height;
        // size: 0xB
        public enum NoiseTypeEnum : uint {
            Plane,
            Check,
            Sine,
            Smooth,
            Fractal,
            Ridged,
            Billow,
            Erosion,
            Volcanic,
            Glacial,
            Plateau,
        }
        /* 0x08 */ public NoiseTypeEnum NoiseType;
        /* 0x0C */ public int Octaves;
        /* 0x10 */ public float RegionRatio;
        /* 0x14 */ public float RegionScale;
        /* 0x18 */ public int SeedOffset;
        /* 0x1C */ public float TurbulenceAmplitude;
        /* 0x20 */ public float TurbulenceFrequency;
        /* 0x24 */ public int TurbulenceOctaves;
        /* 0x28 */ public float Width;
        /* 0x2C */ public bool Absolute;
        /* 0x2D */ public bool Active;
        /* 0x2E */ public bool Invert;
        /* 0x2F */ public bool Subtract;
    }
}
