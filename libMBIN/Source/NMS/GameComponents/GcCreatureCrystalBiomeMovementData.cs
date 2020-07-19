using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x90, GUID = 0x335B3FBA9028B17B, NameHash = 0x2C4F0C252A4FDDE9)]
    public class GcCreatureCrystalBiomeMovementData : NMSTemplate
    {
        /* 0x00 */ public List<GcBiomeSubType> ValidBiomes;
        /* 0x10 */ public List<NMSString0x10> ValidDescriptors;
        /* 0x20 */ public int NumShards;
        /* 0x24 */ public bool UseTerrainAngle;
        /* 0x25 */ public bool ScaleOnAppear;
        /* 0x28 */ public float SpawnDist;
        /* 0x2C */ public float DespawnDist;
        /* 0x30 */ public float MaxOffset;
        /* 0x34 */ public float MaxTilt;
        /* 0x38 */ public float OffsetTilt;
        /* 0x3C */ public float MinScale;
        /* 0x40 */ public float MaxScale;
        /* 0x44 */ public float MinAppearTime;
        /* 0x48 */ public float MaxAppearTime;
        /* 0x4C */ public float AppearOvershoot;
        /* 0x50 */ public float MinDisappearTime;
        /* 0x54 */ public float MaxDisappearTime;
        /* 0x58 */ public float ShowOffset;
        /* 0x5C */ public float HideOffset;
        /* 0x60 */ public float MinShowTime;
        /* 0x64 */ public float WalkSpeedModifier;
        /* 0x68 */ public float RunSpeedModifier;
        /* 0x6C */ public float ParticleScale;
        [NMS(Size = 0x10)]
        /* 0x70 */ public string DustEffect;
        /* 0x80 */ public float DeathFadeStart;
        /* 0x84 */ public float DeathFadeTime;
        public enum DeathTypeEnum { Explode, Drop}
        /* 0x88 */ public DeathTypeEnum DeathType;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x8C */ public byte[] Endpadding;
    }
}
