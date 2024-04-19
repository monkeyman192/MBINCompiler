using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4115B5E6806757B5, NameHash = 0xC7724B26F8E50BC5)]
    public class GcDebugCamera : NMSTemplate
    {
        /* 0x00 */ public List<GcDebugCameraEntry> Waypoints;
        /* 0x10 */ public float BaseSpeed;
        /* 0x14 */ public int CurrentWaypoint;
        /* 0x18 */ public float CurrentWaypointProgress;
        /* 0x1C */ public float Smoothing;
    }
}
