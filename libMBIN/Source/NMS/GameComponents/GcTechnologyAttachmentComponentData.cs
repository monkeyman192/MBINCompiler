using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x30BE414835A620E, NameHash = 0x7CCA2E6781CC7070)]
    public class GcTechnologyAttachmentComponentData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> Techs;

		public enum InventoryEnum { Vehicle }
		public InventoryEnum Inventory;
        /* 0x14 */ public bool Inverted;
    }
}
