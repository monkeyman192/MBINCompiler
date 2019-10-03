using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x44, GUID = 0x1D8328B48879E395, NameHash = 0x74BA808E86F0EC01)]
    public class GcScannableComponentData : NMSTemplate
    {
        /* 0x00 */ public float ScanRange;
        [NMS(Size = 0x20)]
        /* 0x04 */ public string ScanName;
        /* 0x24 */ public float ScanTime;
        /* 0x28 */ public float CompassRangeMultiplier;
        /* 0x2C */ public float AlwaysShowRange;
        /* 0x30 */ public bool CanTagIcon;
        /* 0x31 */ public bool ClearTagOnArrival;
        /* 0x32 */ public bool DisableIfBuildingPart;
        /* 0x33 */ public bool DisableIfInBase;
        /* 0x34 */ public bool UseModelNode;

        /* 0x38 */ public GcScannerIconTypes IconType;
		public enum ScannableTypeEnum { Binoculars, BinocularsHotspots, Scanner, Marker, None }
		/* 0x3C */ public ScannableTypeEnum ScannableType;
        /* 0x40 */ public bool IsPlacedMarker;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x41 */ public byte[] EndPadding;
    }
}
