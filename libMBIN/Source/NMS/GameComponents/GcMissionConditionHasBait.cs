namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBF59356D035642BF, NameHash = 0x23791F53)]
    public class GcMissionConditionHasBait : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 SpecificID;
        [NMS(Index = 0)]
        /* 0x10 */ public bool OnlyPrimaryBait;
        [NMS(Index = 1)]
        /* 0x11 */ public bool RequireInBaitBox;
        [NMS(Index = 3)]
        /* 0x12 */ public bool TakeSpecificBaitIDFromSeasonData;
    }
}
