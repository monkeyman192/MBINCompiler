using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x40211BF6A482C144, NameHash = 0x89DE1BAB1C9B553D)]
    public class GcMaintenanceGroupInstallData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A InstallSubtitle;
        /* 0x20 */ public NMSString0x20A InstallTitle;
        /* 0x40 */ public NMSString0x20A UninstallSubtitle;
        /* 0x60 */ public NMSString0x20A UninstallTitle;
        /* 0x80 */ public int BuildingSeedOffset;
        /* 0x84 */ public GcMaintenanceElementGroups ItemGroupOverride;
        /* 0x88 */ public GcAudioWwiseEvents OverrideAudioID;
        /* 0x8C */ public bool DismantleIsDelete;
        /* 0x8D */ public bool HideChargingInfo;
        /* 0x8E */ public bool InstallIsFree;
    }
}
