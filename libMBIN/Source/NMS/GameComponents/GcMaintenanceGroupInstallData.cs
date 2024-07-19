using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCD2C5BF6A4C82CFB, NameHash = 0x8E28E2A0)]
    public class GcMaintenanceGroupInstallData : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public NMSString0x20A InstallSubtitle;
        [NMS(Index = 4)]
        /* 0x20 */ public NMSString0x20A InstallTitle;
        [NMS(Index = 7)]
        /* 0x40 */ public NMSString0x20A UninstallSubtitle;
        [NMS(Index = 6)]
        /* 0x60 */ public NMSString0x20A UninstallTitle;
        [NMS(Index = 8)]
        /* 0x80 */ public int BuildingSeedOffset;
        [NMS(Index = 0)]
        /* 0x84 */ public GcMaintenanceElementGroups ItemGroupOverride;
        [NMS(Index = 9)]
        /* 0x88 */ public GcAudioWwiseEvents OverrideAudioID;
        [NMS(Index = 1)]
        /* 0x8C */ public bool DismantleIsDelete;
        [NMS(Index = 3)]
        /* 0x8D */ public bool HideChargingInfo;
        [NMS(Index = 2)]
        /* 0x8E */ public bool InstallIsFree;
    }
}
