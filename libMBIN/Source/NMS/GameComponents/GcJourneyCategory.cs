using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8105C20ABDBD3D33, NameHash = 0x88F1E142115EF824)]
    public class GcJourneyCategory : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A DescriptionID;
        /* 0x020 */ public NMSString0x20A NameIDLower;
        /* 0x040 */ public NMSString0x20A NameIDUpper;
        /* 0x060 */ public List<GcJourneyMedal> Medals;
        /* 0x070 */ public TkTextureResource IconOff;
        /* 0x0F4 */ public TkTextureResource IconOn;
        /* 0x178 */ public GcMissionFaction Faction;
        /* 0x17C */ public GcGameMode GameModeRestriction;
        /* 0x180 */ public GcJourneyCategoryType Type;
    }
}
