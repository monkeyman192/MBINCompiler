using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x729308A5EA2A33AF, NameHash = 0x3B1323EC)]
    public class GcMissionSequenceSignalGalacticPoint : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
        [NMS(Index = 1)]
        /* 0x20 */ public GcMissionGalacticPoint Target;
    }
}
