using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6E3AF03C585E73BB, NameHash = 0x51B3554FFBEBED66)]
    public class GcMissionSequenceGroup : NMSTemplate
    {
        /* 0x000 */ public bool Silent;
        /* 0x004 */ public TkTextureResource Icon;
        /* 0x088 */ public GcMissionPageHint PageHint;
        /* 0x090 */ public NMSString0x20A PageDataLocID;
        /* 0x0B0 */ public NMSString0x10 BuildMenuHint;
        /* 0x0C0 */ public NMSString0x10 InventoryHint;
        /* 0x0D0 */ public NMSString0x80 DebugText;
        /* 0x150 */ public NMSString0x20A ObjectiveID;
        /* 0x170 */ public NMSString0x20A ObjectiveTipID;
        /* 0x190 */ public bool HasCategoryOverride;
        /* 0x194 */ public GcMissionCategory OverrideCategory;
        /* 0x198 */ public bool HasColourOverride;
        /* 0x1A0 */ public Colour ColourOverride;
        /* 0x1B0 */ public bool PrefixTitle;
        /* 0x1B8 */ public NMSString0x20A PrefixTitleText;
        /* 0x1D8 */ public bool BlockPinning;
        /* 0x1DC */ public GcMissionConditionTest ConditionTest;
        // size: 0x3
        public enum RepeatLogicEnum { None, Loop, RestartOnConditionFail }
        /* 0x1E0 */ public RepeatLogicEnum RepeatLogic;
        // size: 0x4
        public enum IconStyleEnum { Default, Large, Square, NoFrame }
        /* 0x1E4 */ public IconStyleEnum IconStyle;
        /* 0x1E8 */ public TkInputEnum SpecialButtonIcon;
        /* 0x1F0 */ public GcObjectiveTextFormatOptions ObjectiveFormatting;
        /* 0x238 */ public GcTargetMissionSurveyOptions SurveyTarget;
        /* 0x450 */ public GcCustomNotifyTimerOptions CustomNotifyTimers;
        /* 0x460 */ public List<NMSTemplate> Conditions;
        /* 0x470 */ public List<NMSTemplate> Consequences;
        /* 0x480 */ public List<GcGenericMissionStage> Stages;
    }
}
