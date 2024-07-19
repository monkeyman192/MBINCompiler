using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAC1E79EB9FFB3722, NameHash = 0x466A95A0)]
    public class GcAIShipSpawnData : NMSTemplate
    {
        [NMS(Index = 14)]
        /* 0x000 */ public Vector3f OffsetSphereOffset;
        [NMS(Index = 10)]
        /* 0x010 */ public GcAIShipSpawnMarkerData MarkerData;
        [NMS(Index = 1)]
        /* 0x060 */ public NMSString0x20A CombatMessage;
        [NMS(Index = 0)]
        /* 0x080 */ public NMSString0x20A Message;
        [NMS(Index = 2)]
        /* 0x0A0 */ public NMSString0x20A OSDMessage;
        [NMS(Index = 9)]
        /* 0x0C0 */ public NMSString0x20A RewardMessage;
        [NMS(Index = 12)]
        /* 0x0E0 */ public NMSString0x10 AttackDefinition;
        [NMS(Index = 19)]
        /* 0x0F0 */ public List<GcAIShipSpawnData> ChildSpawns;
        [NMS(Index = 18)]
        /* 0x100 */ public GcShipAIPerformanceArray Performances;
        [NMS(Index = 8)]
        /* 0x110 */ public NMSString0x10 Reward;
        [NMS(Index = 15)]
        /* 0x120 */ public Vector2f Count;
        [NMS(Index = 7)]
        /* 0x128 */ public Vector2f Scale;
        [NMS(Index = 13)]
        /* 0x130 */ public Vector2f Spread;
        [NMS(Index = 16)]
        /* 0x138 */ public Vector2f StartTime;
        [NMS(Index = 6)]
        /* 0x140 */ public float MinRange;
        [NMS(Index = 5)]
        /* 0x144 */ public GcAISpaceshipRoles Role;
        [NMS(Index = 3)]
        /* 0x148 */ public TkInputEnum Shortcut;
        // size: 0x3
        public enum SpawnShapeEnum : uint {
            Sphere,
            Cone,
            OffsetSphere,
        }
        [NMS(Index = 17)]
        /* 0x14C */ public SpawnShapeEnum SpawnShape;
        [NMS(Index = 11)]
        /* 0x150 */ public bool AttackFreighter;
        [NMS(Index = 4)]
        /* 0x151 */ public bool WarpIn;
    }
}
