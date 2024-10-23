using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;
using System;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x41D46FA1C89BA1AA, NameHash = 0x6C799781)]
    public class GcUserSettingsData : NMSTemplate
    {
        [NMS(Index = 28)]
        /* 0x0000 */ public List<NMSString0x10> SeenProducts;
        [NMS(Index = 26)]
        /* 0x0010 */ public List<NMSString0x10> SeenSubstances;
        [NMS(Index = 27)]
        /* 0x0020 */ public List<NMSString0x10> SeenTechnologies;
        [NMS(Index = 29)]
        /* 0x0030 */ public List<NMSString0x20A> SeenWikiTopics;
        [NMS(Index = 35)]
        /* 0x0040 */ public List<NMSString0x10> UnlockedPlatformRewards;
        [NMS(Index = 33)]
        /* 0x0050 */ public List<NMSString0x10> UnlockedSeasonRewards;
        [NMS(Index = 32)]
        /* 0x0060 */ public List<NMSString0x10> UnlockedSpecials;
        [NMS(Index = 31)]
        /* 0x0070 */ public List<NMSString0x10> UnlockedTitles;
        [NMS(Index = 34)]
        /* 0x0080 */ public List<NMSString0x10> UnlockedTwitchRewards;
        [NMS(Index = 30)]
        /* 0x0090 */ public List<NMSString0x20A> UnlockedWikiTopics;
        [NMS(Index = 74)]
        /* 0x00A0 */ public List<NMSString0x80> UpgradedUsers;
        [NMS(Index = 16)]
        /* 0x00B0 */ public GcBlockListPersistence BlockList;
        [NMS(Index = 82)]
        /* 0x3900 */ public GcGyroSettingsData GyroSettings;
        // size: 0x3
        public enum BaseSharingModeEnum : uint {
            Undecided,
            On,
            Off,
        }
        [NMS(Index = 25)]
        /* 0x3974 */ public BaseSharingModeEnum BaseSharingMode;
        [NMS(Index = 71)]
        /* 0x3978 */ public int CamerShakeStrength;
        [NMS(Index = 13)]
        /* 0x397C */ public int CursorSensitivityMode1;
        [NMS(Index = 14)]
        /* 0x3980 */ public int CursorSensitivityMode2;
        [NMS(Index = 85)]
        /* 0x3984 */ public GcHand DominantHand;
        // size: 0x4
        [Flags]
        public enum EyeTrackingFlagsEnum : uint {
            None = 0x0,
            BaseBuilding = 0x1,
            WristMenus = 0x2,
            Menus = 0x4,
        }
        [NMS(Index = 80)]
        /* 0x3988 */ public EyeTrackingFlagsEnum EyeTrackingFlags;
        [NMS(Index = 18)]
        /* 0x398C */ public int Filter;
        [NMS(Index = 68)]
        /* 0x3990 */ public int FireteamSessionCount;
        [NMS(Index = 11)]
        /* 0x3994 */ public int FlightSensitivityMode1;
        [NMS(Index = 12)]
        /* 0x3998 */ public int FlightSensitivityMode2;
        [NMS(Index = 57)]
        /* 0x399C */ public float FrontendZoom;
        [NMS(Index = 86)]
        /* 0x39A0 */ public float HazardEffectsStrength;
        [NMS(Index = 69)]
        /* 0x39A4 */ public int HeadsetVibrationStrength;
        // size: 0x2
        public enum HighResVRUIEnum : uint {
            High,
            Low,
        }
        [NMS(Index = 89)]
        /* 0x39A8 */ public HighResVRUIEnum HighResVRUI;
        [NMS(Index = 56)]
        /* 0x39AC */ public float HUDZoom;
        [NMS(Index = 83)]
        /* 0x39B0 */ public TkLanguages Language;
        [NMS(Index = 46)]
        /* 0x39B4 */ public int LastSeenCommunityMission;
        [NMS(Index = 47)]
        /* 0x39B8 */ public int LastSeenCommunityMissionTier;
        [NMS(Index = 9)]
        /* 0x39BC */ public int LookSensitivityMode1;
        [NMS(Index = 10)]
        /* 0x39C0 */ public int LookSensitivityMode2;
        [NMS(Index = 17)]
        /* 0x39C4 */ public int MotionBlurAmount;
        [NMS(Index = 15)]
        /* 0x39C8 */ public int MouseSpringSmoothing;
        [NMS(Index = 50)]
        /* 0x39CC */ public GcMovementDirection MovementDirectionHands;
        [NMS(Index = 49)]
        /* 0x39D0 */ public GcMovementDirection MovementDirectionPad;
        // size: 0x2
        public enum MovementModeEnum : uint {
            Teleporter,
            Smooth,
        }
        [NMS(Index = 48)]
        /* 0x39D4 */ public MovementModeEnum MovementMode;
        [NMS(Index = 7)]
        /* 0x39D8 */ public int MusicVolume;
        [NMS(Index = 90)]
        /* 0x39DC */ public float PlayerHUDVROffset;
        // size: 0x3
        public enum PS4FixedFPSEnum : uint {
            Invalid,
            False,
            True,
        }
        [NMS(Index = 20)]
        /* 0x39E0 */ public PS4FixedFPSEnum PS4FixedFPS;
        [NMS(Index = 21)]
        /* 0x39E4 */ public float PS4FOVFoot;
        [NMS(Index = 22)]
        /* 0x39E8 */ public float PS4FOVShip;
        [NMS(Index = 6)]
        /* 0x39EC */ public int ScreenBrightness;
        [NMS(Index = 8)]
        /* 0x39F0 */ public int SfxVolume;
        [NMS(Index = 91)]
        /* 0x39F4 */ public float ShipHUDVROffset;
        // size: 0x3
        public enum SpaceCombatFollowModeEnum : uint {
            Disabled,
            Hold,
            Toggle,
        }
        [NMS(Index = 73)]
        /* 0x39F8 */ public SpaceCombatFollowModeEnum SpaceCombatFollowMode;
        // size: 0x4
        public enum TemperatureUnitEnum : uint {
            Invalid,
            C,
            F,
            K,
        }
        [NMS(Index = 44)]
        /* 0x39FC */ public TemperatureUnitEnum TemperatureUnit;
        [NMS(Index = 72)]
        /* 0x3A00 */ public int TriggerFeedbackStrength;
        // size: 0x2
        public enum TurnModeEnum : uint {
            Smooth,
            Snap,
        }
        [NMS(Index = 53)]
        /* 0x3A04 */ public TurnModeEnum TurnMode;
        // size: 0x4
        public enum UIColourSchemeEnum : uint {
            Default,
            Protanopia,
            Deuteranopia,
            Tritanopia,
        }
        [NMS(Index = 60)]
        /* 0x3A08 */ public UIColourSchemeEnum UIColourScheme;
        [NMS(Index = 70)]
        /* 0x3A0C */ public int VibrationStrength;
        [NMS(Index = 54)]
        /* 0x3A10 */ public float VRVignetteStrength;
        [NMS(Index = 76)]
        /* 0x3A14 */ public bool AccessibleText;
        [NMS(Index = 75)]
        /* 0x3A15 */ public bool AllowWhiteScreenTransitions;
        [NMS(Index = 84)]
        /* 0x3A16 */ public bool AutoRotateThirdPersonPlayerCamera;
        [NMS(Index = 77)]
        /* 0x3A17 */ public bool AutoScanDiscoveries;
        [NMS(Index = 52)]
        /* 0x3A18 */ public bool BaseBuildingShowOptionsFromVision;
        [NMS(Index = 66)]
        /* 0x3A19 */ public bool BaseComplexityLimitsEnabled;
        [NMS(Index = 42)]
        /* 0x3A1A */ public bool CrossPlatform;
        [NMS(Index = 43)]
        /* 0x3A1B */ public bool CrossSaves;
        [NMS(Index = 59)]
        /* 0x3A1C */ public bool CrossSavesAutoUploads;
        [NMS(Index = 19)]
        /* 0x3A1D */ public bool DamageNumbers;
        [NMS(Index = 51)]
        /* 0x3A1E */ public bool EnableControllerCursorInVR;
        [NMS(Index = 67)]
        /* 0x3A1F */ public bool EnableLargeLobbies;
        [NMS(Index = 61)]
        /* 0x3A20 */ public bool EnableModdingConsole;
        [NMS(Index = 62)]
        /* 0x3A21 */ public bool HeadBob;
        [NMS(Index = 92)]
        /* 0x3A22 */ public bool HighlightInteractableObjects;
        [NMS(Index = 4)]
        /* 0x3A23 */ public bool HUDHidden;
        [NMS(Index = 39)]
        /* 0x3A24 */ public bool InstantUIDelete;
        [NMS(Index = 38)]
        /* 0x3A25 */ public bool InstantUIInputs;
        [NMS(Index = 1)]
        /* 0x3A26 */ public bool InvertFlightControls;
        [NMS(Index = 0)]
        /* 0x3A27 */ public bool InvertLookControls;
        [NMS(Index = 2)]
        /* 0x3A28 */ public bool InvertVRInWorldFlightControls;
        [NMS(Index = 81)]
        /* 0x3A29 */ public bool MoveableWristMenus;
        [NMS(Index = 37)]
        /* 0x3A2A */ public bool Multiplayer;
        [NMS(Index = 79)]
        /* 0x3A2B */ public bool PlaceJumpSwap;
        [NMS(Index = 24)]
        /* 0x3A2C */ public bool PS4VignetteAndScanlines;
        [NMS(Index = 88)]
        /* 0x3A2D */ public bool QuickMenuBuildMenuSwap;
        [NMS(Index = 40)]
        /* 0x3A2E */ public bool SpeechToText;
        [NMS(Index = 87)]
        /* 0x3A2F */ public bool SpookHazardSkySpin;
        [NMS(Index = 78)]
        /* 0x3A30 */ public bool SprintScanSwap;
        [NMS(Index = 41)]
        /* 0x3A31 */ public bool Translate;
        [NMS(Index = 58)]
        /* 0x3A32 */ public bool UseAutoTorch;
        [NMS(Index = 65)]
        /* 0x3A33 */ public bool UseCharacterHeightForCamera;
        [NMS(Index = 45)]
        /* 0x3A34 */ public bool UseOldMouseFlight;
        [NMS(Index = 55)]
        /* 0x3A35 */ public bool UseShipAutoControlVignette;
        [NMS(Index = 5)]
        /* 0x3A36 */ public bool Vibration;
        [NMS(Index = 36)]
        /* 0x3A37 */ public bool VoiceChat;
        [NMS(Index = 94)]
        /* 0x3A38 */ public bool VRHandControllerEnableTwist;
        [NMS(Index = 93)]
        /* 0x3A39 */ public bool VRHandControllerSwapYawAndRoll;
        [NMS(Index = 63)]
        /* 0x3A3A */ public bool VRHeadBob;
        [NMS(Index = 64)]
        /* 0x3A3B */ public bool VRShowBody;
        [NMS(Index = 3)]
        /* 0x3A3C */ public bool VRVehiclesUseWorldControls;
        [NMS(Index = 23)]
        /* 0x3A3D */ public bool XboxOneXHighResolutionMode;
    }
}
