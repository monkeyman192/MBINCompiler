using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBEFE1C3015A6B9AA, NameHash = 0x35C91009067A6431)]
    public class GcAIShipSpawnData : NMSTemplate
    {
        [NMS(Index = 14)]
        /* 0x000 */ public Vector3f OffsetSphereOffset;
        [NMS(Index = 10)]
        /* 0x010 */ public GcAIShipSpawnMarkerData MarkerData;
        [NMS(Index = 1)]
        /* 0x0C8 */ public NMSString0x20A CombatMessage;
        [NMS(Index = 0)]
        /* 0x0E8 */ public NMSString0x20A Message;
        [NMS(Index = 2)]
        /* 0x108 */ public NMSString0x20A OSDMessage;
        [NMS(Index = 9)]
        /* 0x128 */ public NMSString0x20A RewardMessage;
        [NMS(Index = 12)]
        /* 0x148 */ public NMSString0x10 AttackDefinition;
        [NMS(Index = 19)]
        /* 0x158 */ public List<GcAIShipSpawnData> ChildSpawns;
        [NMS(Index = 18)]
        /* 0x168 */ public GcShipAIPerformanceArray Performances;
        [NMS(Index = 8)]
        /* 0x178 */ public NMSString0x10 Reward;
        [NMS(Index = 15)]
        /* 0x188 */ public Vector2f Count;
        [NMS(Index = 7)]
        /* 0x190 */ public Vector2f Scale;
        [NMS(Index = 13)]
        /* 0x198 */ public Vector2f Spread;
        [NMS(Index = 16)]
        /* 0x1A0 */ public Vector2f StartTime;
        [NMS(Index = 6)]
        /* 0x1A8 */ public float MinRange;
        [NMS(Index = 5)]
        /* 0x1AC */ public GcAISpaceshipRoles Role;
        [NMS(Index = 3)]
        /* 0x1B0 */ public TkInputEnum Shortcut;
        // size: 0x3
        public enum SpawnShapeEnum : uint {
            Sphere,
            Cone,
            OffsetSphere,
        }
        [NMS(Index = 17)]
        /* 0x1B4 */ public SpawnShapeEnum SpawnShape;
        [NMS(Index = 11)]
        /* 0x1B8 */ public bool AttackFreighter;
        [NMS(Index = 4)]
        /* 0x1B9 */ public bool WarpIn;
    }
}
