namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x655CD9EAB6B8C9B5, NameHash = 0x9E230B05)]
    public class GcBuildMenuOption : NMSTemplate
    {
        // size: 0x10
        public enum BuildMenuOptionEnum : uint {
            Place,
            ChangeColour,
            FreeRotate,
            Scale,
            SnapRotate,
            Move,
            Duplicate,
            Delete,
            ToggleBuildCam,
            ToggleSnappingAndCollision,
            ToggleSelectionMode,
            ToggleWiringMode,
            ViewRelatives,
            CyclePart,
            PlaceWire,
            CycleRotateMode,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BuildMenuOptionEnum BuildMenuOption;
    }
}
