namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB20AA54605F1A524, NameHash = 0xA6F481EC)]
    public class TkIdSceneFilename : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString Filename;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Id;
    }
}
