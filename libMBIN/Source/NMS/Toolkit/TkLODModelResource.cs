using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x67A375A47FB01CEA, NameHash = 0xC626640FD5AAB001)]
    public class TkLODModelResource : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public TkModelResource LODModel;
        [NMS(Index = 1)]
        /* 0x84 */ public float Distance;
        [NMS(Index = 2)]
        /* 0x88 */ public float SwapThreshold;
    }
}
