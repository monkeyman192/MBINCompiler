using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB05F67CFA2D11F0C, NameHash = 0xF5EE5140)]
    public class GcPhysicsCollisionTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPhysicsCollisionGroupCollidesWith> CollisionTable;
    }
}
