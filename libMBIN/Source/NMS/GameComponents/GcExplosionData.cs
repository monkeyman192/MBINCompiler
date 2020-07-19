using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC0, GUID = 0x1788579DDB37F0AA, NameHash = 0x8318BC4815036659)]
    public class GcExplosionData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string Id;
        /* 0x10 */ public TkModelResource Model;
        /* 0x94 */ public GcAudioWwiseEvents AkEvent;
        /* 0x98 */ public List<GcDebrisData> Debris;
        /* 0xA8 */ public float Life;                   // 40400000
        /* 0xAC */ public float Scale;                  // 3F800000
        /* 0xB0 */ public float DistanceScale;          // 42480000
        /* 0xB4 */ public float DistanceScaleMax;
        /* 0xB8 */ public bool CamShake;                // di
        /* 0xB9 */ public bool CamShakeSpace;
        /* 0xBA */ public bool AllowTriggerActionOnDebris;
        /* 0xBC */ public float MaxSpawnDistance;       // edi
    }
}
