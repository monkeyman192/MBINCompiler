namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC0055EAEE7B33DCB, NameHash = 0xCCD50D4D)]
    public class TkAudioEmitterLine : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Vector3f End;
        [NMS(Index = 0)]
        /* 0x10 */ public Vector3f Start;
        [NMS(Index = 2)]
        /* 0x20 */ public float Spacing;
    }
}
