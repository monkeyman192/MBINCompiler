using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x48F1C4ABA10746D7, NameHash = 0xC8A6AD07D6C1D49E)]
    public class GcOutSnapSocketCondition : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ObjectId;
        /* 0x10 */ public int OutSocketIndex;
        /* 0x14 */ public int SnapPointIndex;
        /* 0x18 */ public GcBaseSnapState SnapState;
        /* 0x1C */ public NMSString0x80 OutSocket;
        /* 0x9C */ public NMSString0x80 SnapPoint;
    }
}
