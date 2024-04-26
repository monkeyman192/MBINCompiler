using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCA3C2268C5EE8951, NameHash = 0xBE7C831F4A1A69E6)]
    public class GcDifficultyStartWithAllItemsKnownOptionData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public GcInventoryContainer InitialShipInventory;
        [NMS(Index = 2)]
        /* 0x158 */ public GcInventoryContainer InitialWeaponInventory;
        [NMS(Index = 0)]
        /* 0x2B0 */ public GcKnownThingsPreset InitialKnownThings;
    }
}
