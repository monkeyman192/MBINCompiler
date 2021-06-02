using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0xB3C767FF4D0287A2, NameHash = 0xF0ECF4376CE90B93)]
    public class GcCreatureSubstanceList : NMSTemplate
    {
        public NMSString0x10 CreatureType;
        public NMSString0x10 Item;
    }
}