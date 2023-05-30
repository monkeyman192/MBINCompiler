using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    public class GcInventoryContainer : NMSTemplate // 0x20 bytes
    {
        public List<GcInventoryElement> Slots;
        public List<GcInventoryIndex> ValidSlotIndices;
    }
}
