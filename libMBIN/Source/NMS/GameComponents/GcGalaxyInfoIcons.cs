using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5023B9BEB4318580, NameHash = 0x1DE42844C3529A0B)]
    public class GcGalaxyInfoIcons : NMSTemplate
    {
        [NMS(Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x000 */ public TkTextureResource[] RaceIcons;
        [NMS(Size = 0x7, EnumType = typeof(GcTradingClass.TradingClassEnum))]
        /* 0x4A4 */ public TkTextureResource[] EconomyIcons;
        [NMS(Size = 0x4, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0x840 */ public TkTextureResource[] ConflictIcons;
        [NMS(Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0xA50 */ public TkTextureResource[] WealthIcons;
        /* 0xC60 */ public TkTextureResource ConflictTechNotInstalledIcon;
        /* 0xCE4 */ public TkTextureResource EconomyTechNotInstalledIcon;
        /* 0xD68 */ public TkTextureResource WarpErrorIcon;
        /* 0xDEC */ public TkTextureResource WarpIcon;
        /* 0xE70 */ public TkTextureResource WarpTechNotInstalledIcon;
    }
}
