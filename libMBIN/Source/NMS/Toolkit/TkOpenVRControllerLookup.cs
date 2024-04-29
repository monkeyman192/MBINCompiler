namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xBA89BE602B31482E, NameHash = 0x5AFD5621E9999DDA)]
    public class TkOpenVRControllerLookup : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 ResetVRViewLayerName;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x80 DeviceSpec;
        [NMS(Index = 0)]
        /* 0x90 */ public NMSString0x20 DeviceKeywords;
    }
}
