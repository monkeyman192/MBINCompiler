using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8AD6D9760D21ED40, NameHash = 0xA56864A865FEBE6D)]
    public class GcMissionConditionStatLevel : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 CompareStat;
        /* 0x10 */ public NMSString0x10 Stat;
        /* 0x20 */ public NMSString0x10 StatGroup;
        /* 0x30 */ public int DisplayMilestoneNumber;
        /* 0x34 */ public int Level;
        /* 0x38 */ public int LevelledStatRank;
        /* 0x3C */ public TkEqualityEnum Test;
        /* 0x40 */ public bool ForceIgnoreLevelledStat;
        /* 0x41 */ public bool TakeLevelFromSeasonData;
    }
}
