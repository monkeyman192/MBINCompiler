using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1877F9A5397B64AF, NameHash = 0xF0FD370B)]
    public class GcMissionSequenceGroup : NMSTemplate
    {
        [NMS(Index = 13)]
        /* 0x000 */ public Colour ColourOverride;
        [NMS(Index = 28)]
        /* 0x010 */ public GcTargetMissionSurveyOptions SurveyTarget;
        [NMS(Index = 27)]
        /* 0x0B8 */ public GcSeasonalObjectiveOverrides SeasonalObjectiveOverrides;
        [NMS(Index = 26)]
        /* 0x108 */ public GcObjectiveTextFormatOptions ObjectiveFormatting;
        [NMS(Index = 8)]
        /* 0x150 */ public NMSString0x20A ObjectiveID;
        [NMS(Index = 9)]
        /* 0x170 */ public NMSString0x20A ObjectiveTipID;
        [NMS(Index = 3)]
        /* 0x190 */ public NMSString0x20A PageDataLocID;
        [NMS(Index = 15)]
        /* 0x1B0 */ public NMSString0x20A PrefixTitleText;
        [NMS(Index = 1)]
        /* 0x1D0 */ public TkTextureResource Icon;
        [NMS(Index = 4)]
        /* 0x1E8 */ public NMSString0x10 BuildMenuHint;
        [NMS(Index = 30)]
        /* 0x1F8 */ public List<NMSTemplate> Conditions;
        [NMS(Index = 31)]
        /* 0x208 */ public List<NMSTemplate> Consequences;
        [NMS(Index = 7)]
        /* 0x218 */ public VariableSizeString DebugText;
        [NMS(Index = 5)]
        /* 0x228 */ public NMSString0x10 InventoryHint;
        [NMS(Index = 32)]
        /* 0x238 */ public List<GcGenericMissionStage> Stages;
        [NMS(Index = 6)]
        /* 0x248 */ public NMSString0x10 TerrainTarget;
        [NMS(Index = 29)]
        /* 0x258 */ public GcCustomNotifyTimerOptions CustomNotifyTimers;
        [NMS(Index = 19)]
        /* 0x264 */ public GcMissionConditionTest ConditionTest;
        // size: 0x3
        public enum GalMapPathOverrideEnum : uint {
            None,
            BlackHole,
            Atlas,
        }
        [NMS(Index = 24)]
        /* 0x268 */ public GalMapPathOverrideEnum GalMapPathOverride;
        // size: 0x4
        public enum IconStyleEnum : uint {
            Default,
            Large,
            Square,
            NoFrame,
        }
        [NMS(Index = 23)]
        /* 0x26C */ public IconStyleEnum IconStyle;
        [NMS(Index = 11)]
        /* 0x270 */ public GcMissionCategory OverrideCategory;
        [NMS(Index = 2)]
        /* 0x274 */ public GcMissionPageHint PageHint;
        // size: 0x3
        public enum RepeatLogicEnum : uint {
            None,
            Loop,
            RestartOnConditionFail,
        }
        [NMS(Index = 22)]
        /* 0x278 */ public RepeatLogicEnum RepeatLogic;
        [NMS(Index = 25)]
        /* 0x27C */ public TkInputEnum SpecialButtonIcon;
        [NMS(Index = 17)]
        /* 0x280 */ public bool AutoPinRepairs;
        [NMS(Index = 16)]
        /* 0x281 */ public bool BlockPinning;
        [NMS(Index = 18)]
        /* 0x282 */ public bool BlockSpaceBattles;
        [NMS(Index = 21)]
        /* 0x283 */ public bool DoConsequencesIfNeverActivated;
        [NMS(Index = 10)]
        /* 0x284 */ public bool HasCategoryOverride;
        [NMS(Index = 12)]
        /* 0x285 */ public bool HasColourOverride;
        [NMS(Index = 20)]
        /* 0x286 */ public bool HideFromLogIfConditionsMet;
        [NMS(Index = 14)]
        /* 0x287 */ public bool PrefixTitle;
        [NMS(Index = 0)]
        /* 0x288 */ public bool Silent;
    }
}
