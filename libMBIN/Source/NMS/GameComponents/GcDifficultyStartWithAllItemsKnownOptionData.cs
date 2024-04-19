using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA3C2268C5EE8951, NameHash = 0xBE7C831F4A1A69E6)]
    public class GcDifficultyStartWithAllItemsKnownOptionData : NMSTemplate
    {
        /* 0x000 */ public GcInventoryContainer InitialShipInventory;
        /* 0x158 */ public GcInventoryContainer InitialWeaponInventory;
        /* 0x2B0 */ public GcKnownThingsPreset InitialKnownThings;
    }
}
