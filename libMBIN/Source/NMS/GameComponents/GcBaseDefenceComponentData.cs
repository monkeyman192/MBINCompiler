using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2C014DBAB0A74271, NameHash = 0x2D868A2A5696416C)]
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
