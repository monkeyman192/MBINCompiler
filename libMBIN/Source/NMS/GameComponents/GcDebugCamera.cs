using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDCE2D4890B1CD4AD, NameHash = 0xC7724B26F8E50BC5)]
    public class GcDebugCamera : NMSTemplate
    {
        /* 0x00 */ public float BaseSpeed;
        /* 0x04 */ public float Smoothing;
        /* 0x08 */ public List<GcDebugCameraEntry> Waypoints;
        /* 0x18 */ public int CurrentWaypoint;
        /* 0x1C */ public float CurrentWaypointProgress;
    }
}
