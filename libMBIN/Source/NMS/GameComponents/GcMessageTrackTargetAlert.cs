namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6612E5ED349DC772, NameHash = 0x3921F6BD)]
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
