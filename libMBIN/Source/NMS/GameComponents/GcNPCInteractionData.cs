using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7A6AB24B3910461E, NameHash = 0xBB7B4EAD531E3D6)]
    public class GcNPCInteractionData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public TkAttachmentData Data;
        [NMS(Index = 0)]
        /* 0x28 */ public NMSString0x10 ID;
    }
}
