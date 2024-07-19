using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA8FEE8E8E60A66D9, NameHash = 0x63123394)]
    public class GcJourneyCategory : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public NMSString0x20A DescriptionID;
        [NMS(Index = 3)]
        /* 0x20 */ public NMSString0x20A NameIDLower;
        [NMS(Index = 4)]
        /* 0x40 */ public NMSString0x20A NameIDUpper;
        [NMS(Index = 7)]
        /* 0x60 */ public TkTextureResource IconOff;
        [NMS(Index = 6)]
        /* 0x78 */ public TkTextureResource IconOn;
        [NMS(Index = 8)]
        /* 0x90 */ public List<GcJourneyMedal> Medals;
        [NMS(Index = 2)]
        /* 0xA0 */ public GcMissionFaction Faction;
        [NMS(Index = 1)]
        /* 0xA4 */ public GcGameMode GameModeRestriction;
        [NMS(Index = 0)]
        /* 0xA8 */ public GcJourneyCategoryType Type;
    }
}
