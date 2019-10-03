using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x80, GUID = 0x4A9B3DFF84E1DF84, NameHash = 0x2C4F0C252A4FDDE9)]
    public class GcCreatureCrystalBiomeMovementData : NMSTemplate
    {
        /* 0x00 */ public List<GcBiomeSubType> ValidBiomes;
        /* 0x10 */ public int NumShards;
        /* 0x14 */ public bool UseTerrainAngle;
        /* 0x15 */ public bool ScaleOnAppear;
        /* 0x18 */ public float SpawnDist;
        /* 0x1C */ public float DespawnDist;
        /* 0x20 */ public float MaxOffset;
        /* 0x24 */ public float MaxTilt;
        /* 0x28 */ public float OffsetTilt;
        /* 0x2C */ public float MinScale;
        /* 0x30 */ public float MaxScale;
        /* 0x34 */ public float MinAppearTime;
        /* 0x38 */ public float MaxAppearTime;
        /* 0x3C */ public float AppearOvershoot;
        /* 0x40 */ public float MinDisappearTime;
        /* 0x44 */ public float MaxDisappearTime;
        /* 0x48 */ public float ShowOffset;
        /* 0x4C */ public float HideOffset;
        /* 0x50 */ public float MinShowTime;
        /* 0x54 */ public float WalkSpeedModifier;
        /* 0x58 */ public float RunSpeedModifier;
        /* 0x5C */ public float ParticleScale;
        [NMS(Size = 0x10)]
        /* 0x60 */ public string DustEffect;
        /* 0x70 */ public float DeathFadeStart;
        /* 0x74 */ public float DeathFadeTime;
        public enum DeathTypeEnum { Explode, Drop}
        /* 0x78 */ public DeathTypeEnum DeathType;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x7C */ public byte[] Endpadding;
    }
}
