namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9609A1E09A79B15, NameHash = 0x4A57F915F84ABBCD)]
    public class GcAlienPuzzleMissionOverride : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Puzzle;
        /* 0x20 */ public NMSString0x10 AltPriorityMissionForSelection;
        /* 0x30 */ public NMSString0x10 Mission;
        /* 0x40 */ public GcSeed OptionalMissionSeed;
        /* 0x50 */ public bool ForceMissionSeed;
    }
}
