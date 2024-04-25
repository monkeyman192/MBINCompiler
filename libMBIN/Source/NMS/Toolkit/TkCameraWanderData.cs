namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDBA93D8744C56CD0, NameHash = 0xF23D44C69F4360D8)]
    public class TkCameraWanderData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public float CamWanderAmplitude;
        [NMS(Index = 1)]
        /* 0x4 */ public float CamWanderPhase;
        [NMS(Index = 0)]
        /* 0x8 */ public bool CamWander;
    }
}
