using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3D0E90045A039857, NameHash = 0x2155C565)]
    public class TkVoxelGeneratorSettingsArray : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x15, EnumType = typeof(TkVoxelGeneratorSettingsTypes.TerrainSettingsEnum))]
        /* 0x0 */ public TkVoxelGeneratorSettingsElement[] TerrainSettings;
    }
}
