using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB5EB519944E64A89, NameHash = 0xFBADBD2)]
    public class GcMissionConditionStatLevel : NMSTemplate
    {
        [NMS(Index = 10)]
        /* 0x00 */ public NMSString0x10 CompareStat;
        [NMS(Index = 13)]
        /* 0x10 */ public NMSString0x10 FormatItemNameIntoText;
        [NMS(Index = 7)]
        /* 0x20 */ public VariableSizeString FormatStatStyle;
        [NMS(Index = 0)]
        /* 0x30 */ public NMSString0x10 Stat;
        [NMS(Index = 1)]
        /* 0x40 */ public NMSString0x10 StatGroup;
        [NMS(Index = 11)]
        /* 0x50 */ public int DisplayMilestoneNumber;
        [NMS(Index = 2)]
        /* 0x54 */ public int Level;
        [NMS(Index = 3)]
        /* 0x58 */ public int LevelledStatRank;
        [NMS(Index = 12)]
        /* 0x5C */ public TkEqualityEnum Test;
        [NMS(Index = 8)]
        /* 0x60 */ public bool ForceIgnoreLevelledStat;
        [NMS(Index = 9)]
        /* 0x61 */ public bool MulAmountBySeasonTier;
        [NMS(Index = 6)]
        /* 0x62 */ public bool TakeAmountFromMissionStat;
        [NMS(Index = 4)]
        /* 0x63 */ public bool TakeLevelFromSeasonData;
        [NMS(Index = 5)]
        /* 0x64 */ public bool TakeStatFromSeasonData;
    }
}
