using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA275435C36C943E1, NameHash = 0xA8ECA)]
    public class GcWeaponInventoryMaxUpgradeCapacity : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x4, EnumType = typeof(GcInventoryClass.InventoryClassEnum))]
        /* 0x0 */ public int[] MaxInventoryCapacity;
    }
}
