using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4C8832CFE3785F00, NameHash = 0xA45052EB66E281C7)]
    public class TkNoiseGridData : NMSTemplate
    {
        /* 0x000 */ public TkNoiseUberLayerData TurbulenceNoiseLayer;
        /* 0x084 */ public TkNoiseSuperPrimitiveData SuperPrimitive;
        /* 0x0A0 */ public TkNoiseSuperFormulaData SuperFormula1;
        /* 0x0B0 */ public TkNoiseSuperFormulaData SuperFormula2;
        /* 0x0C0 */ public float HeightOffset;
        /* 0x0C4 */ public float MaxHeight;
        /* 0x0C8 */ public float MaxHeightOffset;
        /* 0x0CC */ public int MaximumLOD;
        /* 0x0D0 */ public float MaxWidth;
        /* 0x0D4 */ public float MinHeight;
        /* 0x0D8 */ public float MinHeightOffset;
        /* 0x0DC */ public float MinWidth;
        // size: 0x16
        public enum NoiseGridTypeEnum : uint {
            Cube,
            Cone,
            Torus,
            Sphere,
            Cylinder,
            Capsule,
            Corridor,
            Pipe,
            Puck,
            SuperPrimitiveRandom,
            SuperFormula_01,
            SuperFormula_02,
            SuperFormula_03,
            SuperFormula_04,
            SuperFormula_05,
            SuperFormula_06,
            SuperFormula_07,
            SuperFormula_08,
            SuperFormulaRandom,
            SuperFormula,
            SuperPrimitive,
            File,
        }
        /* 0x0E0 */ public NoiseGridTypeEnum NoiseGridType;
        /* 0x0E4 */ public TkNoiseOffsetEnum Offset;
        /* 0x0E8 */ public float Pitch;
        /* 0x0EC */ public float RandomPrimitive;
        /* 0x0F0 */ public float RegionRatio;
        /* 0x0F4 */ public float RegionScale;
        /* 0x0F8 */ public float Roll;
        /* 0x0FC */ public int SeedOffset;
        /* 0x100 */ public float SmoothRadius;
        /* 0x104 */ public float TileBlendMeters;
        /* 0x108 */ public float VaryPitch;
        /* 0x10C */ public float VaryRoll;
        /* 0x110 */ public float VaryYaw;
        /* 0x114 */ public TkNoiseVoxelTypeEnum VoxelType;
        /* 0x118 */ public float Yaw;
        /* 0x11C */ public NMSString0x80 Filename;
        /* 0x19C */ public bool Active;
        /* 0x19D */ public bool Hemisphere;
        /* 0x19E */ public bool Subtract;
        /* 0x19F */ public bool SwapZY;
    }
}
