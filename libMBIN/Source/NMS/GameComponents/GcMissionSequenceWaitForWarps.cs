namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x42B535CCE92B03DE, NameHash = 0x289105D5)]
    public class GcMissionSequenceWaitForWarps : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public int Amount;
    }
}
