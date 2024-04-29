namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD51F6676FEB9CC69, NameHash = 0xE5075EC0403F94CA)]
    public class GcPhotoModeSettings : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Vector4f SunDir;
        [NMS(Index = 13)]
        /* 0x10 */ public float Bloom;
        [NMS(Index = 1)]
        /* 0x14 */ public float CloudAmount;
        [NMS(Index = 5)]
        /* 0x18 */ public float DepthOfFieldDistance;
        [NMS(Index = 6)]
        /* 0x1C */ public float DepthOfFieldDistanceSpace;
        [NMS(Index = 10)]
        /* 0x20 */ public float DepthOfFieldPhysAperture;
        [NMS(Index = 9)]
        /* 0x24 */ public float DepthOfFieldPhysConvergence;
        // size: 0x4
        public enum DepthOfFieldSettingEnum : uint {
            Off,
            Mid,
            On,
            Macro,
        }
        [NMS(Index = 4)]
        /* 0x28 */ public DepthOfFieldSettingEnum DepthOfFieldSetting;
        [NMS(Index = 12)]
        /* 0x2C */ public int Filter;
        [NMS(Index = 0)]
        /* 0x30 */ public float Fog;
        [NMS(Index = 3)]
        /* 0x34 */ public float FoV;
        [NMS(Index = 7)]
        /* 0x38 */ public float HalfFocalPlaneDepth;
        [NMS(Index = 8)]
        /* 0x3C */ public float HalfFocalPlaneDepthSpace;
        [NMS(Index = 11)]
        /* 0x40 */ public float Vignette;
    }
}
