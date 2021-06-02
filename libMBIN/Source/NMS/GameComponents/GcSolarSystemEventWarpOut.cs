using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2C, GUID = 0x77D27CE2F5C655FC, NameHash = 0xC217A4AF3130299A)]
    public class GcSolarSystemEventWarpOut : NMSTemplate
    {
        /* 0x00 */ public float Time;
        /* 0x04 */ public NMSString0x20 SquadName;
        /* 0x24 */ public Vector2f WarpIntervalRange;
    }
}