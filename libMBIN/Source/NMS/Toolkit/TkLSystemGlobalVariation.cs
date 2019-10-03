using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x381C116EDA8419EA, NameHash = 0xF818362C38FEA359)]
    public class TkLSystemGlobalVariation : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Name;
        [NMS(Size = 0x80)]
        public string Model;

        public int Variations;
    }
}
