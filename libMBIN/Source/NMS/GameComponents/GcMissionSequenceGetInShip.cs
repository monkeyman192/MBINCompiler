namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF0B747A4B2238A71, NameHash = 0x5C890E29)]
    public class GcMissionSequenceGetInShip : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
    }
}
