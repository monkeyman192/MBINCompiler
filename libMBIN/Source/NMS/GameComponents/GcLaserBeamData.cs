using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x1C0, Alignment = 0x10, GUID = 0x940B61A1D3CEBB8E, NameHash = 0x1AA966F8BA4E3153)]
    public class GcLaserBeamData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Id;
        [NMS(Size = 0x80)]
        /* 0x010 */ public string BeamFile;
        [NMS(Size = 0x80)]
        /* 0x090 */ public string BeamCoreFile;
        /* 0x110 */ public float Width;
        /* 0x114 */ public float HitWidth;
        /* 0x118 */ public float PulseFrequency;
        /* 0x11C */ public float PulseAmplitude;
        /* 0x120 */ public float StartTime;
        /* 0x124 */ public float EndTime;
        /* 0x128 */ public GcAudioWwiseEvents AudioStart;
        /* 0x12C */ public GcAudioWwiseEvents AudioStop;
        /* 0x130 */ public GcAudioWwiseEvents AudioOverheat;
        /* 0x134 */ public int Damage;
        /* 0x138 */ public GcDamageType DamageType;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x13C */ public byte[] Padding13C;
        [NMS(Size = 0x10)]
        /* 0x140 */ public string PlayerDamage;
        [NMS(Size = 0x10)]
        /* 0x150 */ public string ImpactEffect;
        /* 0x160 */ public List<GcProjectileImpactData> Impacts;
        /* 0x170 */ public float HitRate;
        /* 0x174 */ public bool SingleHit;
        /* 0x178 */ public float RagdollPush;
        /* 0x17C */ public float PhysicsPush;
        /* 0x180 */ public float MiningHitRate;
        /* 0x184 */ public bool HasLight;
        /* 0x185 */ public bool CanMine;
        /* 0x188 */ public float LightScale;
        /* 0x190 */ public Colour LightColour;
        /* 0x1A0 */ public Colour Colour;
        /* 0x1B0 */ public Vector3f ImpactOffset;
    }

}
