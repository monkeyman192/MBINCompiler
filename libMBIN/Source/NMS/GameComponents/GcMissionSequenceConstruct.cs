using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x78DDA6858EB4759F, NameHash = 0xF0EFDF2B)]
    public class GcMissionSequenceConstruct : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public NMSString0x20A NexusNeedPartsScanEvent;
        [NMS(Index = 6)]
        /* 0x20 */ public NMSString0x20A NoBaseInSystemScanEvent;
        [NMS(Index = 12)]
        /* 0x40 */ public GcBuildingPartSearchType Type;
        [NMS(Index = 15)]
        /* 0x58 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x68 */ public VariableSizeString Message;
        [NMS(Index = 4)]
        /* 0x78 */ public VariableSizeString MessageInNexusAndNeedParts;
        [NMS(Index = 2)]
        /* 0x88 */ public VariableSizeString MessageNoBaseInSystem;
        [NMS(Index = 3)]
        /* 0x98 */ public VariableSizeString MessageNoBaseInSystemAndNoStation;
        [NMS(Index = 1)]
        /* 0xA8 */ public VariableSizeString MessageOutsideBase;
        [NMS(Index = 11)]
        /* 0xB8 */ public List<GcConstructionPartGroup> PotentialPartGroups;
        [NMS(Index = 10)]
        /* 0xC8 */ public List<GcConstructionPart> PotentialParts;
        [NMS(Index = 9)]
        /* 0xD8 */ public int NumUniquePartsRequired;
        [NMS(Index = 7)]
        /* 0xDC */ public bool HideCompletedPartsOutOfBase;
        [NMS(Index = 8)]
        /* 0xDD */ public bool HideOtherPartsWhenBuyingBlueprints;
        [NMS(Index = 13)]
        /* 0xDE */ public bool OnlyPickFromKnown;
        [NMS(Index = 14)]
        /* 0xDF */ public bool ShuffleParts;
    }
}
