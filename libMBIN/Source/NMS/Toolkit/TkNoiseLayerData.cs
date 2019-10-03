using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x30, GUID = 0x4D08A872C503D8EE, NameHash = 0x474596B01166F6A6)]
    public class TkNoiseLayerData : NMSTemplate
    {
        /* 0x00 */ public bool Active;
        /* 0x01 */ public bool Invert;
        /* 0x02 */ public bool Absolute;
        /* 0x03 */ public bool Subtract;
        public enum NoiseTypeEnum { Plane, Check, Sine, Smooth, Fractal, Ridged, Billow, Erosion, Volcanic, Glacial, Plateau }
        /* 0x04 */ public NoiseTypeEnum NoiseType;
        /* 0x08 */ public float Height;
        /* 0x0C */ public float Width;
        /* 0x10 */ public int Octaves;
        /* 0x14 */ public float FrequencyScaleY;
        /* 0x18 */ public float RegionRatio;
        /* 0x1C */ public float RegionScale;
        /* 0x20 */ public float TurbulenceFrequency;
        /* 0x24 */ public float TurbulenceAmplitude;
        /* 0x28 */ public int TurbulenceOctaves;
        /* 0x2C */ public int SeedOffset;
    }
}
