using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF172C1FA6F2F4771, NameHash = 0x6474461C1BF89153)]
    public class GcCreatureRoleFilename : NMSTemplate // 0x90 bytes
    {
        [NMS(Size = 0x80)]
        public string File;

        [NMS(Size = 0x4, EnumType = typeof(GcPlanetLife.LifeSettingEnum))]
        public float[] BiomeProbability;
    }
}
