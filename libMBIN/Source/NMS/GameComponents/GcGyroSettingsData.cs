namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDC3376240A715E64, NameHash = 0x4EA99277E076565E)]
    public class GcGyroSettingsData : NMSTemplate
    {
        /* 0x00 */ public float Acceleration;
        // size: 0x3
        public enum ActiveModeInExocraftEnum : uint {
            None,
            Firing,
            Always,
        }
        /* 0x04 */ public ActiveModeInExocraftEnum ActiveModeInExocraft;
        // size: 0x4
        public enum ActiveModeOnFootEnum : uint {
            None,
            ScopeOnly,
            ScopeOrFiring,
            Always,
        }
        /* 0x08 */ public ActiveModeOnFootEnum ActiveModeOnFoot;
        // size: 0x4
        public enum ActiveModeWhenBuildingEnum : uint {
            None,
            BuildPlacementOnly,
            SelectionModeOnly,
            Always,
        }
        /* 0x0C */ public ActiveModeWhenBuildingEnum ActiveModeWhenBuilding;
        /* 0x10 */ public float AimingMultiplier;
        /* 0x14 */ public float BuildingMultiplier;
        // size: 0x2
        public enum CursorLookStickEnabledEnum : uint {
            None,
            Disabled,
        }
        /* 0x18 */ public CursorLookStickEnabledEnum CursorLookStickEnabled;
        /* 0x1C */ public float CursorSensitivityX;
        /* 0x20 */ public float CursorSensitivityY;
        /* 0x24 */ public float CursorTighteningThreshold;
        /* 0x28 */ public float Deadzone;
        // size: 0x3
        public enum EnableGyroInBuildingFreeCamEnum : uint {
            Never,
            MatchActiveModeWhenBuilding,
            Always,
        }
        /* 0x2C */ public EnableGyroInBuildingFreeCamEnum EnableGyroInBuildingFreeCam;
        /* 0x30 */ public float ExocraftMultiplier;
        // size: 0x2
        public enum GyroRotationSpaceEnum : uint {
            Local,
            Player,
        }
        /* 0x34 */ public GyroRotationSpaceEnum GyroRotationSpace;
        // size: 0x2
        public enum GyroRotationSpaceHandheldEnum : uint {
            Local,
            Player,
        }
        /* 0x38 */ public GyroRotationSpaceHandheldEnum GyroRotationSpaceHandheld;
        // size: 0x2
        public enum HandednessEnum : uint {
            Left,
            Right,
        }
        /* 0x3C */ public HandednessEnum Handedness;
        // size: 0x3
        public enum LookStickEnabledEnum : uint {
            None,
            Disabled,
            Enabled,
        }
        /* 0x40 */ public LookStickEnabledEnum LookStickEnabled;
        // size: 0x3
        public enum PitchAxisDirectionEnum : uint {
            Disabled,
            Standard,
            Inverted,
        }
        /* 0x44 */ public PitchAxisDirectionEnum PitchAxisDirection;
        // size: 0x3
        public enum RollAxisDirectionEnum : uint {
            Disabled,
            Standard,
            Inverted,
        }
        /* 0x48 */ public RollAxisDirectionEnum RollAxisDirection;
        /* 0x4C */ public float ScopeMultiplier;
        /* 0x50 */ public float SensitivityX;
        /* 0x54 */ public float SensitivityY;
        /* 0x58 */ public float SmoothingThreshold;
        /* 0x5C */ public float SmoothingWindow;
        /* 0x60 */ public float Steadying;
        /* 0x64 */ public float TighteningThreshold;
        // size: 0x3
        public enum YawAxisDirectionEnum : uint {
            Disabled,
            Standard,
            Inverted,
        }
        /* 0x68 */ public YawAxisDirectionEnum YawAxisDirection;
        /* 0x6C */ public bool AllowWhenRidingCreatures;
        /* 0x6D */ public bool EnableAdvancedOptions;
        /* 0x6E */ public bool FilterControllerVibrations;
        /* 0x6F */ public bool GyroCursorEnabled;
        /* 0x70 */ public bool GyroEnabled;
        /* 0x71 */ public bool GyroEnabledHandheld;
        /* 0x72 */ public bool ZoomScalesSensitivity;
    }
}
