using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBC112DF5594C83C6, NameHash = 0xCEA77CD4)]
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
