using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x77D27CE2F5C655FC, NameHash = 0xC217A4AF3130299A)]
    public class GcSolarSystemEventWarpOut : NMSTemplate
    {
        /* 0x00 */ public float Time;
        [NMS(Size = 0x20)]
        /* 0x04 */ public string SquadName;
        /* 0x24 */ public Vector2f WarpIntervalRange;
    }
}
