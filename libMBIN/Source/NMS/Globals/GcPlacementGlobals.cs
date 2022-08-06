using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xCC46EA70144FB1CB, NameHash = 0x78E77E9B846089A1)]
    public class GcPlacementGlobals : NMSTemplate
    {
        /* 0x00 */ public float MinFrequency;
        /* 0x04 */ public float MinDensity;
        /* 0x08 */ public float MinPatchSize;
        /* 0x0C */ public int MinPatchVariance;
        /* 0x10 */ public float MaxFrequency;
        /* 0x14 */ public float MaxDensity;
        /* 0x18 */ public float MaxPatchSize;
        /* 0x1C */ public int MaxPatchVariance;
        /* 0x20 */ public float InterpValueVariance;
        /* 0x24 */ public float HighInterpValue;
        /* 0x28 */ public float MidInterpValue;
        /* 0x2C */ public float LowInterpValue;
        /* 0x30 */ public float MultiplyLodDistance;
        /* 0x34 */ public float AddToLodDistance;
        [NMS(Size = 0x5)]
        /* 0x38 */ public float[] LodDistancesDetail;
        [NMS(Size = 0x5)]
        /* 0x4C */ public float[] LodDistancesObject;
        [NMS(Size = 0x5)]
        /* 0x60 */ public float[] LodDistancesLandmark;
        [NMS(Size = 0x5)]
        /* 0x74 */ public float[] LodDistancesDistant;
    }
}
