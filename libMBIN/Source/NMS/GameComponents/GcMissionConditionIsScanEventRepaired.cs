namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x271D912CDFACA1AB, NameHash = 0xA601980170B475C0)]
    public class GcMissionConditionIsScanEventRepaired : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Event;
        [NMS(Index = 1)]
        /* 0x20 */ public bool CheckForAllRepairsInBuilding;
        [NMS(Index = 2)]
        /* 0x21 */ public bool OnlyCheckRequiresEmptySlotTypes;
    }
}
