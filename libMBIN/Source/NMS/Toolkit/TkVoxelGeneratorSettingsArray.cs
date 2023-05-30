using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    public class TkVoxelGeneratorSettingsArray : NMSTemplate  // Size: 0x8CA0
    {
        [NMS(Size = 0x6, EnumValue = new string[6] { "FloatingIslands", "GrandCanyon", "MountainRavines", "HugeArches", "Towers", "Craters" })]
        public TkVoxelGeneratorSettingsElement[] TerrainSettings;
    }
}
