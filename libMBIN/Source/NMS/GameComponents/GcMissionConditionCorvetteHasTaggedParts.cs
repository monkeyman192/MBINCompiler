using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBD1C01DB4DB5D904, NameHash = 0x6A2D282D)]
    public class GcMissionConditionCorvetteHasTaggedParts : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public NMSString0x10 SpecificItem;
        [NMS(Index = 1)]
        /* 0x10 */ public int Amount;
        // size: 0x2
        public enum CorvetteToQueryEnum : uint {
            PrimaryShip,
            Draft,
        }
        [NMS(Index = 4)]
        /* 0x14 */ public CorvetteToQueryEnum CorvetteToQuery;
        [NMS(Index = 0)]
        /* 0x18 */ public GcCorvettePartCategory PartType;
        [NMS(Index = 3)]
        /* 0x1C */ public TkEqualityEnum Test;
        [NMS(Index = 5)]
        /* 0x20 */ public bool AlsoCountPartsInInventory;
        [NMS(Index = 2)]
        /* 0x21 */ public bool TakeAmountFromSeasonData;
        [NMS(Index = 7)]
        /* 0x22 */ public bool UseSpecificItemOnlyForText;
    }
}
