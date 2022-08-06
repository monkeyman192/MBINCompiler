using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9C42F3A1D0B5AE7D, NameHash = 0xA56864A865FEBE6D)]
    public class GcMissionConditionStatLevel : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Stat;
        /* 0x10 */ public NMSString0x10 StatGroup;
        /* 0x20 */ public int Level;
        /* 0x24 */ public bool TakeLevelFromSeasonData;
        /* 0x25 */ public bool ForceIgnoreLevelledStat;
        /* 0x28 */ public NMSString0x10 CompareStat;
        /* 0x38 */ public int DisplayMilestoneNumber;
        /* 0x3C */ public TkEqualityEnum Test;
    }
}
