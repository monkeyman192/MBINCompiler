using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4B9BAF4E53AB1B89, NameHash = 0xB9769DB00B6A3E69)]
    public class GcMissionSequenceBuild : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public GcBuildingPartSearchType Type;
        [NMS(Index = 1)]
        /* 0x018 */ public NMSString0x10 Part;
        [NMS(Index = 5)]
        /* 0x028 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x0A8 */ public NMSString0x80 Message;
        [NMS(Index = 2)]
        /* 0x128 */ public bool TakePartFromSeasonData;
        [NMS(Index = 3)]
        /* 0x129 */ public bool TeachIfNotKnown;
    }
}
