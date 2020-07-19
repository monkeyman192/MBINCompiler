using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xF79A2A1AF7C01112, NameHash = 0xAC19C9A74178EED8)]
    public class GcRewardUnlockTitle : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x0 */ public string titleID;
    }
}
