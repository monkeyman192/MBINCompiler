using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB3617F01FF3C2D0D, NameHash = 0x30324FBB2A97B16E)]
    public class GcWordKnowledge : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Word;
        [NMS(Size = 8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x10 */ public bool[] Races;
    }
}
