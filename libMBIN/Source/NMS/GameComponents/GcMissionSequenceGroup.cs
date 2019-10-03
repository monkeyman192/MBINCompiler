using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x220, Alignment = 0x10, GUID = 0xF3FD7E2B49355009, NameHash = 0x51B3554FFBEBED66)]
    public class GcMissionSequenceGroup : NMSTemplate
    {
        /* 0x000 */ public bool Silent;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x001 */ public byte[] Padding1;
        /* 0x004 */ public TkTextureResource Icon;
        /* 0x088 */ public GcMissionPageHint PageHint;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x08C */ public byte[] Padding8C;
        [NMS(Size = 0x20)]
        /* 0x090 */ public string PageDataLocID;
        [NMS(Size = 0x10)]
        /* 0x0B0 */ public string BuildMenuHint;
        [NMS(Size = 0x10)]
        /* 0x0C0 */ public string InventoryHint;
        [NMS(Size = 0x80)]
        /* 0x0D0 */ public string DebugText;
        [NMS(Size = 0x20)]
        /* 0x150 */ public string ObjectiveID;
        [NMS(Size = 0x20)]
        /* 0x170 */ public string ObjectiveTipID;
        /* 0x190 */ public bool HasCategoryOverride;
        /* 0x194 */ public GcMissionCategory OverrideCategory;
        /* 0x198 */ public bool HasColourOverride;
        /* 0x1A0 */ public Colour ColourOverride;
        /* 0x1B0 */ public bool PrefixTitle;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x1B1 */ public byte[] Padding1A1;
        [NMS(Size = 0x20)]
        /* 0x1B8 */ public string PrefixTitleText;
        /* 0x1D8 */ public GcMissionConditionTest ConditionTest;

		public enum RepeatLogicEnum { None, Loop, RestartOnConditionFail }
		/* 0x1DC */ public RepeatLogicEnum RepeatLogic;
        public enum IconStyleEnum { Default, Large }
		/* 0x1E0 */ public IconStyleEnum IconStyle;
        /* 0x1E4 */ public TkInputEnum SpecialButtonIcon;
        /* 0x1E8 */ public List<NMSTemplate> Conditions;
        /* 0x1F8 */ public List<NMSTemplate> Consequences;
        /* 0x208 */ public List<GcGenericMissionStage> Stages;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x218 */ public byte[] EndPadding;
    }
}
