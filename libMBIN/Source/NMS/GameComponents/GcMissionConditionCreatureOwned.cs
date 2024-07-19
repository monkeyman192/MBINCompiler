using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF5C5265468821A32, NameHash = 0x856C2A5E)]
    public class GcMissionConditionCreatureOwned : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x10 SpecificCreatureID;
        [NMS(Index = 0)]
        /* 0x10 */ public int Amount;
        [NMS(Index = 1)]
        /* 0x14 */ public TkEqualityEnum Test;
        [NMS(Index = 3)]
        /* 0x18 */ public bool AnyPredator;
    }
}
