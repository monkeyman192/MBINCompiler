namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x7188F81C050BDCBE, NameHash = 0x3DF21630)]
    public class TkOpenVRControllerLookup : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString DeviceSpec;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSString0x10 ResetVRViewLayerName;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x20 DeviceKeywords;
    }
}
