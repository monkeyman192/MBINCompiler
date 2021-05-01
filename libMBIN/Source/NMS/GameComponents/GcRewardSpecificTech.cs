using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, Alignment = 0x8, GUID = 0x7E6246CFE3EF3C03, NameHash = 0xDABE4D9A95799081)]
    public class GcRewardSpecificTech : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string TechId;
        /* 0x10 */ public bool AutoPin;
        /* 0x11 */ public bool Silent;
        [NMS(Size = 0x6, Ignore = true)]
        /* 0x12 */ public byte[] EndPadding;
    }
}
