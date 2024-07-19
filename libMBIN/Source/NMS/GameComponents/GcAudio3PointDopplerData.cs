namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x74CC72D7620360B2, NameHash = 0x7F9EFB9A)]
    public class GcAudio3PointDopplerData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float Front;
        [NMS(Index = 1)]
        /* 0x4 */ public float Mid;
        [NMS(Index = 2)]
        /* 0x8 */ public float Rear;
    }
}
