namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x383DBEA33F7678A9, NameHash = 0x4A57F915F84ABBCD)]
    public class GcAlienPuzzleMissionOverride : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A Puzzle;
        [NMS(Index = 4)]
        /* 0x20 */ public NMSString0x10 AltPriorityMissionForSelection;
        [NMS(Index = 0)]
        /* 0x30 */ public NMSString0x10 Mission;
        [NMS(Index = 1)]
        /* 0x40 */ public GcSeed OptionalMissionSeed;
        [NMS(Index = 3)]
        /* 0x50 */ public bool ForceMissionSeed;
    }
}
