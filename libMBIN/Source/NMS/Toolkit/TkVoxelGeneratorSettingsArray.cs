using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x13DCDF1DF2EC7FBE, NameHash = 0x62EA167F11DA4F86)]
    public class TkVoxelGeneratorSettingsArray : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x15, EnumType = typeof(TkVoxelGeneratorSettingsTypes.TerrainSettingsEnum))]
        /* 0x0 */ public TkVoxelGeneratorSettingsElement[] TerrainSettings;
    }
}
