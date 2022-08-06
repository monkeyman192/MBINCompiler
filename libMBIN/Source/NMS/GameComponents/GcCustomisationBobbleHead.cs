using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x359044F0ECE101F8, NameHash = 0x2137035790C4EDC0)]
    public class GcCustomisationBobbleHead : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 LinkedTechId;
        /* 0x10 */ public TkModelResource BobbleHead;
    }
}
