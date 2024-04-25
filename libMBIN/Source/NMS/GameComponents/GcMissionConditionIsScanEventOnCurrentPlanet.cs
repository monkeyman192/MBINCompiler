namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB6A0C3109DCEDE9E, NameHash = 0xEB5EF017837D2565)]
    public class GcMissionConditionIsScanEventOnCurrentPlanet : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Event;
        [NMS(Index = 1)]
        /* 0x20 */ public bool AllowInShip;
    }
}
