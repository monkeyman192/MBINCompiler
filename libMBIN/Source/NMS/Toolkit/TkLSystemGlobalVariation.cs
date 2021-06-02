using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0xA4, GUID = 0x381C116EDA8419EA, NameHash = 0xF818362C38FEA359)]
    public class TkLSystemGlobalVariation : NMSTemplate
    {
        public NMSString0x20 Name;
        public NMSString0x80 Model;

        public int Variations;
    }
}