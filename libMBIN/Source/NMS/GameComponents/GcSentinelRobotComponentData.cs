using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB711DEA3460FE542, NameHash = 0xC3E852EF937E74B5)]
    public class GcSentinelRobotComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        // size: 0x9
        public enum SentinelTypeEnum { PatrolDrone, CombatDrone, MedicDrone, SummonerDrone, CorruptedDrone, Quad,
            Mech, Walker, FriendlyDrone
        }
        /* 0x10 */ public SentinelTypeEnum SentinelType;
    }
}
