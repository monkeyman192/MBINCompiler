namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x949BFD672C55F92C, NameHash = 0x78345334)]
    public class GcFontTableEntry : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString Filename;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Id;
        [NMS(Index = 3)]
        /* 0x20 */ public VariableSizeString LargeOverrideFilename;
        [NMS(Index = 2)]
        /* 0x30 */ public VariableSizeString VROverrideFilename;
        [NMS(Index = 4)]
        /* 0x40 */ public float Spacing;
    }
}
