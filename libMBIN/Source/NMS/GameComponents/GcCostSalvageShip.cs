using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x39FA18D3EA1B3F1B, NameHash = 0x9A04247FE2D03F05)]
    public class GcCostSalvageShip : NMSTemplate
    {
        [NMS(Size = 0xA, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x000 */ public NMSString0x20A[] ShipClassStringOverride;
        /* 0x140 */ public bool CannotAffordIfStringOverrideIsNull;
        /* 0x141 */ public bool WillGiveShipParts;
    }
}
