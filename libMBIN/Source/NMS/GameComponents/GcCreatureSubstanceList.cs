using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xB3C767FF4D0287A2, NameHash = 0xF0ECF4376CE90B93)]
    public class GcCreatureSubstanceList : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string CreatureType;
        [NMS(Size = 0x10)]
        public string Item;
    }
}
