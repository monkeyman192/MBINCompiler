using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4B9BAF4E53AB1B89, NameHash = 0xB9769DB00B6A3E69)]
    public class GcMissionSequenceBuild : NMSTemplate
    {
        /* 0x000 */ public GcBuildingPartSearchType Type;
        /* 0x018 */ public NMSString0x10 Part;
        /* 0x028 */ public NMSString0x80 DebugText;
        /* 0x0A8 */ public NMSString0x80 Message;
        /* 0x128 */ public bool TakePartFromSeasonData;
        /* 0x129 */ public bool TeachIfNotKnown;
    }
}
