using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x80, GUID = 0xD616F53EB85ECEEC, NameHash = 0xD51346A323488A3E)]
    public class GcBlockedMessage : NMSTemplate        // size: 0x80
    {
        public NMSString0x80 MessageID;
    }
}