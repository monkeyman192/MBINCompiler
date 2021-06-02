using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x3960, GUID = 0x4EF81A05468A9B00, NameHash = 0x3A50D683FD1CF4BF)]
    public class GcUserSettingsData : NMSTemplate
    {
        /* 0x0000 */ public bool InvertLookControls;
        /* 0x0001 */ public bool InvertFlightControls;
        /* 0x0002 */ public bool HUDHidden;
        /* 0x0003 */ public bool Vibration;
        /* 0x0004 */ public int ScreenBrightness;
        /* 0x0008 */ public int MusicVolume;
        /* 0x000C */ public int SfxVolume;
        /* 0x0010 */ public int LookSensitivityV2;
        /* 0x0014 */ public int FlightSensitivityV2;
        /* 0x0018 */ public int MouseSpringSmoothing;
        /* 0x001C */ public GcBlockListPersistence BlockList;
        /* 0x386C */ public int MotionBlurAmount;
        /* 0x3870 */ public int Filter;
        /* 0x3874 */ public bool DamageNumbers;
        public enum PS4FixedFPSEnum { Invalid, False, True}
        /* 0x3878 */ public PS4FixedFPSEnum PS4FixedFPS;
        /* 0x387C */ public float PS4FOVFoot;
        /* 0x3880 */ public float PS4FOVShip;
        /* 0x3884 */ public bool XboxOneXHighResolutionMode;
        /* 0x3885 */ public bool PS4VignetteAndScanlines;
        public enum BaseSharingModeEnum { Undecided, On, Off }
        /* 0x3888 */ public BaseSharingModeEnum BaseSharingMode;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x388C */ public byte[] Padding388C;
        /* 0x3890 */ public List<NMSString0x10> SeenSubstances;
        /* 0x38A0 */ public List<NMSString0x10> SeenTechnologies;
        /* 0x38B0 */ public List<NMSString0x10> SeenProducts;
        /* 0x38C0 */ public List<NMSString0x20A> SeenWikiTopics;
        /* 0x38D0 */ public List<NMSString0x20A> UnlockedWikiTopics;
        /* 0x38E0 */ public List<NMSString0x10> UnlockedTitles;
        /* 0x38F0 */ public List<NMSString0x10> UnlockedSeasonRewards;
        /* 0x3900 */ public List<NMSString0x10> UnlockedTwitchRewards;
        /* 0x3910 */ public bool VoiceChat;
        /* 0x3911 */ public bool Multiplayer;
        /* 0x3912 */ public bool InstantUIInputs;
        /* 0x3913 */ public bool SpeechToText;
        /* 0x3914 */ public bool Translate;
        /* 0x3915 */ public bool CrossPlatform;
        public enum TemperatureUnitEnum { Invalid, C, F, K }
        /* 0x3918 */ public TemperatureUnitEnum TemperatureUnit;
        /* 0x391C */ public bool UseOldMouseFlight;
        /* 0x3920 */ public int LastSeenCommunityMission;
        /* 0x3924 */ public int LastSeenCommunityMissionTier;
        public enum MovementModeEnum { Teleporter, Smooth }
        /* 0x3928 */ public MovementModeEnum MovementMode;
        /* 0x392C */ public GcMovementDirection MovementDirectionPad;
        /* 0x3930 */ public GcMovementDirection MovementDirectionHands;
        public enum TurnModeEnum { Smooth, Snap }
        /* 0x3934 */ public TurnModeEnum TurnMode;
        /* 0x3938 */ public bool UseVrVignette;
        /* 0x3939 */ public bool UseShipAutoControlVignette;
        /* 0x393C */ public float HUDZoom;
        /* 0x3940 */ public float FrontendZoom;
        /* 0x3944 */ public bool UseAutoTorch;
        public enum UIColourSchemeEnum { Default, Protanopia, Deuteranopia, Tritanopia }
        /* 0x3948 */ public UIColourSchemeEnum UIColourScheme;
        /* 0x394C */ public bool VRHeadBob;
        /* 0x394D */ public bool VRShowBody;
        /* 0x394E */ public bool BaseComplexityLimitsEnabled;
        /* 0x394F */ public bool EnableLargeLobbies;
        /* 0x3950 */ public int FireteamSessionCount;
        /* 0x3954 */ public int VibrationStrength;
        /* 0x3958 */ public int TriggerFeedbackStrength;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x395C */ public byte[] EndPadding;
    }
}
