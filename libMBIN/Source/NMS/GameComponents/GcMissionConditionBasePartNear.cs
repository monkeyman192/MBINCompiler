namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6411000DEAB2BDC4, NameHash = 0x12DE4C36058305CA)]
    public class GcMissionConditionBasePartNear : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 PartID;
        [NMS(Index = 2)]
        /* 0x10 */ public float Distance;
        [NMS(Index = 1)]
        /* 0x14 */ public bool TakeIDFromSeasonData;
    }
}
