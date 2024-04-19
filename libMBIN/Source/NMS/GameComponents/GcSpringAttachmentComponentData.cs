using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE9FF30673A2D8237, NameHash = 0x70622F0C8DD198C)]
    public class GcSpringAttachmentComponentData : NMSTemplate
    {
        /* 0x00 */ public List<GcCollisionCapsule> CollisionCapsules;
        /* 0x10 */ public List<GcSpringLink> SpringLinks;
        /* 0x20 */ public NMSString0x40 Name;
        /* 0x60 */ public bool Enabled;
    }
}
