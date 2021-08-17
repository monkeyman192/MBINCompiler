using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x30, GUID = 0xE2C3ED24D5C83A8E, NameHash = 0x5995CC3B21976698)]
    public class GcCreatureDebugSpawnData : NMSTemplate
    {
        /* 0x00 */ public int CreatureIndex;
        /* 0x04 */ public float InitialDelay;
        /* 0x08 */ public List<GcCreatureDebugWaypoint> Waypoints;
        // size: 0x3
        public enum OnCompleteEnum { Hold, Loop, Destroy }
        /* 0x18 */ public OnCompleteEnum OnComplete;
        /* 0x1C */ public float SmoothTime;
        /* 0x20 */ public int CurrentWaypoint;
        /* 0x24 */ public bool ArrivedAtCurrentWaypoint;
        /* 0x28 */ public float Timer;
        /* 0x2C */ public float SmoothTimer;
    }
}
