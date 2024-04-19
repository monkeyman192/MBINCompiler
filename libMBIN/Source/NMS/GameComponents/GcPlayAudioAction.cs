namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC1A655F641271435, NameHash = 0x7C82C5EBE3916386)]
    public class GcPlayAudioAction : NMSTemplate
    {
        /* 0x00 */ public float OcclusionRadius;
        /* 0x04 */ public NMSString0x80 Sound;
        /* 0x84 */ public bool UseOcclusion;
    }
}
