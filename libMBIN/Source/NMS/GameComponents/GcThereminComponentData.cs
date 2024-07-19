namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4AF3984B0C0C7E5F, NameHash = 0x56E2344A)]
    public class GcThereminComponentData : NMSTemplate
    {
        [NMS(Index = 11)]
        /* 0x00 */ public float IgnorePlayerDistance;
        [NMS(Index = 10)]
        /* 0x04 */ public float MaxPitch;
        [NMS(Index = 4)]
        /* 0x08 */ public float MaxVolume;
        [NMS(Index = 9)]
        /* 0x0C */ public float MinPitch;
        [NMS(Index = 3)]
        /* 0x10 */ public float MinVolume;
        [NMS(Index = 8)]
        /* 0x14 */ public float PitchMaxDist;
        [NMS(Index = 7)]
        /* 0x18 */ public float PitchMinDist;
        [NMS(Index = 2)]
        /* 0x1C */ public float VolumeMaxDist;
        [NMS(Index = 1)]
        /* 0x20 */ public float VolumeMinDist;
        [NMS(Index = 6)]
        /* 0x24 */ public NMSString0x20 PitchEndLocator;
        [NMS(Index = 5)]
        /* 0x44 */ public NMSString0x20 PitchStartLocator;
        [NMS(Index = 0)]
        /* 0x64 */ public NMSString0x20 VolumeBBName;
    }
}
