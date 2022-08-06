using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA32D947E48CC5752, NameHash = 0x3A50D683FD1CF4BF)]
    public class GcUserSettingsData : NMSTemplate
    {
        /* 0x0000 */ public bool InvertLookControls;
        /* 0x0001 */ public bool InvertFlightControls;
        /* 0x0002 */ public bool InvertVRInWorldFlightControls;
        /* 0x0003 */ public bool HUDHidden;
        /* 0x0004 */ public bool Vibration;
        /* 0x0008 */ public int ScreenBrightness;
        /* 0x000C */ public int MusicVolume;
        /* 0x0010 */ public int SfxVolume;
        /* 0x0014 */ public int LookSensitivityMode1;
        /* 0x0018 */ public int LookSensitivityMode2;
        /* 0x001C */ public int FlightSensitivityMode1;
        /* 0x0020 */ public int FlightSensitivityMode2;
        /* 0x0024 */ public int CursorSensitivityMode1;
        /* 0x0028 */ public int CursorSensitivityMode2;
        /* 0x002C */ public int MouseSpringSmoothing;
        /* 0x0020 */ public GcBlockListPersistence BlockList;
        /* 0x3870 */ public int MotionBlurAmount;
        /* 0x3874 */ public int Filter;
        /* 0x3878 */ public bool DamageNumbers;
        // size: 0x3
        public enum PS4FixedFPSEnum { Invalid, False, True }
        /* 0x387C */ public PS4FixedFPSEnum PS4FixedFPS;
        /* 0x3880 */ public float PS4FOVFoot;
        /* 0x3884 */ public float PS4FOVShip;
        /* 0x3888 */ public bool XboxOneXHighResolutionMode;
        /* 0x3889 */ public bool PS4VignetteAndScanlines;
        // size: 0x3
        public enum BaseSharingModeEnum { Undecided, On, Off }
        /* 0x388C */ public BaseSharingModeEnum BaseSharingMode;
        /* 0x3890 */ public List<NMSString0x10> SeenSubstances;
        /* 0x38A0 */ public List<NMSString0x10> SeenTechnologies;
        /* 0x38B0 */ public List<NMSString0x10> SeenProducts;
        /* 0x38C0 */ public List<NMSString0x20A> SeenWikiTopics;
        /* 0x38D0 */ public List<NMSString0x20A> UnlockedWikiTopics;
        /* 0x38E0 */ public List<NMSString0x10> UnlockedTitles;
        /* 0x38F0 */ public List<NMSString0x10> UnlockedSpecials;
        /* 0x3900 */ public List<NMSString0x10> UnlockedSeasonRewards;
        /* 0x3910 */ public List<NMSString0x10> UnlockedTwitchRewards;
        /* 0x3920 */ public bool VoiceChat;
        /* 0x3921 */ public bool Multiplayer;
        /* 0x3922 */ public bool InstantUIInputs;
        /* 0x3923 */ public bool SpeechToText;
        /* 0x3924 */ public bool Translate;
        /* 0x3925 */ public bool CrossPlatform;
        // size: 0x4
        public enum TemperatureUnitEnum { Invalid, C, F, K }
        /* 0x3928 */ public TemperatureUnitEnum TemperatureUnit;
        /* 0x392C */ public bool UseOldMouseFlight;
        /* 0x3930 */ public int LastSeenCommunityMission;
        /* 0x3934 */ public int LastSeenCommunityMissionTier;
        // size: 0x2
        public enum MovementModeEnum { Teleporter, Smooth }
        /* 0x3938 */ public MovementModeEnum MovementMode;
        /* 0x393C */ public GcMovementDirection MovementDirectionPad;
        /* 0x3940 */ public GcMovementDirection MovementDirectionHands;
        // size: 0x2
        public enum TurnModeEnum { Smooth, Snap }
        /* 0x3944 */ public TurnModeEnum TurnMode;
        /* 0x3948 */ public bool UseVrVignette;
        /* 0x3949 */ public bool UseShipAutoControlVignette;
        /* 0x394C */ public float HUDZoom;
        /* 0x3950 */ public float FrontendZoom;
        /* 0x3954 */ public bool UseAutoTorch;
        // size: 0x4
        public enum UIColourSchemeEnum { Default, Protanopia, Deuteranopia, Tritanopia }
        /* 0x3958 */ public UIColourSchemeEnum UIColourScheme;
        /* 0x395C */ public bool EnableModdingConsole;
        /* 0x395D */ public bool VRHeadBob;
        /* 0x395E */ public bool VRShowBody;
        /* 0x395F */ public bool UseCharacterHeightForCamera;
        /* 0x3960 */ public bool BaseComplexityLimitsEnabled;
        /* 0x3961 */ public bool EnableLargeLobbies;
        /* 0x3964 */ public int FireteamSessionCount;
        /* 0x3968 */ public int VibrationStrength;
        /* 0x396C */ public int CamerShakeStrength;
        /* 0x3970 */ public int TriggerFeedbackStrength;
        // size: 0x3
        public enum SpaceCombatFollowModeEnum { Disabled, Hold, Toggle }
        /* 0x3974 */ public SpaceCombatFollowModeEnum SpaceCombatFollowMode;
        /* 0x3978 */ public List<NMSString0x80> UpgradedUsers;
        /* 0x3998 */ public bool AllowWhiteScreenTransitions;
    }
}
