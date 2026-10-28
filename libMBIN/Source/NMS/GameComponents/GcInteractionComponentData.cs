using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x16F670853370A406, NameHash = 0xBE246A5)]
    public class GcInteractionComponentData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public TkModelRendererData Renderer;
        [NMS(Index = 5)]
        /* 0x0C0 */ public TkModelRendererData RendererAlt;
        [NMS(Index = 31)]
        /* 0x180 */ public GcStoryUtilityOverride StoryUtilityOverrideData;
        [NMS(Index = 13)]
        /* 0x218 */ public GcInteractionActivationCost ActivationCost;
        [NMS(Index = 23)]
        /* 0x280 */ public GcInteractionActivationCost SecondaryActivationCost;
        [NMS(Index = 30)]
        /* 0x2E8 */ public List<GcAdditionalOptionMissionOverride> AdditionalOptionsOverrideTable;
        [NMS(Index = 24)]
        /* 0x2F8 */ public List<TkModelRendererData> EventRenderers;
        [NMS(Index = 25)]
        /* 0x308 */ public List<TkModelRendererData> EventRenderersAlt;
        [NMS(Index = 26)]
        /* 0x318 */ public List<GcInteractionDof> EventRenderersDoF;
        [NMS(Index = 45)]
        /* 0x328 */ public NMSTemplate InteractionSpecificData;
        [NMS(Index = 29)]
        /* 0x338 */ public List<GcAlienPuzzleMissionOverride> PuzzleMissionOverrideTable;
        [NMS(Index = 41)]
        /* 0x348 */ public NMSString0x10 StartMissionOnUse;
        [NMS(Index = 14)]
        /* 0x358 */ public NMSString0x10 TriggerAction;
        [NMS(Index = 15)]
        /* 0x368 */ public NMSString0x10 TriggerActionOnPrepare;
        [NMS(Index = 28)]
        /* 0x378 */ public GcInteractionDof DepthOfField;
        [NMS(Index = 7)]
        /* 0x38C */ public float AttractDistanceSq;
        [NMS(Index = 12)]
        /* 0x390 */ public float BlendFromCameraTime;
        [NMS(Index = 11)]
        /* 0x394 */ public float BlendToCameraTime;
        [NMS(Index = 19)]
        /* 0x398 */ public float InteractAngle;
        [NMS(Index = 20)]
        /* 0x39C */ public float InteractDistance;
        // size: 0x3
        public enum InteractionActionEnum : uint {
            PressButton,
            HoldButton,
            Shoot,
        }
        [NMS(Index = 0)]
        /* 0x3A0 */ public InteractionActionEnum InteractionAction;
        [NMS(Index = 1)]
        /* 0x3A4 */ public GcInteractionType InteractionType;
        [NMS(Index = 18)]
        /* 0x3A8 */ public float InteractMaxHeightDiff;
        [NMS(Index = 38)]
        /* 0x3AC */ public float InWorldUIForcedOffset;
        [NMS(Index = 39)]
        /* 0x3B0 */ public float InWorldUIForcedOffsetV2;
        [NMS(Index = 36)]
        /* 0x3B4 */ public float InWorldUIMinDistOverride;
        [NMS(Index = 37)]
        /* 0x3B8 */ public float InWorldUIMinDistOverrideV2;
        [NMS(Index = 35)]
        /* 0x3BC */ public float InWorldUIScaler;
        [NMS(Index = 6)]
        /* 0x3C0 */ public GcAlienRace Race;
        [NMS(Index = 17)]
        /* 0x3C4 */ public float RangeToAllowAtAnyAngle;
        [NMS(Index = 27)]
        /* 0x3C8 */ public float SecondaryCameraTransitionTime;
        [NMS(Index = 22)]
        /* 0x3CC */ public GcInteractionType SecondaryInteractionType;
        [NMS(Index = 42)]
        /* 0x3D0 */ public bool AllowMissionUnderwater;
        [NMS(Index = 16)]
        /* 0x3D1 */ public bool BroadcastTriggerAction;
        [NMS(Index = 3)]
        /* 0x3D2 */ public bool DontUseIntermediateForOverrides;
        [NMS(Index = 21)]
        /* 0x3D3 */ public bool InteractInvertFace;
        [NMS(Index = 40)]
        /* 0x3D4 */ public bool InWorldUIUseCameraUp;
        [NMS(Index = 43)]
        /* 0x3D5 */ public bool OnlyAvailableInAbandonedMode;
        // size: 0x3
        public enum OverrideInteriorExteriorMarkerEnum : byte {
            No,
            Interior,
            Exterior,
        }
        [NMS(Index = 32)]
        /* 0x3D6 */ public OverrideInteriorExteriorMarkerEnum OverrideInteriorExteriorMarker;
        [NMS(Index = 9)]
        /* 0x3D7 */ public bool RepeatInteraction;
        [NMS(Index = 33)]
        /* 0x3D8 */ public bool ReseedAfterRewardSuccess;
        [NMS(Index = 8)]
        /* 0x3D9 */ public bool SecondaryMeshAlwaysVisible;
        [NMS(Index = 10)]
        /* 0x3DA */ public bool UseInteractCamera;
        [NMS(Index = 2)]
        /* 0x3DB */ public bool UseIntermediateUI;
        [NMS(Index = 34)]
        /* 0x3DC */ public bool UsePersonalPersistentBuffer;
        [NMS(Index = 44)]
        /* 0x3DD */ public bool UseUnlockedInteractionIfMaintDone;
    }
}
