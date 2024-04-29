using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x77CF677862D9EB37, NameHash = 0x8318BC4815036659)]
    public class GcExplosionData : NMSTemplate
    {
        [NMS(Index = 21)]
        /* 0x00 */ public Colour AddedLightColour;
        [NMS(Index = 3)]
        /* 0x10 */ public List<GcDebrisData> Debris;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 Id;
        [NMS(Index = 11)]
        /* 0x30 */ public NMSString0x10 ShakeId;
        [NMS(Index = 1)]
        /* 0x40 */ public TkModelResource Model;
        [NMS(Index = 20)]
        /* 0xC4 */ public float AddedLightIntensity;
        [NMS(Index = 2)]
        /* 0xC8 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 16)]
        /* 0xCC */ public float CamShakeCustomMaxDistance;
        [NMS(Index = 6)]
        /* 0xD0 */ public float DistanceScale;
        [NMS(Index = 7)]
        /* 0xD4 */ public float DistanceScaleMax;
        [NMS(Index = 4)]
        /* 0xD8 */ public float Life;
        [NMS(Index = 17)]
        /* 0xDC */ public float LightFadeInTime;
        [NMS(Index = 18)]
        /* 0xE0 */ public float LightFadeOutTime;
        [NMS(Index = 15)]
        /* 0xE4 */ public float MaxSpawnDistance;
        [NMS(Index = 5)]
        /* 0xE8 */ public float Scale;
        [NMS(Index = 10)]
        /* 0xEC */ public float ShakeStrengthModifier;
        [NMS(Index = 19)]
        /* 0xF0 */ public bool AddLight;
        [NMS(Index = 14)]
        /* 0xF1 */ public bool AllowDestructableDebris;
        [NMS(Index = 13)]
        /* 0xF2 */ public bool AllowShootableDebris;
        [NMS(Index = 12)]
        /* 0xF3 */ public bool AllowTriggerActionOnDebris;
        [NMS(Index = 8)]
        /* 0xF4 */ public bool CamShake;
        [NMS(Index = 9)]
        /* 0xF5 */ public bool CamShakeSpaceScale;
    }
}
