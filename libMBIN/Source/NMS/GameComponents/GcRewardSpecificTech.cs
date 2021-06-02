using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, Alignment = 0x8, GUID = 0xFEB1FC5E038A21E6, NameHash = 0xDABE4D9A95799081)]
    public class GcRewardSpecificTech : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 TechId;
        /* 0x10 */ public bool AutoPin;
        /* 0x11 */ public bool Silent;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x12 */ public byte[] EndPadding;
    }
}
