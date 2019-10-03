using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC8, Alignment = 0x8, GUID = 0xC9A431B313EDED5B, NameHash = 0x35C91009067A6431)]
    public class GcAIShipSpawnData : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x00 */ public string Message;
        [NMS(Size = 0x20)]
        /* 0x00 */ public string OSDMessage;
        /* 0x40 */ public TkInputEnum Shortcut;
        /* 0x44 */ public bool WarpIn;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x45 */ public byte[] Padding45;
        /* 0x48 */ public GcAISpaceshipRoles Role;
        /* 0x4C */ public float MinRange;
        /* 0x50 */ public Vector2f Scale;
        [NMS(Size = 0x10)]
        /* 0x58 */ public string Reward;
        [NMS(Size = 0x20)]
        /* 0x68 */ public string RewardMessage;
        /* 0x88 */ public bool AttackFreighter;
        /* 0x8C */ public Vector2f Spread;
        /* 0x94 */ public Vector2f Count;
        /* 0x9C */ public Vector2f StartTime;
		public enum SpawnShapeEnum { Sphere, Cone }
		/* 0xA4 */ public SpawnShapeEnum SpawnShape;

        /* 0xA8 */ public GcShipAIPerformanceArray Performances;

        /* 0xB8 */ public List<GcAIShipSpawnData> ChildSpawns;
    }
}
