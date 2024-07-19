using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xBFDAADDFB3508982, NameHash = 0x81D3809C)]
    public class TkLODModelResource : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkModelResource LODModel;
        [NMS(Index = 1)]
        /* 0x18 */ public float Distance;
        [NMS(Index = 2)]
        /* 0x1C */ public float SwapThreshold;
    }
}
