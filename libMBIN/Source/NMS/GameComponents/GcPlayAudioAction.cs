namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC1A655F641271435, NameHash = 0x7C82C5EBE3916386)]
    public class GcPlayAudioAction : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public float OcclusionRadius;
        [NMS(Index = 0)]
        /* 0x04 */ public NMSString0x80 Sound;
        [NMS(Index = 1)]
        /* 0x84 */ public bool UseOcclusion;
    }
}
