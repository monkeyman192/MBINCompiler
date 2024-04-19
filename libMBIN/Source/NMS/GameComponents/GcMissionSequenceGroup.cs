using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBEA5909A9D17C463, NameHash = 0x51B3554FFBEBED66)]
    public class GcMissionSequenceGroup : NMSTemplate
    {
        /* 0x000 */ public Colour ColourOverride;
        /* 0x010 */ public GcTargetMissionSurveyOptions SurveyTarget;
        /* 0x228 */ public GcSeasonalObjectiveOverrides SeasonalObjectiveOverrides;
        /* 0x278 */ public GcObjectiveTextFormatOptions ObjectiveFormatting;
        /* 0x2C0 */ public NMSString0x20A ObjectiveID;
        /* 0x2E0 */ public NMSString0x20A ObjectiveTipID;
        /* 0x300 */ public NMSString0x20A PageDataLocID;
        /* 0x320 */ public NMSString0x20A PrefixTitleText;
        /* 0x340 */ public NMSString0x10 BuildMenuHint;
        /* 0x350 */ public List<NMSTemplate> Conditions;
        /* 0x360 */ public List<NMSTemplate> Consequences;
        /* 0x370 */ public NMSString0x10 InventoryHint;
        /* 0x380 */ public List<GcGenericMissionStage> Stages;
        /* 0x390 */ public NMSString0x10 TerrainTarget;
        /* 0x3A0 */ public TkTextureResource Icon;
        /* 0x424 */ public GcCustomNotifyTimerOptions CustomNotifyTimers;
        /* 0x430 */ public GcMissionConditionTest ConditionTest;
        // size: 0x3
        public enum GalMapPathOverrideEnum : uint {
            None,
            BlackHole,
            Atlas,
        }
        /* 0x434 */ public GalMapPathOverrideEnum GalMapPathOverride;
        // size: 0x4
        public enum IconStyleEnum : uint {
            Default,
            Large,
            Square,
            NoFrame,
        }
        /* 0x438 */ public IconStyleEnum IconStyle;
        /* 0x43C */ public GcMissionCategory OverrideCategory;
        /* 0x440 */ public GcMissionPageHint PageHint;
        // size: 0x3
        public enum RepeatLogicEnum : uint {
            None,
            Loop,
            RestartOnConditionFail,
        }
        /* 0x444 */ public RepeatLogicEnum RepeatLogic;
        /* 0x448 */ public TkInputEnum SpecialButtonIcon;
        /* 0x44C */ public NMSString0x80 DebugText;
        /* 0x4CC */ public bool AutoPinRepairs;
        /* 0x4CD */ public bool BlockPinning;
        /* 0x4CE */ public bool BlockSpaceBattles;
        /* 0x4CF */ public bool DoConsequencesIfNeverActivated;
        /* 0x4D0 */ public bool HasCategoryOverride;
        /* 0x4D1 */ public bool HasColourOverride;
        /* 0x4D2 */ public bool HideFromLogIfConditionsMet;
        /* 0x4D3 */ public bool PrefixTitle;
        /* 0x4D4 */ public bool Silent;
    }
}
