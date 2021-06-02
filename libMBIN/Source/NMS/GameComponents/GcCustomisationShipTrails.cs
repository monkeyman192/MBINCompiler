using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x98, GUID = 0xF0149679F3FBEF56, NameHash = 0x235BD45A5DEBE0D8)]
    public class GcCustomisationShipTrails : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 LinkedTechID;
        /* 0x10 */ public TkTextureResource Trails;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x94 */ public byte[] EndPadding;
    }
}
