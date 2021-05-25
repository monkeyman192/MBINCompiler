using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x27B4FEC32B042806, NameHash = 0xBC8B5F2250F65891)]
    public class GcShipDialogueTreeEnum : NMSTemplate
    {
        // size: 0x7
        public enum DialogueTreeEnum { Bribe, Beg, Ambush, Trade, Help, Goods, Hostile }
		public DialogueTreeEnum DialogueTree;
    }
}