using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x48F1C4ABA10746D7, NameHash = 0xC8A6AD07D6C1D49E)]
    public class GcOutSnapSocketCondition : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public NMSString0x10 ObjectId;
        [NMS(Index = 5)]
        /* 0x10 */ public int OutSocketIndex;
        [NMS(Index = 4)]
        /* 0x14 */ public int SnapPointIndex;
        [NMS(Index = 2)]
        /* 0x18 */ public GcBaseSnapState SnapState;
        [NMS(Index = 1)]
        /* 0x1C */ public NMSString0x80 OutSocket;
        [NMS(Index = 0)]
        /* 0x9C */ public NMSString0x80 SnapPoint;
    }
}
