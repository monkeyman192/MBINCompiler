using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x988A28699F489DCB, NameHash = 0xF6CA47F9F51F553F)]
    public class GcCostInstalledTech : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;		
        public enum InventoryToCheckEnum { All, Suit, Ship, Weapon, Freighter, Buggy }
        /* 0x10 */ public InventoryToCheckEnum InventoryToCheck;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14 */ public byte[] EndPadding;
    }
}