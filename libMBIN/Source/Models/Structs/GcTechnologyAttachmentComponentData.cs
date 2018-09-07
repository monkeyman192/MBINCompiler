using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcTechnologyAttachmentComponentData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> Techs;

		public enum InventoryEnum { Vehicle }
		public InventoryEnum Inventory;
        /* 0x14 */ public bool Inverted;
    }
}
