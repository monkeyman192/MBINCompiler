using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x91000A607A20B9A5, NameHash = 0x4FBB062D)]
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
