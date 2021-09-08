using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x2D0, GUID = 0x0FBE2AEABA3D65ED, NameHash = 0xDAB0554EA36957B5)]
    public class GcInteractionComponentData : NMSTemplate
    {
        public enum InteractionActionEnum { PressButton, HoldButton, Shoot }
        /* 0x000 */ public InteractionActionEnum InteractionAction;
        /* 0x004 */ public GcInteractionType InteractionType;
        /* 0x008 */ public bool UseIntermediateUI;
        /* 0x010 */ public TkModelRendererData Renderer;
        /* 0x0C0 */ public TkModelRendererData RendererAlt;
        /* 0x170 */ public GcAlienRace Race;
        /* 0x174 */ public float AttractDistanceSq;
        /* 0x178 */ public bool RepeatInteraction;
        /* 0x179 */ public bool UseInteractCamera;
        /* 0x17C */ public float BlendToCameraTime;
        /* 0x180 */ public float BlendFromCameraTime;
        /* 0x188 */ public GcInteractionActivationCost ActivationCost;
        /* 0x1C0 */ public NMSString0x10 TriggerAction;
        /* 0x1D0 */ public NMSString0x10 TriggerActionOnPrepare;
        /* 0x1E0 */ public bool BroadcastTriggerAction;
        /* 0x1E4 */ public float InteractAngle;
        /* 0x1E8 */ public float InteractDistance;
        /* 0x1EC */ public bool InteractInvertFace;
        /* 0x1F0 */ public GcInteractionType SecondaryInteractionType;
        /* 0x1F8 */ public GcInteractionActivationCost SecondaryActivationCost;
        /* 0x230 */ public List<TkModelRendererData> EventRenderers;
        /* 0x240 */ public List<TkModelRendererData> EventRenderersAlt;
        /* 0x250 */ public float SecondaryCameraTransitionTime;
        /* 0x254 */ public GcInteractionDof DepthOfField;
        /* 0x268 */ public List<GcAlienPuzzleMissionOverride> PuzzleMissionOverrideTable;
        /* 0x278 */ public GcStoryUtilityOverride StoryUtilityOverrideData;
        public enum OverrideInteriorExteriorMarkerEnum { No, Interior, Exterior }
        /* 0x2B8 */ public OverrideInteriorExteriorMarkerEnum OverrideInteriorExteriorMarker;
        /* 0x2BC */ public bool ReseedAfterRewardSuccess;
        /* 0x2BD */ public bool UsePersonalPersistentBuffer;
        /* 0x2C0 */ public float InWorldUIScaler;
    }
}
