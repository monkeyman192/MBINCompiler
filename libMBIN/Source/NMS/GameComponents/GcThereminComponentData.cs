namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9E9E8E9F0A88323, NameHash = 0xD0E5A023C215AB4A)]
    public class GcThereminComponentData : NMSTemplate
    {
        /* 0x00 */ public float IgnorePlayerDistance;
        /* 0x04 */ public float MaxPitch;
        /* 0x08 */ public float MaxVolume;
        /* 0x0C */ public float MinPitch;
        /* 0x10 */ public float MinVolume;
        /* 0x14 */ public float PitchMaxDist;
        /* 0x18 */ public float PitchMinDist;
        /* 0x1C */ public float VolumeMaxDist;
        /* 0x20 */ public float VolumeMinDist;
        /* 0x24 */ public NMSString0x20 PitchEndLocator;
        /* 0x44 */ public NMSString0x20 PitchStartLocator;
        /* 0x64 */ public NMSString0x20 VolumeBBName;
    }
}
