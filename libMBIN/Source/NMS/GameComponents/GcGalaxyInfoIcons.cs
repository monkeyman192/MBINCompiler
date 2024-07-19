using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xABB81F0E1180CACC, NameHash = 0x6B5C3214)]
    public class GcGalaxyInfoIcons : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x000 */ public TkTextureResource[] RaceIcons;
        [NMS(Index = 1, Size = 0x7, EnumType = typeof(GcTradingClass.TradingClassEnum))]
        /* 0x0D8 */ public TkTextureResource[] EconomyIcons;
        [NMS(Index = 4, Size = 0x4, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x180 */ public TkTextureResource[] ConflictIcons;
        [NMS(Index = 3, Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x1E0 */ public TkTextureResource[] WealthIcons;
        [NMS(Index = 5)]
        /* 0x240 */ public TkTextureResource ConflictTechNotInstalledIcon;
        [NMS(Index = 2)]
        /* 0x258 */ public TkTextureResource EconomyTechNotInstalledIcon;
        [NMS(Index = 7)]
        /* 0x270 */ public TkTextureResource WarpErrorIcon;
        [NMS(Index = 6)]
        /* 0x288 */ public TkTextureResource WarpIcon;
        [NMS(Index = 8)]
        /* 0x2A0 */ public TkTextureResource WarpTechNotInstalledIcon;
    }
}
