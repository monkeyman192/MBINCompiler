namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF90EE308A4458A80, NameHash = 0xACD740CC9B208196)]
    public class GcMessageTrackTargetAlert : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public Vector3f AlertPos;
        [NMS(Index = 0)]
        /* 0x10 */ public int Attacker;
        [NMS(Index = 1)]
        /* 0x14 */ public int Victim;
        [NMS(Index = 3)]
        /* 0x18 */ public bool Primary;
    }
}
