using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x200, Alignment = 0x8)]
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
        [NMS(Size = 0x80)]
        /* 0x0C0 */ public string DebugText;
        [NMS(Size = 0x20)]
        /* 0x140 */ public string ObjectiveID;
        [NMS(Size = 0x20)]
        /* 0x160 */ public string ObjectiveTipID;
        /* 0x180 */ public bool HasCategoryOverride;
        /* 0x184 */ public GcMissionCategory OverrideCategory;
        /* 0x188 */ public bool HasColourOverride;
        /* 0x190 */ public Colour ColourOverride;
        /* 0x1A0 */ public bool PrefixTitle;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x1A1 */ public byte[] Padding1A1;
        [NMS(Size = 0x20)]
        /* 0x1A8 */ public string PrefixTitleText;
        /* 0x1C8 */ public GcMissionConditionTest ConditionTest;        // not so sure about this and the condition enum

		public enum RepeatLogicEnum { None, Loop, RestartOnConditionFail }
		public RepeatLogicEnum RepeatLogic;
        /* 0x1D0 */ public List<NMSTemplate> Conditions;
        /* 0x1E0 */ public List<NMSTemplate> Consequences;
        /* 0x1F0 */ public List<GcGenericMissionStage> Stages;
    }
}
