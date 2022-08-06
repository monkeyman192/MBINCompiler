using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6A3591AFD161D028, NameHash = 0xE1F61A258ED99443)]
    public class GcBaseBuildingPartNavData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 PartID;
        /* 0x20 */ public List<GcBaseBuildingPartInteractionData> SharedInteractions;
        /* 0x30 */ public List<GcBaseBuildingPartNavNodeData> NavNodeData;
    }
}
