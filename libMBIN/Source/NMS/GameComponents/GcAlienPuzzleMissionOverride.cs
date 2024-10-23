namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x882D4CCF94867AC, NameHash = 0xBC60B5DE)]
    public class GcAlienPuzzleMissionOverride : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A Puzzle;
        [NMS(Index = 7)]
        /* 0x20 */ public NMSString0x20A RequireScanEventActive;
        [NMS(Index = 4)]
        /* 0x40 */ public NMSString0x10 AltPriorityMissionForSelection;
        [NMS(Index = 0)]
        /* 0x50 */ public NMSString0x10 Mission;
        [NMS(Index = 1)]
        /* 0x60 */ public GcSeed OptionalMissionSeed;
        [NMS(Index = 3)]
        /* 0x70 */ public bool ForceMissionSeed;
        [NMS(Index = 6)]
        /* 0x71 */ public bool RequireMainMissionActiveWhenUsingAlt;
        [NMS(Index = 5)]
        /* 0x72 */ public bool RequireMainMissionSelected;
    }
}
