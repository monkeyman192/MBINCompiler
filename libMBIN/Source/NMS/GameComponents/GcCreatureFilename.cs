namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x41AE8DDA4B46C639, NameHash = 0x5AD86084)]
    public class GcCreatureFilename : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public VariableSizeString ExtraFilename;
        [NMS(Index = 1)]
        /* 0x10 */ public VariableSizeString Filename;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 ID;
    }
}
