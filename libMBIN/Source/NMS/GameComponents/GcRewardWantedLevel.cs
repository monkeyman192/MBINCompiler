namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB5CDE7C45B68F851, NameHash = 0xEE96EA03)]
    public class GcRewardWantedLevel : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Message;
        [NMS(Index = 1)]
        /* 0x20 */ public int Level;
    }
}
