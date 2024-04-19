namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA6116160B4E36AE2, NameHash = 0xE5075EC0403F94CA)]
    public class GcPhotoModeSettings : NMSTemplate
    {
        /* 0x00 */ public Vector4f SunDir;
        /* 0x10 */ public float Bloom;
        /* 0x14 */ public float CloudAmount;
        /* 0x18 */ public float DepthOfFieldDistance;
        /* 0x1C */ public float DepthOfFieldDistanceSpace;
        /* 0x20 */ public float DepthOfFieldPhysAperture;
        /* 0x24 */ public float DepthOfFieldPhysConvergence;
        // size: 0x4
        public enum DepthOfFieldSettingEnum : uint {
            Off,
            Mid,
            On,
            Macro,
        }
        /* 0x28 */ public DepthOfFieldSettingEnum DepthOfFieldSetting;
        /* 0x2C */ public int Filter;
        /* 0x30 */ public float Fog;
        /* 0x34 */ public float FoV;
        /* 0x38 */ public float HalfFocalPlaneDepth;
        /* 0x3C */ public float HalfFocalPlaneDepthSpace;
        /* 0x40 */ public float Vignette;
    }
}
