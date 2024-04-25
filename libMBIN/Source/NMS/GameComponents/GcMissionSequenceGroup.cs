using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBEA5909A9D17C463, NameHash = 0x51B3554FFBEBED66)]
    public class GcMissionSequenceGroup : NMSTemplate
    {
        [NMS(Index = 13)]
        /* 0x000 */ public Colour ColourOverride;
        [NMS(Index = 28)]
        /* 0x010 */ public GcTargetMissionSurveyOptions SurveyTarget;
        [NMS(Index = 27)]
        /* 0x228 */ public GcSeasonalObjectiveOverrides SeasonalObjectiveOverrides;
        [NMS(Index = 26)]
        /* 0x278 */ public GcObjectiveTextFormatOptions ObjectiveFormatting;
        [NMS(Index = 8)]
        /* 0x2C0 */ public NMSString0x20A ObjectiveID;
        [NMS(Index = 9)]
        /* 0x2E0 */ public NMSString0x20A ObjectiveTipID;
        [NMS(Index = 3)]
        /* 0x300 */ public NMSString0x20A PageDataLocID;
        [NMS(Index = 15)]
        /* 0x320 */ public NMSString0x20A PrefixTitleText;
        [NMS(Index = 4)]
        /* 0x340 */ public NMSString0x10 BuildMenuHint;
        [NMS(Index = 30)]
        /* 0x350 */ public List<NMSTemplate> Conditions;
        [NMS(Index = 31)]
        /* 0x360 */ public List<NMSTemplate> Consequences;
        [NMS(Index = 5)]
        /* 0x370 */ public NMSString0x10 InventoryHint;
        [NMS(Index = 32)]
        /* 0x380 */ public List<GcGenericMissionStage> Stages;
        [NMS(Index = 6)]
        /* 0x390 */ public NMSString0x10 TerrainTarget;
        [NMS(Index = 1)]
        /* 0x3A0 */ public TkTextureResource Icon;
        [NMS(Index = 29)]
        /* 0x424 */ public GcCustomNotifyTimerOptions CustomNotifyTimers;
        [NMS(Index = 19)]
        /* 0x430 */ public GcMissionConditionTest ConditionTest;
        // size: 0x3
        public enum GalMapPathOverrideEnum : uint {
            None,
            BlackHole,
            Atlas,
        }
        [NMS(Index = 24)]
        /* 0x434 */ public GalMapPathOverrideEnum GalMapPathOverride;
        // size: 0x4
        public enum IconStyleEnum : uint {
            Default,
            Large,
            Square,
            NoFrame,
        }
        [NMS(Index = 23)]
        /* 0x438 */ public IconStyleEnum IconStyle;
        [NMS(Index = 11)]
        /* 0x43C */ public GcMissionCategory OverrideCategory;
        [NMS(Index = 2)]
        /* 0x440 */ public GcMissionPageHint PageHint;
        // size: 0x3
        public enum RepeatLogicEnum : uint {
            None,
            Loop,
            RestartOnConditionFail,
        }
        [NMS(Index = 22)]
        /* 0x444 */ public RepeatLogicEnum RepeatLogic;
        [NMS(Index = 25)]
        /* 0x448 */ public TkInputEnum SpecialButtonIcon;
        [NMS(Index = 7)]
        /* 0x44C */ public NMSString0x80 DebugText;
        [NMS(Index = 17)]
        /* 0x4CC */ public bool AutoPinRepairs;
        [NMS(Index = 16)]
        /* 0x4CD */ public bool BlockPinning;
        [NMS(Index = 18)]
        /* 0x4CE */ public bool BlockSpaceBattles;
        [NMS(Index = 21)]
        /* 0x4CF */ public bool DoConsequencesIfNeverActivated;
        [NMS(Index = 10)]
        /* 0x4D0 */ public bool HasCategoryOverride;
        [NMS(Index = 12)]
        /* 0x4D1 */ public bool HasColourOverride;
        [NMS(Index = 20)]
        /* 0x4D2 */ public bool HideFromLogIfConditionsMet;
        [NMS(Index = 14)]
        /* 0x4D3 */ public bool PrefixTitle;
        [NMS(Index = 0)]
        /* 0x4D4 */ public bool Silent;
    }
}
