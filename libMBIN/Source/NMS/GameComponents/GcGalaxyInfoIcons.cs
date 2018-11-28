using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xB58, GUID = 0xEDDBE7AE19612B8F)]
    public class GcGalaxyInfoIcons : NMSTemplate
    {
        [NMS( EnumType = typeof( GcAlienRace.AlienRaceEnum ) )]
        /* 0x000 */ public TkTextureResource[] RaceIcons;
        [NMS( EnumType = typeof( GcTradingClass.TradingClassEnum ) )]
        /* 0x39C */ public TkTextureResource[] EconomyIcons;
        /* 0x738 */ public TkTextureResource EconomyTechNotInstalledIcon;
        [NMS( EnumType = typeof( GcPlayerConflictData.ConflictLevelEnum ) )]
        /* 0x7BC */ public TkTextureResource[] ConflictIcons;
        /* 0x948 */ public TkTextureResource ConflictTechNotInstalledIcon;
        /* 0x9CC */ public TkTextureResource Warpicon;
        /* 0xA50 */ public TkTextureResource WarpErrorIcon;
        /* 0xAD4 */ public TkTextureResource WarpTechNotInstalledIcon;
    }
}
