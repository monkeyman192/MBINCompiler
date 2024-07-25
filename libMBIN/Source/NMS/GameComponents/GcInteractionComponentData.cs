using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB2C632E60EB8C2B1, NameHash = 0xBE246A5)]
    public class GcInteractionComponentData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x000 */ public TkModelRendererData Renderer;
        [NMS(Index = 4)]
        /* 0x0B0 */ public TkModelRendererData RendererAlt;
        [NMS(Index = 12)]
        /* 0x160 */ public GcInteractionActivationCost ActivationCost;
        [NMS(Index = 20)]
        /* 0x1C8 */ public GcInteractionActivationCost SecondaryActivationCost;
        [NMS(Index = 28)]
        /* 0x230 */ public GcStoryUtilityOverride StoryUtilityOverrideData;
        [NMS(Index = 27)]
        /* 0x270 */ public List<GcAdditionalOptionMissionOverride> AdditionalOptionsOverrideTable;
        [NMS(Index = 21)]
        /* 0x280 */ public List<TkModelRendererData> EventRenderers;
        [NMS(Index = 22)]
        /* 0x290 */ public List<TkModelRendererData> EventRenderersAlt;
        [NMS(Index = 23)]
        /* 0x2A0 */ public List<GcInteractionDof> EventRenderersDoF;
        [NMS(Index = 26)]
        /* 0x2B0 */ public List<GcAlienPuzzleMissionOverride> PuzzleMissionOverrideTable;
        [NMS(Index = 38)]
        /* 0x2C0 */ public NMSString0x10 StartMissionOnUse;
        [NMS(Index = 13)]
        /* 0x2D0 */ public NMSString0x10 TriggerAction;
        [NMS(Index = 14)]
        /* 0x2E0 */ public NMSString0x10 TriggerActionOnPrepare;
        [NMS(Index = 25)]
        /* 0x2F0 */ public GcInteractionDof DepthOfField;
        [NMS(Index = 6)]
        /* 0x304 */ public float AttractDistanceSq;
        [NMS(Index = 11)]
        /* 0x308 */ public float BlendFromCameraTime;
        [NMS(Index = 10)]
        /* 0x30C */ public float BlendToCameraTime;
        [NMS(Index = 16)]
        /* 0x310 */ public float InteractAngle;
        [NMS(Index = 17)]
        /* 0x314 */ public float InteractDistance;
        // size: 0x3
        public enum InteractionActionEnum : uint {
            PressButton,
            HoldButton,
            Shoot,
        }
        [NMS(Index = 0)]
        /* 0x318 */ public InteractionActionEnum InteractionAction;
        [NMS(Index = 1)]
        /* 0x31C */ public GcInteractionType InteractionType;
        [NMS(Index = 35)]
        /* 0x320 */ public float InWorldUIForcedOffset;
        [NMS(Index = 36)]
        /* 0x324 */ public float InWorldUIForcedOffsetV2;
        [NMS(Index = 33)]
        /* 0x328 */ public float InWorldUIMinDistOverride;
        [NMS(Index = 34)]
        /* 0x32C */ public float InWorldUIMinDistOverrideV2;
        [NMS(Index = 32)]
        /* 0x330 */ public float InWorldUIScaler;
        // size: 0x3
        public enum OverrideInteriorExteriorMarkerEnum : uint {
            No,
            Interior,
            Exterior,
        }
        [NMS(Index = 29)]
        /* 0x334 */ public OverrideInteriorExteriorMarkerEnum OverrideInteriorExteriorMarker;
        [NMS(Index = 5)]
        /* 0x338 */ public GcAlienRace Race;
        [NMS(Index = 24)]
        /* 0x33C */ public float SecondaryCameraTransitionTime;
        [NMS(Index = 19)]
        /* 0x340 */ public GcInteractionType SecondaryInteractionType;
        [NMS(Index = 39)]
        /* 0x344 */ public bool AllowMissionUnderwater;
        [NMS(Index = 15)]
        /* 0x345 */ public bool BroadcastTriggerAction;
        [NMS(Index = 18)]
        /* 0x346 */ public bool InteractInvertFace;
        [NMS(Index = 37)]
        /* 0x347 */ public bool InWorldUIUseCameraUp;
        [NMS(Index = 8)]
        /* 0x348 */ public bool RepeatInteraction;
        [NMS(Index = 30)]
        /* 0x349 */ public bool ReseedAfterRewardSuccess;
        [NMS(Index = 7)]
        /* 0x34A */ public bool SecondaryMeshAlwaysVisible;
        [NMS(Index = 9)]
        /* 0x34B */ public bool UseInteractCamera;
        [NMS(Index = 2)]
        /* 0x34C */ public bool UseIntermediateUI;
        [NMS(Index = 31)]
        /* 0x34D */ public bool UsePersonalPersistentBuffer;
        [NMS(Index = 40)]
        /* 0x34E */ public bool UseUnlockedInteractionIfMaintDone;
    }
}
