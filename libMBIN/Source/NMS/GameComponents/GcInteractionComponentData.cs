using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEBF28F88CAC268BE, NameHash = 0xDAB0554EA36957B5)]
    public class GcInteractionComponentData : NMSTemplate
    {
        /* 0x000 */ public TkModelRendererData Renderer;
        /* 0x0B0 */ public TkModelRendererData RendererAlt;
        /* 0x160 */ public GcInteractionActivationCost ActivationCost;
        /* 0x1C8 */ public GcInteractionActivationCost SecondaryActivationCost;
        /* 0x230 */ public GcStoryUtilityOverride StoryUtilityOverrideData;
        /* 0x270 */ public List<TkModelRendererData> EventRenderers;
        /* 0x280 */ public List<TkModelRendererData> EventRenderersAlt;
        /* 0x290 */ public List<GcInteractionDof> EventRenderersDoF;
        /* 0x2A0 */ public List<GcAlienPuzzleMissionOverride> PuzzleMissionOverrideTable;
        /* 0x2B0 */ public NMSString0x10 StartMissionOnUse;
        /* 0x2C0 */ public NMSString0x10 TriggerAction;
        /* 0x2D0 */ public NMSString0x10 TriggerActionOnPrepare;
        /* 0x2E0 */ public GcInteractionDof DepthOfField;
        /* 0x2F4 */ public float AttractDistanceSq;
        /* 0x2F8 */ public float BlendFromCameraTime;
        /* 0x2FC */ public float BlendToCameraTime;
        /* 0x300 */ public float InteractAngle;
        /* 0x304 */ public float InteractDistance;
        // size: 0x3
        public enum InteractionActionEnum : uint {
            PressButton,
            HoldButton,
            Shoot,
        }
        /* 0x308 */ public InteractionActionEnum InteractionAction;
        /* 0x30C */ public GcInteractionType InteractionType;
        /* 0x310 */ public float InWorldUIForcedOffset;
        /* 0x314 */ public float InWorldUIForcedOffsetV2;
        /* 0x318 */ public float InWorldUIMinDistOverride;
        /* 0x31C */ public float InWorldUIMinDistOverrideV2;
        /* 0x320 */ public float InWorldUIScaler;
        // size: 0x3
        public enum OverrideInteriorExteriorMarkerEnum : uint {
            No,
            Interior,
            Exterior,
        }
        /* 0x324 */ public OverrideInteriorExteriorMarkerEnum OverrideInteriorExteriorMarker;
        /* 0x328 */ public GcAlienRace Race;
        /* 0x32C */ public float SecondaryCameraTransitionTime;
        /* 0x330 */ public GcInteractionType SecondaryInteractionType;
        /* 0x334 */ public bool AllowMissionUnderwater;
        /* 0x335 */ public bool BroadcastTriggerAction;
        /* 0x336 */ public bool InteractInvertFace;
        /* 0x337 */ public bool InWorldUIUseCameraUp;
        /* 0x338 */ public bool RepeatInteraction;
        /* 0x339 */ public bool ReseedAfterRewardSuccess;
        /* 0x33A */ public bool SecondaryMeshAlwaysVisible;
        /* 0x33B */ public bool UseInteractCamera;
        /* 0x33C */ public bool UseIntermediateUI;
        /* 0x33D */ public bool UsePersonalPersistentBuffer;
        /* 0x33E */ public bool UseUnlockedInteractionIfMaintDone;
    }
}
