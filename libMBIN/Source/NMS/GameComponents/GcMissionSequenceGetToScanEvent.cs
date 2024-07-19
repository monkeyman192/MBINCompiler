using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x803144C8B3A28351, NameHash = 0x3D1218BD)]
    public class GcMissionSequenceGetToScanEvent : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public NMSString0x20A Event;
        [NMS(Index = 3)]
        /* 0x020 */ public NMSString0x20A NexusMessage;
        [NMS(Index = 15)]
        /* 0x040 */ public NMSString0x20A SurveyHint;
        [NMS(Index = 13)]
        /* 0x060 */ public NMSString0x20A SurveyInactiveHint;
        [NMS(Index = 14)]
        /* 0x080 */ public NMSString0x20A SurveySwapHint;
        [NMS(Index = 16)]
        /* 0x0A0 */ public NMSString0x20A SurveyVehicleHint;
        [NMS(Index = 17)]
        /* 0x0C0 */ public VariableSizeString DebugText;
        [NMS(Index = 1)]
        /* 0x0D0 */ public VariableSizeString GalaxyMapMessage;
        [NMS(Index = 2)]
        /* 0x0E0 */ public VariableSizeString GalaxyMapMessageNotSpace;
        [NMS(Index = 0)]
        /* 0x0F0 */ public VariableSizeString Message;
        [NMS(Index = 9)]
        /* 0x100 */ public VariableSizeString TimeoutOSD;
        [NMS(Index = 5)]
        /* 0x110 */ public float Distance;
        [NMS(Index = 7)]
        /* 0x114 */ public float Timeout;
        [NMS(Index = 10)]
        /* 0x118 */ public GcScanEventGPSHint UseGPSInText;
        [NMS(Index = 12)]
        /* 0x11C */ public bool AlwaysAllowInShip;
        [NMS(Index = 11)]
        /* 0x11D */ public bool CanFormatObjectives;
        [NMS(Index = 8)]
        /* 0x11E */ public bool DistanceTimeout;
        [NMS(Index = 6)]
        /* 0x11F */ public bool EndEventWhenReached;
    }
}
