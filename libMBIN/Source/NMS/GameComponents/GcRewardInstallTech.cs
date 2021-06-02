using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x3F521E3791894C14, NameHash = 0x75DF796697F3DB0A)]
    public class GcRewardInstallTech : NMSTemplate
    {
		/* 0x00 */ public NMSString0x10 TechId;
        public enum InventoryToInstallInEnum { Personal, PersonalTech, Ship, ShipTech, Freighter, Vehicle, Weapon };
        /* 0x10 */ public InventoryToInstallInEnum InventoryToInstallIn;
        /* 0x14 */ public bool Silent;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x15 */ public byte[] EndPadding;
    }
}