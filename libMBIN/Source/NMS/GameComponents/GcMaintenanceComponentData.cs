using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6F902FFDA7CAA1, NameHash = 0x479CFCB871ABBE0)]
    public class GcMaintenanceComponentData : NMSTemplate
    {
        [NMS(Index = 22)]
        /* 0x000 */ public TkModelRendererData ModelRenderData;
        [NMS(Index = 23)]
        /* 0x0B0 */ public TkModelRendererData ModelRenderDataAlt;
        [NMS(Index = 51)]
        /* 0x160 */ public GcMaintenanceGroupInstallData GroupInstallSetup;
        [NMS(Index = 28)]
        /* 0x1F0 */ public NMSString0x20A ActionButtonOverride;
        [NMS(Index = 29)]
        /* 0x210 */ public NMSString0x20A ActionDescriptionOverride;
        [NMS(Index = 36)]
        /* 0x230 */ public NMSString0x20A ActionWarningOverride;
        [NMS(Index = 34)]
        /* 0x250 */ public NMSString0x20A ChargeButtonOverride;
        [NMS(Index = 35)]
        /* 0x270 */ public NMSString0x20A ChargeDescriptionOverride;
        [NMS(Index = 27)]
        /* 0x290 */ public NMSString0x20A Description;
        [NMS(Index = 32)]
        /* 0x2B0 */ public NMSString0x20A DiscardButtonOverride;
        [NMS(Index = 33)]
        /* 0x2D0 */ public NMSString0x20A DiscardDescriptionOverride;
        [NMS(Index = 26)]
        /* 0x2F0 */ public NMSString0x20A Title;
        [NMS(Index = 30)]
        /* 0x310 */ public NMSString0x20A TransferButtonOverride;
        [NMS(Index = 31)]
        /* 0x330 */ public NMSString0x20A TransferDescriptionOverride;
        [NMS(Index = 47)]
        /* 0x350 */ public NMSString0x10 GiveRewardOnCompletion;
        [NMS(Index = 0)]
        /* 0x360 */ public List<GcMaintenanceElement> PreInstalledTech;
        [NMS(Index = 46)]
        /* 0x370 */ public NMSString0x10 StartMissionOnCompletion;
        [NMS(Index = 45)]
        /* 0x380 */ public NMSString0x10 StartMissionOnUse;
        [NMS(Index = 50)]
        /* 0x390 */ public GcAudioWwiseEvents AudioIDOnSuccess;
        [NMS(Index = 25)]
        /* 0x394 */ public GcBroadcastLevel BroadcastLevel;
        [NMS(Index = 19)]
        /* 0x398 */ public float CompletedTransitionDelay;
        // size: 0x4
        public enum InteractableEnum : uint {
            OnlyWhenComplete,
            OnlyWhenNotComplete,
            Always,
            Never,
        }
        [NMS(Index = 17)]
        /* 0x39C */ public InteractableEnum Interactable;
        [NMS(Index = 41)]
        /* 0x3A0 */ public float InWorldUIForcedOffset;
        [NMS(Index = 42)]
        /* 0x3A4 */ public float InWorldUIForcedOffsetV2;
        [NMS(Index = 39)]
        /* 0x3A8 */ public float InWorldUIMinDistOverride;
        [NMS(Index = 40)]
        /* 0x3AC */ public float InWorldUIMinDistOverrideV2;
        [NMS(Index = 38)]
        /* 0x3B0 */ public float InWorldUIScaler;
        // size: 0x2
        public enum ModelRendererResourceEnum : uint {
            ModelNode,
            MasterModelNode,
        }
        [NMS(Index = 24)]
        /* 0x3B4 */ public ModelRendererResourceEnum ModelRendererResource;
        [NMS(Index = 1)]
        /* 0x3B8 */ public int VisibleMaintenanceSlots;
        [NMS(Index = 3)]
        /* 0x3BC */ public bool AllowCharge;
        [NMS(Index = 7)]
        /* 0x3BD */ public bool AllowCraftProduct;
        [NMS(Index = 5)]
        /* 0x3BE */ public bool AllowDiscard;
        [NMS(Index = 4)]
        /* 0x3BF */ public bool AllowDismantle;
        [NMS(Index = 6)]
        /* 0x3C0 */ public bool AllowInstallTech;
        [NMS(Index = 9)]
        /* 0x3C1 */ public bool AllowMoveAndStack;
        [NMS(Index = 11)]
        /* 0x3C2 */ public bool AllowPinning;
        [NMS(Index = 2)]
        /* 0x3C3 */ public bool AllowRepair;
        [NMS(Index = 8)]
        /* 0x3C4 */ public bool AllowTransfer;
        [NMS(Index = 10)]
        /* 0x3C5 */ public bool AllowTransferIn;
        [NMS(Index = 12)]
        /* 0x3C6 */ public bool AutoCompleteOnStart;
        [NMS(Index = 52)]
        /* 0x3C7 */ public bool DisableSynchronise;
        [NMS(Index = 18)]
        /* 0x3C8 */ public bool ForceNoninteraction;
        [NMS(Index = 49)]
        /* 0x3C9 */ public bool ForceOneClickRepair;
        [NMS(Index = 15)]
        /* 0x3CA */ public bool ForceRemoveUIRenderLayer;
        [NMS(Index = 16)]
        /* 0x3CB */ public bool HideMaxAmountOnProductSlots;
        [NMS(Index = 44)]
        /* 0x3CC */ public bool InteractionRequiresPower;
        [NMS(Index = 43)]
        /* 0x3CD */ public bool InWorldUIUseCameraUp;
        [NMS(Index = 48)]
        /* 0x3CE */ public bool OpenInteractionOnQuit;
        [NMS(Index = 20)]
        /* 0x3CF */ public bool ShareInteractionModelRender;
        [NMS(Index = 37)]
        /* 0x3D0 */ public bool SilenceSuitVOIAlerts;
        [NMS(Index = 14)]
        /* 0x3D1 */ public bool UseBoundsForIconCentre;
        [NMS(Index = 21)]
        /* 0x3D2 */ public bool UseInteractionStyleCameraEvent;
        [NMS(Index = 13)]
        /* 0x3D3 */ public bool UseModelResourceRenderer;
    }
}
