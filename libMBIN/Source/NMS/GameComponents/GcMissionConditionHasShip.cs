using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4EAAE266BBC7F3C4, NameHash = 0x9511DDC4A0C718D3)]
    public class GcMissionConditionHasShip : NMSTemplate
    {
        /* 0x0 */ public GcInventoryClass ShipInventoryClass;
        /* 0x4 */ public GcSpaceshipClasses ShipType;
        /* 0x8 */ public bool BetterClassMatches;
        /* 0x9 */ public bool CheckAllShips;
        /* 0xA */ public bool DontCheckType;
        /* 0xB */ public bool TakeValueFromSeasonData;
    }
}
