using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8105C20ABDBD3D33, NameHash = 0x88F1E142115EF824)]
    public class GcJourneyCategory : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x000 */ public NMSString0x20A DescriptionID;
        [NMS(Index = 3)]
        /* 0x020 */ public NMSString0x20A NameIDLower;
        [NMS(Index = 4)]
        /* 0x040 */ public NMSString0x20A NameIDUpper;
        [NMS(Index = 8)]
        /* 0x060 */ public List<GcJourneyMedal> Medals;
        [NMS(Index = 7)]
        /* 0x070 */ public TkTextureResource IconOff;
        [NMS(Index = 6)]
        /* 0x0F4 */ public TkTextureResource IconOn;
        [NMS(Index = 2)]
        /* 0x178 */ public GcMissionFaction Faction;
        [NMS(Index = 1)]
        /* 0x17C */ public GcGameMode GameModeRestriction;
        [NMS(Index = 0)]
        /* 0x180 */ public GcJourneyCategoryType Type;
    }
}
