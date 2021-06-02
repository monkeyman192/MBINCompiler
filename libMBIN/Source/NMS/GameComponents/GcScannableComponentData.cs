using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x80, Alignment = 0x8, GUID = 0xCA5FBE1F6ACA4F92, NameHash = 0x74BA808E86F0EC01)]
    public class GcScannableComponentData : NMSTemplate
    {
        /* 0x00 */ public float ScanRange;
        /* 0x04 */ public NMSString0x20 ScanName;
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
        /* 0x41 */ public bool ShowInFreighterBranchRoom;
        /* 0x42 */ public bool TellPlayerIfFreighterObjectUsed;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x43 */ public byte[] Padding43;
        /* 0x48 */ public NMSString0x20 FreighterObjectAlreadyUsedLocID;
        /* 0x68 */ public bool AllowedToMerge;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x69 */ public byte[] Padding69;
        /* 0x70 */ public NMSString0x10 MissionSurveyId;
    }
}
