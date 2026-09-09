using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEDF81BC3A5170F4B, NameHash = 0x4FBB062D)]
    public class GcDifficultyStartWithAllItemsKnownOptionData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public GcInventoryContainer InitialShipInventory;
        [NMS(Index = 2)]
        /* 0x160 */ public GcInventoryContainer InitialWeaponInventory;
        [NMS(Index = 0)]
        /* 0x2C0 */ public GcKnownThingsPreset InitialKnownThings;
    }
}
