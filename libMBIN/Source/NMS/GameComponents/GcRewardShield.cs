using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xAA4D1FD4A2A60F64, NameHash = 0x55E2192D51D7971B)]
    public class GcRewardShield : NMSTemplate
    {
        /* 0x0 */ public int AmountMin;
        /* 0x4 */ public int AmountMax;
        /* 0x8 */ public bool ShowOSDOnSuccess;
        /* 0x9 */ public bool ShowOSDOnFail;
    }
}