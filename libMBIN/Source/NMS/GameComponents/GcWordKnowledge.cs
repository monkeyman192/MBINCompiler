using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7E2465E15E835B87, NameHash = 0x526EBF38)]
    public class GcWordKnowledge : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Word;
        [NMS(Index = 1, Size = 0x9, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x10 */ public bool[] Races;
    }
}
