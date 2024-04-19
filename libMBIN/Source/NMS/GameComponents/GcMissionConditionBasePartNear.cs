namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6411000DEAB2BDC4, NameHash = 0x12DE4C36058305CA)]
    public class GcMissionConditionBasePartNear : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 PartID;
        /* 0x10 */ public float Distance;
        /* 0x14 */ public bool TakeIDFromSeasonData;
    }
}
