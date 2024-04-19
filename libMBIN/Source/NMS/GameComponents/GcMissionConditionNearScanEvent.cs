namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBAC1B3D2509B3C8A, NameHash = 0x8F7E57B730A9C7F8)]
    public class GcMissionConditionNearScanEvent : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Event;
        /* 0x20 */ public float Distance;
        /* 0x24 */ public bool AllowInShip;
        /* 0x25 */ public bool MustMatchThisMissionIDSeed;
        /* 0x26 */ public bool RequiresFullFireteam;
        /* 0x27 */ public bool ReturnTrueIfMarkerGone;
    }
}
