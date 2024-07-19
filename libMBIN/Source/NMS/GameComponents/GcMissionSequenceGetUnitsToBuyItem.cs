namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB1267714F205DD09, NameHash = 0xF9C8C667)]
    public class GcMissionSequenceGetUnitsToBuyItem : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSString0x10 Item;
        [NMS(Index = 0)]
        /* 0x20 */ public VariableSizeString Message;
    }
}
