namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAF0267ACFEB51B50, NameHash = 0x77B3408A8150441E)]
    public class GcCameraShakeComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ShakeID;
        [NMS(Index = 2)]
        /* 0x10 */ public float FalloffDistanceMax;
        [NMS(Index = 1)]
        /* 0x14 */ public float FalloffDistanceMin;
    }
}
