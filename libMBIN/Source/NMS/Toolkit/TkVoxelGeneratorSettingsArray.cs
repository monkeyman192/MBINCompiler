using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x1B440, GUID = 0xC4741AF54DADAC92, NameHash = 0x62EA167F11DA4F86)]
    public class TkVoxelGeneratorSettingsArray : NMSTemplate
    {
        [NMS(Size = 0xA, EnumValue = new[] { "FloatingIslands", "GrandCanyon", "MountainRavines", "HugeArches", "Alien", "Craters", "Caverns", "Alpine", "LilyPad", "Desert" })]        // TkVoxelGeneratorSettingsTypes
        public TkVoxelGeneratorSettingsElement[] TerrainSettings;
    }
}
