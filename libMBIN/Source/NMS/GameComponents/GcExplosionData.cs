using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC8, GUID = 0x31F4B7FF54348572, NameHash = 0x8318BC4815036659)]
    public class GcExplosionData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public TkModelResource Model;
        /* 0x94 */ public GcAudioWwiseEvents AudioEvent;
        /* 0x98 */ public List<GcDebrisData> Debris;
        /* 0xA8 */ public float Life;
        /* 0xAC */ public float Scale;
        /* 0xB0 */ public float DistanceScale;
        /* 0xB4 */ public float DistanceScaleMax;
        /* 0xB8 */ public bool CamShake;
        /* 0xB9 */ public bool CamShakeSpaceScale;
        /* 0xBA */ public bool AllowTriggerActionOnDebris;
        /* 0xBB */ public bool AllowShootableDebris;
        /* 0xBC */ public bool AllowDestructableDebris;
        /* 0xC0 */ public float MaxSpawnDistance;
        /* 0xC4 */ public float CamShakeCustomMaxDistance;
    }
}
