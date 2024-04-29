using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7F4E10F8A3B72688, NameHash = 0xC127D8D3D9D7F5D8)]
    public class GcRewardSalvageShip : NMSTemplate
    {
        [NMS(Index = 1, Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x00 */ public NMSString0x10[] SpecificCustomisationSlotIDs;
        [NMS(Index = 0)]
        /* 0xA0 */ public bool RewardShipParts;
    }
}
