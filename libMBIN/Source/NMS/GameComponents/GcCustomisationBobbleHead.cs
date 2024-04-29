using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBA3698FC5728B5DE, NameHash = 0x2137035790C4EDC0)]
    public class GcCustomisationBobbleHead : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 LinkedTechId;
        [NMS(Index = 1)]
        /* 0x10 */ public TkModelResource BobbleHead;
    }
}
