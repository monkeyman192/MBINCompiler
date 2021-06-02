using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x130, GUID = 0x65B3EC85D2F35211, NameHash = 0x502F1C3425CDC8EC)]
    public class TkSceneNodeAttributeData : NMSTemplate     // size: 0x130
    {
        public NMSString0x10 Name;
        public NMSString0x20 AltID;
        public NMSString0x100 Value;
    }
}