using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF6F70602F611DE61, NameHash = 0xDCEA4C2E)]
    public class GcCreatureRoleFilename : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public VariableSizeString File;
        [NMS(Index = 1, Size = 0x4, EnumType = typeof(GcPlanetLife.LifeSettingEnum))]
        /* 0x10 */ public float[] BiomeProbability;
    }
}
