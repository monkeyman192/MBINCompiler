namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xBE610CE1E59DB420, NameHash = 0x55E4C0EB)]
    public class TkCameraAttachmentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float BaseOffset;
        [NMS(Index = 1)]
        /* 0x4 */ public float OffsetScaler;
    }
}
