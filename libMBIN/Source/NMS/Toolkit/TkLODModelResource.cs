using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x8C, GUID = 0xB8D561F082A01C10, NameHash = 0xC626640FD5AAB001)]
    public class TkLODModelResource : NMSTemplate
    {
        /* 0x00 */ public TkModelResource LODModel;
        /* 0x84 */ public float Distance;
        /* 0x88 */ public float SwapThreshold;
    }
}
