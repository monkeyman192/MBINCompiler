using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x54F2E2B79686F776, NameHash = 0x8318BC4815036659)]
    public class GcExplosionData : NMSTemplate
    {
        /* 0x00 */ public Colour AddedLightColour;
        /* 0x10 */ public List<GcDebrisData> Debris;
        /* 0x20 */ public NMSString0x10 Id;
        /* 0x30 */ public NMSString0x10 ShakeId;
        /* 0x40 */ public TkModelResource Model;
        /* 0xC4 */ public float AddedLightIntensity;
        /* 0xC8 */ public GcAudioWwiseEvents AudioEvent;
        /* 0xCC */ public float CamShakeCustomMaxDistance;
        /* 0xD0 */ public float DistanceScale;
        /* 0xD4 */ public float DistanceScaleMax;
        /* 0xD8 */ public float Life;
        /* 0xDC */ public float LightFadeInTime;
        /* 0xE0 */ public float LightFadeOutTime;
        /* 0xE4 */ public float MaxSpawnDistance;
        /* 0xE8 */ public float Scale;
        /* 0xEC */ public float ShakeStrengthModifier;
        /* 0xF0 */ public bool AddLight;
        /* 0xF1 */ public bool AllowDestructableDebris;
        /* 0xF2 */ public bool AllowShootableDebris;
        /* 0xF3 */ public bool AllowTriggerActionOnDebris;
        /* 0xF4 */ public bool CamShake;
        /* 0xF5 */ public bool CamShakeSpaceScale;
    }
}
