using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF6F70602F611DE61, NameHash = 0x6474461C1BF89153)]
    public class GcCreatureRoleFilename : NMSTemplate
    {
        [NMS(Size = 0x4, EnumType = typeof(GcPlanetLife.LifeSettingEnum))]
        /* 0x00 */ public float[] BiomeProbability;
        /* 0x10 */ public NMSString0x80 File;
    }
}
