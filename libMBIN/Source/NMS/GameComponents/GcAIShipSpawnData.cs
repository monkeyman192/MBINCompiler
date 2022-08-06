using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC1E37CAD611FFF3A, NameHash = 0x35C91009067A6431)]
    public class GcAIShipSpawnData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A Message;
        /* 0x020 */ public NMSString0x20A CombatMessage;
        /* 0x040 */ public NMSString0x20A OSDMessage;
        /* 0x060 */ public TkInputEnum Shortcut;
        /* 0x064 */ public bool WarpIn;
        /* 0x068 */ public GcAISpaceshipRoles Role;
        /* 0x06C */ public float MinRange;
        /* 0x070 */ public Vector2f Scale;
        /* 0x078 */ public NMSString0x10 Reward;
        /* 0x088 */ public NMSString0x20A RewardMessage;
        /* 0x0A8 */ public GcAIShipSpawnMarkerData MarkerData;
        /* 0x168 */ public bool AttackFreighter;
        /* 0x16C */ public Vector2f Spread;
        /* 0x174 */ public Vector2f Count;
        /* 0x17C */ public Vector2f StartTime;
        // size: 0x2
        public enum SpawnShapeEnum { Sphere, Cone }
        /* 0x184 */ public SpawnShapeEnum SpawnShape;
        /* 0x188 */ public List<NMSTemplate> Array;
        /* 0x198 */ public List<GcAIShipSpawnData> ChildSpawns;
    }
}
