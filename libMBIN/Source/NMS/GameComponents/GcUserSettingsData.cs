using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;
using System;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3DF85DC4FC201AF5, NameHash = 0x3A50D683FD1CF4BF)]
    public class GcUserSettingsData : NMSTemplate
    {
        /* 0x0000 */ public List<NMSString0x10> SeenProducts;
        /* 0x0010 */ public List<NMSString0x10> SeenSubstances;
        /* 0x0020 */ public List<NMSString0x10> SeenTechnologies;
        /* 0x0030 */ public List<NMSString0x20A> SeenWikiTopics;
        /* 0x0040 */ public List<NMSString0x10> UnlockedPlatformRewards;
        /* 0x0050 */ public List<NMSString0x10> UnlockedSeasonRewards;
        /* 0x0060 */ public List<NMSString0x10> UnlockedSpecials;
        /* 0x0070 */ public List<NMSString0x10> UnlockedTitles;
        /* 0x0080 */ public List<NMSString0x10> UnlockedTwitchRewards;
        /* 0x0090 */ public List<NMSString0x20A> UnlockedWikiTopics;
        /* 0x00A0 */ public List<NMSString0x80> UpgradedUsers;
        /* 0x00B0 */ public GcBlockListPersistence BlockList;
        /* 0x3900 */ public GcGyroSettingsData GyroSettings;
        // size: 0x3
        public enum BaseSharingModeEnum : uint {
            Undecided,
            On,
            Off,
        }
        /* 0x3974 */ public BaseSharingModeEnum BaseSharingMode;
        /* 0x3978 */ public int CamerShakeStrength;
        /* 0x397C */ public int CursorSensitivityMode1;
        /* 0x3980 */ public int CursorSensitivityMode2;
        /* 0x3984 */ public GcHand DominantHand;
        // size: 0x4
        [Flags]
        public enum EyeTrackingFlagsEnum : uint {
            None = 0x0,
            BaseBuilding = 0x1,
            WristMenus = 0x2,
            Menus = 0x4,
        }
        /* 0x3988 */ public EyeTrackingFlagsEnum EyeTrackingFlags;
        /* 0x398C */ public int Filter;
        /* 0x3990 */ public int FireteamSessionCount;
        /* 0x3994 */ public int FlightSensitivityMode1;
        /* 0x3998 */ public int FlightSensitivityMode2;
        /* 0x399C */ public float FrontendZoom;
        /* 0x39A0 */ public float HazardEffectsStrength;
        /* 0x39A4 */ public int HeadsetVibrationStrength;
        // size: 0x2
        public enum HighResVRUIEnum : uint {
            High,
            Low,
        }
        /* 0x39A8 */ public HighResVRUIEnum HighResVRUI;
        /* 0x39AC */ public float HUDZoom;
        /* 0x39B0 */ public TkLanguages Language;
        /* 0x39B4 */ public int LastSeenCommunityMission;
        /* 0x39B8 */ public int LastSeenCommunityMissionTier;
        /* 0x39BC */ public int LookSensitivityMode1;
        /* 0x39C0 */ public int LookSensitivityMode2;
        /* 0x39C4 */ public int MotionBlurAmount;
        /* 0x39C8 */ public int MouseSpringSmoothing;
        /* 0x39CC */ public GcMovementDirection MovementDirectionHands;
        /* 0x39D0 */ public GcMovementDirection MovementDirectionPad;
        // size: 0x2
        public enum MovementModeEnum : uint {
            Teleporter,
            Smooth,
        }
        /* 0x39D4 */ public MovementModeEnum MovementMode;
        /* 0x39D8 */ public int MusicVolume;
        /* 0x39DC */ public float PlayerHUDVROffset;
        // size: 0x3
        public enum PS4FixedFPSEnum : uint {
            Invalid,
            False,
            True,
        }
        /* 0x39E0 */ public PS4FixedFPSEnum PS4FixedFPS;
        /* 0x39E4 */ public float PS4FOVFoot;
        /* 0x39E8 */ public float PS4FOVShip;
        /* 0x39EC */ public int ScreenBrightness;
        /* 0x39F0 */ public int SfxVolume;
        /* 0x39F4 */ public float ShipHUDVROffset;
        // size: 0x3
        public enum SpaceCombatFollowModeEnum : uint {
            Disabled,
            Hold,
            Toggle,
        }
        /* 0x39F8 */ public SpaceCombatFollowModeEnum SpaceCombatFollowMode;
        // size: 0x4
        public enum TemperatureUnitEnum : uint {
            Invalid,
            C,
            F,
            K,
        }
        /* 0x39FC */ public TemperatureUnitEnum TemperatureUnit;
        /* 0x3A00 */ public int TriggerFeedbackStrength;
        // size: 0x2
        public enum TurnModeEnum : uint {
            Smooth,
            Snap,
        }
        /* 0x3A04 */ public TurnModeEnum TurnMode;
        // size: 0x4
        public enum UIColourSchemeEnum : uint {
            Default,
            Protanopia,
            Deuteranopia,
            Tritanopia,
        }
        /* 0x3A08 */ public UIColourSchemeEnum UIColourScheme;
        /* 0x3A0C */ public int VibrationStrength;
        /* 0x3A10 */ public float VRVignetteStrength;
        /* 0x3A14 */ public bool AccessibleText;
        /* 0x3A15 */ public bool AllowWhiteScreenTransitions;
        /* 0x3A16 */ public bool AutoRotateThirdPersonPlayerCamera;
        /* 0x3A17 */ public bool AutoScanDiscoveries;
        /* 0x3A18 */ public bool BaseBuildingShowOptionsFromVision;
        /* 0x3A19 */ public bool BaseComplexityLimitsEnabled;
        /* 0x3A1A */ public bool CrossPlatform;
        /* 0x3A1B */ public bool DamageNumbers;
        /* 0x3A1C */ public bool EnableControllerCursorInVR;
        /* 0x3A1D */ public bool EnableLargeLobbies;
        /* 0x3A1E */ public bool EnableModdingConsole;
        /* 0x3A1F */ public bool HeadBob;
        /* 0x3A20 */ public bool HighlightInteractableObjects;
        /* 0x3A21 */ public bool HUDHidden;
        /* 0x3A22 */ public bool InstantUIDelete;
        /* 0x3A23 */ public bool InstantUIInputs;
        /* 0x3A24 */ public bool InvertFlightControls;
        /* 0x3A25 */ public bool InvertLookControls;
        /* 0x3A26 */ public bool InvertVRInWorldFlightControls;
        /* 0x3A27 */ public bool MoveableWristMenus;
        /* 0x3A28 */ public bool Multiplayer;
        /* 0x3A29 */ public bool PlaceJumpSwap;
        /* 0x3A2A */ public bool PS4VignetteAndScanlines;
        /* 0x3A2B */ public bool QuickMenuBuildMenuSwap;
        /* 0x3A2C */ public bool SpeechToText;
        /* 0x3A2D */ public bool SprintScanSwap;
        /* 0x3A2E */ public bool Translate;
        /* 0x3A2F */ public bool UseAutoTorch;
        /* 0x3A30 */ public bool UseCharacterHeightForCamera;
        /* 0x3A31 */ public bool UseOldMouseFlight;
        /* 0x3A32 */ public bool UseShipAutoControlVignette;
        /* 0x3A33 */ public bool Vibration;
        /* 0x3A34 */ public bool VoiceChat;
        /* 0x3A35 */ public bool VRHandControllerEnableTwist;
        /* 0x3A36 */ public bool VRHandControllerSwapYawAndRoll;
        /* 0x3A37 */ public bool VRHeadBob;
        /* 0x3A38 */ public bool VRShowBody;
        /* 0x3A39 */ public bool VRVehiclesUseWorldControls;
        /* 0x3A3A */ public bool XboxOneXHighResolutionMode;
    }
}
