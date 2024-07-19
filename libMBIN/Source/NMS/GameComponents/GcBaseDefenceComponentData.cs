using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD681E2A2D35C5417, NameHash = 0xC9DA42D)]
    public class GcBaseDefenceComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcBaseDefenceTrigger> Triggers;
        [NMS(Index = 4)]
        /* 0x10 */ public float LaserRangeAnimateTime;
        [NMS(Index = 1)]
        /* 0x14 */ public float LostUncertaintyThreshold;
        [NMS(Index = 2)]
        /* 0x18 */ public float SearchTime;
        [NMS(Index = 3)]
        /* 0x1C */ public bool PrioritiseThreats;
    }
}
