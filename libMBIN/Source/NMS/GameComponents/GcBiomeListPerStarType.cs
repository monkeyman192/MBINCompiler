using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x15C, GUID = 0xC41550066972A7DF, NameHash = 0xFABB438AC71DAB8D)]
    public class GcBiomeListPerStarType : NMSTemplate
    {
        [NMS(Size = 4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x000 */ public GcBiomeList[] StarType;

        /* 0x0D0 */ public GcBiomeList LushYellow;
        /* 0x104 */ public GcBiomeList AbandonedYellow;

        [NMS(Size = 4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x138 */ public float[] LifeChance;

        [NMS(Size = 4, EnumType = typeof(GcGalaxyStarTypes.GalaxyStarTypeEnum))]
        /* 0x148 */ public float[] AbandonedLifeChance;

        /* 0x158 */ public float ConvertDeadToWeird;
    }
}
