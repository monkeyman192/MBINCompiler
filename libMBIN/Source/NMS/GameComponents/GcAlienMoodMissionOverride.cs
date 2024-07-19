using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7185897A1C71FD16, NameHash = 0xD2CF978B)]
    public class GcAlienMoodMissionOverride : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Mission;
        [NMS(Index = 1)]
        /* 0x10 */ public GcAlienMood Mood;
    }
}
