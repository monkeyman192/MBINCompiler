using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4BE6FE4C814CFCCE, NameHash = 0x9A04247FE2D03F05)]
    public class GcCostSalvageShip : NMSTemplate
    {
        [NMS(Index = 1, Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x000 */ public NMSString0x20A[] ShipClassStringOverride;
        [NMS(Index = 2)]
        /* 0x140 */ public bool CannotAffordIfStringOverrideIsNull;
        [NMS(Index = 0)]
        /* 0x141 */ public bool WillGiveShipParts;
    }
}
