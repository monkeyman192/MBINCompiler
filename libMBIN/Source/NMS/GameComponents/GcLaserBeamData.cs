using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcLaserBeamData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Id;
        /* 0x010 */ public NMSString0x80 BeamFile;
        /* 0x090 */ public NMSString0x80 BeamCoreFile;
        /* 0x110 */ public float Width;
        /* 0x114 */ public float HitWidth;
        /* 0x118 */ public float PulseFrequency;
        /* 0x11C */ public float PulseAmplitude;
        /* 0x120 */ public float StartTime;
        /* 0x124 */ public float EndTime;
        /* 0x128 */ public GcAudioWwiseEvents AkEvent1;
        /* 0x12C */ public GcAudioWwiseEvents AkEvent2;
        /* 0x130 */ public GcAudioWwiseEvents AkEvent3;
        /* 0x134 */ public int Damage;
        /* 0x138 */ public NMSString0x10 PlayerDamage;
        /* 0x148 */ public NMSString0x10 ImpactEffect;
        /* 0x158 */ public List<GcProjectileImpactData> Impacts;
        /* 0x168 */ public float HitRate;
        /* 0x16C */ public float RagdollPush;
        /* 0x170 */ public float MiningHitRate;
        /* 0x174 */ public bool HasLight;
        /* 0x175 */ public bool CanMine;
        /* 0x178 */ public float LightScale;
        /* 0x180 */ public Colour LightColour;
        /* 0x190 */ public Colour Colour;
    }

}
