namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEE5F21EB47A392C9, NameHash = 0xE9977E68)]
    public class GcGyroSettingsData : NMSTemplate
    {
        [NMS(Index = 18)]
        /* 0x00 */ public float Acceleration;
        // size: 0x3
        public enum ActiveModeInExocraftEnum : uint {
            None,
            Firing,
            Always,
        }
        [NMS(Index = 6)]
        /* 0x04 */ public ActiveModeInExocraftEnum ActiveModeInExocraft;
        // size: 0x4
        public enum ActiveModeOnFootEnum : uint {
            None,
            ScopeOnly,
            ScopeOrFiring,
            Always,
        }
        [NMS(Index = 2)]
        /* 0x08 */ public ActiveModeOnFootEnum ActiveModeOnFoot;
        // size: 0x4
        public enum ActiveModeWhenBuildingEnum : uint {
            None,
            BuildPlacementOnly,
            SelectionModeOnly,
            Always,
        }
        [NMS(Index = 4)]
        /* 0x0C */ public ActiveModeWhenBuildingEnum ActiveModeWhenBuilding;
        [NMS(Index = 21)]
        /* 0x10 */ public float AimingMultiplier;
        [NMS(Index = 23)]
        /* 0x14 */ public float BuildingMultiplier;
        // size: 0x2
        public enum CursorLookStickEnabledEnum : uint {
            None,
            Disabled,
        }
        [NMS(Index = 13)]
        /* 0x18 */ public CursorLookStickEnabledEnum CursorLookStickEnabled;
        [NMS(Index = 10)]
        /* 0x1C */ public float CursorSensitivityX;
        [NMS(Index = 11)]
        /* 0x20 */ public float CursorSensitivityY;
        [NMS(Index = 12)]
        /* 0x24 */ public float CursorTighteningThreshold;
        [NMS(Index = 33)]
        /* 0x28 */ public float Deadzone;
        // size: 0x3
        public enum EnableGyroInBuildingFreeCamEnum : uint {
            Never,
            MatchActiveModeWhenBuilding,
            Always,
        }
        [NMS(Index = 5)]
        /* 0x2C */ public EnableGyroInBuildingFreeCamEnum EnableGyroInBuildingFreeCam;
        [NMS(Index = 22)]
        /* 0x30 */ public float ExocraftMultiplier;
        // size: 0x3
        public enum GyroLookTouchEnabledEnum : uint {
            None,
            Disabled,
            Enabled,
        }
        [NMS(Index = 8)]
        /* 0x34 */ public GyroLookTouchEnabledEnum GyroLookTouchEnabled;
        // size: 0x2
        public enum GyroRotationSpaceEnum : uint {
            Local,
            Player,
        }
        [NMS(Index = 25)]
        /* 0x38 */ public GyroRotationSpaceEnum GyroRotationSpace;
        // size: 0x2
        public enum GyroRotationSpaceHandheldEnum : uint {
            Local,
            Player,
        }
        [NMS(Index = 26)]
        /* 0x3C */ public GyroRotationSpaceHandheldEnum GyroRotationSpaceHandheld;
        // size: 0x2
        public enum HandednessEnum : uint {
            Left,
            Right,
        }
        [NMS(Index = 14)]
        /* 0x40 */ public HandednessEnum Handedness;
        // size: 0x3
        public enum LookStickEnabledEnum : uint {
            None,
            Disabled,
            Enabled,
        }
        [NMS(Index = 7)]
        /* 0x44 */ public LookStickEnabledEnum LookStickEnabled;
        // size: 0x3
        public enum PitchAxisDirectionEnum : uint {
            Disabled,
            Standard,
            Inverted,
        }
        [NMS(Index = 29)]
        /* 0x48 */ public PitchAxisDirectionEnum PitchAxisDirection;
        // size: 0x3
        public enum RollAxisDirectionEnum : uint {
            Disabled,
            Standard,
            Inverted,
        }
        [NMS(Index = 28)]
        /* 0x4C */ public RollAxisDirectionEnum RollAxisDirection;
        [NMS(Index = 20)]
        /* 0x50 */ public float ScopeMultiplier;
        [NMS(Index = 15)]
        /* 0x54 */ public float SensitivityX;
        [NMS(Index = 16)]
        /* 0x58 */ public float SensitivityY;
        [NMS(Index = 30)]
        /* 0x5C */ public float SmoothingThreshold;
        [NMS(Index = 31)]
        /* 0x60 */ public float SmoothingWindow;
        [NMS(Index = 17)]
        /* 0x64 */ public float Steadying;
        [NMS(Index = 32)]
        /* 0x68 */ public float TighteningThreshold;
        // size: 0x3
        public enum YawAxisDirectionEnum : uint {
            Disabled,
            Standard,
            Inverted,
        }
        [NMS(Index = 27)]
        /* 0x6C */ public YawAxisDirectionEnum YawAxisDirection;
        [NMS(Index = 3)]
        /* 0x70 */ public bool AllowWhenRidingCreatures;
        [NMS(Index = 19)]
        /* 0x71 */ public bool EnableAdvancedOptions;
        [NMS(Index = 34)]
        /* 0x72 */ public bool FilterControllerVibrations;
        [NMS(Index = 9)]
        /* 0x73 */ public bool GyroCursorEnabled;
        [NMS(Index = 0)]
        /* 0x74 */ public bool GyroEnabled;
        [NMS(Index = 1)]
        /* 0x75 */ public bool GyroEnabledHandheld;
        [NMS(Index = 24)]
        /* 0x76 */ public bool ZoomScalesSensitivity;
    }
}
