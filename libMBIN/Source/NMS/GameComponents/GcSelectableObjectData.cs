using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x3AC56A6710928927, NameHash = 0xABB922E067F5CB40)]
    public class GcSelectableObjectData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Filename;
    }
}
