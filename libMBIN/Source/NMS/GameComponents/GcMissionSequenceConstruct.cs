using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3EDABF4875942867, NameHash = 0x694A21AA8BC8BAD4)]
    public class GcMissionSequenceConstruct : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A NexusNeedPartsScanEvent;
        /* 0x020 */ public NMSString0x20A NoBaseInSystemScanEvent;
        /* 0x040 */ public GcBuildingPartSearchType Type;
        /* 0x058 */ public List<GcConstructionPartGroup> PotentialPartGroups;
        /* 0x068 */ public List<GcConstructionPart> PotentialParts;
        /* 0x078 */ public int NumUniquePartsRequired;
        /* 0x07C */ public NMSString0x80 DebugText;
        /* 0x0FC */ public NMSString0x80 Message;
        /* 0x17C */ public NMSString0x80 MessageInNexusAndNeedParts;
        /* 0x1FC */ public NMSString0x80 MessageNoBaseInSystem;
        /* 0x27C */ public NMSString0x80 MessageNoBaseInSystemAndNoStation;
        /* 0x2FC */ public NMSString0x80 MessageOutsideBase;
        /* 0x37C */ public bool HideCompletedPartsOutOfBase;
        /* 0x37D */ public bool HideOtherPartsWhenBuyingBlueprints;
        /* 0x37E */ public bool OnlyPickFromKnown;
        /* 0x37F */ public bool ShuffleParts;
    }
}
