namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF90EE308A4458A80, NameHash = 0xACD740CC9B208196)]
    public class GcMessageTrackTargetAlert : NMSTemplate
    {
        /* 0x00 */ public Vector3f AlertPos;
        /* 0x10 */ public int Attacker;
        /* 0x14 */ public int Victim;
        /* 0x18 */ public bool Primary;
    }
}
