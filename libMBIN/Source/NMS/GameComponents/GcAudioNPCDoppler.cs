using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5B71C70C9ED2A183, NameHash = 0x308DBEDE)]
    public class GcAudioNPCDoppler : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x7, EnumType = typeof(GcAISpaceshipTypes.ShipTypeEnum))]
        /* 0x0 */ public GcAudio3PointDopplerData[] Config;
    }
}
