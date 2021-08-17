using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0xDE0E4B894E24695A, NameHash = 0xFC703DAD77E37E30)]
    public class GcBuildingDensity : NMSTemplate
    {
        /* 0x0 */ public float BuildingSpacing;
        public enum ClusterChanceEnum { Cluster, Single, None }     // related to BuildingClusterPlacement enum
        [NMS(Size = 0x3, EnumType = typeof(ClusterChanceEnum))]
        /* 0x4 */ public float[] BuildingClusterChance;
    }
}
