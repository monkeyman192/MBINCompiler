using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x647CC049F9BFCD2F, NameHash = 0x39650419)]
    public class GcAttachmentPointSet : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public List<GcAttachmentPointData> AttachmentPoints;
        [NMS(Index = 6)]
        /* 0x10 */ public float AttractionStartDistance;
        [NMS(Index = 5)]
        /* 0x14 */ public float AttractionStrength;
        [NMS(Index = 3)]
        /* 0x18 */ public int NumSimI;
        [NMS(Index = 4)]
        /* 0x1C */ public int NumSimJ;
        [NMS(Index = 2)]
        /* 0x20 */ public NMSString0x40 JointName;
        [NMS(Index = 1)]
        /* 0x60 */ public NMSString0x40 Name;
        [NMS(Index = 0)]
        /* 0xA0 */ public bool Enabled;
    }
}
