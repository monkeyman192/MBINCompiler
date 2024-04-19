namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDBA93D8744C56CD0, NameHash = 0xF23D44C69F4360D8)]
    public class TkCameraWanderData : NMSTemplate
    {
        /* 0x0 */ public float CamWanderAmplitude;
        /* 0x4 */ public float CamWanderPhase;
        /* 0x8 */ public bool CamWander;
    }
}
