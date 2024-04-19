using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4804062C877D7175, NameHash = 0x5995CC3B21976698)]
    public class GcCreatureDebugSpawnData : NMSTemplate
    {
        /* 0x00 */ public List<GcCreatureDebugWaypoint> Waypoints;
        /* 0x10 */ public int CreatureIndex;
        /* 0x14 */ public int CurrentWaypoint;
        /* 0x18 */ public float InitialDelay;
        // size: 0x3
        public enum OnCompleteEnum : uint {
            Hold,
            Loop,
            Destroy,
        }
        /* 0x1C */ public OnCompleteEnum OnComplete;
        /* 0x20 */ public float SmoothTime;
        /* 0x24 */ public float SmoothTimer;
        /* 0x28 */ public float Timer;
        /* 0x2C */ public bool ArrivedAtCurrentWaypoint;
    }
}
