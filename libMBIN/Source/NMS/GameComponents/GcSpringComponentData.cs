using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4A60E7DB993E913F, NameHash = 0x45D2A3)]
    public class GcSpringComponentData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public List<GcCollisionCapsule> CollisionCapsules;
        [NMS(Index = 2)]
        /* 0x10 */ public List<GcSpringLink> SpringLinks;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x40 Name;
        [NMS(Index = 0)]
        /* 0x60 */ public bool Enabled;
    }
}
