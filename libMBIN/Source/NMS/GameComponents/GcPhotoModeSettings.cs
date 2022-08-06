using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x04DFB9FAA89995B6, NameHash = 0xE5075EC0403F94CA)]
    public class GcPhotoModeSettings : NMSTemplate
    {
        /* 0x00 */ public float Fog;
        /* 0x04 */ public float CloudAmount;
        /* 0x10 */ public Vector4f SunDir;
        /* 0x20 */ public float FoV;
		public enum DepthOfFieldSettingEnum { Off, Mid, On, Macro }
		/* 0x24 */ public DepthOfFieldSettingEnum DepthOfFieldSetting;
        /* 0x28 */ public float DepthOfFieldDistance;
        /* 0x2C */ public float DepthOfFieldDistanceSpace;
        /* 0x30 */ public float HalfFocalPlaneDepth;
        /* 0x34 */ public float HalfFocalPlaneDepthSpace;
        /* 0x38 */ public float DepthOfFieldPhysConvergence;
        /* 0x3C */ public float DepthOfFieldPhysAperture;
        /* 0x40 */ public float Vignette;
        /* 0x44 */ public int Filter;
        /* 0x48 */ public float Bloom;
    }
}
