using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcExplosionData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public TkModelResource Model;
        /* 0x94 */ public GcAudioWwiseEvents AkEvent;
        /* 0x98 */ public List<GcDebrisData> Debris;
        /* 0xA8 */ public float Life;
        /* 0xAC */ public float Scale;
        /* 0xB0 */ public float DistanceScale;
        /* 0xB4 */ public bool CamShake;
        /* 0xB8 */ public float MaxSpawnDistance;
    }
}
