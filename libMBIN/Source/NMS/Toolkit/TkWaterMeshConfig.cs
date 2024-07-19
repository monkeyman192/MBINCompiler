namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7AA7B4781DA652DD, NameHash = 0xDB8D6EE6)]
    public class TkWaterMeshConfig : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public float BaseScale;
        [NMS(Index = 4)]
        /* 0x04 */ public int FoamScale;
        [NMS(Index = 1)]
        /* 0x08 */ public int GeometryDownSampleFactor;
        [NMS(Index = 2)]
        /* 0x0C */ public int LodCount;
        [NMS(Index = 3)]
        /* 0x10 */ public int LodDataResolution;
        [NMS(Index = 6)]
        /* 0x14 */ public int MaxHorizontalScaleMultiplier;
        [NMS(Index = 7)]
        /* 0x18 */ public int MinHorizontalScaleMultiplier;
        [NMS(Index = 5)]
        /* 0x1C */ public bool DisableSkirtGeneration;
    }
}
