using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xFC78865088D14F81, NameHash = 0x2D868A2A5696416C)]
    public class GcBaseDefenceComponentData : NMSTemplate
    {
        /* 0x00 */ public List<GcBaseDefenceTrigger> Triggers;
        /* 0x10 */ public float ThreatUncertaintyThreshold;
        /* 0x14 */ public float LaserAnimateTime;
    }
}