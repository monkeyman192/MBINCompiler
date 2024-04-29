using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDED6121EF7581E5, NameHash = 0x6474461C1BF89153)]
    public class GcCreatureRoleFilename : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x4, EnumType = typeof(GcPlanetLife.LifeSettingEnum))]
        /* 0x00 */ public float[] BiomeProbability;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x80 File;
    }
}
