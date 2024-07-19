using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA493BF278160CE27, NameHash = 0xD942199B)]
    public class GcCreatureComponentData : NMSTemplate
    {
        [NMS(Index = 9)]
        /* 0x00 */ public Vector3f DiscoveryUIOffset;
        [NMS(Index = 13)]
        /* 0x10 */ public Vector3f PetLargeUIOverrideOffset;
        [NMS(Index = 4)]
        /* 0x20 */ public NMSString0x10 DeathEffect;
        [NMS(Index = 0)]
        /* 0x30 */ public NMSString0x10 Id;
        [NMS(Index = 5)]
        /* 0x40 */ public List<GcReplacementEffectData> ReplacementImpacts;
        [NMS(Index = 10)]
        /* 0x50 */ public List<GcCreatureDiscoveryThumbnailOverride> ThumbnailOverrides;
        [NMS(Index = 6)]
        /* 0x60 */ public float AccessoryPitchOffset;
        [NMS(Index = 1)]
        /* 0x64 */ public GcPrimaryAxis Axis;
        [NMS(Index = 7)]
        /* 0x68 */ public float DiscoveryFurScaler;
        [NMS(Index = 8)]
        /* 0x6C */ public float DiscoveryUIScaler;
        [NMS(Index = 3)]
        /* 0x70 */ public float PetIndoorScaler;
        [NMS(Index = 12)]
        /* 0x74 */ public float PetLargeUIOverrideScaler;
        [NMS(Index = 2)]
        /* 0x78 */ public float Scaler;
        [NMS(Index = 11)]
        /* 0x7C */ public bool UsePetLargeUIOverride;
    }
}
