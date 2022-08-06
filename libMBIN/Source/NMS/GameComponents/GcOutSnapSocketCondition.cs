using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7B90E39D84CAF8D7, NameHash = 0xC8A6AD07D6C1D49E)]
    public class GcOutSnapSocketCondition : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 SnapPoint;
        /* 0x080 */ public NMSString0x80 OutSocket;
        /* 0x100 */ public GcBaseSnapState SnapState;
        /* 0x108 */ public NMSString0x10 ObjectId;
        /* 0x118 */ public int SnapPointIndex;
        /* 0x11C */ public int OutSocketIndex;
    }
}
