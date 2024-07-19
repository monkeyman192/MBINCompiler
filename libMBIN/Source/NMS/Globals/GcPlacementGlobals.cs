namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x18225C1DB242EC3F, NameHash = 0x81D98A00)]
    public class GcPlacementGlobals : NMSTemplate
    {
        [NMS(Index = 14, Size = 0x5)]
        /* 0x00 */ public float[] LodDistancesDetail;
        [NMS(Index = 17, Size = 0x5)]
        /* 0x14 */ public float[] LodDistancesDistant;
        [NMS(Index = 16, Size = 0x5)]
        /* 0x28 */ public float[] LodDistancesLandmark;
        [NMS(Index = 15, Size = 0x5)]
        /* 0x3C */ public float[] LodDistancesObject;
        [NMS(Index = 13)]
        /* 0x50 */ public float AddToLodDistance;
        [NMS(Index = 9)]
        /* 0x54 */ public float HighInterpValue;
        [NMS(Index = 8)]
        /* 0x58 */ public float InterpValueVariance;
        [NMS(Index = 11)]
        /* 0x5C */ public float LowInterpValue;
        [NMS(Index = 5)]
        /* 0x60 */ public float MaxDensity;
        [NMS(Index = 4)]
        /* 0x64 */ public float MaxFrequency;
        [NMS(Index = 6)]
        /* 0x68 */ public float MaxPatchSize;
        [NMS(Index = 7)]
        /* 0x6C */ public int MaxPatchVariance;
        [NMS(Index = 10)]
        /* 0x70 */ public float MidInterpValue;
        [NMS(Index = 1)]
        /* 0x74 */ public float MinDensity;
        [NMS(Index = 0)]
        /* 0x78 */ public float MinFrequency;
        [NMS(Index = 2)]
        /* 0x7C */ public float MinPatchSize;
        [NMS(Index = 3)]
        /* 0x80 */ public int MinPatchVariance;
        [NMS(Index = 12)]
        /* 0x84 */ public float MultiplyLodDistance;
    }
}
