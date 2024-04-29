namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7C81D2EB6295662C, NameHash = 0x474596B01166F6A6)]
    public class TkNoiseLayerData : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x00 */ public float FrequencyScaleY;
        [NMS(Index = 5)]
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
        [NMS(Index = 4)]
        /* 0x08 */ public NoiseTypeEnum NoiseType;
        [NMS(Index = 7)]
        /* 0x0C */ public int Octaves;
        [NMS(Index = 9)]
        /* 0x10 */ public float RegionRatio;
        [NMS(Index = 10)]
        /* 0x14 */ public float RegionScale;
        [NMS(Index = 14)]
        /* 0x18 */ public int SeedOffset;
        [NMS(Index = 12)]
        /* 0x1C */ public float TurbulenceAmplitude;
        [NMS(Index = 11)]
        /* 0x20 */ public float TurbulenceFrequency;
        [NMS(Index = 13)]
        /* 0x24 */ public int TurbulenceOctaves;
        [NMS(Index = 6)]
        /* 0x28 */ public float Width;
        [NMS(Index = 2)]
        /* 0x2C */ public bool Absolute;
        [NMS(Index = 0)]
        /* 0x2D */ public bool Active;
        [NMS(Index = 1)]
        /* 0x2E */ public bool Invert;
        [NMS(Index = 3)]
        /* 0x2F */ public bool Subtract;
    }
}
