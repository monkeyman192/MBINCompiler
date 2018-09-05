namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x1B440)]
    public class TkVoxelGeneratorSettingsArray : NMSTemplate
    {
        [NMS(Size = 0xA)]
        public TkVoxelGeneratorSettingsElement[] TerrainSettings;
    }
}
