using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6F902FFDA7CAA1, NameHash = 0x479CFCB871ABBE0)]
    public class GcMaintenanceComponentData : NMSTemplate
    {
        /* 0x000 */ public TkModelRendererData ModelRenderData;
        /* 0x0B0 */ public TkModelRendererData ModelRenderDataAlt;
        /* 0x160 */ public GcMaintenanceGroupInstallData GroupInstallSetup;
        /* 0x1F0 */ public NMSString0x20A ActionButtonOverride;
        /* 0x210 */ public NMSString0x20A ActionDescriptionOverride;
        /* 0x230 */ public NMSString0x20A ActionWarningOverride;
        /* 0x250 */ public NMSString0x20A ChargeButtonOverride;
        /* 0x270 */ public NMSString0x20A ChargeDescriptionOverride;
        /* 0x290 */ public NMSString0x20A Description;
        /* 0x2B0 */ public NMSString0x20A DiscardButtonOverride;
        /* 0x2D0 */ public NMSString0x20A DiscardDescriptionOverride;
        /* 0x2F0 */ public NMSString0x20A Title;
        /* 0x310 */ public NMSString0x20A TransferButtonOverride;
        /* 0x330 */ public NMSString0x20A TransferDescriptionOverride;
        /* 0x350 */ public NMSString0x10 GiveRewardOnCompletion;
        /* 0x360 */ public List<GcMaintenanceElement> PreInstalledTech;
        /* 0x370 */ public NMSString0x10 StartMissionOnCompletion;
        /* 0x380 */ public NMSString0x10 StartMissionOnUse;
        /* 0x390 */ public GcAudioWwiseEvents AudioIDOnSuccess;
        /* 0x394 */ public GcBroadcastLevel BroadcastLevel;
        /* 0x398 */ public float CompletedTransitionDelay;
        // size: 0x4
        public enum InteractableEnum : uint {
            OnlyWhenComplete,
            OnlyWhenNotComplete,
            Always,
            Never,
        }
        /* 0x39C */ public InteractableEnum Interactable;
        /* 0x3A0 */ public float InWorldUIForcedOffset;
        /* 0x3A4 */ public float InWorldUIForcedOffsetV2;
        /* 0x3A8 */ public float InWorldUIMinDistOverride;
        /* 0x3AC */ public float InWorldUIMinDistOverrideV2;
        /* 0x3B0 */ public float InWorldUIScaler;
        // size: 0x2
        public enum ModelRendererResourceEnum : uint {
            ModelNode,
            MasterModelNode,
        }
        /* 0x3B4 */ public ModelRendererResourceEnum ModelRendererResource;
        /* 0x3B8 */ public int VisibleMaintenanceSlots;
        /* 0x3BC */ public bool AllowCharge;
        /* 0x3BD */ public bool AllowCraftProduct;
        /* 0x3BE */ public bool AllowDiscard;
        /* 0x3BF */ public bool AllowDismantle;
        /* 0x3C0 */ public bool AllowInstallTech;
        /* 0x3C1 */ public bool AllowMoveAndStack;
        /* 0x3C2 */ public bool AllowPinning;
        /* 0x3C3 */ public bool AllowRepair;
        /* 0x3C4 */ public bool AllowTransfer;
        /* 0x3C5 */ public bool AllowTransferIn;
        /* 0x3C6 */ public bool AutoCompleteOnStart;
        /* 0x3C7 */ public bool DisableSynchronise;
        /* 0x3C8 */ public bool ForceNoninteraction;
        /* 0x3C9 */ public bool ForceOneClickRepair;
        /* 0x3CA */ public bool ForceRemoveUIRenderLayer;
        /* 0x3CB */ public bool HideMaxAmountOnProductSlots;
        /* 0x3CC */ public bool InteractionRequiresPower;
        /* 0x3CD */ public bool InWorldUIUseCameraUp;
        /* 0x3CE */ public bool OpenInteractionOnQuit;
        /* 0x3CF */ public bool ShareInteractionModelRender;
        /* 0x3D0 */ public bool SilenceSuitVOIAlerts;
        /* 0x3D1 */ public bool UseBoundsForIconCentre;
        /* 0x3D2 */ public bool UseInteractionStyleCameraEvent;
        /* 0x3D3 */ public bool UseModelResourceRenderer;
    }
}
