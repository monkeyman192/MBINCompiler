using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9CC12C54EEB80742, NameHash = 0xBB7B4EAD531E3D6)]
    public class GcNPCInteractionData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public TkAttachmentData Data;
    }
}
