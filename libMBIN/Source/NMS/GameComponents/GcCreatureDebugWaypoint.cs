using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x30, GUID = 0x98B79D0E3A5D1787, NameHash = 0x4C03886F1A1C1DF7)]
    public class GcCreatureDebugWaypoint : NMSTemplate
    {
        /* 0x00 */ public Vector3f Position;
        public enum WaypointTypeEnum { Move, MoveAlt, Idle };
        /* 0x10 */ public WaypointTypeEnum WaypointType;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14 */ public byte[] Padding14;
        /* 0x18 */ public NMSString0x10 Anim;
        /* 0x28 */ public float Time;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2C */ public byte[] EndPadding;
    }
}
