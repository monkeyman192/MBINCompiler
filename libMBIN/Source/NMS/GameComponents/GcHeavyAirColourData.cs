using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x7F4FEC98BB8FF450, NameHash = 0x5D985DDFEB620E01)]
    public class GcHeavyAirColourData : NMSTemplate
    {
        /* 0x000 */ public Colour Colour1;
        /* 0x010 */ public Colour Colour2;
    }
}
