using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBEFE1C3015A6B9AA, NameHash = 0x35C91009067A6431)]
    public class GcAIShipSpawnData : NMSTemplate
    {
        /* 0x000 */ public Vector3f OffsetSphereOffset;
        /* 0x010 */ public GcAIShipSpawnMarkerData MarkerData;
        /* 0x0C8 */ public NMSString0x20A CombatMessage;
        /* 0x0E8 */ public NMSString0x20A Message;
        /* 0x108 */ public NMSString0x20A OSDMessage;
        /* 0x128 */ public NMSString0x20A RewardMessage;
        /* 0x148 */ public NMSString0x10 AttackDefinition;
        /* 0x158 */ public List<GcAIShipSpawnData> ChildSpawns;
        /* 0x168 */ public GcShipAIPerformanceArray Performances;
        /* 0x178 */ public NMSString0x10 Reward;
        /* 0x188 */ public Vector2f Count;
        /* 0x190 */ public Vector2f Scale;
        /* 0x198 */ public Vector2f Spread;
        /* 0x1A0 */ public Vector2f StartTime;
        /* 0x1A8 */ public float MinRange;
        /* 0x1AC */ public GcAISpaceshipRoles Role;
        /* 0x1B0 */ public TkInputEnum Shortcut;
        // size: 0x3
        public enum SpawnShapeEnum : uint {
            Sphere,
            Cone,
            OffsetSphere,
        }
        /* 0x1B4 */ public SpawnShapeEnum SpawnShape;
        /* 0x1B8 */ public bool AttackFreighter;
        /* 0x1B9 */ public bool WarpIn;
    }
}
