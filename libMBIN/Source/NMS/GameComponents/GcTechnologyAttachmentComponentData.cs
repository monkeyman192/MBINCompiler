using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7168E53F55CDAD62, NameHash = 0x1CECD102)]
    public class GcTechnologyAttachmentComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<NMSString0x10> Techs;
        // size: 0x1
        public enum InventoryEnum : uint {
            Vehicle,
        }
        [NMS(Index = 1)]
        /* 0x10 */ public InventoryEnum Inventory;
        [NMS(Index = 2)]
        /* 0x14 */ public bool Inverted;
    }
}
