using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x79724331D73DF595, NameHash = 0xDEC89720)]
    public class GcMaintenanceComponentData : NMSTemplate
    {
        [NMS(Index = 23)]
        /* 0x000 */ public TkModelRendererData ModelRenderData;
        [NMS(Index = 24)]
        /* 0x0C0 */ public TkModelRendererData ModelRenderDataAlt;
        [NMS(Index = 54)]
        /* 0x180 */ public GcMaintenanceGroupInstallData GroupInstallSetup;
        [NMS(Index = 30)]
        /* 0x210 */ public NMSString0x20A ActionButtonOverride;
        [NMS(Index = 31)]
        /* 0x230 */ public NMSString0x20A ActionDescriptionOverride;
        [NMS(Index = 38)]
        /* 0x250 */ public NMSString0x20A ActionWarningOverride;
        [NMS(Index = 36)]
        /* 0x270 */ public NMSString0x20A ChargeButtonOverride;
        [NMS(Index = 37)]
        /* 0x290 */ public NMSString0x20A ChargeDescriptionOverride;
        [NMS(Index = 29)]
        /* 0x2B0 */ public NMSString0x20A Description;
        [NMS(Index = 34)]
        /* 0x2D0 */ public NMSString0x20A DiscardButtonOverride;
        [NMS(Index = 35)]
        /* 0x2F0 */ public NMSString0x20A DiscardDescriptionOverride;
        [NMS(Index = 28)]
        /* 0x310 */ public NMSString0x20A Title;
        [NMS(Index = 32)]
        /* 0x330 */ public NMSString0x20A TransferButtonOverride;
        [NMS(Index = 33)]
        /* 0x350 */ public NMSString0x20A TransferDescriptionOverride;
        [NMS(Index = 50)]
        /* 0x370 */ public List<NMSString0x10> ForceDamageDuringMissions;
        [NMS(Index = 49)]
        /* 0x380 */ public NMSString0x10 GiveRewardOnCompletion;
        [NMS(Index = 0)]
        /* 0x390 */ public List<GcMaintenanceElement> PreInstalledTech;
        [NMS(Index = 48)]
        /* 0x3A0 */ public NMSString0x10 StartMissionOnCompletion;
        [NMS(Index = 47)]
        /* 0x3B0 */ public NMSString0x10 StartMissionOnUse;
        [NMS(Index = 26)]
        /* 0x3C0 */ public GcInteractionDof DepthOfField;
        [NMS(Index = 15)]
        /* 0x3D4 */ public Vector2f CustomIconCentre;
        [NMS(Index = 53)]
        /* 0x3DC */ public GcAudioWwiseEvents AudioIDOnSuccess;
        [NMS(Index = 27)]
        /* 0x3E0 */ public GcBroadcastLevel BroadcastLevel;
        [NMS(Index = 20)]
        /* 0x3E4 */ public float CompletedTransitionDelay;
        // size: 0x4
        public enum InteractableEnum : uint {
            OnlyWhenComplete,
            OnlyWhenNotComplete,
            Always,
            Never,
        }
        [NMS(Index = 18)]
        /* 0x3E8 */ public InteractableEnum Interactable;
        [NMS(Index = 43)]
        /* 0x3EC */ public float InWorldUIForcedOffset;
        [NMS(Index = 44)]
        /* 0x3F0 */ public float InWorldUIForcedOffsetV2;
        [NMS(Index = 41)]
        /* 0x3F4 */ public float InWorldUIMinDistOverride;
        [NMS(Index = 42)]
        /* 0x3F8 */ public float InWorldUIMinDistOverrideV2;
        [NMS(Index = 40)]
        /* 0x3FC */ public float InWorldUIScaler;
        // size: 0x2
        public enum ModelRendererResourceEnum : uint {
            ModelNode,
            MasterModelNode,
        }
        [NMS(Index = 25)]
        /* 0x400 */ public ModelRendererResourceEnum ModelRendererResource;
        [NMS(Index = 1)]
        /* 0x404 */ public int VisibleMaintenanceSlots;
        [NMS(Index = 3)]
        /* 0x408 */ public bool AllowCharge;
        [NMS(Index = 7)]
        /* 0x409 */ public bool AllowCraftProduct;
        [NMS(Index = 5)]
        /* 0x40A */ public bool AllowDiscard;
        [NMS(Index = 4)]
        /* 0x40B */ public bool AllowDismantle;
        [NMS(Index = 6)]
        /* 0x40C */ public bool AllowInstallTech;
        [NMS(Index = 9)]
        /* 0x40D */ public bool AllowMoveAndStack;
        [NMS(Index = 11)]
        /* 0x40E */ public bool AllowPinning;
        [NMS(Index = 2)]
        /* 0x40F */ public bool AllowRepair;
        [NMS(Index = 8)]
        /* 0x410 */ public bool AllowTransfer;
        [NMS(Index = 10)]
        /* 0x411 */ public bool AllowTransferIn;
        [NMS(Index = 12)]
        /* 0x412 */ public bool AutoCompleteOnStart;
        [NMS(Index = 56)]
        /* 0x413 */ public bool CanUseOutsideOfBase;
        [NMS(Index = 55)]
        /* 0x414 */ public bool DisableSynchronise;
        [NMS(Index = 19)]
        /* 0x415 */ public bool ForceNoninteraction;
        [NMS(Index = 52)]
        /* 0x416 */ public bool ForceOneClickRepair;
        [NMS(Index = 16)]
        /* 0x417 */ public bool ForceRemoveUIRenderLayer;
        [NMS(Index = 17)]
        /* 0x418 */ public bool HideMaxAmountOnProductSlots;
        [NMS(Index = 46)]
        /* 0x419 */ public bool InteractionRequiresPower;
        [NMS(Index = 45)]
        /* 0x41A */ public bool InWorldUIUseCameraUp;
        [NMS(Index = 51)]
        /* 0x41B */ public bool OpenInteractionOnQuit;
        [NMS(Index = 21)]
        /* 0x41C */ public bool ShareInteractionModelRender;
        [NMS(Index = 39)]
        /* 0x41D */ public bool SilenceSuitVOIAlerts;
        [NMS(Index = 14)]
        /* 0x41E */ public bool UseBoundsForIconCentre;
        [NMS(Index = 22)]
        /* 0x41F */ public bool UseInteractionStyleCameraEvent;
        [NMS(Index = 13)]
        /* 0x420 */ public bool UseModelResourceRenderer;
        [NMS(Index = 57)]
        /* 0x421 */ public bool UseNetworkLock;
    }
}
