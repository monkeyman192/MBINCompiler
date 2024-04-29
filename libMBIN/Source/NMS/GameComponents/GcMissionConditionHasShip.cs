using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x15EB331F9AA3D871, NameHash = 0x9511DDC4A0C718D3)]
    public class GcMissionConditionHasShip : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcInventoryClass ShipInventoryClass;
        [NMS(Index = 0)]
        /* 0x4 */ public GcSpaceshipClasses ShipType;
        [NMS(Index = 3)]
        /* 0x8 */ public bool BetterClassMatches;
        [NMS(Index = 2)]
        /* 0x9 */ public bool CheckAllShips;
        [NMS(Index = 4)]
        /* 0xA */ public bool DontCheckType;
        [NMS(Index = 5)]
        /* 0xB */ public bool TakeValueFromSeasonData;
    }
}
