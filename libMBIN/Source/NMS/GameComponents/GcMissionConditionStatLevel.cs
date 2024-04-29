using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8C025A35408CC58, NameHash = 0xA56864A865FEBE6D)]
    public class GcMissionConditionStatLevel : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x00 */ public NMSString0x10 CompareStat;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSString0x10 Stat;
        [NMS(Index = 1)]
        /* 0x20 */ public NMSString0x10 StatGroup;
        [NMS(Index = 7)]
        /* 0x30 */ public int DisplayMilestoneNumber;
        [NMS(Index = 2)]
        /* 0x34 */ public int Level;
        [NMS(Index = 3)]
        /* 0x38 */ public int LevelledStatRank;
        [NMS(Index = 8)]
        /* 0x3C */ public TkEqualityEnum Test;
        [NMS(Index = 5)]
        /* 0x40 */ public bool ForceIgnoreLevelledStat;
        [NMS(Index = 4)]
        /* 0x41 */ public bool TakeLevelFromSeasonData;
    }
}
