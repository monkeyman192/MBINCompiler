using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE31A7A59B1C47513, NameHash = 0xE9BF52BE754A51E0)]
    public class GcMissionSequenceSignalGalacticPoint : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcMissionGalacticPoint Target;
        [NMS(Index = 2)]
        /* 0x04 */ public NMSString0x80 DebugText;
        [NMS(Index = 0)]
        /* 0x84 */ public NMSString0x80 Message;
    }
}
