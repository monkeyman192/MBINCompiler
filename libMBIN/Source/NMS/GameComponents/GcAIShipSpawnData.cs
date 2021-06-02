using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC8, Alignment = 0x8, GUID = 0xD860F7A0405EE7AB, NameHash = 0x35C91009067A6431)]
    public class GcAIShipSpawnData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 Message;
        /* 0x00 */ public NMSString0x20 OSDMessage;
        /* 0x40 */ public TkInputEnum Shortcut;
        /* 0x44 */ public bool WarpIn;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x45 */ public byte[] Padding45;
        /* 0x48 */ public GcAISpaceshipRoles Role;
        /* 0x4C */ public float MinRange;
        /* 0x50 */ public Vector2f Scale;
        /* 0x58 */ public NMSString0x10 Reward;
        /* 0x68 */ public NMSString0x20 RewardMessage;
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
