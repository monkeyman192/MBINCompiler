using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x30BC0E1C6079088A, NameHash = 0x1DE42844C3529A0B)]
    public class GcGalaxyInfoIcons : NMSTemplate
    {
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x000 */ public TkTextureResource[] RaceIcons;
        [NMS(Size = 0x7, EnumType = typeof(GcTradingClass.TradingClassEnum))]
        /* 0x420 */ public TkTextureResource[] EconomyIcons;
        /* 0x7BC */ public TkTextureResource EconomyTechNotInstalledIcon;
        [NMS(Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x840 */ public TkTextureResource[] WealthIcons;
        [NMS(Size = 0x4, EnumType = typeof(GcPlayerConflictData.ConflictLevelEnum))]
        /* 0xA50 */ public TkTextureResource[] ConflictIcons;
        /* 0xC60 */ public TkTextureResource ConflictTechNotInstalledIcon;
        /* 0xCE4 */ public TkTextureResource WarpIcon;
        /* 0xD68 */ public TkTextureResource WarpErrorIcon;
        /* 0xDEC */ public TkTextureResource WarpTechNotInstalledIcon;
    }
}
