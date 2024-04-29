using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6752FED5A7309C5, NameHash = 0x694A21AA8BC8BAD4)]
    public class GcMissionSequenceConstruct : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x000 */ public NMSString0x20A NexusNeedPartsScanEvent;
        [NMS(Index = 6)]
        /* 0x020 */ public NMSString0x20A NoBaseInSystemScanEvent;
        [NMS(Index = 12)]
        /* 0x040 */ public GcBuildingPartSearchType Type;
        [NMS(Index = 11)]
        /* 0x058 */ public List<GcConstructionPartGroup> PotentialPartGroups;
        [NMS(Index = 10)]
        /* 0x068 */ public List<GcConstructionPart> PotentialParts;
        [NMS(Index = 9)]
        /* 0x078 */ public int NumUniquePartsRequired;
        [NMS(Index = 15)]
        /* 0x07C */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x0FC */ public NMSString0x80 Message;
        [NMS(Index = 4)]
        /* 0x17C */ public NMSString0x80 MessageInNexusAndNeedParts;
        [NMS(Index = 2)]
        /* 0x1FC */ public NMSString0x80 MessageNoBaseInSystem;
        [NMS(Index = 3)]
        /* 0x27C */ public NMSString0x80 MessageNoBaseInSystemAndNoStation;
        [NMS(Index = 1)]
        /* 0x2FC */ public NMSString0x80 MessageOutsideBase;
        [NMS(Index = 7)]
        /* 0x37C */ public bool HideCompletedPartsOutOfBase;
        [NMS(Index = 8)]
        /* 0x37D */ public bool HideOtherPartsWhenBuyingBlueprints;
        [NMS(Index = 13)]
        /* 0x37E */ public bool OnlyPickFromKnown;
        [NMS(Index = 14)]
        /* 0x37F */ public bool ShuffleParts;
    }
}
