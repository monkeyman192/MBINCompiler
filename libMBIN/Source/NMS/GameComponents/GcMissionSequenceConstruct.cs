using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x138, GUID = 0xBABCADD30C56C67, NameHash = 0x694A21AA8BC8BAD4)]
    public class GcMissionSequenceConstruct : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x00 */ public string Message;
        /* 0x80 */ public int NumUniquePartsRequired;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x84 */ public byte[] Padding84;
        /* 0x88 */ public List<GcConstructionPart> PotentialParts;
        /* 0x98 */ public GcBuildingPartSearchType Type;
        [NMS(Size = 0x80)]
        /* 0xB8 */ public string DebugText;
    }
}
