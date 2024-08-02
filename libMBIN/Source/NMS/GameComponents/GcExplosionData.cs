using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x375CD9F1EBF061BF, NameHash = 0xB1AE9C6)]
    public class GcExplosionData : NMSTemplate
    {
        [NMS(Index = 21)]
        /* 0x00 */ public Colour AddedLightColour;
        [NMS(Index = 1)]
        /* 0x10 */ public TkModelResource Model;
        [NMS(Index = 3)]
        /* 0x28 */ public List<GcDebrisData> Debris;
        [NMS(Index = 0)]
        /* 0x38 */ public NMSString0x10 Id;
        [NMS(Index = 11)]
        /* 0x48 */ public NMSString0x10 ShakeId;
        [NMS(Index = 20)]
        /* 0x58 */ public float AddedLightIntensity;
        [NMS(Index = 2)]
        /* 0x5C */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 16)]
        /* 0x60 */ public float CamShakeCustomMaxDistance;
        [NMS(Index = 6)]
        /* 0x64 */ public float DistanceScale;
        [NMS(Index = 7)]
        /* 0x68 */ public float DistanceScaleMax;
        [NMS(Index = 4)]
        /* 0x6C */ public float Life;
        [NMS(Index = 17)]
        /* 0x70 */ public float LightFadeInTime;
        [NMS(Index = 18)]
        /* 0x74 */ public float LightFadeOutTime;
        [NMS(Index = 15)]
        /* 0x78 */ public float MaxSpawnDistance;
        [NMS(Index = 5)]
        /* 0x7C */ public float Scale;
        [NMS(Index = 10)]
        /* 0x80 */ public float ShakeStrengthModifier;
        [NMS(Index = 19)]
        /* 0x84 */ public bool AddLight;
        [NMS(Index = 14)]
        /* 0x85 */ public bool AllowDestructableDebris;
        [NMS(Index = 13)]
        /* 0x86 */ public bool AllowShootableDebris;
        [NMS(Index = 12)]
        /* 0x87 */ public bool AllowTriggerActionOnDebris;
        [NMS(Index = 8)]
        /* 0x88 */ public bool CamShake;
        [NMS(Index = 9)]
        /* 0x89 */ public bool CamShakeSpaceScale;
    }
}
