using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xE569503D1DADCA5D, NameHash = 0x36E3583)]
    public class GcCollisionTable : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcPhysicsCollisionGroupCollidesWith> CollisionTable;
    }
}
