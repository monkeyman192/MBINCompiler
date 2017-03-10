using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcSolarSystemEventWarpOut : NMSTemplate
    {
        /* 0x00 */ public float Time;
        [NMS(Size = 0x20)]
        /* 0x04 */ public  string SquadName;
        /* 0x24 */ public Vector2f WarpIntervalRange;
    }
}
