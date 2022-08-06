using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x723CA38259F6CFA, NameHash = 0x694A21AA8BC8BAD4)]
    public class GcMissionSequenceConstruct : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public int NumUniquePartsRequired;
        /* 0x88 */ public List<GcConstructionPart> PotentialParts;
        /* 0x98 */ public GcBuildingPartSearchType Type;
        /* 0xB8 */ public NMSString0x80 DebugText;
    }
}
