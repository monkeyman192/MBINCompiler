namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xAA241672A87E189B, NameHash = 0x78E77E9B846089A1)]
    public class GcPlacementGlobals : NMSTemplate
    {
        [NMS(Size = 0x5)]
        /* 0x00 */ public float[] LodDistancesDetail;
        [NMS(Size = 0x5)]
        /* 0x14 */ public float[] LodDistancesDistant;
        [NMS(Size = 0x5)]
        /* 0x28 */ public float[] LodDistancesLandmark;
        [NMS(Size = 0x5)]
        /* 0x3C */ public float[] LodDistancesObject;
        /* 0x50 */ public float AddToLodDistance;
        /* 0x54 */ public float HighInterpValue;
        /* 0x58 */ public float InterpValueVariance;
        /* 0x5C */ public float LowInterpValue;
        /* 0x60 */ public float MaxDensity;
        /* 0x64 */ public float MaxFrequency;
        /* 0x68 */ public float MaxPatchSize;
        /* 0x6C */ public int MaxPatchVariance;
        /* 0x70 */ public float MidInterpValue;
        /* 0x74 */ public float MinDensity;
        /* 0x78 */ public float MinFrequency;
        /* 0x7C */ public float MinPatchSize;
        /* 0x80 */ public int MinPatchVariance;
        /* 0x84 */ public float MultiplyLodDistance;
    }
}
