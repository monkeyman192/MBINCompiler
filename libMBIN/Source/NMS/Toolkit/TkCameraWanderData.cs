namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD19F101CC5FDC6CB, NameHash = 0x56A51859)]
    public class TkCameraWanderData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public float CamWanderAmplitude;
        [NMS(Index = 1)]
        /* 0x04 */ public float CamWanderAngle;
        [NMS(Index = 3)]
        /* 0x08 */ public float CamWanderPhase;
        [NMS(Index = 2)]
        /* 0x0C */ public float CamWanderSpringTime;
        [NMS(Index = 0)]
        /* 0x10 */ public bool CamWander;
    }
}
