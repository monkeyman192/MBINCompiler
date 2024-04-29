using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x215B4BA208E76774, NameHash = 0x1DE42844C3529A0B)]
    public class GcGalaxyInfoIcons : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x000 */ public TkTextureResource[] RaceIcons;
        [NMS(Index = 1, Size = 0x7, EnumType = typeof(GcTradingClass.TradingClassEnum))]
        /* 0x4A4 */ public TkTextureResource[] EconomyIcons;
        [NMS(Index = 4, Size = 0x4, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x840 */ public TkTextureResource[] ConflictIcons;
        [NMS(Index = 3, Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0xA50 */ public TkTextureResource[] WealthIcons;
        [NMS(Index = 5)]
        /* 0xC60 */ public TkTextureResource ConflictTechNotInstalledIcon;
        [NMS(Index = 2)]
        /* 0xCE4 */ public TkTextureResource EconomyTechNotInstalledIcon;
        [NMS(Index = 7)]
        /* 0xD68 */ public TkTextureResource WarpErrorIcon;
        [NMS(Index = 6)]
        /* 0xDEC */ public TkTextureResource WarpIcon;
        [NMS(Index = 8)]
        /* 0xE70 */ public TkTextureResource WarpTechNotInstalledIcon;
    }
}
