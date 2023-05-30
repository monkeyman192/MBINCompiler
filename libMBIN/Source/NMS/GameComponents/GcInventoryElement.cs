using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcInventoryElement : NMSTemplate
    {
        public GcInventoryType Type;
        [NMS(Ignore = true)]
        public int EmptyNode1;
        public NMSString0x10 Id;
        public int Amount;
        public int MaxAmount;
        public float DamageFactor;
        public GcInventoryIndex Index;
        [NMS(Ignore = true)]
        public int EmptyNode2;
    }
}
