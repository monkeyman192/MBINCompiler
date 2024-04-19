using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC456A057ECE2EEC9, NameHash = 0x74BA808E86F0EC01)]
    public class GcScannableComponentData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A FreighterObjectAlreadyUsedLocID;
        /* 0x20 */ public NMSString0x10 MissionSurveyId;
        /* 0x30 */ public float AlwaysShowRange;
        /* 0x34 */ public float CompassRangeMultiplier;
        /* 0x38 */ public GcScannerIconTypes Icon;
        /* 0x3C */ public float MinDisplayDistanceOverride;
        // size: 0x6
        public enum ScannableTypeEnum : uint {
            Binoculars,
            BinocularsHotspots,
            Scanner,
            Marker,
            SpaceBattleTarget,
            None,
        }
        /* 0x40 */ public ScannableTypeEnum ScannableType;
        /* 0x44 */ public float ScanRange;
        /* 0x48 */ public float ScanTime;
        /* 0x4C */ public NMSString0x20 ScanName;
        /* 0x6C */ public bool AllowedToMerge;
        /* 0x6D */ public bool CanTagIcon;
        /* 0x6E */ public bool ClearTagOnArrival;
        /* 0x6F */ public bool DisableIfBuildingPart;
        /* 0x70 */ public bool DisableIfInBase;
        /* 0x71 */ public bool IsPlacedMarker;
        /* 0x72 */ public bool MarkerActiveWithNodeInactive;
        /* 0x73 */ public bool ShowInFreighterBranchRoom;
        /* 0x74 */ public bool TellPlayerIfFreighterObjectUsed;
        /* 0x75 */ public bool UseModelNode;
    }
}
