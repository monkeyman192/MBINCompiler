using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x373F7C6FBE5C8178, NameHash = 0x294639B)]
    public class GcBiomeListPerStarType : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x5, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x000 */ public GcBiomeList[] StarType;
        [NMS(Index = 2)]
        /* 0x280 */ public GcBiomeList AbandonedYellow;
        [NMS(Index = 1)]
        /* 0x300 */ public GcBiomeList LushYellow;
        [NMS(Index = 4, Size = 0x4, EnumType = typeof(GcPlanetLife.LifeSettingEnum))]
        /* 0x380 */ public float[] AbandonedLifeChance;
        [NMS(Index = 3, Size = 0x4, EnumType = typeof(GcPlanetLife.LifeSettingEnum))]
        /* 0x390 */ public float[] LifeChance;
        [NMS(Index = 5)]
        /* 0x3A0 */ public float ConvertDeadToWeird;
    }
}
