using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE532A46BB911296D, NameHash = 0xB1AE9C6)]
    public class GcExplosionData : NMSTemplate
    {
        [NMS(Index = 22)]
        /* 0x00 */ public Colour AddedLightColour;
        [NMS(Index = 1)]
        /* 0x10 */ public TkModelResource Model;
        [NMS(Index = 4)]
        /* 0x30 */ public List<GcDebrisData> Debris;
        [NMS(Index = 0)]
        /* 0x40 */ public NMSString0x10 Id;
        [NMS(Index = 12)]
        /* 0x50 */ public NMSString0x10 ShakeId;
        [NMS(Index = 21)]
        /* 0x60 */ public float AddedLightIntensity;
        [NMS(Index = 3)]
        /* 0x64 */ public GcAudioWwiseEvents AudioEndEvent;
        [NMS(Index = 2)]
        /* 0x68 */ public GcAudioWwiseEvents AudioEvent;
        [NMS(Index = 13)]
        /* 0x6C */ public float CamShakeCustomMaxDistance;
        [NMS(Index = 26)]
        /* 0x70 */ public float ClampToGroundRayDownLength;
        [NMS(Index = 25)]
        /* 0x74 */ public float ClampToGroundRayUpLength;
        [NMS(Index = 7)]
        /* 0x78 */ public float DistanceScale;
        [NMS(Index = 8)]
        /* 0x7C */ public float DistanceScaleMax;
        [NMS(Index = 5)]
        /* 0x80 */ public float Life;
        [NMS(Index = 18)]
        /* 0x84 */ public float LightFadeInTime;
        [NMS(Index = 19)]
        /* 0x88 */ public float LightFadeOutTime;
        [NMS(Index = 17)]
        /* 0x8C */ public float MaxSpawnDistance;
        [NMS(Index = 6)]
        /* 0x90 */ public float Scale;
        [NMS(Index = 11)]
        /* 0x94 */ public float ShakeStrengthModifier;
        [NMS(Index = 20)]
        /* 0x98 */ public bool AddLight;
        [NMS(Index = 16)]
        /* 0x99 */ public bool AllowDestructableDebris;
        [NMS(Index = 15)]
        /* 0x9A */ public bool AllowShootableDebris;
        [NMS(Index = 14)]
        /* 0x9B */ public bool AllowTriggerActionOnDebris;
        [NMS(Index = 9)]
        /* 0x9C */ public bool CamShake;
        [NMS(Index = 10)]
        /* 0x9D */ public bool CamShakeSpaceScale;
        [NMS(Index = 23)]
        /* 0x9E */ public bool ClampToGround;
        [NMS(Index = 24)]
        /* 0x9F */ public bool ClampToGroundContinuously;
        [NMS(Index = 27)]
        /* 0xA0 */ public bool UseGroundNormal;
    }
}
