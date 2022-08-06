using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x367474B2655F5076, NameHash = 0xBF5506070D1A6102)]
    public class GcPlayerSpringAttachmentComponentData : NMSTemplate
    {
        /* 0x00 */ public bool Enabled;
        /* 0x01 */ public NMSString0x40 DebugName;
        /* 0x48 */ public List<GcSpringLink> SpringLinks;
    }
}
