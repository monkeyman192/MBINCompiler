using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE5122F389153E457, NameHash = 0x31D184CC)]
    public class TkMeshWaterQualitySettingData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkWaterMeshConfig WaterMeshConfig;
        [NMS(Index = 4)]
        /* 0x20 */ public bool EnableDetailNormals;
        [NMS(Index = 1)]
        /* 0x21 */ public bool EnableFoam;
        [NMS(Index = 2)]
        /* 0x22 */ public bool EnableLocalTerrain;
        [NMS(Index = 3)]
        /* 0x23 */ public bool PostProcessWater;
    }
}
