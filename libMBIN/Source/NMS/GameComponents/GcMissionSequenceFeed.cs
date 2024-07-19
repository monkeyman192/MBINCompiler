namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE3899A0F98257310, NameHash = 0x5E3CACC1)]
    public class GcMissionSequenceFeed : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 3)]
        /* 0x20 */ public int AmountMax;
        [NMS(Index = 2)]
        /* 0x24 */ public int AmountMin;
        [NMS(Index = 1)]
        /* 0x28 */ public bool RequireSpecificBait;
    }
}
