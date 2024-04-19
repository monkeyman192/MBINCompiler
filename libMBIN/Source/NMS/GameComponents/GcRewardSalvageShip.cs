using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x429BAEC272104F10, NameHash = 0xC127D8D3D9D7F5D8)]
    public class GcRewardSalvageShip : NMSTemplate
    {
        [NMS(Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x00 */ public NMSString0x10[] SpecificCustomisationSlotIDs;
        /* 0xA0 */ public bool RewardShipParts;
    }
}
