using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB5DBBE772BEDA04, NameHash = 0x762F430C6C191529)]
    public class GcAttachmentPointSet : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public List<GcAttachmentPointData> FixedPoints;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSString0x40 BoneName;
        [NMS(Index = 1)]
        /* 0x50 */ public NMSString0x40 DebugName;
        [NMS(Index = 0)]
        /* 0x90 */ public bool Enabled;
    }
}
