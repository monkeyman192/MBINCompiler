namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB4702E2ADF2F7506, NameHash = 0x964386EAF98E113C)]
    public class GcCreatureFilename : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ID;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSString0x80 ExtraFilename;
        [NMS(Index = 1)]
        /* 0x90 */ public NMSString0x80 Filename;
    }
}
