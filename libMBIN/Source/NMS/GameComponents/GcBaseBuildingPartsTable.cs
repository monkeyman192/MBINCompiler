using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x46F2C9FD43F7EB48, NameHash = 0x3D61DD26)]
    public class GcBaseBuildingPartsTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcBaseBuildingPart> Parts;
    }
}
