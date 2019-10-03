using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x65B3EC85D2F35211, NameHash = 0x502F1C3425CDC8EC)]
    public class TkSceneNodeAttributeData : NMSTemplate     // size: 0x130
    {
        [NMS(Size = 0x10)]
        public string Name;
        [NMS(Size = 0x20)]
        public string AltID;
        [NMS(Size = 0x100)]
        public string Value;
    }
}
