using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkNoiseUberLayerData : NMSTemplate // 0x54 bytes
    {
        /* 0x00 */ public TkNoiseUberData NoiseData;
        /* 0x28 */ public bool Active;
        /* 0x29 */ public bool Subtract;
        /* 0x2C */ public TkNoiseVoxelTypeEnum NoiseVoxelType;
        /* 0x30 */ public float Height;
        /* 0x34 */ public float Width;
        /* 0x38 */ public float RegionRatio;
        /* 0x3C */ public float RegionScale;
        /* 0x40 */ public float SmoothRadius;
        /* 0x44 */ public float HeightOffset;
        /* 0x48 */ public TkNoiseOffsetEnum OffsetType;
        /* 0x4C */ public int WaterFade;
        public string[] WaterFadeValues()
        {
            return new[] { "None", "Above", "Below" };
        }
        /* 0x50 */ public int SeedOffset;
    }
}
