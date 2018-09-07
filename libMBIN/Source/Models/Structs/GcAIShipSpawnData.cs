using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xA8, Alignment = 0x8)]
    public class GcAIShipSpawnData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string Message;

        /* 0x20 */ public int Shortcut;     // should be TkInputEnum I think...
        /* 0x24 */ public bool WarpIn;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x25 */ public byte[] Padding25;
        /* 0x28 */ public GcAISpaceshipRoles ShipRole;
        /* 0x2C */ public float MinRange;
        /* 0x30 */ public Vector2f Scale;
        [NMS(Size = 0x10)]
        /* 0x38 */ public string Reward;
        [NMS(Size = 0x20)]
        /* 0x48 */ public string RewardMessage;
        /* 0x68 */ public bool AttackFreighter;
        /* 0x6C */ public Vector2f Spread;
        /* 0x74 */ public Vector2f Count;
        /* 0x7C */ public Vector2f StartTime;
		public enum SpawnShapeEnum { Sphere, Cone }
		public SpawnShapeEnum SpawnShape;

        /* 0x88 */ public GcShipAIPerformanceArray Performances;

        /* 0x98 */ public List<GcAIShipSpawnData> ChildSpawns;
    }
}
