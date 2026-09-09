using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC6AEB5859D206600, NameHash = 0xB0C9B25F)]
    public class GcPhysicsCollisionGroupCollidesWith : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcPhysicsCollisionGroups> CollidesWith;
        [NMS(Index = 0)]
        /* 0x10 */ public GcPhysicsCollisionGroups Group;
    }
}
