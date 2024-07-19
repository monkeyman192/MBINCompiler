namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5A4C774F70FC9BB5, NameHash = 0xA1524EBD)]
    public class GcMissionConditionNearScanEvent : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Event;
        [NMS(Index = 1)]
        /* 0x20 */ public float Distance;
        [NMS(Index = 2)]
        /* 0x24 */ public bool AllowInShip;
        [NMS(Index = 4)]
        /* 0x25 */ public bool MustMatchThisMissionIDSeed;
        [NMS(Index = 3)]
        /* 0x26 */ public bool RequiresFullFireteam;
        [NMS(Index = 5)]
        /* 0x27 */ public bool ReturnTrueIfMarkerGone;
    }
}
