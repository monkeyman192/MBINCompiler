using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x60, GUID = 0x4C02A41D41E19035, NameHash = 0xE5075EC0403F94CA)]
    public class GcPhotoModeSettings : NMSTemplate
    {
        /* 0x00 */ public float Fog;
        /* 0x04 */ public float CloudAmount;
        /* 0x10 */ public Vector4f SunDir;
        /* 0x20 */ public bool SunDirSet;
        /* 0x24 */ public float FoV;
        /* 0x28 */ public bool FoVSet;
		public enum DepthOfFieldEnum { Off, Automatic, Manual }
		/* 0x2C */ public DepthOfFieldEnum DepthOfField;
        /* 0x30 */ public int DepthOfFieldStrengthSetting;
        /* 0x34 */ public float DepthOfFieldDistance;
        /* 0x38 */ public float DepthOfFieldDistanceSpace;
        /* 0x3C */ public float HalfFocalPlaneDepth;
        /* 0x40 */ public float HalfFocalPlaneDepthSpace;
        /* 0x44 */ public float DepthOfFieldPhysConvergence;
        /* 0x48 */ public float DepthOfFieldPhysAperture;
        /* 0x4C */ public float Vignette;
        /* 0x50 */ public int Filter;
        /* 0x54 */ public float Bloom;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x58 */ public byte[] EndPadding;
    }
}
