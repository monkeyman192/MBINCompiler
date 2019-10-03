using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x240, Alignment = 0x10, GUID = 0xFDFD8E69BF99E55B, NameHash = 0x479CFCB871ABBE0)]
    public class GcMaintenanceComponentData : NMSTemplate
    {
        /* 0x000 */ public List<GcMaintenanceElement> PreInstalledTech;
        /* 0x010 */ public int VisibleMaintenanceSlots;
        /* 0x014 */ public bool AllowRepair;
        /* 0x015 */ public bool AllowCharge;
        /* 0x016 */ public bool AllowDismantle;
        /* 0x017 */ public bool AllowInstallTech;
        /* 0x018 */ public bool AllowCraftProduct;
        /* 0x019 */ public bool AllowTransfer;
        /* 0x01A */ public bool AllowMoveAndStack;
        /* 0x01B */ public bool AllowTransferIn;
        /* 0x01C */ public bool AutoCompleteOnStart;
        /* 0x01D */ public bool UseModelResourceRenderer;
        /* 0x01E */ public bool UseBoundsForIconCentre;

		public enum InteractableEnum { OnlyWhenComplete, OnlyWhenNotComplete, Always, Never }
		/* 0x20 */ public InteractableEnum Interactable;

        /* 0x024 */ public bool ForceNoninteraction;
        /* 0x028 */ public float CompletedTransitionDelay;
        /* 0x02C */ public bool ShareInteractionModelRender;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x02D */ public byte[] Padding2D;

        /* 0x030 */ public TkModelRendererData ModelRendererData;
        /* 0x0E0 */ public TkModelRendererData ModelRendererDataAlt;

		public enum ModelRendererResourceEnum { ModelNode, MasterModelNode }
		/* 0x190 */ public ModelRendererResourceEnum ModelRendererResource;

        /* 0x194 */ public GcBroadcastLevel BroadcastLevel;

        [NMS(Size = 0x20)]
        /* 0x198 */ public string Title;
        [NMS(Size = 0x20)]
        /* 0x1B8 */ public string Description;
        [NMS(Size = 0x20)]
        /* 0x1D8 */ public string ActionButtonOverride;
        [NMS(Size = 0x20)]
        /* 0x1F8 */ public string ActionDescriptionOverride;
        [NMS(Size = 0x20)]
        /* 0x218 */ public string ActionWarningOverride;
        /* 0x238 */ public float InWorldUIScaler;
        /* 0x23C */ public bool InteractionRequiresPower;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x23D */ public byte[] EndPadding;
    }
}
