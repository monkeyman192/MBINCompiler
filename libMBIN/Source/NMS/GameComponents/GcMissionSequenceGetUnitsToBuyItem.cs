namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCDD71379B855AEC2, NameHash = 0x9DE374680DE23364)]
    public class GcMissionSequenceGetUnitsToBuyItem : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 Item;
        [NMS(Index = 2)]
        /* 0x10 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x90 */ public NMSString0x80 Message;
    }
}
