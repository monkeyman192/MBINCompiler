using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x97E40C9FAEC771F, NameHash = 0xDEC89720)]
    public class GcMaintenanceComponentData : NMSTemplate
    {
        [NMS(Index = 23)]
        /* 0x000 */ public TkModelRendererData ModelRenderData;
        [NMS(Index = 24)]
        /* 0x0B0 */ public TkModelRendererData ModelRenderDataAlt;
        [NMS(Index = 53)]
        /* 0x160 */ public GcMaintenanceGroupInstallData GroupInstallSetup;
        [NMS(Index = 29)]
        /* 0x1F0 */ public NMSString0x20A ActionButtonOverride;
        [NMS(Index = 30)]
        /* 0x210 */ public NMSString0x20A ActionDescriptionOverride;
        [NMS(Index = 37)]
        /* 0x230 */ public NMSString0x20A ActionWarningOverride;
        [NMS(Index = 35)]
        /* 0x250 */ public NMSString0x20A ChargeButtonOverride;
        [NMS(Index = 36)]
        /* 0x270 */ public NMSString0x20A ChargeDescriptionOverride;
        [NMS(Index = 28)]
        /* 0x290 */ public NMSString0x20A Description;
        [NMS(Index = 33)]
        /* 0x2B0 */ public NMSString0x20A DiscardButtonOverride;
        [NMS(Index = 34)]
        /* 0x2D0 */ public NMSString0x20A DiscardDescriptionOverride;
        [NMS(Index = 27)]
        /* 0x2F0 */ public NMSString0x20A Title;
        [NMS(Index = 31)]
        /* 0x310 */ public NMSString0x20A TransferButtonOverride;
        [NMS(Index = 32)]
        /* 0x330 */ public NMSString0x20A TransferDescriptionOverride;
        [NMS(Index = 49)]
        /* 0x350 */ public List<NMSString0x10> ForceDamageDuringMissions;
        [NMS(Index = 48)]
        /* 0x360 */ public NMSString0x10 GiveRewardOnCompletion;
        [NMS(Index = 0)]
        /* 0x370 */ public List<GcMaintenanceElement> PreInstalledTech;
        [NMS(Index = 47)]
        /* 0x380 */ public NMSString0x10 StartMissionOnCompletion;
        [NMS(Index = 46)]
        /* 0x390 */ public NMSString0x10 StartMissionOnUse;
        [NMS(Index = 15)]
        /* 0x3A0 */ public Vector2f CustomIconCentre;
        [NMS(Index = 52)]
        /* 0x3A8 */ public GcAudioWwiseEvents AudioIDOnSuccess;
        [NMS(Index = 26)]
        /* 0x3AC */ public GcBroadcastLevel BroadcastLevel;
        [NMS(Index = 20)]
        /* 0x3B0 */ public float CompletedTransitionDelay;
        // size: 0x4
        public enum InteractableEnum : uint {
            OnlyWhenComplete,
            OnlyWhenNotComplete,
            Always,
            Never,
        }
        [NMS(Index = 18)]
        /* 0x3B4 */ public InteractableEnum Interactable;
        [NMS(Index = 42)]
        /* 0x3B8 */ public float InWorldUIForcedOffset;
        [NMS(Index = 43)]
        /* 0x3BC */ public float InWorldUIForcedOffsetV2;
        [NMS(Index = 40)]
        /* 0x3C0 */ public float InWorldUIMinDistOverride;
        [NMS(Index = 41)]
        /* 0x3C4 */ public float InWorldUIMinDistOverrideV2;
        [NMS(Index = 39)]
        /* 0x3C8 */ public float InWorldUIScaler;
        // size: 0x2
        public enum ModelRendererResourceEnum : uint {
            ModelNode,
            MasterModelNode,
        }
        [NMS(Index = 25)]
        /* 0x3CC */ public ModelRendererResourceEnum ModelRendererResource;
        [NMS(Index = 1)]
        /* 0x3D0 */ public int VisibleMaintenanceSlots;
        [NMS(Index = 3)]
        /* 0x3D4 */ public bool AllowCharge;
        [NMS(Index = 7)]
        /* 0x3D5 */ public bool AllowCraftProduct;
        [NMS(Index = 5)]
        /* 0x3D6 */ public bool AllowDiscard;
        [NMS(Index = 4)]
        /* 0x3D7 */ public bool AllowDismantle;
        [NMS(Index = 6)]
        /* 0x3D8 */ public bool AllowInstallTech;
        [NMS(Index = 9)]
        /* 0x3D9 */ public bool AllowMoveAndStack;
        [NMS(Index = 11)]
        /* 0x3DA */ public bool AllowPinning;
        [NMS(Index = 2)]
        /* 0x3DB */ public bool AllowRepair;
        [NMS(Index = 8)]
        /* 0x3DC */ public bool AllowTransfer;
        [NMS(Index = 10)]
        /* 0x3DD */ public bool AllowTransferIn;
        [NMS(Index = 12)]
        /* 0x3DE */ public bool AutoCompleteOnStart;
        [NMS(Index = 54)]
        /* 0x3DF */ public bool DisableSynchronise;
        [NMS(Index = 19)]
        /* 0x3E0 */ public bool ForceNoninteraction;
        [NMS(Index = 51)]
        /* 0x3E1 */ public bool ForceOneClickRepair;
        [NMS(Index = 16)]
        /* 0x3E2 */ public bool ForceRemoveUIRenderLayer;
        [NMS(Index = 17)]
        /* 0x3E3 */ public bool HideMaxAmountOnProductSlots;
        [NMS(Index = 45)]
        /* 0x3E4 */ public bool InteractionRequiresPower;
        [NMS(Index = 44)]
        /* 0x3E5 */ public bool InWorldUIUseCameraUp;
        [NMS(Index = 50)]
        /* 0x3E6 */ public bool OpenInteractionOnQuit;
        [NMS(Index = 21)]
        /* 0x3E7 */ public bool ShareInteractionModelRender;
        [NMS(Index = 38)]
        /* 0x3E8 */ public bool SilenceSuitVOIAlerts;
        [NMS(Index = 14)]
        /* 0x3E9 */ public bool UseBoundsForIconCentre;
        [NMS(Index = 22)]
        /* 0x3EA */ public bool UseInteractionStyleCameraEvent;
        [NMS(Index = 13)]
        /* 0x3EB */ public bool UseModelResourceRenderer;
    }
}
