namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xED23B8C9CF7CCF62, NameHash = 0x122FE9C1D39C44F6)]
    public class TkIdSceneFilename : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Id;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x80 Filename;
    }
}
