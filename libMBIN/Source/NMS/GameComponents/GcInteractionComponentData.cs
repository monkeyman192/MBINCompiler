using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2A0, GUID = 0xA588B42C1FA803DE, Alignment = 0x10, NameHash = 0xDAB0554EA36957B5)]
    public class GcInteractionComponentData : NMSTemplate
    {
		public enum InteractionActionEnum { PressButton, HoldButton, Shoot }
		/* 0x000 */ public InteractionActionEnum InteractionAction;

        /* 0x004 */ public GcInteractionType InteractionType;
        [NMS(Size = 8, Ignore = true)]
        /* 0x008 */ public byte[] Padding8;
        /* 0x010 */ public TkModelRendererData Renderer;
        /* 0x0C0 */ public TkModelRendererData RendererAlt;
        /* 0x170 */ public GcAlienRace Race;
        /* 0x174 */ public float AttractDistanceSq;
        /* 0x178 */ public bool RepeatInteraction;
        /* 0x179 */ public bool UseInteractCamera;
        /* 0x17C */ public float BlendToCameraTime;
        /* 0x180 */ public float BlendFromCameraTime;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x184 */ public byte[] Padding184;
        /* 0x188 */ public GcInteractionActivationCost ActivationCost;

        [NMS(Size = 0x10)]
        /* 0x1C0 */ public string TriggerAction;
        /* 0x1D0 */ public bool BroadcastTriggerAction;
        /* 0x1D4 */ public float InteractAngle;
        /* 0x1D8 */ public float InteractDistance;
        /* 0x1DC */ public bool InteractInvertFace;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x1DD */ public byte[] Padding1DD;
        /* 0x1E0 */ public GcInteractionType SecondaryInteractionType;
        [NMS(Size = 4, Ignore = true)]
        /* 0x1E4 */ public byte[] Padding1E4;
        /* 0x1E8 */ public GcInteractionActivationCost SecondaryActivationCost;
        /* 0x220 */ public List<TkModelRendererData> EventRenderers;
        /* 0x220 */ public List<TkModelRendererData> EventRenderersAlt;
        /* 0x240 */ public float SecondaryCameraTransitionTime;
        /* 0x244 */ public GcInteractionDof DepthOfField;
        /* 0x258 */ public List<GcAlienPuzzleMissionOverride> PuzzleMissionOverrideTable;
        /* 0x268 */ public GcStoryUtilityOverride StoryUtilityOverrideData;
        /* 0x298 */ public bool ReseedAfterRewardSuccess;
        /* 0x299 */ public bool UsePersonalPersistentBuffer;
        /* 0x29C */ public float InWorldUIScaler;
    }
}
