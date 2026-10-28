using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;
using System;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEDA4EB3572CFDC05, NameHash = 0x6C799781)]
    public class GcUserSettingsData : NMSTemplate
    {
        [NMS(Index = 113)]
        /* 0x0000 */ public List<GcInputActionMapping2> CustomBindingsMac;
        [NMS(Index = 112)]
        /* 0x0010 */ public List<GcInputActionMapping2> CustomBindingsPC;
        [NMS(Index = 115)]
        /* 0x0020 */ public List<GcInputActionMapping2> CustomBindingsPlaystation;
        [NMS(Index = 116)]
        /* 0x0030 */ public List<GcInputActionMapping2> CustomBindingsSwitch;
        [NMS(Index = 114)]
        /* 0x0040 */ public List<GcInputActionMapping2> CustomBindingsXbox;
        [NMS(Index = 34)]
        /* 0x0050 */ public List<NMSString0x10> SeenProducts;
        [NMS(Index = 32)]
        /* 0x0060 */ public List<NMSString0x10> SeenSubstances;
        [NMS(Index = 33)]
        /* 0x0070 */ public List<NMSString0x10> SeenTechnologies;
        [NMS(Index = 35)]
        /* 0x0080 */ public List<NMSString0x20A> SeenWikiTopics;
        [NMS(Index = 41)]
        /* 0x0090 */ public List<NMSString0x10> UnlockedPlatformRewards;
        [NMS(Index = 39)]
        /* 0x00A0 */ public List<NMSString0x10> UnlockedSeasonRewards;
        [NMS(Index = 38)]
        /* 0x00B0 */ public List<NMSString0x10> UnlockedSpecials;
        [NMS(Index = 37)]
        /* 0x00C0 */ public List<NMSString0x10> UnlockedTitles;
        [NMS(Index = 40)]
        /* 0x00D0 */ public List<NMSString0x10> UnlockedTwitchRewards;
        [NMS(Index = 36)]
        /* 0x00E0 */ public List<NMSString0x20A> UnlockedWikiTopics;
        [NMS(Index = 89)]
        /* 0x00F0 */ public List<NMSString0x80> UpgradedUsers;
        [NMS(Index = 20)]
        /* 0x0100 */ public GcBlockListPersistence BlockList;
        [NMS(Index = 98)]
        /* 0x6C20 */ public GcGyroSettingsData GyroSettings;
        // size: 0x3
        public enum BaseSharingModeEnum : uint {
            Undecided,
            On,
            Off,
        }
        [NMS(Index = 31)]
        /* 0x6C98 */ public BaseSharingModeEnum BaseSharingMode;
        [NMS(Index = 86)]
        /* 0x6C9C */ public int CamerShakeStrength;
        // size: 0x2
        public enum ConsoleHFREnum : uint {
            False,
            True,
        }
        [NMS(Index = 30)]
        /* 0x6CA0 */ public ConsoleHFREnum ConsoleHFR;
        [NMS(Index = 69)]
        /* 0x6CA4 */ public float CrossSavesUploadTimeout;
        [NMS(Index = 17)]
        /* 0x6CA8 */ public int CursorSensitivityMode1;
        [NMS(Index = 18)]
        /* 0x6CAC */ public int CursorSensitivityMode2;
        [NMS(Index = 101)]
        /* 0x6CB0 */ public GcHand DominantHand;
        // size: 0x4
        [Flags]
        public enum EyeTrackingFlagsEnum : uint {
            None = 0x0,
            BaseBuilding = 0x1,
            WristMenus = 0x2,
            Menus = 0x4,
        }
        [NMS(Index = 96)]
        /* 0x6CB4 */ public EyeTrackingFlagsEnum EyeTrackingFlags;
        [NMS(Index = 22)]
        /* 0x6CB8 */ public int Filter;
        [NMS(Index = 82)]
        /* 0x6CBC */ public int FireteamSessionCount;
        [NMS(Index = 15)]
        /* 0x6CC0 */ public int FlightSensitivityMode1;
        [NMS(Index = 16)]
        /* 0x6CC4 */ public int FlightSensitivityMode2;
        [NMS(Index = 66)]
        /* 0x6CC8 */ public float FrontendZoom;
        [NMS(Index = 102)]
        /* 0x6CCC */ public float HazardEffectsStrength;
        [NMS(Index = 83)]
        /* 0x6CD0 */ public int HeadsetVibrationStrength;
        // size: 0x2
        public enum HighResVRUIEnum : uint {
            High,
            Low,
        }
        [NMS(Index = 106)]
        /* 0x6CD4 */ public HighResVRUIEnum HighResVRUI;
        [NMS(Index = 65)]
        /* 0x6CD8 */ public float HUDZoom;
        [NMS(Index = 99)]
        /* 0x6CDC */ public TkLanguages Language;
        [NMS(Index = 55)]
        /* 0x6CE0 */ public int LastSeenCommunityMission;
        [NMS(Index = 56)]
        /* 0x6CE4 */ public int LastSeenCommunityMissionTier;
        // size: 0x3
        public enum LeftStickVisibilityIOSEnum : uint {
            OnTouch,
            Hidden,
            AlwaysVisible,
        }
        [NMS(Index = 53)]
        /* 0x6CE8 */ public LeftStickVisibilityIOSEnum LeftStickVisibilityIOS;
        [NMS(Index = 13)]
        /* 0x6CEC */ public int LookSensitivityMode1;
        [NMS(Index = 14)]
        /* 0x6CF0 */ public int LookSensitivityMode2;
        [NMS(Index = 21)]
        /* 0x6CF4 */ public int MotionBlurAmount;
        [NMS(Index = 19)]
        /* 0x6CF8 */ public int MouseSpringSmoothing;
        [NMS(Index = 59)]
        /* 0x6CFC */ public GcMovementDirection MovementDirectionHands;
        [NMS(Index = 58)]
        /* 0x6D00 */ public GcMovementDirection MovementDirectionPad;
        // size: 0x2
        public enum MovementModeEnum : uint {
            Teleporter,
            Smooth,
        }
        [NMS(Index = 57)]
        /* 0x6D04 */ public MovementModeEnum MovementMode;
        [NMS(Index = 8)]
        /* 0x6D08 */ public int MusicVolume;
        [NMS(Index = 107)]
        /* 0x6D0C */ public float PlayerHUDVROffset;
        // size: 0x4
        public enum PlayerVoiceEnum : uint {
            Off,
            High,
            Low,
            Alien,
        }
        [NMS(Index = 12)]
        /* 0x6D10 */ public PlayerVoiceEnum PlayerVoice;
        // size: 0x4
        public enum PS4FixedFPSEnum : uint {
            Invalid,
            True,
            False,
            MaxPerformance,
        }
        [NMS(Index = 24)]
        /* 0x6D14 */ public PS4FixedFPSEnum PS4FixedFPS;
        [NMS(Index = 25)]
        /* 0x6D18 */ public float PS4FOVFoot;
        [NMS(Index = 26)]
        /* 0x6D1C */ public float PS4FOVShip;
        [NMS(Index = 7)]
        /* 0x6D20 */ public int ScreenBrightness;
        [NMS(Index = 9)]
        /* 0x6D24 */ public int SfxVolume;
        // size: 0x2
        public enum ShipControlsModeIOSEnum : uint {
            Swiping,
            StickSwipe,
        }
        [NMS(Index = 52)]
        /* 0x6D28 */ public ShipControlsModeIOSEnum ShipControlsModeIOS;
        [NMS(Index = 108)]
        /* 0x6D2C */ public float ShipHUDVROffset;
        // size: 0x3
        public enum SpaceCombatFollowModeEnum : uint {
            Disabled,
            Hold,
            Toggle,
        }
        [NMS(Index = 88)]
        /* 0x6D30 */ public SpaceCombatFollowModeEnum SpaceCombatFollowMode;
        // size: 0x3
        public enum SuitVoiceEnum : uint {
            Off,
            High,
            Low,
        }
        [NMS(Index = 11)]
        /* 0x6D34 */ public SuitVoiceEnum SuitVoice;
        // size: 0x4
        public enum TemperatureUnitEnum : uint {
            Invalid,
            C,
            F,
            K,
        }
        [NMS(Index = 50)]
        /* 0x6D38 */ public TemperatureUnitEnum TemperatureUnit;
        [NMS(Index = 87)]
        /* 0x6D3C */ public int TriggerFeedbackStrength;
        // size: 0x2
        public enum TurnModeEnum : uint {
            Smooth,
            Snap,
        }
        [NMS(Index = 62)]
        /* 0x6D40 */ public TurnModeEnum TurnMode;
        // size: 0x4
        public enum UIColourSchemeEnum : uint {
            Default,
            Protanopia,
            Deuteranopia,
            Tritanopia,
        }
        [NMS(Index = 71)]
        /* 0x6D44 */ public UIColourSchemeEnum UIColourScheme;
        [NMS(Index = 103)]
        /* 0x6D48 */ public float UnderwaterDepthOfFieldStrength;
        [NMS(Index = 84)]
        /* 0x6D4C */ public int VibrationStrength;
        [NMS(Index = 10)]
        /* 0x6D50 */ public int VoiceVolume;
        [NMS(Index = 63)]
        /* 0x6D54 */ public float VRVignetteStrength;
        [NMS(Index = 91)]
        /* 0x6D58 */ public bool AccessibleText;
        [NMS(Index = 90)]
        /* 0x6D59 */ public bool AllowWhiteScreenTransitions;
        [NMS(Index = 100)]
        /* 0x6D5A */ public bool AutoRotateThirdPersonPlayerCamera;
        [NMS(Index = 92)]
        /* 0x6D5B */ public bool AutoScanDiscoveries;
        [NMS(Index = 61)]
        /* 0x6D5C */ public bool BaseBuildingShowOptionsFromVision;
        [NMS(Index = 80)]
        /* 0x6D5D */ public bool BaseComplexityLimitsEnabled;
        [NMS(Index = 48)]
        /* 0x6D5E */ public bool CrossPlatform;
        [NMS(Index = 49)]
        /* 0x6D5F */ public bool CrossSaves;
        [NMS(Index = 68)]
        /* 0x6D60 */ public bool CrossSavesAutoUploads;
        [NMS(Index = 70)]
        /* 0x6D61 */ public bool CrossSavesSuppressAutoUploadTimeoutPopup;
        [NMS(Index = 23)]
        /* 0x6D62 */ public bool DamageNumbers;
        [NMS(Index = 60)]
        /* 0x6D63 */ public bool EnableControllerCursorInVR;
        [NMS(Index = 81)]
        /* 0x6D64 */ public bool EnableLargeLobbies;
        [NMS(Index = 72)]
        /* 0x6D65 */ public bool EnableModdingConsole;
        [NMS(Index = 73)]
        /* 0x6D66 */ public bool HeadBob;
        [NMS(Index = 109)]
        /* 0x6D67 */ public bool HighlightInteractableObjects;
        [NMS(Index = 4)]
        /* 0x6D68 */ public bool HUDHidden;
        [NMS(Index = 5)]
        /* 0x6D69 */ public bool HUDMinimal;
        [NMS(Index = 95)]
        /* 0x6D6A */ public bool IncreaseMissionTextContrast;
        [NMS(Index = 45)]
        /* 0x6D6B */ public bool InstantUIDelete;
        [NMS(Index = 44)]
        /* 0x6D6C */ public bool InstantUIInputs;
        [NMS(Index = 1)]
        /* 0x6D6D */ public bool InvertFlightControls;
        [NMS(Index = 0)]
        /* 0x6D6E */ public bool InvertLookControls;
        [NMS(Index = 2)]
        /* 0x6D6F */ public bool InvertVRInWorldFlightControls;
        [NMS(Index = 54)]
        /* 0x6D70 */ public bool LeftStickFollowsTouchIOS;
        [NMS(Index = 85)]
        /* 0x6D71 */ public bool MenuHaptics;
        [NMS(Index = 97)]
        /* 0x6D72 */ public bool MoveableWristMenus;
        [NMS(Index = 43)]
        /* 0x6D73 */ public bool Multiplayer;
        [NMS(Index = 94)]
        /* 0x6D74 */ public bool PlaceJumpSwap;
        [NMS(Index = 29)]
        /* 0x6D75 */ public bool PS4VignetteAndScanlines;
        [NMS(Index = 28)]
        /* 0x6D76 */ public bool PS5ProVRPSSR;
        [NMS(Index = 105)]
        /* 0x6D77 */ public bool QuickMenuBuildMenuSwap;
        [NMS(Index = 46)]
        /* 0x6D78 */ public bool SpeechToText;
        [NMS(Index = 104)]
        /* 0x6D79 */ public bool SpookHazardSkySpin;
        [NMS(Index = 93)]
        /* 0x6D7A */ public bool SprintScanSwap;
        [NMS(Index = 47)]
        /* 0x6D7B */ public bool Translate;
        [NMS(Index = 67)]
        /* 0x6D7C */ public bool UseAutoTorch;
        [NMS(Index = 79)]
        /* 0x6D7D */ public bool UseCharacterHeightForCamera;
        [NMS(Index = 51)]
        /* 0x6D7E */ public bool UseOldMouseFlight;
        [NMS(Index = 64)]
        /* 0x6D7F */ public bool UseShipAutoControlVignette;
        [NMS(Index = 6)]
        /* 0x6D80 */ public bool Vibration;
        [NMS(Index = 42)]
        /* 0x6D81 */ public bool VoiceChat;
        [NMS(Index = 78)]
        /* 0x6D82 */ public bool VREyeAiming;
        [NMS(Index = 111)]
        /* 0x6D83 */ public bool VRHandControllerEnableTwist;
        [NMS(Index = 110)]
        /* 0x6D84 */ public bool VRHandControllerSwapYawAndRoll;
        [NMS(Index = 74)]
        /* 0x6D85 */ public bool VRHeadBob;
        [NMS(Index = 77)]
        /* 0x6D86 */ public bool VRHelmetCompassLock;
        [NMS(Index = 76)]
        /* 0x6D87 */ public bool VRHelmetHUDLock;
        [NMS(Index = 75)]
        /* 0x6D88 */ public bool VRShowBody;
        [NMS(Index = 3)]
        /* 0x6D89 */ public bool VRVehiclesUseWorldControls;
        [NMS(Index = 27)]
        /* 0x6D8A */ public bool XboxOneXHighResolutionMode;
    }
}
