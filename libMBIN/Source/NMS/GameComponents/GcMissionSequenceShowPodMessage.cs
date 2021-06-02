using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x100, GUID = 0x0A7D9D37A1A02B65, NameHash = 0xA3940C8D106BB96E)]
    public class GcMissionSequenceShowPodMessage : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public NMSString0x80 DebugText;
    }
}
