using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA440BC946753A2E4, NameHash = 0x42144093)]
    public class GcPlanetInfo : NMSTemplate
    {
        [NMS(Index = 6, Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x000 */ public NMSString0x80[] SentinelsPerDifficulty;
        [NMS(Index = 5)]
        /* 0x200 */ public NMSString0x80 Fauna;
        [NMS(Index = 4)]
        /* 0x280 */ public NMSString0x80 Flora;
        [NMS(Index = 0)]
        /* 0x300 */ public NMSString0x80 PlanetDescription;
        [NMS(Index = 1)]
        /* 0x380 */ public NMSString0x80 PlanetType;
        [NMS(Index = 3)]
        /* 0x400 */ public NMSString0x80 Resources;
        [NMS(Index = 2)]
        /* 0x480 */ public NMSString0x80 Weather;
        [NMS(Index = 7, Size = 0x4, EnumType = typeof(GcCombatTimerDifficultyOption.CombatTimerDifficultyOptionEnum))]
        /* 0x500 */ public bool[] SentinelHighlightPerDifficulty;
        [NMS(Index = 8)]
        /* 0x504 */ public bool IsWeatherExtreme;
        [NMS(Index = 9)]
        /* 0x505 */ public bool SpecialFauna;
    }
}
