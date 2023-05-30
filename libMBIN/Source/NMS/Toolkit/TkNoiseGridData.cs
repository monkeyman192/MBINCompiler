using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkNoiseGridData : NMSTemplate // 0x168 bytes
    {
        /* 0x000 */ public bool Active;
        /* 0x001 */ public bool Subtract;
        /* 0x002 */ public bool SwapZY;
        /* 0x003 */ public bool Hemisphere;
        /* 0x004 */ public TkNoiseVoxelTypeEnum NoiseVoxelType;
        /* 0x008 */ public int NoiseGridType;
        public string[] NoiseGridTypeValues()
        {
            return new[]
            {
                "Cube", "Cone", "Torus", "Sphere", "Cylinder", "Capsule", "Corridor", "Pipe",
                "Puck", "SuperPrimitiveRandom", "SuperFormula_01", "SuperFormula_02", "SuperFormula_03", "SuperFormula_04", "SuperFormula_05", "SuperFormula_06",
                "SuperFormula_07", "SuperFormula_08", "SuperFormulaRandom", "SuperFormula", "SuperPrimitive", "File"
            };
        }

        [NMS(Size = 0x80)]
        /* 0x00C */ public string Filename;
        /* 0x08C */ public float MinWidth;
        /* 0x090 */ public float MaxWidth;
        /* 0x094 */ public float MinHeight;
        /* 0x098 */ public float MaxHeight;
        /* 0x09C */ public float MinHeightOffset;
        /* 0x0A0 */ public float MaxHeightOffset;
        /* 0x0A4 */ public float HeightOffset;

        /* 0x0A8 */ public TkNoiseOffsetEnum OffsetType;
        /* 0x0AC */ public float RegionRatio;
        /* 0x0B0 */ public float RegionScale;
        /* 0x0B4 */ public TkNoiseUberLayerData TurbulenceNoiseLayer;
        /* 0x108 */ public float Yaw;
        /* 0x10C */ public float Pitch;
        /* 0x110 */ public float Roll;
        /* 0x114 */ public float VaryYaw;
        /* 0x118 */ public float VaryPitch;
        /* 0x11C */ public float VaryRoll;
        /* 0x120 */ public float SmoothRadius;
        /* 0x124 */ public int SeedOffset;
        /* 0x128 */ public float RandomPrimitive;
        /* 0x12C */ public TkNoiseSuperFormulaData SuperFormula1;
        /* 0x13C */ public TkNoiseSuperFormulaData SuperFormula2;
        /* 0x14C */ public TkNoiseSuperPrimitiveData SuperPrimitive;
    }
}
