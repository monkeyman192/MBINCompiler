using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9E8F9A2C82494267, NameHash = 0x6F313AAA)]
    public class GcNPCInteractionData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkAttachmentData Data;
        [NMS(Index = 0)]
        /* 0x38 */ public NMSString0x10 ID;
    }
}
