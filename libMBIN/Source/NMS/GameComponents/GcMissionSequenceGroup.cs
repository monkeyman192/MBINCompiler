using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x410, Alignment = 0x10, GUID = 0x350EC7222905E2E9, NameHash = 0x51B3554FFBEBED66)]
    public class GcMissionSequenceGroup : NMSTemplate
    {
        /* 0x000 */ public bool Silent;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x001 */ public byte[] Padding1;
        /* 0x004 */ public TkTextureResource Icon;
        /* 0x088 */ public GcMissionPageHint PageHint;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x08C */ public byte[] Padding8C;
        /* 0x090 */ public NMSString0x20 PageDataLocID;
        /* 0x0B0 */ public NMSString0x10 BuildMenuHint;
        /* 0x0C0 */ public NMSString0x10 InventoryHint;
        /* 0x0D0 */ public NMSString0x80 DebugText;
        /* 0x150 */ public NMSString0x20 ObjectiveID;
        /* 0x170 */ public NMSString0x20 ObjectiveTipID;
        /* 0x190 */ public bool HasCategoryOverride;
        /* 0x194 */ public GcMissionCategory OverrideCategory;
        /* 0x198 */ public bool HasColourOverride;
        /* 0x1A0 */ public Colour ColourOverride;
        /* 0x1B0 */ public bool PrefixTitle;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x1B1 */ public byte[] Padding1B1;
        /* 0x1B8 */ public NMSString0x20 PrefixTitleText;
        /* 0x1D8 */ public bool BlockPinning;
        /* 0x1DC */ public GcMissionConditionTest ConditionTest;
		public enum RepeatLogicEnum { None, Loop, RestartOnConditionFail }
		/* 0x1E0 */ public RepeatLogicEnum RepeatLogic;
        public enum IconStyleEnum { Default, Large, Square, NoFrame }
		/* 0x1E4 */ public IconStyleEnum IconStyle;
        /* 0x1E8 */ public TkInputEnum SpecialButtonIcon;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1EC */ public byte[] Padding1EC;
        /* 0x1F0 */ public GcObjectiveTextFormatOptions ObjectiveFormatting;
        /* 0x238 */ public GcTargetMissionSurveyOptions SurveyTarget;
        /* 0x3D0 */ public GcCustomNotifyTimerOptions CustomNotifyTimers;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x3DC */ public byte[] Padding3DC;
        /* 0x3E0 */ public List<NMSTemplate> Conditions;
        /* 0x3F0 */ public List<NMSTemplate> Consequences;
        /* 0x400 */ public List<GcGenericMissionStage> Stages;
    }
}
