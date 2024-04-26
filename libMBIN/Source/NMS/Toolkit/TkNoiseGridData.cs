using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4C8832CFE3785F00, NameHash = 0xA45052EB66E281C7)]
    public class TkNoiseGridData : NMSTemplate
    {
        [NMS(Index = 18)]
        /* 0x000 */ public TkNoiseUberLayerData TurbulenceNoiseLayer;
        [NMS(Index = 30)]
        /* 0x084 */ public TkNoiseSuperPrimitiveData SuperPrimitive;
        [NMS(Index = 28)]
        /* 0x0A0 */ public TkNoiseSuperFormulaData SuperFormula1;
        [NMS(Index = 29)]
        /* 0x0B0 */ public TkNoiseSuperFormulaData SuperFormula2;
        [NMS(Index = 14)]
        /* 0x0C0 */ public float HeightOffset;
        [NMS(Index = 11)]
        /* 0x0C4 */ public float MaxHeight;
        [NMS(Index = 13)]
        /* 0x0C8 */ public float MaxHeightOffset;
        [NMS(Index = 1)]
        /* 0x0CC */ public int MaximumLOD;
        [NMS(Index = 9)]
        /* 0x0D0 */ public float MaxWidth;
        [NMS(Index = 10)]
        /* 0x0D4 */ public float MinHeight;
        [NMS(Index = 12)]
        /* 0x0D8 */ public float MinHeightOffset;
        [NMS(Index = 8)]
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
        [NMS(Index = 6)]
        /* 0x0E0 */ public NoiseGridTypeEnum NoiseGridType;
        [NMS(Index = 15)]
        /* 0x0E4 */ public TkNoiseOffsetEnum Offset;
        [NMS(Index = 20)]
        /* 0x0E8 */ public float Pitch;
        [NMS(Index = 27)]
        /* 0x0EC */ public float RandomPrimitive;
        [NMS(Index = 16)]
        /* 0x0F0 */ public float RegionRatio;
        [NMS(Index = 17)]
        /* 0x0F4 */ public float RegionScale;
        [NMS(Index = 21)]
        /* 0x0F8 */ public float Roll;
        [NMS(Index = 26)]
        /* 0x0FC */ public int SeedOffset;
        [NMS(Index = 25)]
        /* 0x100 */ public float SmoothRadius;
        [NMS(Index = 31)]
        /* 0x104 */ public float TileBlendMeters;
        [NMS(Index = 23)]
        /* 0x108 */ public float VaryPitch;
        [NMS(Index = 24)]
        /* 0x10C */ public float VaryRoll;
        [NMS(Index = 22)]
        /* 0x110 */ public float VaryYaw;
        [NMS(Index = 5)]
        /* 0x114 */ public TkNoiseVoxelTypeEnum VoxelType;
        [NMS(Index = 19)]
        /* 0x118 */ public float Yaw;
        [NMS(Index = 7)]
        /* 0x11C */ public NMSString0x80 Filename;
        [NMS(Index = 0)]
        /* 0x19C */ public bool Active;
        [NMS(Index = 4)]
        /* 0x19D */ public bool Hemisphere;
        [NMS(Index = 2)]
        /* 0x19E */ public bool Subtract;
        [NMS(Index = 3)]
        /* 0x19F */ public bool SwapZY;
    }
}
