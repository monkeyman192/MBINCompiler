using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x610C003647B17DC8, NameHash = 0xDABE4D9A95799081)]
    public class GcRewardSpecificTech : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 TechId;
        /* 0x10 */ public bool AutoPin;
        /* 0x11 */ public bool Silent;
        /* 0x12 */ public bool HideInSeasonRewards;
    }
}
